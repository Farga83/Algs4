using System;
using System.Collections.Generic;
using System.Linq;

namespace Algs4.Searching {
    public class GPA {
        private static IDictionary<string, double> gpaValues =
          new Dictionary<string, double> {
              { "A+", 4.33 },
              { "A", 4.00 },
              { "A-", 3.67 },
              { "B+", 3.33 },
              { "B", 3.00 },
              { "B-", 2.67 },
              { "C+", 2.33 },
              { "C", 2.00 },
              { "C-", 1.67 },
              { "D", 1.00 },
              { "F", 0.00 }
          };

        public double CalculateGradeAverages(
            IEnumerable<string> grades) {
            var total = 0.0;
            var count = 0;
            foreach (var grade in grades) {
                double gradeValue;
                if(!gpaValues.TryGetValue(grade, out gradeValue)) {
                    throw new ArgumentException(String.Format("Unrecognized grade: {0}", grade));
                }
                total += gradeValue;
                count++;
            }
            return total / count;
        }
    }
}
