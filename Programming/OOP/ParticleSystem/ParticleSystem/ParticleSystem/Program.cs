﻿namespace ParticleSystem
{
    using System;

    class Program
    {
        const int Rows = 30;
        const int Cols = 30;

        static readonly Random RandomGenerator = new Random();

        static void Main(string[] args)
        {
            var renderer = new ConsoleRenderer(Rows, Cols);

            var particleOperator = new AdvancedParticleOperator();

            var engine =
                new Engine(renderer, particleOperator, null, 300);

            GenerateInitialData(engine);

            engine.Run();
        }

        private static void GenerateInitialData(Engine engine)
        {
            //engine.AddParticle(
            //    new Particle(
            //        new MatrixCoords(0, 5),
            //        new MatrixCoords(1, 1))
            //    );

            //engine.AddParticle(
            //    new DyingParticle(
            //        new MatrixCoords(20, 5),
            //        new MatrixCoords(-1, 1),
            //        12)
            //    );

            var emitterPosition = new MatrixCoords(29, 3);
            var emitterSpeed = new MatrixCoords(0, 0);
            var emitter = new ParticleEmitter(emitterPosition, emitterSpeed,
                RandomGenerator,
                5,
                2,
                GenerateRandomParticle
                );

            engine.AddParticle(emitter);

            var attractorPosition = new MatrixCoords(10, 3);
            var attractor = new ParticleAttractor(
                attractorPosition,
                new MatrixCoords(0, 0),
                1);

            var attractorPosition2 = new MatrixCoords(10, 13);
            var attractor2 = new ParticleAttractor(
                attractorPosition2,
                new MatrixCoords(0, 0),
                3);

            //engine.AddParticle(attractor);
            //engine.AddParticle(attractor2);

            //Add one chaotic particle to the engine
            //engine.AddParticle(
            //    new ChaoticParticle(
            //       new MatrixCoords(15, 15),
            //       new MatrixCoords(-1, 1),
            //       RandomGenerator)
            //    );

            //Add one chicken particle to the engine
            //engine.AddParticle(
            //    new ChickenParticle(
            //       new MatrixCoords(15, 15),
            //       new MatrixCoords(-1, 1),
            //       RandomGenerator)
            //    );

            //Add one particle repeller to the engine
            //engine.AddParticle(
            //    new ParticleRepeller(
            //       new MatrixCoords(17, 20),
            //       new MatrixCoords(0, 0),
            //       5,
            //       10)
            //    );         
        }

        static Particle GenerateRandomParticle(ParticleEmitter emitterParameter)
        {
            MatrixCoords particlePos = emitterParameter.Position;

            int particleRowSpeed = emitterParameter.RandomGenerator.Next(emitterParameter.MinSpeedCoord, emitterParameter.MaxSpeedCoord + 1);
            int particleColSpeed = emitterParameter.RandomGenerator.Next(emitterParameter.MinSpeedCoord, emitterParameter.MaxSpeedCoord + 1);

            MatrixCoords particleSpeed = new MatrixCoords(particleRowSpeed, particleColSpeed);

            Particle generated = null;

            int particleTypeIndex = emitterParameter.RandomGenerator.Next(0, 2);
            switch (particleTypeIndex)
            {
                case 0: generated = new Particle(particlePos, particleSpeed); break;
                case 1:
                    uint lifespan = (uint)emitterParameter.RandomGenerator.Next(8);
                    generated = new DyingParticle(particlePos, particleSpeed, lifespan);
                    break;
                default:
                    throw new Exception("No such particle for this particleTypeIndex");
                    break;
            }
            return generated;
        }
    }
}
