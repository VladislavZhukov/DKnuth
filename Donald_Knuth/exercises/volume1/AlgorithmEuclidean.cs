namespace Donald_Knuth.exercises.volume1
{
    using System.Collections.Generic;
    using System.Linq;

    public static class AlgorithmEuclidean
    {
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
