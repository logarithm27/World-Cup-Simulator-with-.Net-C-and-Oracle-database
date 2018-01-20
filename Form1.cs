/* Maftoul Omar December 2017 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace worldCupTest2
{
    public partial class Form1 : Form
    {
        //determine if the draw button is clicked or not
        public static bool drawClicked = false;

        public static bool DrawFinished = false;
        //boolean member that distinguish wether the
        //first pot is terminated or not
        //the same philosophy for the others
        public static bool firstTimerStoped = false;
        public static bool secondTimerStoped = false;
        public static bool thirdTimerStopped = false;
        //time to wait Between Each Timer 
        public static bool timeTowait1 = false;
        public static bool timeTowait2 = false;
        public static bool timeTowait3 = false;
        public static Teams setDraw;
        public static Image img;
        public static bool[] setsPot1;
        public static bool[] setsPot2;
        public static bool[] setsPot3;
        public static bool[] setsPot4;
        public static TimeSpan secEndForFirstWaiting;
        public static TimeSpan secStartForFirstWaiting;
        public static int incrementingSeconds;
        public static List<string> GroupA;
        public static List<string> GroupB;
        public static List<string> GroupC;
        public static List<string> GroupD;
        public static List<string> GroupE;
        public static List<string> GroupF;
        public static List<string> GroupG;
        public static List<string> GroupH;
        public static List<List<string>> allGroups;
        private Form2 second;
        private static Form3 afterPhaseGroupWindow;
        public  static List<Label> listOfLabelNames1;
        public static  List<Label> listOfLabelNames2;
        public  static List<Label> listOfLabelNames3;
        public  static List<Label> listOfLabelNames4;
        public static int[] indexEurope;
        public static int[] indexAsia;
        public static  int[] indexAfrica;
        public static int[] indexSouthAmerica;
        public static int[] indexNorthAmerica;
        public  List<Label> listOfPositions;
        public static List<int> posSecondPot;
        public static List<int>posTestSecondPot;
        public static List<int> posTestThirdPot;
        public static List<int> posTestFourthPot;
        public static List<int> tempForFourth;
        public static List<int> anotherTest;
        public Form1()
        {
            InitializeComponent();
            makeAnimationSmooth();
            InitializeIndexersOfConfederations();
            IntitializeGroups();
            groupingGroups();
            setDraw = new Teams();
            setDraw.createListOfOrderedTeamsForPot1();
            InitializeArrayOfBooleansUsedInTimer();
            schedule.Visible = false;
            second = new Form2();
            initializePosition();
            groupingNames1();
            groupingNames2();
            groupingNames3();
            groupingNames3();
            groupingName4();
            HideAllTeams();
            posSecondPot=new List<int>();
            initializeposTestSecondPot();
            initializeposTestThirdPot();
            initializeposTestFourthPot();
        }

        public void initializeposTestSecondPot()
        {
            posTestSecondPot=new List<int>();
            for (int i = 0; i < 8; i++)
            {
                posTestSecondPot.Add(i);
            }
        }
        public void initializeposTestThirdPot()
        {
            posTestThirdPot = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                posTestThirdPot.Add(i);
            }
        }

        public void initializeposTestFourthPot()
        {
            posTestFourthPot = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                posTestFourthPot.Add(i);
            }
        }

        public void initializePosition()
        {
            listOfPositions = new List<Label>();
            listOfPositions.Add(A);
            listOfPositions.Add(B);
            listOfPositions.Add(C);
            listOfPositions.Add(D);
            listOfPositions.Add(E);
            listOfPositions.Add(F);
            listOfPositions.Add(G);
            listOfPositions.Add(H);

        }       
        public void groupingNames1()
        {
            listOfLabelNames1 = new List<Label>();
            initializeGroupNames(listOfLabelNames1, "1");
        }

        public void groupingNames2()
        {
            listOfLabelNames2=new List<Label>();
            initializeGroupNames(listOfLabelNames2, "2");

        }

        public void groupingNames3()
        {
            listOfLabelNames3 = new List<Label>();
            initializeGroupNames(listOfLabelNames3, "3");
        }

        public void groupingName4()
        {
            listOfLabelNames4 = new List<Label>();
            initializeGroupNames(listOfLabelNames4, "4");
        }
        public void initializeGroupNames(List<Label> currentListOfLabels, string endsWith)
        {
            var labels = this.Controls.OfType<Label>()
                .Where(c => c.Name.EndsWith(endsWith)).OrderBy(x => x.Name)
                .ToList();
            foreach (var label in labels)
            {
                currentListOfLabels.Add(label);
            }
        }
        private void paint(object sender, PaintEventArgs e)
        {
            
            setDraw.drawPots(e);
        }

      
        public void theTimer(object sender, EventArgs e)
        {
            //Start the draw if only the draw button is clicked
            if (drawClicked == true)
            {
                Engine eng = new Engine();
                eng.engine(1, setDraw.CountriesOfPot1, listOfPositions, setsPot1, allGroups, listOfLabelNames1,
                    setDraw.TeamsOfPot1, 10, setDraw.Teams1);
                Invalidate();
                utilityForTimer(setsPot1, timer, true, 1);
            }
        }
        //TickToWait Method is a method that waits
        //a second after the previous pot is drawed
        private void tickTowait(object sender, EventArgs e)
        {
            if (firstTimerStoped)
            {
               if(waiting())
                {
                    timerToWait.Stop();
                    timeTowait1 = true;
                }
            }
        }
        private void  Tick2(object sender, EventArgs e)
        {
            if (timeTowait1==true)
            {
                    Engine eng2=new Engine();
                    eng2.engine(2, setDraw.CountriesOfPot2, listOfPositions, setsPot2, allGroups, listOfLabelNames2, setDraw.TeamsOfPot2, 40, setDraw.TeamsOtherPots);
                    Invalidate();
                }
            utilityForTimer(setsPot2, timer2, true, 2);
        }
        private void tickToWait2(object sender, EventArgs e)
        {
            if (secondTimerStoped == true)
            {
               if(waiting())
                {
                   timerToWait2.Stop();
                    //MessageBox.Show(indexEurope[1].ToString());
                    timeTowait2 = true;
                }
            }
        }

     
        private void Tick3(object sender, EventArgs e)
        {
            if (timeTowait2 == true)
            {
                Engine eng = new Engine();
                eng.engine(3, setDraw.CountriesOfPot3, listOfPositions, setsPot3, allGroups, listOfLabelNames3, setDraw.TeamsOfPot3, 70, setDraw.TeamsOtherPots);
                Invalidate();
            }
            utilityForTimer(setsPot3, timer3,true,3);

        }
        
        private void tickTowait3(object sender, EventArgs e)
        {
            if (thirdTimerStopped == true)
            {
               if(waiting())
                {
                    timerToWait3.Stop();
                    timeTowait3 = true;
                }
            }
        }
        private void Tick4(object sender, EventArgs e)
        {
            if (timeTowait3 == true)
            {
                Engine eng = new Engine();
                eng.engine(4, setDraw.CountriesOfPot4, listOfPositions, setsPot4, allGroups, listOfLabelNames4, setDraw.TeamsOfPot4, 100, setDraw.TeamsOtherPots);
                Invalidate();
            }
            utilityForTimer(setsPot4, timer4, true, 4);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           //Nothing to do
        }

        private void draw_Click(object sender, EventArgs e)
        {
            drawClicked = true;
            draw.Enabled = false;
            //draw.Enabled = false;

        }

        private void setTimerTowait()
        {
            secEndForFirstWaiting = new TimeSpan(0, 0,2);
            incrementingSeconds = 0;
            secStartForFirstWaiting = new TimeSpan(0, 0, 0);
        }

        public static bool waiting()
        {
            while (secStartForFirstWaiting.Seconds < secEndForFirstWaiting.Seconds)
            {
                incrementingSeconds++;
                secStartForFirstWaiting = new TimeSpan(0, 0, incrementingSeconds);
                return false;
            }
            return true;
        }

        private void HideOrShowNameOfTeamsAfterDrawOfPot1(bool showOrHide)
        {
            foreach (var l in listOfLabelNames1)
                l.Visible = showOrHide;
        }
        private void HideOrShowNameOfTeamsAfterDrawOfPot2(bool showOrHide)
        {
            foreach (var l in listOfLabelNames2)
                l.Visible = showOrHide;
        }
        private void HideOrShowNameOfTeamsAfterDrawOfPot3(bool showOrHide)
        {
            foreach (var l in listOfLabelNames3)
                l.Visible = showOrHide;
        }
        private void HideOrShowNameOfTeamsAfterDrawOfPot4(bool showOrHide)
        {
            foreach (var l in listOfLabelNames4)
                l.Visible = showOrHide;
        }

        private void HideAllTeams()
        {
            HideOrShowNameOfTeamsAfterDrawOfPot1(false);
            HideOrShowNameOfTeamsAfterDrawOfPot2(false);
            HideOrShowNameOfTeamsAfterDrawOfPot3(false);
            HideOrShowNameOfTeamsAfterDrawOfPot4(false);
        }

        private void InitializeArrayOfBooleansUsedInTimer()
        {
            setsPot1 = new bool[8];
            for (int i = 0; i < setsPot1.Length; i++)
            {
                setsPot1[i] = false;
            }
            setsPot2 = new bool[8];
            for (int i = 0; i < setsPot2.Length; i++)
            {
                setsPot2[i] = false;
            }
            setsPot3 = new bool[8];
            for (int i = 0; i < setsPot3.Length; i++)
            {
                setsPot3[i] = false;
            }
            setsPot4 = new bool[8];
            for (int i = 0; i < setsPot4.Length; i++)
            {
                setsPot4[i] = false;
            }
        }

        private void scheduleForGroup(List<string> group)
        {

            if (DrawFinished == true)
            {
                const int num_teams = 4;
                int[,] results = Scheduler.GenerateRoundRobin(num_teams);

                for (int round = 0; round <= results.GetUpperBound(1); round++)
                {                  
                    for (int team = 0; team < num_teams; team++)
                    {
                    if (team < results[team, round])
                        {
                            for (int i = 0; i < allGroups.Count; i++)
                            {
                                if (group == allGroups[i])
                                {
                                    if (round == 1 && team == 0 && results[team, round] == 1)
                                    {
                                        second.listOfLabels[i][0].Text = group[team];
                                        second.listOfLabels[i][1].Text = group[results[team, round]];
                                    }
                                    if (round == 1 && team == 2 && results[team, round] == 3)
                                    {
                                        second.listOfLabels[i][2].Text = group[team];
                                        second.listOfLabels[i][3].Text = group[results[team, round]];
                                    }
                                    if (round == 0 && team == 0 && results[team, round] == 3)
                                    {
                                        second.listOfLabels[i][4].Text = group[team];
                                        second.listOfLabels[i][5].Text = group[results[team, round]];
                                    }
                                    if (round == 0 && team == 1 && results[team, round] == 2)
                                    {
                                        second.listOfLabels[i][6].Text = group[team];
                                        second.listOfLabels[i][7].Text = group[results[team, round]];
                                    }
                                    if (round == 2 && team == 0 && results[team, round] == 2)
                                    {
                                        second.listOfLabels[i][8].Text = group[team];
                                        second.listOfLabels[i][9].Text = group[results[team, round]];
                                    }
                                    if (round == 2 && team == 1 && results[team, round] == 3)
                                    {
                                        second.listOfLabels[i][10].Text = group[team];
                                        second.listOfLabels[i][11].Text = group[results[team, round]];
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void IntitializeGroups()
        {
            GroupA = new List<string>();
            GroupB = new List<string>();
            GroupC = new List<string>();
            GroupD = new List<string>();
            GroupE = new List<string>();
            GroupF = new List<string>();
            GroupG = new List<string>();
            GroupH = new List<string>();
        }

        private void groupingGroups()
        {
            allGroups = new List<List<string>>();
            allGroups.Add(GroupA);
            allGroups.Add(GroupB);
            allGroups.Add(GroupC);
            allGroups.Add(GroupD);
            allGroups.Add(GroupE);
            allGroups.Add(GroupF);
            allGroups.Add(GroupG);
            allGroups.Add(GroupH);
        }
        private void schedule_Click(object sender, EventArgs e)
        {
            //groupingGroups();
            for (int i = 0; i < allGroups.Count; i++)
            {
                scheduleForGroup(allGroups[i]);
            }
            schedule.Enabled = false;
            second.Show();
        }
        private void Close(object sender, FormClosingEventArgs e)
        {

        }

        private void afterGroupPhase_Click(object sender, EventArgs e)
        {
             afterPhaseGroupWindow = new Form3();
            GroupPhase.generateSecondTourTeams(afterPhaseGroupWindow);
            afterPhaseGroupWindow.ShowDialog();          
        }

        public static void afterGroupPhaseWin()
        {
            afterPhaseGroupWindow = new Form3();
            GroupPhase.generateSecondTourTeams(afterPhaseGroupWindow);
            afterPhaseGroupWindow.ShowDialog();
        }
        private void utilityForTimer(bool[] setPots, Timer timer, bool flag, int i)
        {
            if (setPots[0] == true &&
                setPots[1] == true &&
                setPots[2] == true &&
                setPots[3] == true &&
                setPots[4] == true &&
                setPots[5] == true &&
                setPots[6] == true &&
                setPots[7] == true)
            {
                timer.Stop();
                if (i == 3)
                {
                    thirdTimerStopped = true;
                    HideOrShowNameOfTeamsAfterDrawOfPot3(flag);
                    setDraw.createListPot4constraint();
                    Constraints.initilizeConstraintsPot4();
                    setTimerTowait();
                }
                if (i == 2)
                {
                    secondTimerStoped = true;
                    HideOrShowNameOfTeamsAfterDrawOfPot2(flag);
                    setDraw.createListPot3constraint();
                    Constraints.initilizeConstraintsPot3();
                    setTimerTowait();
                }
                if (i == 1)
                {
                    firstTimerStoped = true;
                    HideOrShowNameOfTeamsAfterDrawOfPot1(flag);
                    setDraw.createListPot2constraint();
                    Constraints.initializeConstraintsPot2();
                    setTimerTowait();
                }
                if (i == 4)
                {
                    DrawFinished = true;
                    HideOrShowNameOfTeamsAfterDrawOfPot4(flag);
                    schedule.Visible = true;
                }
            }
        }

        private void makeAnimationSmooth()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            
        }
        private void InitializeIndexersOfConfederations()
        {
            indexEurope = new int[8];
            indexAfrica = new int[8];
            indexAsia = new int[8];
            indexNorthAmerica = new int[8];
            indexSouthAmerica = new int[8];
            for (int i = 0; i < indexEurope.Length; i++)
            {
                indexEurope[i] = 0;
                indexAfrica[i] = 0;
                indexAsia[i] = 0;
                indexNorthAmerica[i] = 0;
                indexSouthAmerica[i] = 0;
            }
        }

        private void aboutUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("World Cup Draw \nMaftoul Omar.");
        }
    }
}



