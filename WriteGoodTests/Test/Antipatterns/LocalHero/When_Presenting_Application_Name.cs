using Should;
using Xunit;

namespace WriteGoodTests.Test.Antipatterns.LocalHero
{
    public class When_Presenting_Application_Name
    {
        [Fact]
        public void Should_IncorporateMachineName()
        {
            new Application().Name.ShouldEqual($"Super Awesome App On {System.Environment.MachineName}", "Presented the wrong application name");
        }
    }

    public class Application
    {
        public string Name => "Super Awesome App On DESKTOP-L2K0RMS";
    }
}
