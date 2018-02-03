/* Maftoul Omar December 2017 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace worldCupTest2
{
    public class Teams
    {
        public  List<int> teamsOtherPots;
        public List<int> teamsPot2Constraint;
        public List<int> teamsPot3Constraint;
        public List<int> teamsPot4Constraint;
        //List to make random teams for draw 
        public  List<int> teams;

        public  List<int> aferGourpPhaseTeams;
        //Array of rectangles to draw for each Pot
        public  Rectangle[] _countriesOfPot1;
        //Variable that contains name of corresponding flag
        //same thing for other teams in each Pot 1 2 3 and 4
        public  Dictionary<Rectangle, string> teamsOfPot1;
        public  Rectangle[] _countriesOfPot2;
        public  Dictionary<Rectangle, string> teamsOfPot2;
        public  Rectangle[] _countriesOfPot3;
        public  Dictionary<Rectangle, string> teamsOfPot3;
        public  Rectangle[] _countriesOfPot4;
        public  Dictionary<Rectangle, string> teamsOfPot4;
        //Lists of Flags to draw flag for each rectangle in each Pot
        private  List<Image> _countriesFlagsOfPot1;
        private  List<Image> _countriesFlagsOfPot2;
        private  List<Image> _countriesFlagsOfPot3;
        private  List<Image> _countriesFlagsOfPot4;
        private  Rectangle singleCountry;
        private  Graphics g;
        public   List<string> ConfederationOfEveryTeamInPot1;
        public   List<string> ConfederationOfEveryTeamInPot2;
        public   List<string> ConfederationOfEveryTeamInPot3;
        public   List<string> ConfederationOfEveryTeamInPot4;
        public static  Dictionary<Image, string> flagsPots;
        public WorldCupDataBase data;

        public Teams()
        {
            //Initializing the rectangles to draw before painting them
            //on the paint method
            flagsPots=new Dictionary<Image, string>();
            InitializeAllPots();
        
        }

        private void initializePot1()
        {
            ConfederationOfEveryTeamInPot1 = new List<string>();
            data = new WorldCupDataBase();
            data.OpenConnection();
            teamsOfPot1 = new Dictionary<Rectangle, string>();
            //Initialize array of rectangles that contains teams of Pot 1
            _countriesOfPot1 = new Rectangle[8];
            //Initialize List of images that contains flags of Pot 1's teams
            _countriesFlagsOfPot1 = new List<Image>();
            for (int k = 0; k < 8; k++)
            {
                //Adding images of flags from file
                //you must change the directory where you are putting your flags pictures
                //with a png format.
                //each png file must have a name within 1.png and 7.png 
                _countriesFlagsOfPot1.Add
                    (Image.FromFile
                    (@"D:\WorldCup\Pot1\" + k + ".png"));
                
            }
            //yDown specify the Y coordinate on the 2D plane of the graphic
            //each increment of i on the loop the yDown move by 30 
            //to draw the next rectangle
            int yDown = 70;
            for (int i = 0; i < 8; i++)
            {
                //if it's the first rectangle don't add 30 to the Y coordinate
                if (i == 0)
                {
                    var currentTeam = data.selectTeams("Pot1", 0);
                    singleCountry = new Rectangle(60, yDown, 40, 30);
                    _countriesOfPot1[i] = singleCountry;
                    teamsOfPot1.Add(_countriesOfPot1[i],currentTeam[0]);
                    flagsPots.Add(_countriesFlagsOfPot1[i],currentTeam[0]);
                    //Add Name Of Confederation to list of confederation in each team of the pot
                    ConfederationOfEveryTeamInPot1.Add(currentTeam[1]);
                }
                if (i > 0)
                {
                    var currentTeam = data.selectTeams("Pot1", i);
                    yDown += 30;
                    singleCountry = new Rectangle(60, yDown, 40, 30);
                    _countriesOfPot1[i] = singleCountry;
                    teamsOfPot1.Add(_countriesOfPot1[i],currentTeam[0]);
                    flagsPots.Add(_countriesFlagsOfPot1[i], currentTeam[0]);
                    ConfederationOfEveryTeamInPot1.Add(currentTeam[1]);
                }
            }
        }

        private void initializePot2()
        {
            ConfederationOfEveryTeamInPot2 = new List<string>();
            teamsOfPot2 = new Dictionary<Rectangle, string>();
            _countriesOfPot2 = new Rectangle[8];
            _countriesFlagsOfPot2 = new List<Image>();
            for (int k = 0; k < 8; k++)
            {
                _countriesFlagsOfPot2.Add(Image.FromFile(@"D:\WorldCup\Pot2\" + k + ".png"));
            }
            int yDown = 70;
            for (int i = 0; i < 8; i++)
            {
                if (i == 0)
                {
                    var currentTeam = data.selectTeams("Pot2", i);
                    singleCountry = new Rectangle(265, yDown, 40, 30);
                    _countriesOfPot2[i] = singleCountry;
                    teamsOfPot2.Add(_countriesOfPot2[i], currentTeam[0]);
                    flagsPots.Add(_countriesFlagsOfPot2[i], currentTeam[0]);
                    ConfederationOfEveryTeamInPot2.Add(currentTeam[1]);

                }
                if (i > 0)
                {
                    yDown += 30;
                    var currentTeam = data.selectTeams("Pot2", i);
                    singleCountry = new Rectangle(265, yDown, 40, 30);
                    _countriesOfPot2[i] = singleCountry;
                    teamsOfPot2.Add(_countriesOfPot2[i], currentTeam[0]);
                    flagsPots.Add(_countriesFlagsOfPot2[i], currentTeam[0]);
                    ConfederationOfEveryTeamInPot2.Add(currentTeam[1]);
                }
            }
        }

        private void initializePot3()
        {
            ConfederationOfEveryTeamInPot3 = new List<string>();
            teamsOfPot3 = new Dictionary<Rectangle, string>();
            _countriesOfPot3 = new Rectangle[8];
            _countriesFlagsOfPot3 = new List<Image>();
            for (int k = 0; k < 8; k++)
            {
                _countriesFlagsOfPot3.Add(Image.FromFile(@"D:\WorldCup\Pot3\" + k + ".png"));
            }
            int yDown = 70;
            for (int i = 0; i < 8; i++)
            {
                if (i == 0)
                {
                    var currentTeam = data.selectTeams("Pot3", i);
                    singleCountry = new Rectangle(500, yDown, 40, 30);
                    _countriesOfPot3[i] = singleCountry;
                    teamsOfPot3.Add(_countriesOfPot3[i],currentTeam[0]);
                    flagsPots.Add(_countriesFlagsOfPot3[i], currentTeam[0]);
                    ConfederationOfEveryTeamInPot3.Add(currentTeam[1]);

                }
                if (i > 0)
                {
                    yDown += 30;
                    var currentTeam = data.selectTeams("Pot3", i);
                    singleCountry = new Rectangle(500, yDown, 40, 30);
                    _countriesOfPot3[i] = singleCountry;
                    teamsOfPot3.Add(_countriesOfPot3[i], currentTeam[0]);
                    flagsPots.Add(_countriesFlagsOfPot3[i], currentTeam[0]);
                    ConfederationOfEveryTeamInPot3.Add(currentTeam[1]);
                }
            }
        }

        private void initializePot4()
        {
            ConfederationOfEveryTeamInPot4 = new List<string>();
            teamsOfPot4 = new Dictionary<Rectangle, string>();
            _countriesOfPot4 = new Rectangle[8];
            _countriesFlagsOfPot4 = new List<Image>();
            for (int k = 0; k < 8; k++)
            {
                _countriesFlagsOfPot4.Add(Image.FromFile(@"D:\WorldCup\Pot4\" + k + ".png"));
            }
            int yDown = 70;
            for (int i = 0; i < 8; i++)
            {
                if (i == 0)
                {
                    var currentTeam = data.selectTeams("Pot4", i);
                    singleCountry = new Rectangle(740, yDown, 40, 30);
                    _countriesOfPot4[i] = singleCountry;
                    //Get Name of the Team
                    teamsOfPot4.Add(_countriesOfPot4[i],currentTeam[0]);
                    flagsPots.Add(_countriesFlagsOfPot4[i], currentTeam[0]);
                    //Get confederation of The Team
                    ConfederationOfEveryTeamInPot4.Add(currentTeam[1]);
                }
                if (i > 0)
                {
                    yDown += 30;
                    var currentTeam = data.selectTeams("Pot4", i);
                    singleCountry = new Rectangle(740, yDown, 40, 30);
                    _countriesOfPot4[i] = singleCountry;
                    teamsOfPot4.Add(_countriesOfPot4[i], currentTeam[0]);
                    flagsPots.Add(_countriesFlagsOfPot4[i], currentTeam[0]);
                    ConfederationOfEveryTeamInPot4.Add(currentTeam[1]);
                }
            }
            data.CloseConnection();
        }
        public void drawPots(PaintEventArgs e)
        {
            g = e.Graphics;
            try
            {
                //For each team initialized in the initializePot1() or others initializers methods 
                //we draw teams inside the paint method 
                for (int j = 0; j < _countriesOfPot1.Length; j++)
                {
                    //DrawImage takes two arguments 
                    g.DrawImage(_countriesFlagsOfPot1[j], _countriesOfPot1[j]);
                    g.DrawImage(_countriesFlagsOfPot2[j], _countriesOfPot2[j]);
                    g.DrawImage(_countriesFlagsOfPot3[j], _countriesOfPot3[j]);
                    g.DrawImage(_countriesFlagsOfPot4[j], _countriesOfPot4[j]);

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public Rectangle[] CountriesOfPot1
        {
            get { return _countriesOfPot1; }
            set { _countriesOfPot1 = value; }
        }

        public Rectangle[] CountriesOfPot2
        {
            get { return _countriesOfPot2; }
            set { _countriesOfPot2 = value; }
        }

        public Rectangle[] CountriesOfPot3
        {
            get { return _countriesOfPot3; }
            set { _countriesOfPot3 = value; }
        }

        public Rectangle[] CountriesOfPot4
        {
            get { return _countriesOfPot4; }
            set { _countriesOfPot4 = value; }
        }

        public void createListPot2constraint()
        {
            List<int> available = new List<int>(8);
            List<int>temp=new List<int>();
            for (int i = 0; i < 8; i++)
                available.Add(i);
            teamsPot2Constraint = new List<int>();
            teamsPot2Constraint.Add(1);
            teamsPot2Constraint.Add(4);
            teamsPot2Constraint.Add(6);
            teamsPot2Constraint = teamsPot2Constraint.OrderBy(a => Guid.NewGuid()).ToList();
            temp = shuffleTeamsConstraints(available);
            temp.Remove(1);
            temp.Remove(4);
            temp.Remove(6);
            foreach (var value in temp)
            {
                teamsPot2Constraint.Add(value);
            }

        }
        public void createListPot3constraint()
        {
            List<int> available = new List<int>(8);
            List<int> shuffleFourNumbers=new List<int>();
            List<int> temp = new List<int>();
            for (int i = 0; i < 8; i++)
                available.Add(i);
            for (int i = 0; i < 4; i++)
                shuffleFourNumbers.Add(i);
            teamsPot3Constraint = shuffleTeams(shuffleFourNumbers);
            temp = shuffleTeamsConstraints(available);
            temp.Remove(0);
            temp.Remove(1);
            temp.Remove(2);
            temp.Remove(3);
            foreach (var value in temp)
            {
                teamsPot3Constraint.Add(value);
            }

        }

        public void createListPot4constraint()
        {
            teamsPot4Constraint = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                teamsPot4Constraint.Add(i);
            }
            
        }
        private List<int> shuffleTeamsConstraints(List<int> available)
        {
            Random random = new Random();
            List<int> result = new List<int>();
            while (available.Count > 0)
            {
                //Assign to Index a random value between 0 and the max size of List (here is 8)
                int index = random.Next(0, available.Count);
                //Such indexes will be used to get the value from the available list,
                //Add it in the result 
                result.Add(available[index]);
                //remove it from the available list to avoid repetition 
                available.RemoveAt(index);
            }
            return result;
        }
        public void createListOfOrderedTeamsForOtherPots()
        {
            List<int> available = new List<int>(8);
            for (int i = 0; i < 8; i++)
                available.Add(i);
            teamsOtherPots = new List<int>(8);
            teamsOtherPots = shuffleTeams(available);
        }

        public  void createListOfOrderedTeamsForPot1()
        {
            List<int> available = new List<int>(8);
            for (int i = 1; i < 8; i++)
                available.Add(i);
               teams =new List<int>(8);
             teams = shuffleTeams(available);
        }
        //This method take List of int and shuffle it 
        //
        private List<int> shuffleTeams(List<int> available)
        {
            Random random = new Random();
            List<int> result = new List<int>(8);
            while (available.Count > 0)
            {
                //Assign to Index a random value between 0 and the max size of List (here is 8)
                int index = random.Next(0, available.Count);
                //Such indexes will be used to get the value from the available list,
                //Add it in the result 
                result.Add(available[index]);
                //remove it from the available list to avoid repetition 
                available.RemoveAt(index);
            }
            return result;
        }

        public void createListOfTeamsAfterGroups()
        {
            List<int> available = new List<int>(4);
            for (int i = 0; i < 4; i++)
                available.Add(i);
            aferGourpPhaseTeams = new List<int>(4);
            aferGourpPhaseTeams = shuffleTeamsForeight(available);
        }
        private List<int> shuffleTeamsForeight(List<int> available)
        {
            Random random = new Random();
            List<int> result = new List<int>(4);
            while (available.Count > 0)
            {
                //Assign to Index a random value between 0 and the max size of List (here is 8)
                int index = random.Next(0, available.Count);
                //Such indexes will be used to get the value from the available list,
                //Add it in the result 
                result.Add(available[index]);
                //remove it from the available list to avoid repetition 
                available.RemoveAt(index);
            }
            return result;
        }
        public List<int> Teams1
        {
            get { return teams; }
            set { teams = value; }
        }

        public List<int> TeamsOtherPots
        {
            get { return teamsOtherPots; }
            set { teamsOtherPots = value; }
        }

        public Dictionary<Rectangle, string> TeamsOfPot1
        {
            get { return teamsOfPot1; }
            set { teamsOfPot1 = value; }
        }

        public Dictionary<Rectangle, string> TeamsOfPot2
        {
            get { return teamsOfPot2; }
            set { teamsOfPot2 = value; }
        }

        public Dictionary<Rectangle, string> TeamsOfPot3
        {
            get { return teamsOfPot3; }
            set { teamsOfPot3 = value; }
        }

        public Dictionary<Rectangle, string> TeamsOfPot4
        {
            get { return teamsOfPot4; }
            set { teamsOfPot4 = value; }
        }

        private void InitializeAllPots()
        {
            initializePot1();
            initializePot2();
            initializePot3();
            initializePot4();
        }

        public List<string> ConfederationOfEveryTeamInPot1_1
        {
            get { return ConfederationOfEveryTeamInPot1; }
            set { ConfederationOfEveryTeamInPot1 = value; }
        }

        public List<string> ConfederationOfEveryTeamInPot2_2
        {
            get { return ConfederationOfEveryTeamInPot2; }
            set { ConfederationOfEveryTeamInPot2 = value; }
        }

        public List<string> ConfederationOfEveryTeamInPot3_3
        {
            get { return ConfederationOfEveryTeamInPot3; }
            set { ConfederationOfEveryTeamInPot3 = value; }
        }

        public List<string> ConfederationOfEveryTeamInPot4_4
        {
            get { return ConfederationOfEveryTeamInPot4; }
            set { ConfederationOfEveryTeamInPot4 = value; }
        }
    }
}
