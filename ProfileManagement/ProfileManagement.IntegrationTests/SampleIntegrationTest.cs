using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace ProfileManagement.ProfileManagement.IntegrationTests
{
    public class SampleIntegrationTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void SampleIntegrationTestPass()
        {
            Assert.True(true);
        }

        [Test]
        public void SampleIntegrationTestFail()
        {
            //Assert.False(false);
        }


        [TearDown]
        public void TearDown()
        {

        }
    }
}
