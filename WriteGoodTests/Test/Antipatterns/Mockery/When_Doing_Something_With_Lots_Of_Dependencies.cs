using Rhino.Mocks;
using Should;
using Xunit;

namespace WriteGoodTests.Test.Antipatterns.Mockery
{
    public class When_Doing_Something_With_Lots_Of_Dependencies
    {
        [Fact]
        public void Should_Do_Something_Useful_After_Setting_Up_Dependencies()
        {
            // Heavy setup burden:
            var mockDependency0 = MockRepository.GenerateStub<IDependency0>();
            var mockDependency1 = MockRepository.GenerateStub<IDependency1>();
            var mockDependency2 = MockRepository.GenerateStub<IDependency2>();

            var instanceUnderTest = new ClassUnderTest(mockDependency0, mockDependency1, mockDependency2);

            // TODO: create a more useful assert:
            instanceUnderTest.UsefulFunctionality().ShouldEqual(0);
        }
    }

    public class ClassUnderTest
    {
        private IDependency0 _dependency0;
        private IDependency1 _dependency1;
        private IDependency2 _dependency2;

        public ClassUnderTest(IDependency0 dependency0, IDependency1 dependency1, IDependency2 dependency2)
        {
            _dependency0 = dependency0;
            _dependency1 = dependency1;
            _dependency2 = dependency2;
        }

        public int UsefulFunctionality()
        {
            // TODO: use the depeendencies to do something useful
            return 0;
        }
    }

    public interface IDependency0
    {
    }

    public interface IDependency1
    {
    }

    public interface IDependency2
    {
    }
}
