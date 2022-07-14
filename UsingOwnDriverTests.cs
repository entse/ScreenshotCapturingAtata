using Atata;
using NUnit.Framework;

namespace AtataSamples.ExtentReports
{
    public class UsingOwnDriverTests : UITestFixture
    {
        [Test]
        public void Test()
        {
            Go.To<HomePage>()
                .PageTitle.Should.Not.Contain("Atata");
        }

        [TearDown]
        public void Teardown()
        {
            Go.To<SignInPage>();
        }
    }
}
