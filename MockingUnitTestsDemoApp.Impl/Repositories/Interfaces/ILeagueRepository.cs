using MockingUnitTestsDemoApp.Impl.Models;
using System.Collections.Generic;

namespace MockingUnitTestsDemoApp.Impl.Repositories.Interfaces
{
    public interface ILeagueRepository
    {
        League GetByID(int id);
        List<League> GetAll();
        bool IsValid(int leagueID);
    }
}
