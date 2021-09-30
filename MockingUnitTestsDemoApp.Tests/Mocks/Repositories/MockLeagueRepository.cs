using MockingUnitTestsDemoApp.Impl.Repositories.Interfaces;
using Moq;

namespace MockingUnitTestsDemoApp.Tests.Mocks.Repositories
{
    public class MockLeagueRepository : Mock<ILeagueRepository>
    {
        public MockLeagueRepository MockIsValid(bool result)
        {
            Setup(x => x.IsValid(It.IsAny<int>()))
                .Returns(result);

            return this;
        }

        public MockLeagueRepository VerifyIsValid(Times times)
        {
            Verify(x => x.IsValid(It.IsAny<int>()), times);

            return this;
        }
    }
}
