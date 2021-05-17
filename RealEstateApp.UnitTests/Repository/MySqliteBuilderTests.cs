using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RealEstateApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.UnitTests.Repository
{
    [TestClass]
    public class MySqliteBuilderTests
    {
        [TestMethod]
        public void ShouldBuildQuery()
        {
            MySqliteBuilder sqlBuilder = new MySqliteBuilder();
            sqlBuilder.SetTable("MyTable");
            sqlBuilder.AddClause("Test", "eq", "Me");

            sqlBuilder.GetQuery().Should().Be("SELECT * FROM MyTable WHERE Test = @Test");
            sqlBuilder.GetParams().Should().BeEquivalentTo(new { Test = "Me" });
        }
    }
}
