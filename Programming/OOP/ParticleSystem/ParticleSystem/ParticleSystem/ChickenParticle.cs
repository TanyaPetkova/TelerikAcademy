namespace ParticleSystem
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public class ChickenParticle : ChaoticParticle
    {
        public ChickenParticle(MatrixCoords position, MatrixCoords speed, Random randomGenerator)
            : base(position, speed, randomGenerator)
        {
            this.TickCounter = (uint)randomGenerator.Next(5);
            this.StopCounter = (uint)randomGenerator.Next(5,10);
        }

        public uint TickCounter { get; private set; }
        public uint StopCounter { get; private set; }

        public override IEnumerable<Particle> Update()
        {
            if (this.TickCounter == 0)
            {
                if (this.StopCounter != 0)
                {
                    this.StopCounter--;

                    this.Accelerate(new MatrixCoords(-this.Speed.Row,-this.Speed.Col));
                    return new List<Particle>();
                }
                else
                {
                    var produced = new List<Particle>() { new ChickenParticle(this.Position, this.Speed, RandomGenerator) };

                    this.TickCounter = (uint)RandomGenerator.Next(5);
                    this.StopCounter = (uint)RandomGenerator.Next(5, 10);
                    return produced;
                }
            }
            else
            {
                this.TickCounter--;
                return base.Update();
            }
        }

        public override char[,] GetImage()
        {
            return new char[,] { { '@' } };
        }
    }
}
