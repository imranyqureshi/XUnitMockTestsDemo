using MockingUnitTestsDemoApp.Impl.Models;
using System.Collections.Generic;

namespace MockingUnitTestsDemoApp.Impl.Services.Interfaces
{
    public interface ILeagueService
    {
        bool IsValid(int id);

        List<League> GetAll();
    }
}
