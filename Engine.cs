/* Maftoul Omar December 2017 */

/*The Engine class control constraints of 
the draw phase (e.g : switzerland cannot be on the same group
with germany because they're bot on the european confederation,"see FIFA rules")
---------------------------------------------------------------------------
Second role of Engine class, it moves the flags 

*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace worldCupTest2
{
    
    public class Engine
    {
        public static bool done5;
        public void engine(int whichOne,
            Rectangle[] countriesOfPot,
            List<Label> positions,
            bool[] setsPots,
            List<List<string>> groups,
            List<Label> labelNames,
            Dictionary<Rectangle, string> dictionnary,
            int positionOfY,
            List<int> randomValues
        )
        {
            List<string> confederations = new List<string>();
            switch (whichOne)
            {
                case 1:
                    confederations = Form1.setDraw.ConfederationOfEveryTeamInPot1;
                    randomValues = Form1.setDraw.Teams1;
                    countriesOfPot = Form1.setDraw.CountriesOfPot1;
                    setsPots = Form1.setsPot1;
                    labelNames = new List<Label>();
                    labelNames = Form1.listOfLabelNames1;
                    dictionnary = Form1.setDraw.TeamsOfPot1;

                    break;
                case 2:
                    confederations = Form1.setDraw.ConfederationOfEveryTeamInPot2;
                    randomValues = Form1.setDraw.teamsPot2Constraint;
                    countriesOfPot = Form1.setDraw.CountriesOfPot2;
                    setsPots = Form1.setsPot2;
                    labelNames = Form1.listOfLabelNames2;
                    dictionnary = Form1.setDraw.TeamsOfPot2;
                    for (int i = 0; i < 8; i++)
                    {
                        if (setsPots[i] == false)
                        {
                            countriesOfPot[randomValues[i]].X = positions[Constraints.positions[i]].Location.X;
                            countriesOfPot[randomValues[i]].Y += 10;

                            if (countriesOfPot[randomValues[i]].Y > positions[Constraints.positions[i]].Location.Y + positionOfY)
                            {
                                //timer.Stop();

                                setsPots[i] = true;
                                labelNames[Constraints.positions[i]].Text = dictionnary.ElementAt(randomValues[i]).Value;
                                groups[Constraints.positions[i]].Add(labelNames[Constraints.positions[i]].Text);
                                incrementIndexByConfederation(confederations[randomValues[i]], Constraints.positions[i]);
                            }
                        }
                    }     
                    break;
                case 3:
                    confederations = Form1.setDraw.ConfederationOfEveryTeamInPot3;
                    randomValues = Form1.setDraw.teamsPot3Constraint;
                    countriesOfPot = Form1.setDraw.CountriesOfPot3;
                    setsPots = Form1.setsPot3;
                    labelNames = Form1.listOfLabelNames3;
                    dictionnary = Form1.setDraw.TeamsOfPot3;
                    for (int i = 0; i < 8; i++)
                    {
                        if (setsPots[i] == false)
                        {
                            countriesOfPot[randomValues[i]].X = positions[Constraints.positions[i]].Location.X;
                            countriesOfPot[randomValues[i]].Y += 10;

                            if (countriesOfPot[randomValues[i]].Y > positions[Constraints.positions[i]].Location.Y + positionOfY)
                            {
                                //timer.Stop();

                                setsPots[i] = true;
                                labelNames[Constraints.positions[i]].Text = dictionnary.ElementAt(randomValues[i]).Value;
                                groups[Constraints.positions[i]].Add(labelNames[Constraints.positions[i]].Text);
                                incrementIndexByConfederation(confederations[randomValues[i]], Constraints.positions[i]);
                            }
                        }
                    }
        break;
        case 4:

        confederations = Form1.setDraw.ConfederationOfEveryTeamInPot4;
                    randomValues = Form1.setDraw.teamsPot4Constraint;
                    countriesOfPot = Form1.setDraw.CountriesOfPot4;
                    setsPots = Form1.setsPot4;
                    labelNames = Form1.listOfLabelNames4;
                    dictionnary = Form1.setDraw.TeamsOfPot4;
            for (int i = 0; i < 8; i++)
            {
                if (setsPots[i] == false)
                {
                    countriesOfPot[randomValues[i]].X = positions[Constraints.positions[i]].Location.X;
                    countriesOfPot[randomValues[i]].Y += 10;

                    if (countriesOfPot[randomValues[i]].Y >
                        positions[Constraints.positions[i]].Location.Y + positionOfY)
                    {
                        //timer.Stop();

                        setsPots[i] = true;
                        labelNames[Constraints.positions[i]].Text = dictionnary.ElementAt(randomValues[i]).Value;
                        groups[Constraints.positions[i]].Add(labelNames[Constraints.positions[i]].Text);
                        incrementIndexByConfederation(confederations[randomValues[i]], Constraints.positions[i]);
                    }
                }
            }
                    break;
            }
            if (whichOne == 1)
            {
                if (setsPots[0] == false)
                {
                    countriesOfPot[0].X = positions[0].Location.X;
                    countriesOfPot[0].Y += 10;
                    if (countriesOfPot[0].Y > positions[0].Location.Y + positionOfY)
                    {
                        //timer.Stop();

                        setsPots[0] = true;
                        labelNames[0].Text = dictionnary.ElementAt(0).Value;
                        groups[0].Add(labelNames[0].Text);
                        incrementIndexByConfederation(confederations[0],0);
                    }
                }
                for (int i = 1; i < 8; i++)
                {
                    if (setsPots[i] == false)
                    {
                        //RUSSIA BY DEFAULT IN GROUP A
                        countriesOfPot[randomValues[i - 1]].X = positions[i].Location.X;
                        countriesOfPot[randomValues[i - 1]].Y += 10;
                        if (countriesOfPot[randomValues[i - 1]].Y > positions[i].Location.Y + positionOfY)
                        {
                            //timer.Stop();

                            setsPots[i] = true;
                            labelNames[i].Text = dictionnary.ElementAt(randomValues[i - 1]).Value;
                            groups[i].Add(labelNames[i].Text);
                            incrementIndexByConfederation(confederations[randomValues[i-1]], i);
                        }
                    }
                }
            }


        }
        private void incrementIndexByConfederation(string confederation, int group)
        {
            switch (group)
            {
                case 0:
                    switch (confederation)
                    {
                        case "EU":
                            Form1.indexEurope[0]++;
                            break;
                        case "AF":
                            Form1.indexAfrica[0]++;
                            break;
                        case "AS":
                            Form1.indexAsia[0]++;
                            break;
                        case "NA":
                            Form1.indexNorthAmerica[0]++;
                            break;
                        case "SA":
                            Form1.indexSouthAmerica[0]++;
                            break;
                    }
                    break;
                case 1:
                    switch (confederation)
                    {
                        case "EU":
                            Form1.indexEurope[1]++;
                            break;
                        case "AF":
                            Form1.indexAfrica[1]++;
                            break;
                        case "AS":
                            Form1.indexAsia[1]++;
                            break;
                        case "NA":
                            Form1.indexNorthAmerica[1]++;
                            break;
                        case "SA":
                            Form1.indexSouthAmerica[1]++;
                            break;
                    }
                    break;
                case 2:
                    switch (confederation)
                    {
                        case "EU":
                            Form1.indexEurope[2]++;
                            break;
                        case "AF":
                            Form1.indexAfrica[2]++;
                            break;
                        case "AS":
                            Form1.indexAsia[2]++;
                            break;
                        case "NA":
                            Form1.indexNorthAmerica[2]++;
                            break;
                        case "SA":
                            Form1.indexSouthAmerica[2]++;
                            break;
                    }
                    break;
                case 3:
                    switch (confederation)
                    {
                        case "EU":
                            Form1.indexEurope[3]++;
                            break;
                        case "AF":
                            Form1.indexAfrica[3]++;
                            break;
                        case "AS":
                            Form1.indexAsia[3]++;
                            break;
                        case "NA":
                            Form1.indexNorthAmerica[3]++;
                            break;
                        case "SA":
                            Form1.indexSouthAmerica[3]++;
                            break;
                    }
                    break;
                case 4:
                    switch (confederation)
                    {
                        case "EU":
                            Form1.indexEurope[4]++;
                            break;
                        case "AF":
                            Form1.indexAfrica[4]++;
                            break;
                        case "AS":
                            Form1.indexAsia[4]++;
                            break;
                        case "NA":
                            Form1.indexNorthAmerica[4]++;
                            break;
                        case "SA":
                            Form1.indexSouthAmerica[4]++;
                            break;
                    }
                    break;
                case 5:
                    switch (confederation)
                    {
                        case "EU":
                            Form1.indexEurope[5]++;
                            break;
                        case "AF":
                            Form1.indexAfrica[5]++;
                            break;
                        case "AS":
                            Form1.indexAsia[5]++;
                            break;
                        case "NA":
                            Form1.indexNorthAmerica[5]++;
                            break;
                        case "SA":
                            Form1.indexSouthAmerica[5]++;
                            break;
                    }
                    break;
                case 6:
                    switch (confederation)
                    {
                        case "EU":
                            Form1.indexEurope[6]++;
                            break;
                        case "AF":
                            Form1.indexAfrica[6]++;
                            break;
                        case "AS":
                            Form1.indexAsia[6]++;
                            break;
                        case "NA":
                            Form1.indexNorthAmerica[6]++;
                            break;
                        case "SA":
                            Form1.indexSouthAmerica[6]++;
                            break;
                    }
                    break;
                case 7:
                    switch (confederation)
                    {
                        case "EU":
                            Form1.indexEurope[7]++;
                            break;
                        case "AF":
                            Form1.indexAfrica[7]++;
                            break;
                        case "AS":
                            Form1.indexAsia[7]++;
                            break;
                        case "NA":
                            Form1.indexNorthAmerica[7]++;
                            break;
                        case "SA":
                            Form1.indexSouthAmerica[7]++;
                            break;
                    }
                    break;
            }
        }
    }
}