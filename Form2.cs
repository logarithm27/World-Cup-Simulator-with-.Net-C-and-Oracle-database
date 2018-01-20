/* Maftoul Omar December 2017 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace worldCupTest2
{
    public partial class Form2 : Form
    {
        public List<Label> listOfTeamsinA;
        public List<Label> listOfTeamsinB;
        public List<Label> listOfTeamsinC;
        public List<Label> listOfTeamsinD;
        public List<Label> listOfTeamsinE;
        public List<Label> listOfTeamsinF;
        public List<Label> listOfTeamsinG;
        public List<Label> listOfTeamsinH;
        public List<List<Label>> listOfLabels;
        public List<List<PictureBox>> flagsOfAllGroups;
        public List<List<string>> namesOfTeams;
        public List<PictureBox> flagsA;
        public List<PictureBox> flagsB;
        public List<PictureBox> flagsC;
        public List<PictureBox> flagsD;
        public List<PictureBox> flagsE;
        public List<PictureBox> flagsF;
        public List<PictureBox> flagsG;
        public List<PictureBox> flagsH;
        public List<Label> allScores;
        public List<Label> FirstMatch;
        public List<Label> secondMatch;
        public List<Label> thirdMatch;
        public Dictionary<string, string> scoreAndNameFirstMatch;
        public Dictionary<string, string> scoreAndNameSecondMatch;
        public Dictionary<string, string> scoreAndNamesThirdMatch;
        public Dictionary<string, Label> flagWithName;
        public Dictionary<string, int> pointsOfTeams;
        public int whichMatch = 0;
        public List<string> groupA;
        public List<string> groupB;
        public List<string> groupC;
        public List<string> groupD;
        public List<string> groupE;
        public List<string> groupF;
        public List<string> groupG;
        public List<string> groupH;
        private Dictionary<string, int> numberOfGoals;
        public static List<List<string>> winners=new List<List<string>>();
        private List<Label> nameIngroups;
        public Form2()
        {
            InitializeComponent();
            makeAnimationSmooth();
            initializeListOfLabels();
            initializeAllScoreses();
            hideScores();
            initFirstMatch();
            initSecondMatch();
            initThirdMatch();
        }

        public void names()
        {
            nameIngroups=new List<Label>();
            flagWithName = new Dictionary<string, Label>();
            var temp = temporaryList(747,"n");
            var temp2 = temporaryList(846,"p");
            groupA = Form1.GroupA;
            groupB = Form1.GroupB;
            groupC = Form1.GroupC;
            groupD = Form1.GroupD;
            groupE = Form1.GroupE;
            groupF = Form1.GroupF;
            groupG = Form1.GroupG;
            groupH = Form1.GroupH;
            for (int i = 0; i < groupA.Count; i++)
            {
                temp[i].Text = groupA[i];
                flagWithName.Add(temp[i].Text,temp2[i]);
                nameIngroups.Add(temp[i]);
                //goals.SetToolTip(temp[i], "nombre de but : " + numberOfGoals.FirstOrDefault(x => x.Key == temp[i].Text).Value);
            }
            temp = temporaryList(958,"n");
             temp2 = temporaryList(1055, "p");
            for (int i = 0; i < groupB.Count; i++)
            {
                temp[i].Text = groupB[i];
                flagWithName.Add(temp[i].Text, temp2[i]);
                nameIngroups.Add(temp[i]);
            }
            temp = temporaryList(1195,"n");
            temp2 = temporaryList(1286, "p");
            for (int i = 0; i < groupC.Count; i++)
            {
                temp[i].Text = groupC[i];
                flagWithName.Add(temp[i].Text, temp2[i]);
                nameIngroups.Add(temp[i]);
            }
            temp = temporaryList(745,"n");
            temp2 = temporaryList(838, "p");
            for (int i = 0; i < groupD.Count; i++)
            {
                temp[i].Text = groupD[i];
                flagWithName.Add(temp[i].Text, temp2[i]);
                nameIngroups.Add(temp[i]);
            }
            temp = temporaryList(957,"n");
            temp2 = temporaryList(1049, "p");
            for (int i = 0; i < groupE.Count; i++)
            {
                temp[i].Text = groupE[i];
                flagWithName.Add(temp[i].Text, temp2[i]);
                nameIngroups.Add(temp[i]);
            }
            temp = temporaryList(1193,"n");
            temp2 = temporaryList(1281, "p");
            for (int i = 0; i < groupF.Count; i++)
            {
                temp[i].Text = groupF[i];
                flagWithName.Add(temp[i].Text, temp2[i]);
                nameIngroups.Add(temp[i]);
            }
            temp = temporaryList(812,"n");
            temp2 = temporaryList(903, "p");
            for (int i = 0; i < groupG.Count; i++)
            {
                temp[i].Text = groupG[i];
                flagWithName.Add(temp[i].Text, temp2[i]);
                nameIngroups.Add(temp[i]);
            }
            temp = temporaryList(1090,"n");
            temp2 = temporaryList(1183, "p");
            for (int i = 0; i < groupH.Count; i++)
            {
                temp[i].Text = groupH[i];
                flagWithName.Add(temp[i].Text, temp2[i]);
                nameIngroups.Add(temp[i]);
            }
        }

        public List<Label> temporaryList(int position,string startsWith)
        {
            var temp = new List<Label>();
            var names = Controls.OfType<Label>()
                .OrderBy(x => x.Name).Where(c => c.Name.StartsWith(startsWith) &&
                                                 c.Location.X.Equals(position))
                .ToList();
            foreach (var name in names)
            {
                temp.Add(name);
            }
            return temp;
        }
        public void initFirstMatch()
        {
            FirstMatch = new List<Label>();
            var scores = Controls.OfType<Label>()
                .OrderBy(x => x.Name).Where(c => c.Name.StartsWith("s"))
                .ToList();
            foreach (var score in scores)
            {
                FirstMatch.Add(score);
            }
        }


        public void initSecondMatch()
        {
            secondMatch = new List<Label>();
            var scores = Controls.OfType<Label>().Where(c => c.Name.StartsWith("t"))
                .OrderBy(x => x.Name)
                .ToList();
            foreach (var score in scores)
            {
                secondMatch.Add(score);
            }
        }

        public void initThirdMatch()
        {
            thirdMatch=new List<Label>();
            var scores = Controls.OfType<Label>().Where(c => c.Name.StartsWith("u"))
                .OrderBy(x => x.Name)
                .ToList();
            foreach (var score in scores)
            {
                thirdMatch.Add(score);
            }
        }
        public void initializeAllScoreses()
        {
            allScores=new List<Label>();
            var scores = Controls.OfType<Label>()
                .OrderBy(x => x.Name).Where(c=>c.Name.StartsWith("s") && c.Name.StartsWith("t") && 
                c.Name.StartsWith("u"))
                .ToList();
            foreach (var score in scores)
            {
                allScores.Add(score);
            }
        }

        public void hideScores()
        {
            allScores = new List<Label>();
            var scores = Controls.OfType<Label>().ToList().Where(c=>c.Name.StartsWith("s") || 
            c.Name.StartsWith("t") || c.Name.StartsWith("u") || c.Name.StartsWith("p"));
            foreach (var score in scores)
            {
                score.Visible = false;
            }

        }

        public void playFirstMatch()
        {
            pointsOfTeams = new Dictionary<string, int>();
            numberOfGoals=new Dictionary<string, int>();
            scoreAndNameFirstMatch = new Dictionary<string, string>();
            var names = new List<Label>();
            var names2 = Controls.OfType<Label>().Where(c => c.Name.StartsWith("i"))
                .OrderBy(x => x.Name)
                .ToList();
            foreach (var name in names2)
            {
                names.Add(name);
            }
            Utility.generateRandomScore();
            int j = 0;
            for (int i = 0; i < FirstMatch.Count; i++)
            {
                if (j == 7)
                {
                    Utility.generateRandomScore();
                    j = 0;
                }
                FirstMatch[i].Text = Utility.randomScores[j].ToString();
                scoreAndNameFirstMatch.Add(names[i].Text, FirstMatch[i].Text);
                pointsOfTeams.Add(names[i].Text, 0);
                numberOfGoals.Add(names[i].Text, Utility.randomScores[j]);
                toolTip1.SetToolTip(nameIngroups.FirstOrDefault(x=>x.Text.Equals(names[i].Text)),"nombre de buts : "+ Utility.randomScores[j]);
                j++;
            }
         
        }

        public void calculatePoints()
        {
            for (int i = 0; i < FirstMatch.Count - 1; i++)
            {
                if (int.Parse(FirstMatch[i].Text) > int.Parse(FirstMatch[i + 1].Text))
                {
                    //if team wins get 3 point, else 0
                    //each team has label associated with , which points
                    //the points updates each time the match is played
                    pointsOfTeams[scoreAndNameFirstMatch.ElementAt(i).Key] += 3;
                    pointsOfTeams[scoreAndNameFirstMatch.ElementAt(i+1).Key] += 0;

                    flagWithName[scoreAndNameFirstMatch.ElementAt(i).Key].Text = 
                        pointsOfTeams[scoreAndNameFirstMatch.ElementAt(i).Key].ToString();

                    flagWithName[scoreAndNameFirstMatch.ElementAt(i+1).Key].Text = 
                        pointsOfTeams[scoreAndNameFirstMatch.ElementAt(i+1).Key].ToString();

                }
                else
                {
                    //MessageBox.Show(pointsOfTeams.ElementAt(i+1).Key + " wins");
                    pointsOfTeams[scoreAndNameFirstMatch.ElementAt(i).Key] += 0;
                    pointsOfTeams[scoreAndNameFirstMatch.ElementAt(i+1).Key] += 3;

                    flagWithName[scoreAndNameFirstMatch.ElementAt(i).Key].Text =
                        pointsOfTeams[scoreAndNameFirstMatch.ElementAt(i).Key].ToString();
                    flagWithName[scoreAndNameFirstMatch.ElementAt(i + 1).Key].Text =
                        pointsOfTeams[scoreAndNameFirstMatch.ElementAt(i + 1).Key].ToString();
                }
                i++;
            }
        }
        public void playSecondMatch()
        {
            scoreAndNameSecondMatch=new Dictionary<string, string>();
            var names = new List<Label>();
            var names2 = Controls.OfType<Label>().Where(c => c.Name.StartsWith("r"))
                .OrderBy(x => x.Name)
                .ToList();
            foreach (var name in names2)
            {
                names.Add(name);
            }
            Utility.generateRandomScore();
            int j = 0;
            for (int i = 0; i < secondMatch.Count; i++)
            {
                if (j == 7)
                {
                    Utility.generateRandomScore();
                    j = 0;
                }
                secondMatch[i].Text = Utility.randomScores[j].ToString();
                scoreAndNameSecondMatch.Add(names[i].Text, secondMatch[i].Text);
                numberOfGoals[scoreAndNameSecondMatch.ElementAt(i).Key] += Utility.randomScores[j];
                toolTip1.SetToolTip(nameIngroups.FirstOrDefault(x => x.Text.Equals(names[i].Text)), "nombre de buts : " + numberOfGoals[scoreAndNameSecondMatch.ElementAt(i).Key]);
                j++;
            }
        }

        public void calculatePoints2()
        {
            for (int i = 0; i < secondMatch.Count - 1; i++)
            {
                if (int.Parse(secondMatch[i].Text) > int.Parse(secondMatch[i + 1].Text))
                {
                    
                    pointsOfTeams[scoreAndNameSecondMatch.ElementAt(i).Key] += 3;
                    pointsOfTeams[scoreAndNameSecondMatch.ElementAt(i+1).Key] += 0;

                    flagWithName[scoreAndNameSecondMatch.ElementAt(i).Key].Text =
                        pointsOfTeams[scoreAndNameSecondMatch.ElementAt(i).Key].ToString();
                    flagWithName[scoreAndNameSecondMatch.ElementAt(i + 1).Key].Text =
                        pointsOfTeams[scoreAndNameSecondMatch.ElementAt(i + 1).Key].ToString();
                    //pointsOfTeams[FirstMatch[i+1].Text] = pointsOfTeams.ElementAt(i).Value + (int)Point.lose;
                }
                else
                {
                    //MessageBox.Show(pointsOfTeams.ElementAt(i+1).Key + " wins");
                    pointsOfTeams[scoreAndNameSecondMatch.ElementAt(i).Key] += 0;
                    pointsOfTeams[scoreAndNameSecondMatch.ElementAt(i + 1).Key] += 3;
                    flagWithName[scoreAndNameSecondMatch.ElementAt(i).Key].Text =
                        pointsOfTeams[scoreAndNameSecondMatch.ElementAt(i).Key].ToString();
                    flagWithName[scoreAndNameSecondMatch.ElementAt(i + 1).Key].Text =
                        pointsOfTeams[scoreAndNameSecondMatch.ElementAt(i + 1).Key].ToString();
                }
                i++;
            }
        }

        public void playThirdMatch()
        {
            scoreAndNamesThirdMatch=new Dictionary<string, string>();
            var names = new List<Label>();
            var names2 = Controls.OfType<Label>().Where(c => c.Name.StartsWith("q"))
                .OrderBy(x => x.Name)
                .ToList();
            foreach (var name in names2)
            {
                names.Add(name);
            }
            Utility.generateRandomScore();
            int j = 0;
            for (int i = 0; i < secondMatch.Count; i++)
            {
                if (j == 7)
                {
                    Utility.generateRandomScore();
                    j = 0;
                }
                thirdMatch[i].Text = Utility.randomScores[j].ToString();
                scoreAndNamesThirdMatch.Add(names[i].Text, thirdMatch[i].Text);
                numberOfGoals[scoreAndNamesThirdMatch.ElementAt(i).Key] += Utility.randomScores[j];
                toolTip1.SetToolTip(nameIngroups.FirstOrDefault(x => x.Text.Equals(names[i].Text)), "nombre de buts : " + numberOfGoals[scoreAndNamesThirdMatch.ElementAt(i).Key]);

                j++;
            }
        }
        public void calculatePoints3()
        {
            for (int i = 0; i < thirdMatch.Count - 1; i++)
            {
                if (int.Parse(thirdMatch[i].Text) > int.Parse(thirdMatch[i + 1].Text))
                {
                    //MessageBox.Show(pointsOfTeams.ElementAt(i).Key + " wins");
                    //Debug.writeLine("wins");
                    pointsOfTeams[scoreAndNamesThirdMatch.ElementAt(i).Key] += 3;
                    pointsOfTeams[scoreAndNamesThirdMatch.ElementAt(i + 1).Key] += 0;
                    //pointsOfTeams[FirstMatch[i+1].Text] = pointsOfTeams.ElementAt(i).Value + (int)Point.lose;
                    flagWithName[scoreAndNamesThirdMatch.ElementAt(i).Key].Text =
                        pointsOfTeams[scoreAndNamesThirdMatch.ElementAt(i).Key].ToString();
                    flagWithName[scoreAndNamesThirdMatch.ElementAt(i + 1).Key].Text =
                        pointsOfTeams[scoreAndNamesThirdMatch.ElementAt(i + 1).Key].ToString();
                }
                else
                {
                    //MessageBox.Show(pointsOfTeams.ElementAt(i+1).Key + " wins");
                    pointsOfTeams[scoreAndNamesThirdMatch.ElementAt(i).Key] += 0;
                    pointsOfTeams[scoreAndNamesThirdMatch.ElementAt(i + 1).Key] += 3;

                    flagWithName[scoreAndNamesThirdMatch.ElementAt(i).Key].Text =
                        pointsOfTeams[scoreAndNamesThirdMatch.ElementAt(i).Key].ToString();
                    flagWithName[scoreAndNamesThirdMatch.ElementAt(i + 1).Key].Text =
                        pointsOfTeams[scoreAndNamesThirdMatch.ElementAt(i + 1).Key].ToString();
                }
                i++;
            }
        }

        private List<Label> getPoints(int location)
        {
            var temp = new List<Label>();
            var names = Controls.OfType<Label>()
                .OrderBy(x => x.Name).Where(c => c.Name.StartsWith("p") &&
                                                 c.Location.X.Equals(846))
                .ToList();
            foreach (var name in names)
            {
                temp.Add(name);
            }
            return temp;
        }
        private void WinnersOfGroupPhase()
        {
            for (int i = 0; i < 8; i++)
            {
                winners.Add(new List<string>());
            }
           whoWillPass(winners[0], 846);
           whoWillPass(winners[1], 1055);
           whoWillPass(winners[2], 1286);
           whoWillPass(winners[3], 838);
           whoWillPass(winners[4], 1049);
           whoWillPass(winners[5], 1281);
           whoWillPass(winners[6], 903);
           whoWillPass(winners[7], 1183);
        }

        private void whoWillPass(List<string> Group, int position)
        {
            var teams = flagWithName.OrderByDescending(x => int.Parse(x.Value.Text)).Where(c => c.Value.Name.StartsWith("p") && c.Value.Location.X.Equals(position));
            if (int.Parse(teams.ElementAt(0).Value.Text) == int.Parse(teams.ElementAt(1).Value.Text))
            {
                flagWithName[teams.ElementAt(0).Key].BackColor = Color.Chartreuse;
                flagWithName[teams.ElementAt(1).Key].BackColor = Color.Chartreuse;
                if (numberOfGoals[teams.ElementAt(0).Key] > numberOfGoals[teams.ElementAt(1).Key])
                {
                    Group.Add(teams.ElementAt(0).Key);
                    Group.Add(teams.ElementAt(1).Key);
                }
                else 
                {
                    Group.Add(teams.ElementAt(1).Key);
                    Group.Add(teams.ElementAt(0).Key);
                }
            }
            else
            {
                Group.Add(teams.ElementAt(0).Key);
                flagWithName[teams.ElementAt(0).Key].BackColor = Color.Chartreuse;
                if (int.Parse(teams.ElementAt(1).Value.Text) == int.Parse(teams.ElementAt(2).Value.Text))
                {
                    if (int.Parse(teams.ElementAt(1).Value.Text) == int.Parse(teams.ElementAt(3).Value.Text))
                    {
                        if (numberOfGoals[teams.ElementAt(1).Key] > numberOfGoals[teams.ElementAt(3).Key])
                        {
                            Group.Add(teams.ElementAt(1).Key);
                            flagWithName[teams.ElementAt(1).Key].BackColor = Color.Chartreuse;
                        }
                        else
                        {
                            Group.Add(teams.ElementAt(3).Key);
                            flagWithName[teams.ElementAt(3).Key].BackColor = Color.Chartreuse;
                        }
                        if (numberOfGoals[teams.ElementAt(2).Key] > numberOfGoals[teams.ElementAt(3).Key])
                        {
                            Group.Add(teams.ElementAt(2).Key);
                            flagWithName[teams.ElementAt(2).Key].BackColor = Color.Chartreuse;
                        }
                        else
                        {
                            Group.Add(teams.ElementAt(3).Key);
                            flagWithName[teams.ElementAt(3).Key].BackColor = Color.Chartreuse;
                        }
                    }
                    else 
                    {
                        if (numberOfGoals[teams.ElementAt(1).Key] > numberOfGoals[teams.ElementAt(2).Key])
                        {
                            Group.Add(teams.ElementAt(1).Key);
                            flagWithName[teams.ElementAt(1).Key].BackColor = Color.Chartreuse;
                        }
                        else
                        { 
                            Group.Add(teams.ElementAt(2).Key);
                            flagWithName[teams.ElementAt(2).Key].BackColor = Color.Chartreuse;
                        }
                    }
                }
                else
                {
                    Group.Add(teams.ElementAt(1).Key);
                    flagWithName[teams.ElementAt(1).Key].BackColor = Color.Chartreuse;
                }
            }
           
        }
        private void Play_Click(object sender, EventArgs e)
        {
            whichMatch++;
            if (whichMatch == 1)
            {
                playFirstMatch();
                calculatePoints();
                foreach (var score in FirstMatch)
                    score.Visible = true;
                var scores = Controls.OfType<Label>().ToList().Where(c => c.Name.StartsWith("p"));
                foreach (var score in scores)
                {
                    score.Visible = true;
                }
                Play.Text = "Play Second Matches";
                //MessageBox.Show(pointsOfTeams.ElementAt(10).Value.ToString());
            }
           
            if (whichMatch == 2)
            {
                playSecondMatch();
                calculatePoints2();
                foreach (var score in secondMatch)
                {
                    score.Visible = true;
                }
                //MessageBox.Show(pointsOfTeams.ElementAt(10).Value.ToString());
                Play.Text = "Play Third Matches";
            }
            if (whichMatch == 3)
            {
                playThirdMatch();
                calculatePoints3();
                foreach (var score in thirdMatch)
                {
                    score.Visible = true;
                }
                //MessageBox.Show(pointsOfTeams.ElementAt(10).Value.ToString());
                Play.Text = "Discover winners ";
            }
            if (whichMatch == 4)
            {
                WinnersOfGroupPhase();
                Play.Text = "Play 16 th Phase ";
            }
            if (whichMatch == 5)
            {
                Play.Enabled = false;
                Form1.afterGroupPhaseWin();
                //MessageBox.Show(numberOfGoals["Morocco"].ToString());
            }

        }
        public void initializeListOfLabels()
        {
            initializeListOfA();
            initializeListOfB();
            initializeListOfC();
            initializrListOfD();
            initializeListOfE();
            initializeListOfF();
            initializeListOfG();
            initializeListOfH();
            listOfLabels = new List<List<Label>>();
            listOfLabels.Add(listOfTeamsinA);
            listOfLabels.Add(listOfTeamsinB);
            listOfLabels.Add(listOfTeamsinC);
            listOfLabels.Add(listOfTeamsinD);
            listOfLabels.Add(listOfTeamsinE);
            listOfLabels.Add(listOfTeamsinF);
            listOfLabels.Add(listOfTeamsinG);
            listOfLabels.Add(listOfTeamsinH);
            groups();
        }

        public void initializeListOfA()
        {
            listOfTeamsinA = new List<Label>();
            listOfTeamsinA.Add(i_0);
            listOfTeamsinA.Add(i_01);
            listOfTeamsinA.Add(i_02);
            listOfTeamsinA.Add(i_03);
            listOfTeamsinA.Add(q_01);
            listOfTeamsinA.Add(q_02);
            listOfTeamsinA.Add(q_03);
            listOfTeamsinA.Add(q_04);
            listOfTeamsinA.Add(r_0);
            listOfTeamsinA.Add(r_01);
            listOfTeamsinA.Add(r_05);
            listOfTeamsinA.Add(r_04);

        }

        public void initializeListOfB()
        {
            listOfTeamsinB = new List<Label>();
            listOfTeamsinB.Add(i_06);
            listOfTeamsinB.Add(i_07);
            listOfTeamsinB.Add(i_04);
            listOfTeamsinB.Add(i_05);
            listOfTeamsinB.Add(q_05);
            listOfTeamsinB.Add(q_06);
            listOfTeamsinB.Add(q_08);
            listOfTeamsinB.Add(q_07);
            listOfTeamsinB.Add(r_02);
            listOfTeamsinB.Add(r_03);
            listOfTeamsinB.Add(r_07);
            listOfTeamsinB.Add(r_06);
        }

        public void initializeListOfC()
        {
            listOfTeamsinC = new List<Label>();
            listOfTeamsinC.Add(i_08);
            listOfTeamsinC.Add(i_09);
            listOfTeamsinC.Add(i_12);
            listOfTeamsinC.Add(i_13);
            listOfTeamsinC.Add(q_10);
            listOfTeamsinC.Add(q_09);
            listOfTeamsinC.Add(q_11);
            listOfTeamsinC.Add(q_12);
            listOfTeamsinC.Add(r_10);
            listOfTeamsinC.Add(r_11);
            listOfTeamsinC.Add(r_09);
            listOfTeamsinC.Add(r_08);
        }

        public void initializrListOfD()
        {
            listOfTeamsinD = new List<Label>();
            listOfTeamsinD.Add(i_10);
            listOfTeamsinD.Add(i_11);
            listOfTeamsinD.Add(i_14);
            listOfTeamsinD.Add(i_15);
            listOfTeamsinD.Add(q_14);
            listOfTeamsinD.Add(q_13);
            listOfTeamsinD.Add(q_15);
            listOfTeamsinD.Add(q_16);
            listOfTeamsinD.Add(r_12);
            listOfTeamsinD.Add(r_13);
            listOfTeamsinD.Add(r_17);
            listOfTeamsinD.Add(r_16);
        }

        public void initializeListOfE()
        {
            listOfTeamsinE = new List<Label>();
            listOfTeamsinE.Add(i_20);
            listOfTeamsinE.Add(i_21);
            listOfTeamsinE.Add(i_16);
            listOfTeamsinE.Add(i_17);
            listOfTeamsinE.Add(q_22);
            listOfTeamsinE.Add(q_21);
            listOfTeamsinE.Add(q_23);
            listOfTeamsinE.Add(q_24);
            listOfTeamsinE.Add(r_14);
            listOfTeamsinE.Add(r_15);
            listOfTeamsinE.Add(r_19);
            listOfTeamsinE.Add(r_18);
        }

        public void initializeListOfF()
        {
            listOfTeamsinF = new List<Label>();
            listOfTeamsinF.Add(i_18);
            listOfTeamsinF.Add(i_19);
            listOfTeamsinF.Add(i_22);
            listOfTeamsinF.Add(i_23);
            listOfTeamsinF.Add(q_18);
            listOfTeamsinF.Add(q_17);
            listOfTeamsinF.Add(q_19);
            listOfTeamsinF.Add(q_20);
            listOfTeamsinF.Add(r_24);
            listOfTeamsinF.Add(r_25);
            listOfTeamsinF.Add(r_23);
            listOfTeamsinF.Add(r_22);
        }

        public void initializeListOfG()
        {
            listOfTeamsinG = new List<Label>();
            listOfTeamsinG.Add(i_24);
            listOfTeamsinG.Add(i_25);
            listOfTeamsinG.Add(i_26);
            listOfTeamsinG.Add(i_27);
            listOfTeamsinG.Add(q_30);
            listOfTeamsinG.Add(q_29);
            listOfTeamsinG.Add(q_31);
            listOfTeamsinG.Add(q_32);
            listOfTeamsinG.Add(r_20);
            listOfTeamsinG.Add(r_21);
            listOfTeamsinG.Add(r_27);
            listOfTeamsinG.Add(r_26);
        }

        public void initializeListOfH()
        {
            listOfTeamsinH = new List<Label>();
            listOfTeamsinH.Add(i_30);
            listOfTeamsinH.Add(i_31);
            listOfTeamsinH.Add(i_28);
            listOfTeamsinH.Add(i_29);
            listOfTeamsinH.Add(q_26);
            listOfTeamsinH.Add(q_25);
            listOfTeamsinH.Add(q_27);
            listOfTeamsinH.Add(q_28);
            listOfTeamsinH.Add(r_30);
            listOfTeamsinH.Add(r_31);
            listOfTeamsinH.Add(r_29);
            listOfTeamsinH.Add(r_28);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(FirstMatch.Count().ToString());
           
            names();
            var dictionary = Teams.flagsPots;
            var points = new List<Label>();
            var AllPoints = Controls.OfType<Label>().Where(c => c.Name.StartsWith("p"))
                .OrderBy(x => x.Name)
                .ToList();
            foreach (var flag in AllPoints)
            {
                points.Add(flag);
            }
            for (int i = 0; i < flagsOfAllGroups.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    flagsOfAllGroups[i][j].SizeMode = PictureBoxSizeMode.StretchImage;
                    flagsOfAllGroups[i][j].Image = dictionary.FirstOrDefault(x => x.Value == namesOfTeams[i][j])
                        .Key;
                    //flagWithName.Add(flagsOfAllGroups[i][j], null);
                }
            }
        }
        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void makeAnimationSmooth()
        {
            /*
             * If true, the control is first drawn to a buffer rather than directly to the screen,
             *  which can reduce flicker. If you set this property to true, you should also set 
             *  the AllPaintingInWmPaint to true.
             *  */
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void C4_4_Click(object sender, EventArgs e)
        {

        }

        private void groups()
        {
            namesOfTeams = new List<List<string>>();
            namesOfTeams.Add(Form1.GroupA);
            namesOfTeams.Add(Form1.GroupB);
            namesOfTeams.Add(Form1.GroupC);
            namesOfTeams.Add(Form1.GroupD);
            namesOfTeams.Add(Form1.GroupE);
            namesOfTeams.Add(Form1.GroupF);
            namesOfTeams.Add(Form1.GroupG);
            namesOfTeams.Add(Form1.GroupH);
            flagsOfAllGroups = new List<List<PictureBox>>();
            flagsA = new List<PictureBox>();
            var flagA =  Controls.OfType<PictureBox>()
                .OrderBy(x => x.Name).Where(c=>c.Name.Contains("A"))
                .ToList();
            foreach (var flagOfA in flagA)
            {
                flagsA.Add(flagOfA);
            }
            flagsB = new List<PictureBox>();
            var flagB = Controls.OfType<PictureBox>()
                .OrderBy(x => x.Name).Where(c => c.Name.Contains("B"))
                .ToList();
            foreach (var flagOfB in flagB)
            {
                flagsB.Add(flagOfB);
            }
            flagsC = new List<PictureBox>();
            var flagC = Controls.OfType<PictureBox>()
                .OrderBy(x => x.Name).Where(c => c.Name.Contains("C"))
                .ToList();
            foreach (var flagOfC in flagC)
            {
                flagsC.Add(flagOfC);
            }
            flagsD = new List<PictureBox>();
            var flagD = Controls.OfType<PictureBox>()
                .OrderBy(x => x.Name).Where(c => c.Name.Contains("D"))
                .ToList();
            foreach (var flagOfD in flagD)
            {
                flagsD.Add(flagOfD);
            }
            flagsE = new List<PictureBox>();
            var flagE = Controls.OfType<PictureBox>()
                .OrderBy(x => x.Name).Where(c => c.Name.Contains("E"))
                .ToList();
            foreach (var flagOfE in flagE)
            {
                flagsE.Add(flagOfE);
            }
            flagsF = new List<PictureBox>();
            var flagF = Controls.OfType<PictureBox>()
                .OrderBy(x => x.Name).Where(c => c.Name.Contains("F"))
                .ToList();
            foreach (var flagOfF in flagF)
            {
                flagsF.Add(flagOfF);
            }
            flagsG = new List<PictureBox>();
            var flagG = Controls.OfType<PictureBox>()
                .OrderBy(x => x.Name).Where(c => c.Name.Contains("G"))
                .ToList();
            foreach (var flagOfG in flagG)
            {
                flagsG.Add(flagOfG);
            }
            flagsH = new List<PictureBox>();
            var flagH = Controls.OfType<PictureBox>()
                .OrderBy(x => x.Name).Where(c => c.Name.Contains("H"))
                .ToList();
            foreach (var flagOfH in flagH)
            {
                flagsH.Add(flagOfH);
            }
            flagsOfAllGroups.Add(flagsA);
            flagsOfAllGroups.Add(flagsB);
            flagsOfAllGroups.Add(flagsC);
            flagsOfAllGroups.Add(flagsD);
            flagsOfAllGroups.Add(flagsE);
            flagsOfAllGroups.Add(flagsF);
            flagsOfAllGroups.Add(flagsG);
            flagsOfAllGroups.Add(flagsH);
        }

        private void t32_Click(object sender, EventArgs e)
        {

        }

        private void tooltipDraw(object sender, DrawToolTipEventArgs e)
        {
                Font f = new Font("Arial", 16.0f);
                e.DrawBackground();
                e.DrawBorder();
                e.Graphics.DrawString(e.ToolTipText, f, Brushes.Black, new PointF(2, 2));     
        }
    }
}












