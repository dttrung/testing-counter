using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(numTeams(new int[7] { 1, 1, 2, 5, 3, 4, 1 }));
            Console.WriteLine(numTeams(new int[5] { 2,5,3,4,1 }));
            Console.WriteLine(numTeams(new int[3] { 2,1,3 }));
            Console.WriteLine(numTeams(new int[4] { 1,2,3,4 }));
            Console.ReadLine();
        }

        public static int numTeams(int[] rating)
        {
            int result = 0;
            for (int i = 1; i < rating.Length - 1; ++i)
            {
                int[] lesser = new int[2];
                int[] greater = new int[2];
                for (int j = 0; j < rating.Length; ++j)
                {
                    if (rating[i] < rating[j])
                        ++lesser[j > i ? 1 : 0];
                    if (rating[i] > rating[j])
                        ++greater[j > i ? 1 : 0];
                }
                result += lesser[0] * greater[1] + greater[0] * lesser[1];
            }
            return result;
        }
    }
}
