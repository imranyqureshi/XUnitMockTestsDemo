using MockingUnitTestsDemoApp.Impl.Models;
using MockingUnitTestsDemoApp.Impl.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace MockingUnitTestsDemoApp.Impl.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        public Team GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Team> GetForLeague(int leagueID)
        {
            throw new NotImplementedException();
        }
    }
}
