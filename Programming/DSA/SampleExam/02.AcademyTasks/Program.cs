namespace AcademyTasks
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static List<int> tasks = new List<int>();
        static int variety;
        static int bestSoluton = int.MaxValue;
        static int maxIndex = -1;

        public static void Main()
        {
            string[] tasksAsString = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            variety = int.Parse(Console.ReadLine());
            foreach (var task in tasksAsString)
            {
                tasks.Add(int.Parse(task));
            }

            bestSoluton = tasks.Count;

            int currentMin = tasks[0];
            int currentMax = tasks[0];
            for (int i = 0; i < tasks.Count; i++)
            {
                currentMin = Math.Min(currentMin, tasks[i]);
                currentMax = Math.Max(currentMax, tasks[i]);
                if (currentMax - currentMin >= variety)
                {
                    maxIndex = i;
                    break;
                }
            }

            if (maxIndex == -1)
            {
                Console.WriteLine(tasks.Count);
                return;
            }


            Solve(0, 1, tasks[0], tasks[0]);
            Console.WriteLine(bestSoluton);
        }

        static void Solve(int currentIndex, int taskSolved, int currentMin, int currentMax)
        {
            if (variety <= currentMax - currentMin)
            {
                bestSoluton = Math.Min(bestSoluton, taskSolved);
                return;
            }

            if (currentIndex >= maxIndex)
            {
                return;
            }

            for (int i = 2; i >= 1; i--)
            {
                if (currentIndex + i < tasks.Count)
                {
                    Solve(currentIndex + i, taskSolved + 1,
                        Math.Min(currentMin, tasks[currentIndex + i]),
                        Math.Max(currentMax, tasks[currentIndex + i]));

                    if (bestSoluton != tasks.Count)
                    {
                        return;
                    }
                }
            }
        }
    }
}
