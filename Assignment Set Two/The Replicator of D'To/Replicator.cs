// Written By: Patrick Leonard
// 2/6/25

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Replicator_of_D_To
{
    public static class Replicator
    {
        public static int[] Replicate(int[] inArr)
        {
            int[] outArr = new int[inArr.Length];

            for(int index = 0; index != inArr.Length; index++)
            {
                outArr[index] = inArr[index];
            }

            return outArr;
        }

    }
}
