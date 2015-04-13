namespace Space3D
{
    using System.Reflection;
    using System.Text;

    public struct Point3D
    {
        private static readonly Point3D pointO = new Point3D(0, 0, 0);

        public static Point3D Point0
        {
            get
            {
                return Point3D.pointO;
            }
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            StringBuilder content = new StringBuilder();
            PropertyInfo[] properties = this.GetType().GetProperties();

            content.Append("(");

            for (int i = 0; i < properties.Length; i++)
            {
                if (properties[i].GetValue(this) != null && !properties[i].GetGetMethod().IsStatic)
                {
                    content.Append(properties[i].GetValue(this));

                    if (i != properties.Length - 1)
                    {
                        content.Append(",");
                    }
                }
            }

            content.Append(")");

            return content.ToString();
        }
    }
}