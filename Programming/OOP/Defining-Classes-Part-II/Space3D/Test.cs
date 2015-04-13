namespace Space3D
{
    using System.Collections.Generic;

    class Test
    {
        static void Main()
        {
            Point3D point = new Point3D(1, 2, 3);
            Path path = new Path();

            //Add two points to the path
            path.AddPoint(point);
            path.AddPoint(Point3D.Point0);

            //Save the path
            PathStorage.SavePath(path);

            Path someOtherPath = new Path();

            //Add two points to the other path
            someOtherPath.AddPoint(Point3D.Point0);
            someOtherPath.AddPoint(point);

            //Save the other path
            PathStorage.SavePath(someOtherPath);

            //Print all paths
            List<Path> paths = PathStorage.LoadPath();
            PathStorage.PrintPaths(paths);
        }
    }
}
