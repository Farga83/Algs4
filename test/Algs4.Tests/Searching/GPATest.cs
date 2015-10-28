using System.Collections.Generic;
using Algs4.Searching;
using NUnit.Framework;

namespace Algs4.Test.Searching {
    [TestFixture]
    public class GPATest {

        [Test]
        public void Two_As_Two_Bs_35_Average() {
            var gpa = new GPA();
            var average = gpa.CalculateGradeAverages(
                new List<string> {
                    "A",
                    "A",
                    "B",
                    "B"
                }
            );
            Assert.AreEqual(3.50, average);
        }
    }
}
