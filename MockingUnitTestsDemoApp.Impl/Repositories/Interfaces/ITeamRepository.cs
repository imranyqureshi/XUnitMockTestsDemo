using MockingUnitTestsDemoApp.Impl.Models;
using System.Collections.Generic;

namespace MockingUnitTestsDemoApp.Impl.Repositories.Interfaces
{
    public interface ITeamRepository
    {
        Team GetByID(int id);
        List<Team> GetForLeague(int leagueID);
    }
}
