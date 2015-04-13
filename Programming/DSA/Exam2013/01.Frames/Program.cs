namespace Frames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        static SortedSet<string> result = new SortedSet<string>();

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var frames = new Frame[n];
            for (int i = 0; i < n; i++)
            {
                string[] sizes = Console.ReadLine().Split(' ');
                frames[i] = new Frame(int.Parse(sizes[0]), int.Parse(sizes[1]));
            }

            Perm(frames, 0);
            Console.WriteLine(result.Count);
            var output = new StringBuilder();
            foreach (var frame in result)
            {
                output.AppendLine(frame);
            }

            Console.WriteLine(output.ToString().Trim());
        }

        static void Perm(Frame[] arr, int k)
        {
            if (k >= arr.Length)
            {
                result.Add(string.Join(" | ", arr));
            }
            else
            {
                Perm(arr, k + 1);
                SwapFrame(ref arr[k]);
                Perm(arr, k + 1);

                for (int i = k + 1; i < arr.Length; i++)
                {
                    Swap(ref arr[k], ref arr[i]);

                    Perm(arr, k + 1);
                    SwapFrame(ref arr[k]); 
                    Perm(arr, k + 1);

                    Swap(ref arr[k], ref arr[i]);
                }
            }
        }

        static void SwapFrame(ref Frame frame)
        {
            int oldFirst = frame.Width;
            frame.Width = frame.Heigth;
            frame.Heigth = oldFirst;
        }

        static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }

        struct Frame
        {
            public Frame(int width, int height)
                : this()
            {
                this.Width = width;
                this.Heigth = height;
            }

            public int Width { get; set; }

            public int Heigth { get; set; }

            public override string ToString()
            {
                return string.Format("({0}, {1})", this.Width, this.Heigth);
            }
        }
    }
}
