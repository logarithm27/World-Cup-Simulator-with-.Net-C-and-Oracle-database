/* Maftoul Omar December 2017 */

namespace worldCupTest2
{
    public static class GroupPhase
    {
        public static void generateSecondTourTeams(Form3 afterPhaseGroupWindow)
        {
            Form1.setDraw.createListOfTeamsAfterGroups();
            afterPhaseGroupWindow.initializeTeamsOfGroups();
            for (int i = 0; i < Form2.winners.Count; i++)
            {
                for (int j = 0; j < Form2.winners[i].Count; j++)
                {
                    afterPhaseGroupWindow.ListOfTeamsPassed[i].Add(Form2.winners[i][j]);
                }
            }
        }
    }
}