using MockingUnitTestsDemoApp.Impl.Models;
using System.Collections.Generic;

namespace MockingUnitTestsDemoApp.Impl.Services.Interfaces
{
    public interface ITeamService
    {
        List<Team> Search(TeamSearch search);
    }
}
