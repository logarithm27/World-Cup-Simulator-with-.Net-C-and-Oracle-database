/* Maftoul Omar December 2017 */

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using worldCupTest2;

namespace worldCupTest2
{
    public static class Constraints
    {
        public static List<int> inWhichGroupthereIsConstraintAfrica;
        public static List<int> inWhichGroupAsia;
        public static List<int> inWhichGroupthereIsConstraintEurope;

        public static List<int> firstRemoving;

        //Case 3
        public static List<int> inWhichGroupthereIsConstraint2;

        public static List<int> inWhichGroupNorthAmerica;
        public static List<int> positions;

        public static void initializeConstraintsPot2()
        {
            List<int> removing = new List<int>();
            positions = new List<int>();
            for (int t = 0; t < 8; t++)
            {
                if (Form1.indexSouthAmerica[t] < 1)
                {
                    positions.Add(t);
                    removing.Add(t);
                    break;
                }
            }
            for (int t = 0; t < 8; t++)
            {
                if (Form1.indexSouthAmerica[t] < 1 && t != removing[0])
                {
                    positions.Add(t);
                    removing.Add(t);
                    break;
                }
            }
            for (int t = 0; t < 8; t++)
            {
                if (Form1.indexSouthAmerica[t] < 1 && t != removing[0]&&t != removing[1])
                {
                    positions.Add(t);
                    removing.Add(t);
                    break;
                }
            }
            for (int t = 0; t < 8; t++)
            {
                if (t != removing[0] && t != removing[1] && t != removing[2])
                {
                    positions.Add(t);
                    removing.Add(t);
                    break;
                }
            }
            for (int t = 0; t < 8; t++)
            {
                if (t != removing[0] && t != removing[1] && t != removing[2] && t != removing[3])
                {
                    positions.Add(t);
                    removing.Add(t);
                    break;
                }
            }
            for (int t = 0; t < 8; t++)
            {
                if (t != removing[0] && t != removing[1] && t != removing[2] && t != removing[3] && t != removing[4])
                {
                    positions.Add(t);
                    removing.Add(t);
                    break;
                }
            }
            for (int t = 0; t < 8; t++)
            {
                if (t != removing[0] && t != removing[1] && t != removing[2] && t != removing[3] && t != removing[4] && t!=removing[5])
                {
                    positions.Add(t);
                    removing.Add(t);
                    break;
                }
            }
            for (int t = 0; t < 8; t++)
            {
                if (t != removing[0] && t != removing[1] && t != removing[2] && t != removing[3] && t != removing[4] && t != removing[5] && t!=removing[6])
                {
                    positions.Add(t);
                    removing.Add(t);
                    break;
                }
            }
        }
        public static void initilizeConstraintsPot4()
        {
            positions=new List<int>();
            var Africa = new List<int>();
            var Asia = new List<int>();
            var Eu = new List<int>();
            var Na=new List<int>();
            int i = 0;
            List<int> removing = new List<int>();
            for (int t = 0; t < 8; t++)
            {
                if (Form1.indexEurope[t] == 1)
                {
                    positions.Add(t);
                    removing.Add(t);
                    Eu.Add(t);
                    break;
                }
            }
            for (int t = 0; t < 8; t++)
            {
                if (Form1.indexAfrica[t] < 1 && t != removing[0])
                {
                    positions.Add(t);
                    removing.Add(t);
                    Africa.Add(t);
                    break;
                }
            }
            for (int t = 0; t < 8; t++)
            {
                if (Form1.indexAsia[t] < 1 && t != removing[0] && t != removing[1])
                {
                    positions.Add(t);
                    removing.Add(t);
                    Asia.Add(t);
                    break;
                }
            }
            for (int t = 0; t < 8; t++)
            {
                if (Form1.indexAsia[t] <1 && t != removing[0] && t != removing[1] && t != removing[2])
                {
                    positions.Add(t);
                    removing.Add(t);
                    Asia.Add(t);
                    break;
                }
            }
            for (int t = 0; t < 8; t++)
            {
                if (Form1.indexAfrica[t] < 1 && t != removing[0] && t != removing[1] && t != removing[2] && t != removing[3])
                {
                    positions.Add(t);
                    removing.Add(t);
                    Africa.Add(t);
                    break;
                }
            }
            for (int t = 0; t < 8; t++)
            {
                if (Form1.indexNorthAmerica[t] < 1 && t != removing[0] && t != removing[1] && t != removing[2] && t != removing[3] && t != removing[4])
                {
                    positions.Add(t);
                    removing.Add(t);
                    //MessageBox.Show(positions[5].ToString());
                    Na.Add(t);
                    break;
                }
            }
            for (int t = 0; t < 8; t++)
            {
                if(Form1.indexAsia[t] < 1 && t != removing[0] && t != removing[1] && t != removing[2] &&
                    t != removing[3] && t != removing[4] && t != removing[5])
                {
                    positions.Add(t);
                    removing.Add(t);
                    break;
                }
            }
            for (int t = 0; t < 8; t++)
            {
                if (t==7 && Form1.indexAsia[t] == 1 )
                {
                    if (Form1.indexAsia[Eu[0]] < 1 && Form1.indexEurope[t] < 2)
                    {
                        positions.Add(Eu[0]);
                        positions[0] = t;
                        break;
                    }
                     if (Form1.indexAsia[Africa[0]] < 1 && Form1.indexAfrica[t] < 1)
                    {
                        positions.Add(Africa[0]);
                        positions[1] = t;
                    }
                     if (Form1.indexAsia[Africa[1]] < 1 && Form1.indexAfrica[t] < 1)
                    {
                        positions.Add(Africa[1]);
                        positions[4] = t;
                        break;
                    }
                    if (Form1.indexAsia[Na[0]] < 1 && Form1.indexNorthAmerica[t] < 1)
                    {
                        positions.Add(Na[0]);
                        positions[5] = t;
                        break;

                    }
                }
                if (Form1.indexAsia[t] < 1 && t != removing[0] && t != removing[1] && t != removing[2] &&
                    t != removing[3] && t != removing[4] && t != removing[5] && t != removing[6])
                {
                    positions.Add(t);
                    break;
                }
            }
            //MessageBox.Show(positions.Count.ToString());
        }

