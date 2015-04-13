namespace ParticleSystem
{
    using System;
    using System.Collections.Generic;

    public class ChaoticParticle : Particle
    {
        public ChaoticParticle(MatrixCoords position, MatrixCoords speed, Random randomGenerator)
            : base(position, speed)
        {
            this.RandomGenerator = randomGenerator;
        }

        public Random RandomGenerator { get; private set; }

        public override IEnumerable<Particle> Update()
        {
            this.Accelerate(new MatrixCoords(-this.Speed.Row, -this.Speed.Col));
            this.Accelerate(new MatrixCoords(RandomGenerator.Next(-2, 2), RandomGenerator.Next(-2, 2)));

            return base.Update();
        }

        public override char[,] GetImage()
        {
            return new char[,] { { 'H' } };
        }
    }
}
