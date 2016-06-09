using System;
using Xunit;

namespace Classic.XUnit.Tests.TearDown
{
    public class ClassicXUnitTearDownPassedTests : IDisposable
    {
        [Fact]
        public void ClassicXUnitTearDown_Passed_Test1() => Assert.Equal(true, true);

        [Fact]
        public void ClassicXUnitTearDown_Passed_Test2() => Assert.Equal(true, true);

        [Fact]
        public void ClassicXUnitTearDown_Passed_Test3() => Assert.Equal(true, true);

        public void Dispose()
        {
                        
        }
    }
}