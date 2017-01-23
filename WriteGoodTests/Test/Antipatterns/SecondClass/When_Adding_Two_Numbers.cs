using Should;
using Xunit;

namespace WriteGoodTests.Test.Antipatterns.SecondClass
{
    public class When_Adding_Two_Numbers
    {
        [Fact]
        public void Should_Result_Four()
        {
            Add(2, 2).ShouldEqual(4);
        }

        [Fact]
        public void Should_Result_Five()
        {
            Add(2, 3).ShouldEqual(5);
        }

        [Fact]
        public void Should_Result_Six()
        {
            Add(3, 3).ShouldEqual(6);
        }

        private int Add(int addend0, int addend1)
        {
            return addend0 + addend1;
        }
    }
}
