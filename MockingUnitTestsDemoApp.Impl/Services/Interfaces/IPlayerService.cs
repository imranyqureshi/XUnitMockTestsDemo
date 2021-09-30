using MockingUnitTestsDemoApp.Impl.Models;
using System.Collections.Generic;

namespace MockingUnitTestsDemoApp.Impl.Services.Interfaces
{
    public interface IPlayerService
    {
        Player GetByID(int id);

        List<Player> GetForLeague(int leagueID);
    }
}
