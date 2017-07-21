using FluentAssertions;
using Katayuno;
using Xunit;

namespace Tests
{
    public class Test
    {
        [Fact]
        public void Foo_DoFoo_Returns_Foo()
        {
            // arrange
            var bar = new Bar();
            var sut = new Foo(bar);

            // act
            var result = sut.DoFoo();

            // assert
            result.Should().Be("FooBar");
        }

        [Fact]
        public void Bar_DoBar_Returns_Bar()
        {
            // arrange
            var sut = new Bar();

            // act
            var result = sut.DoBar();

            // assert
            result.Should().Be("Bar");
        }
    }
}
