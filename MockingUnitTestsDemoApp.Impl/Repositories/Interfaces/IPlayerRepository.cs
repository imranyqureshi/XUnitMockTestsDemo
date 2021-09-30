using MockingUnitTestsDemoApp.Impl.Models;
using System.Collections.Generic;

namespace MockingUnitTestsDemoApp.Impl.Repositories.Interfaces
{
    public interface IPlayerRepository
    {
        Player GetByID(int id);
        List<Player> GetForTeam(int id);
    }
}
