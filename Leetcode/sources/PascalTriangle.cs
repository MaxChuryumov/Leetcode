// Given an integer numRows, return the first numRows of Pascal's triangle.

// In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
//     1
//    1 1
//   1 2 1
//  1 3 3 1
// 1 4 6 4 1
 

// Example 1:

// Input: numRows = 5
// Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]

using System.Collections.Generic;
using System;

namespace Leetcode.Questions
{
    public static class PascalTriangle
    {
        public static IList<IList<int>> Generate(byte numRows)
        {
            if (numRows == 0)
                throw new ArgumentException("The number of rows must be greater than 0.");

            IList<IList<int>> result = new List<IList<int>>();
            
            result.Add(new List<int>() { 1 });

            for (int i = 0; i < numRows - 1; i++)
            {
                IList<int> targetList = new List<int>();
                targetList.Add(1);

                IList<int> sourceList = result[i];
                for (int j = 0; j < sourceList.Count - 1; j++)
                {
                    targetList.Add(sourceList[j] + sourceList[j + 1]);
                }

                targetList.Add(1);
                result.Add(targetList);
            }

            return result;
        }

        public static void Print(byte numRows)
        {
            IList<IList<int>> rows = Generate(numRows);

            for (int i = 0; i < rows.Count; i++)
            {
                Console.Write(new string(' ', (numRows - i) * 2));

                Console.WriteLine(String.Join("   ", rows[i]));
            }
        }
    }
}