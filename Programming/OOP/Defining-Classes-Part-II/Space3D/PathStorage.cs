namespace Space3D
{
    using System.Collections.Generic;
    using System.IO;

    static class PathStorage
    {
        public static void SavePath(Path path)
        {
            StreamWriter writer = new StreamWriter(@"../../path.txt", true);

            using (writer)
            {
                foreach (var point in path.ListOf3DPoints)
                {
                    writer.Write(string.Format("{0},{1},{2} ", point.X, point.Y, point.Z));
                }

                writer.WriteLine();
            }
        }

        public static List<Path> LoadPath()
        {
            StreamReader reader = new StreamReader(@"..\..\path.txt");
            List<Path> paths = new List<Path>();

            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    Path path = new Path();

                    string[] points = line.Trim().Split(' ');

                    foreach (var point in points)
                    {
                        string[] coordinate = point.Split(',');
                        Point3D point3D = new Point3D(int.Parse(coordinate[0]), int.Parse(coordinate[1]), int.Parse(coordinate[2]));
                        path.AddPoint(point3D);
                    }

                    paths.Add(path);
                    line = reader.ReadLine();
                }
            }

            return paths;
        }

        public static void PrintPaths(List<Path> paths)
        {
            foreach (var path in paths)
            {
                System.Console.WriteLine(path);
            }
        }
    }
}
