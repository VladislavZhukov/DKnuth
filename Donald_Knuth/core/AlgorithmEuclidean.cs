using System.Collections.Generic;
using System.Linq;

namespace Donald_Knuth.core
{
    public static class AlgorithmEuclidean
    {
        /// <summary>
        /// GCD
        /// </summary>
        /// <param name="nn1"> natural numbers 1</param>
        /// <param name="nn2"> natural numbers 2</param>
        /// <returns></returns>
        public static int GreatestCommonDivisor(int nn1, int nn2)
        {
            for (var q = nn1 / nn2; q > 0;)
            {
                var r = nn1 % nn2;
                nn1 = nn2;
                nn2 = r;
                if (nn1 != 0 & nn2 != 0)
                {
                    q = nn1 / nn2;
                }
                else
                {
                    q = 0;
                }
            }

            return nn1;
        }

        public static int GreatestCommonDivisorMod(int nn1, int nn2)
        {
            var nn = new List<int> { nn1, nn2 };

            var quantityCycles = 1;

            //nn = nn.OrderByDescending(x => x).ToList();

            if (!nn.Contains(0))
            {
                for (int i = 0; 0 < nn[i] % nn[i + 1]; i++)
                {
                    nn.Add(nn[i] % nn[i + 1]);

                    quantityCycles += 1;
                }
            }

            return nn.Last();
        }
    }
}
