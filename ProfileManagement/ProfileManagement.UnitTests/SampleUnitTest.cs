using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace ProfileManagement.ProfileManagement.UnitTests
{
    public class SampleUnitTest
    {

        [Test]
        public void SampleUnitTestPass()
        {
            Assert.True(true);
        }

        [Test]
        public void SampleUnitTestFail()
        {
            Assert.False(false);
        }
    }
}
