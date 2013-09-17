using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerhoeffAlgorithm
{
    class VerhoeffChecker
    {
        private static int D5(int j, int k)
        {
            int[,] group5 = {
                                 {0,1,2,3,4,5,6,7,8,9},
                                 {1,2,3,4,0,6,7,8,9,5},
                                 {2,3,4,0,1,7,8,9,5,6},
                                 {3,4,0,1,2,8,9,5,6,7},
                                 {4,0,1,2,3,9,5,6,7,8},
                                 {5,9,8,7,6,0,4,3,2,1},
                                 {6,5,9,8,7,1,0,4,3,2},
                                 {7,6,5,9,8,2,1,0,4,3},
                                 {8,7,6,5,9,3,2,1,0,4},
                                 {9,8,7,6,5,4,3,2,1,0}
                             };

            return group5[j,k];
        }
        

    }
}
