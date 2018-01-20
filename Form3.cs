/* Maftoul Omar December 2017 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace worldCupTest2
{
    public partial class Form3 : Form
    {
        private WorldCupDataBase worldcup;
        private bool sixteenthPhaseLeftSide=true;
        private bool sixteenthPhaseRightSide =true;
        private bool semiLeftSide = true;
        private bool semiRightSide = true;
        private bool toFinalLeft = true;
        private bool toFinalRight = true;
        private int i = 0;
        private List<List<FlowLayoutPanel>> listOfFlags;
        private List<FlowLayoutPanel> listOfFlagsOfLeftSide;
        private List<FlowLayoutPanel> listOfFlagsOfRightSide;
        private List<FlowLayoutPanel> listOfAllflagsCombined;
        public List<List<string>> ListOfTeamsPassed;
        private List<Label> listOfNamesLeft;
        private List<Label> listOfNamesRight;
        public Form3()
        {
            InitializeComponent();
            makeAnimationSmooth();
            initializeTeamNames();
            initializeTeamsOfGroups();
            hideScoresOfSixteenPhaseLeftSide(false);
            hideScoresOfSixteenPhaseRightSide(false);
            hideScoresOfSemisLeft(false);
            hideScoresOfSemisRight(false);
            hideScoresToFinalRight(false);
            hideScoresToFinalleft(false);
            finalleftscore.Visible = false;
            finalrightscore.Visible = false;
            initializeListOfFlags();
            initializeAllFlagsCombined();
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void initializeListOfFlagsLeftSide()
        {
            listOfFlagsOfLeftSide = new List<FlowLayoutPanel>();
            var flowLayoutPanels = Controls.OfType<FlowLayoutPanel>()
                .Where(c => c.Location.X==12).OrderBy(x => x.Name)
                .ToList();
            foreach (var flag in flowLayoutPanels)
            {
                listOfFlagsOfLeftSide.Add(flag);
            }
        }

        private void initializeListOfFlagsRightSide()
        {
            listOfFlagsOfRightSide = new List<FlowLayoutPanel>();
            var flowLayoutPanels = Controls.OfType<FlowLayoutPanel>()
                .Where(c => c.Location.X == 557).OrderBy(x => x.Name)
                .ToList();
            foreach (var flag in flowLayoutPanels)
            {
                listOfFlagsOfRightSide.Add(flag);
            }
        }

        private void initializeListOfFlags()
        {
            initializeListOfFlagsLeftSide();
            initializeListOfFlagsRightSide();
            listOfFlags = new List<List<FlowLayoutPanel>>();
            listOfFlags.Add(listOfFlagsOfLeftSide);//0 to access flags in left side
            listOfFlags.Add(listOfFlagsOfRightSide);//1 to access flags in right side
        }

        private void initializeAllFlagsCombined()
        {
            listOfAllflagsCombined = new List<FlowLayoutPanel>();
            var flowLayoutPanels = Controls.OfType<FlowLayoutPanel>()
                .OrderBy(x => x.Name)
                .ToList();
            foreach (var flag in flowLayoutPanels)
            {
                listOfAllflagsCombined.Add(flag);
            }
        }

        private void initializeTeamNames()
        {
            listOfNamesLeft=new List<Label>();
            listOfNamesRight=new List<Label>();
            var labelsleft =Controls.OfType<Label>()
                .Where(c => c.Location.X == 79).OrderBy(x => x.Name)
                .ToList();
            foreach (var label in labelsleft)
            {
                listOfNamesLeft.Add(label);
            }
            var labelsRight = Controls.OfType<Label>()
                .Where(c => c.Location.X == 499).OrderBy(x => x.Name)
                .ToList();
            foreach (var label in labelsRight)
            {
                listOfNamesRight.Add(label);
            }
        }

        public void initializeTeamsOfGroups()
        {
            ListOfTeamsPassed = new List<List<string>>();
            for (int i = 0; i < 8; i++)
            {
                ListOfTeamsPassed.Add(new List<string>());
            }
        }

        public void randomScoresForSixteenPhaseLeftSide()
        {
            if (sixteenthPhaseLeftSide)
            {
                hideScoresOfSixteenPhaseLeftSide(true);
                hideTeamsNamesLeftSide();
                Utility.generateRandomScore();
                a1s.Text = Utility.randomScores[0].ToString();
                b2s.Text = Utility.randomScores[1].ToString();
                if (Utility.randomScores[0] > Utility.randomScores[1])
                    a1orb2.BackgroundImage = A1_1.BackgroundImage;
                else
                {
                    a1orb2.BackgroundImage = B2_2.BackgroundImage;
                }
                c1s.Text = Utility.randomScores[2].ToString();
                d2s.Text = Utility.randomScores[3].ToString();
                if (Utility.randomScores[2] > Utility.randomScores[3])
                    c1ord2.BackgroundImage = C1_1.BackgroundImage;
                else
                {
                    c1ord2.BackgroundImage = D2_2.BackgroundImage;
                }
                e1s.Text = Utility.randomScores[4].ToString();
                f2s.Text = Utility.randomScores[5].ToString();
                if (Utility.randomScores[4] > Utility.randomScores[5])
                    e1orf2.BackgroundImage = E1_1.BackgroundImage;
                else
                {
                    e1orf2.BackgroundImage = F2_2.BackgroundImage;
                }
                g1s.Text = Utility.randomScores[6].ToString();
                h2s.Text = Utility.randomScores[0].ToString();
                if (Utility.randomScores[6] > Utility.randomScores[0])
                    g1orh2.BackgroundImage = G1_1.BackgroundImage;
                else
                {
                    g1orh2.BackgroundImage = H2_2.BackgroundImage;
                }
                sixteenthPhaseLeftSide = false;
            }
        }
        public void randomScoresForSixteenPhaseRightSide()
        {
                if (sixteenthPhaseRightSide)
                {
                    hideTeamsNamesRightSide();
                    hideScoresOfSixteenPhaseRightSide(true);
                    Utility.generateRandomScore();
                    b1s.Text = Utility.randomScores[0].ToString();
                    a2s.Text = Utility.randomScores[1].ToString();
                    if (Utility.randomScores[0] > Utility.randomScores[1])
                        b1ora2.BackgroundImage = B1_1.BackgroundImage;
                    else
                    {
                        b1ora2.BackgroundImage = A2_2.BackgroundImage;
                    }
                    d1s.Text = Utility.randomScores[2].ToString();
                    c2s.Text = Utility.randomScores[3].ToString();
                    if (Utility.randomScores[2] > Utility.randomScores[3])
                        d1orc2.BackgroundImage = D1_1.BackgroundImage;
                    else
                    {
                        d1orc2.BackgroundImage = C2_2.BackgroundImage;
                    }
                    f1s.Text = Utility.randomScores[4].ToString();
                    e2s.Text = Utility.randomScores[5].ToString();
                    if (Utility.randomScores[4] > Utility.randomScores[5])
                        f1ore2.BackgroundImage = F1_1.BackgroundImage;
                    else
                    {
                        f1ore2.BackgroundImage = E2_2.BackgroundImage;
                    }
                    h1s.Text = Utility.randomScores[6].ToString();
                    g2s.Text = Utility.randomScores[0].ToString();
                    if (Utility.randomScores[6] > Utility.randomScores[0])
                        h1org2.BackgroundImage = H1_1.BackgroundImage;
                    else
                    {
                        h1org2.BackgroundImage = G2_2.BackgroundImage;
                    }
                    sixteenthPhaseRightSide = false;
                    button1.Text = "Play Quarter";
            }
            
        }

        private void setTeams()
        {
            for (int i = 0; i < ListOfTeamsPassed.Count ; i++)
            {               
                    string[] a = worldcup.getFlags(ListOfTeamsPassed[i][0]);
                listOfNamesLeft[i].Text = a[0]; 
                      listOfFlagsOfLeftSide[i].BackgroundImage=
                          Image.FromFile(@"D:\Mes Documents\Docs\S3\C#\TP C#\WorldCup\" + a[1] + @"\" + a[2] + ".png");
                    string[] b = worldcup.getFlags(ListOfTeamsPassed[i][1]);
                listOfNamesRight[i].Text = b[0];
                    listOfFlagsOfRightSide[i].BackgroundImage= Image.FromFile(@"D:\Mes Documents\Docs\S3\C#\TP C#\WorldCup\" + b[1] + @"\" + b[2] + ".png");
            }
        }

        public void randomScoresForSemisLeft()
        {
            if (semiLeftSide)
            {
                hideScoresOfSemisLeft(true);
                Utility.generateRandomScore();
                a1orb2s.Text = Utility.randomScores[0].ToString();
                c1ord2s.Text = Utility.randomScores[1].ToString();
                if (Utility.randomScores[0] > Utility.randomScores[1])
                    semi1left.BackgroundImage = a1orb2.BackgroundImage;
                else
                {
                    semi1left.BackgroundImage = a1orb2.BackgroundImage;
                }
                e1orf2s.Text = Utility.randomScores[2].ToString();
                g1orh2s.Text = Utility.randomScores[3].ToString();
                if (Utility.randomScores[2] > Utility.randomScores[3])
                    semi2left.BackgroundImage = e1orf2.BackgroundImage;
                else
                {
                    semi2left.BackgroundImage = g1orh2.BackgroundImage;
                }
                semiLeftSide = false;
            }
        }

        public void randomScoresForSemisRight()
        {
            if (semiRightSide)
            {
                hideScoresOfSemisRight(true);
                Utility.generateRandomScore();
                b1ora2s.Text = Utility.randomScores[0].ToString();
                d1orc2s.Text = Utility.randomScores[1].ToString();
                if (Utility.randomScores[0] > Utility.randomScores[1])
                    semi1right.BackgroundImage = b1ora2.BackgroundImage;
                else
                {
                    semi1right.BackgroundImage = d1orc2.BackgroundImage;
                }
                f1ore2s.Text = Utility.randomScores[2].ToString();
                h1org2s.Text = Utility.randomScores[3].ToString();
                if (Utility.randomScores[2] > Utility.randomScores[3])
                    semi2right.BackgroundImage = f1ore2.BackgroundImage;
                else
                {
                    semi2right.BackgroundImage = h1org2.BackgroundImage;
                }
                semiRightSide = false;
            }
        }

        public void hideScoresOfSemisLeft(bool hideShow)
        {
            a1orb2s.Visible = hideShow;
            c1ord2s.Visible = hideShow;
            e1orf2s.Visible = hideShow;
            g1orh2s.Visible = hideShow;
        }

        public void randomScoreToFinalLeft()
        {
            if (toFinalLeft)
            {
                Utility.generateRandomScore();
                hideScoresToFinalleft(true);
                semi1lefts.Text = Utility.randomScores[0].ToString();
                semi2lefts.Text = Utility.randomScores[1].ToString();
                if (Utility.randomScores[0] > Utility.randomScores[1])
                    finalleft.BackgroundImage = semi1left.BackgroundImage;
                else
                {
                    finalleft.BackgroundImage = semi2left.BackgroundImage;
                }
                toFinalLeft = false;
            }
        }

        public void randomScoreToFinalRight()
        {
            if (toFinalRight)
            {
                Utility.generateRandomScore();
                hideScoresToFinalRight(true);
                semi1rights.Text = Utility.randomScores[0].ToString();
                semi2rights.Text = Utility.randomScores[5].ToString();
                if (Utility.randomScores[0] > Utility.randomScores[5])
                    finalright.BackgroundImage = semi1right.BackgroundImage;
                else
                {
                    finalright.BackgroundImage = semi2right.BackgroundImage;
                }
                toFinalRight = false;
            }
        }

        public void randomScoreForFinal()
        {
            finalleftscore.Visible = true;
            finalrightscore.Visible = true;
            Utility.generateRandomScore();
            finalleftscore.Text = Utility.randomScores[4].ToString();
            finalrightscore.Text = Utility.randomScores[1].ToString();
            if (Utility.randomScores[4] > Utility.randomScores[1])
                champion.BackgroundImage = finalleft.BackgroundImage;
            else
            {
                champion.BackgroundImage = finalright.BackgroundImage;
            }
        }

        private void hideScoresToFinalleft(bool hideShow)
        {
            semi1lefts.Visible = hideShow;
            semi2lefts.Visible = hideShow;
        }

        private void hideScoresToFinalRight(bool hideShow)
        {
            semi1rights.Visible = hideShow;
            semi2rights.Visible = hideShow;
        }
        public void hideScoresOfSemisRight(bool hideShow)
        {
            b1ora2s.Visible = hideShow;
            d1orc2s.Visible = hideShow;
            f1ore2s.Visible = hideShow;
            h1org2s.Visible = hideShow;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            worldcup = new WorldCupDataBase();
            worldcup.OpenConnection();
            setTeams();
            //MessageBox.Show(listOfNamesLeft[4].Text);
        }

        private void hideScoresOfSixteenPhaseLeftSide(bool hideShow)
        {
            a1s.Visible = hideShow;
            b2s.Visible = hideShow;
            c1s.Visible = hideShow;
            d2s.Visible = hideShow;
            e1s.Visible = hideShow;
            f2s.Visible = hideShow;
            g1s.Visible = hideShow;
            h2s.Visible = hideShow;
        }
        private void hideScoresOfSixteenPhaseRightSide(bool hideShow)
        {
            b1s.Visible = hideShow;
            a2s.Visible = hideShow;
            d1s.Visible = hideShow;
            c2s.Visible = hideShow;
            f1s.Visible = hideShow;
            e2s.Visible = hideShow;
            h1s.Visible = hideShow;
            g2s.Visible = hideShow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            randomScoresForSixteenPhaseLeftSide();
            randomScoresForSixteenPhaseRightSide();
            i++;
            switch (i)
            {
                case 2:                  
                    randomScoresForSemisLeft();
                    randomScoresForSemisRight();
                    button1.Text = "Play Semi Finals";
                    break;
                case 3:
                    randomScoreToFinalLeft();
                    randomScoreToFinalRight();
                    button1.Text = "Discover the Winner";
                    break;
                case 4:
                    randomScoreForFinal();
                    button1.Enabled = false;
                    break;
            }
          
        }

        private void hideTeamsNamesLeftSide()
        {
            foreach (var l in listOfNamesLeft)
                l.Visible = false;
        }
        private void hideTeamsNamesRightSide()
        {
            foreach (var l in listOfNamesRight)
                l.Visible = false;
        }

        private void h1s_Click(object sender, EventArgs e)
        {

        }
        private void makeAnimationSmooth()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);

        }
    }
}
