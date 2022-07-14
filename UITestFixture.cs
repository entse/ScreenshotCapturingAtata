using Atata;
using Atata.ExtentReports;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace AtataSamples.ExtentReports
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class UITestFixture
    {
        [SetUp]
        public void SetUp()
        {
            var testContextBuilder = AtataContext.Configure()
                .LogConsumers.Add<ExtentLogConsumer>();
            testContextBuilder.Build();
        }

        [TearDown]
        public void TearDown() =>
            AtataContext.Current?.CleanUp();
    }
}
