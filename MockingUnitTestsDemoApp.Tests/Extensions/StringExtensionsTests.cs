using MockingUnitTestsDemoApp.Impl.Extensions;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MockingUnitTestsDemoApp.Tests.Extensions
{
    public class StringExtensionsTests
    {
        [Theory]
        [InlineData("Test Case", "test case")]
        [InlineData("TeSt CaSe", "tEsT cAsE")]
        [InlineData(null, null)]
        [InlineData("", "")]
        public void StringExtensions_CIEquals_TrueCases(string first, string second)
        {
            var result = first.CIEquals(second);
            Assert.True(result);
        }

        [Theory]
        [InlineData("Test Case", "test case ")]
        [InlineData("TeSt CaSe", "tEsT cAsE 2")]
        [InlineData("Test Case", null)]
        [InlineData("", "Test Case")]
        public void StringExtensions_CIEquals_FalseCases(string first, string second)
        {
            var result = first.CIEquals(second);
            Assert.False(result);
        }

        [Theory]
        [InlineData(null, "")]
        [InlineData("", null)]
        [InlineData(null, null)]
        [InlineData("", "")]
        public void StringExtensions_CIEquals_NullEqualsEmpty_TrueCases(string first, string second)
        {
            var result = first.CIEquals(second, CIEqualsOption.NullEqualsEmpty);
            Assert.True(result);
        }

        [Theory]
        [MemberData(nameof(GetData), parameters: 20)]
        public void StringExtensions_CIEquals_TrueCases_Variation(string first, string second)
        {
            var result = first.CIEquals(second);
            Assert.True(result);
        }

        public static IEnumerable<object[]> GetData(int dataRow)
        {
            var allData = new List<object[]>
        {
            new object[] { "Test Case", "test case" },
            new object[] { "TeSt CaSe", "tEsT cAsE" },
            new object[] { "tEsT cAsE", "TeSt CaSe" },
            new object[] { null, null },
            new object[] { "", "" },
            new object[] {"1","1"},
            new object[] {"~","~"},
            new object[] {"~!@#$%^&*","~!@#$%^&*"},
            new object[] {" "," " }
        };
            return allData.Take(dataRow);
        }
    }
}
