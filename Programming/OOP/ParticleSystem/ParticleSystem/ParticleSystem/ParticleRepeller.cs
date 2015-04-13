namespace ParticleSystem
{
    public class ParticleRepeller : Particle
    {
        public ParticleRepeller(MatrixCoords position, MatrixCoords speed, int repulsiveForce, int radius)
            : base(position, speed)
        {
            this.RepulsiveForce = repulsiveForce;
            this.Radius = radius;
        }

        public int RepulsiveForce { get; private set; }
        public int Radius { get; private set; }

        public override char[,] GetImage()
        {
            return new char[,] { { 'R' } };
        }
    }
}
