using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCTD_indexer
{
    public static class Toolbox
    {
        public static String [] StartsWithTheSameSubstring(String A, String B)
        {
            // Create return value
            String [] rv = new String[3];

            // Position
            int differposition = 0;

            // Get the length for the upcomming for-loop
            int forcount = 0;
            if(A.Length > B.Length)
            {
                forcount = B.Length;
            }
            else
            {
                forcount = A.Length;
            }

            for(int i=0;i<forcount;i++)
            {
                // When the point is found where the strings differ from each other
                if(A[i] != B[i])
                {
                    differposition = i;
                    i = forcount;
                }
            }

            rv[0] = A.Substring(0, differposition);
            rv[1] = A.Substring(differposition);
            rv[2] = B.Substring(differposition);

            // 0 = The identical part of both strings
            // 1 = The part which is different (Part A)
            // 1 = The part which is different (Part B)
            return rv;
        }
    }
}
