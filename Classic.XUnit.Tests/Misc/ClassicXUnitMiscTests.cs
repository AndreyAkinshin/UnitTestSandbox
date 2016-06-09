using System.Runtime.CompilerServices;
using System.Threading;
using Xunit;
using Xunit.Abstractions;

namespace Classic.XUnit.Tests.Misc
{
    public class ClassicXUnitMiscTests
    {
        private readonly ITestOutputHelper output;

        public ClassicXUnitMiscTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void ClassicXUnitMisc_Uncategorized_Passed() => Passed();

        [Fact]
        public void ClassicXUnitMisc_Uncategorized_Failed() => Failed();

        [Fact]
        public void ClassicXUnitMisc_Uncategorized_Passed_Long()
        {
            Thread.Sleep(5000);
            Passed();
        }

        [Fact(DisplayName = "CustomDisplayName")]
        public void ClassicXUnitMisc_Uncategorized_Passed_CustomDisplayName() => Passed();

        [Trait("Category", "CategoryA")]
        [Fact]
        public void ClassicXUnitMisc_CategoryA_Passed() => Passed();

        [Trait("Category", "CategoryB")]
        [Fact]
        public void ClassicXUnitMisc_CategoryB_Failed() => Failed();

        [Trait("Category", "CategoryA")]
        [Trait("Category", "CategoryB")]
        [Fact]
        public void ClassicXUnitMisc_CategoryAB_Passed() => Passed();

        [Trait("Category", "CategoryA")]
        [Trait("Category", "CategoryC")]
        [Fact]
        public void ClassicXUnitMisc_CategoryAC_Passed() => Passed();

        [Fact(Skip = "SkipMessage1")]
        public void ClassicXUnitMisc_Uncategorized_Skipped()
        {
        }

        [Fact(Skip = "SkipMessage2")]
        [Trait("Category", "CategoryB")]
        [Trait("Category", "CategoryC")]
        public void ClassicXUnitMisc_CategoryBC_Skipped()
        {
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        public void ClassicXUnitMisc_Theory_Passed(int value)
        {
            output.WriteLine("Output: ClassicXUnitMisc_Theory_Passed, value = " + value);
            Assert.True(value % 2 == 1);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void ClassicXUnitMisc_Theory_Failed(int value)
        {
            output.WriteLine("Output: ClassicXUnitMisc_Theory_Failed, value = " + value);
            Assert.True(value % 2 == 1);
        }

        private void Passed([CallerMemberName] string caller = null)
        {
            output.WriteLine("Output: " + caller);
            Assert.Equal(true, true);
        }

        private void Failed([CallerMemberName] string caller = null)
        {
            output.WriteLine("Output: " + caller);
            Assert.Equal(true, false);
        }
    }
}