        public static void initilizeConstraintsPot3()
        {
            positions = new List<int>();
            inWhichGroupthereIsConstraint2 = searchForEurope(Form1.indexEurope);
            inWhichGroupNorthAmerica = search(Form1.indexNorthAmerica);
            int x1 = inWhichGroupthereIsConstraint2[0];
            int y1 = inWhichGroupthereIsConstraint2[1];
            int r = inWhichGroupNorthAmerica[0];
            initializeFirstRemoving();
            firstRemoving.Remove(x1);
            firstRemoving.Remove(y1);
            firstRemoving.Remove(r);
            for (int i = 0; i < 4; i++)
            {
                positions.Add(firstRemoving[i]);
                //Form1.posTestThirdPot.Remove(firstRemoving[i]);
            }
            for (int i = 0; i < 4; i++)
            {
                Form1.posTestThirdPot.Remove(firstRemoving[i]);
            }
            for (int i = 0; i < 4; i++)
            {
                positions.Add(Form1.posTestThirdPot[i]);
            }
        }

        public static void initializeFirstRemoving()
        {
            firstRemoving = new List<int>(8);
            for (int i = 0; i < 8; i++)
            {
                firstRemoving.Add(i);
            }
        }

        public static List<int> search(int[] wsichContinent)
        {
            List<int> whereIsConstraintInGroupes = new List<int>();
            for (int j = 0; j < 8; j++)
            {
                if (wsichContinent[j] == 1)
                    whereIsConstraintInGroupes.Add(j);
            }
            return whereIsConstraintInGroupes;
        }

        public static List<int> searchForEurope(int[] wsichContinent)
        {
            List<int> whereIsConstraintInGroupes = new List<int>();
            for (int j = 0; j < 8; j++)
            {
                if (wsichContinent[j] == 2)
                    whereIsConstraintInGroupes.Add(j);
            }
            return whereIsConstraintInGroupes;
        }
    }
}