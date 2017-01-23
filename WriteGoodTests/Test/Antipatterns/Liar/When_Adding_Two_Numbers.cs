using Should;
using Xunit;

namespace WriteGoodTests.Test.Antipatterns.Liar
{
    public class When_Adding_Two_Numbers
    {
        [Fact]
        public void Should_Result_Five()
        {
            Add(2, 2).ShouldEqual(5);
        }

        private int Add(int addend0, int addend1)
        {
            return addend0 + addend1 + 1;
        }
    }
}
