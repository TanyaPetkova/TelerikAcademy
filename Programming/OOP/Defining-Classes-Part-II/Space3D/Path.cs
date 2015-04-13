namespace Space3D
{
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;

    class Path
    {
        private List<Point3D> listOf3DPoints = new List<Point3D>();

        public List<Point3D> ListOf3DPoints
        {
            get 
            {
                return this.listOf3DPoints; 
            }
        }
        
        public void AddPoint(Point3D point)
        {
            this.listOf3DPoints.Add(point);
        }

        public override string ToString()
        {
            return string.Join(" ", this.listOf3DPoints.ToArray());
        }
    }
}
