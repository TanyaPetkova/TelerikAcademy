﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class ParticleRepellerUpdater : ParticleUpdater
    {
        List<ParticleRepeller> repellers = new List<ParticleRepeller>();
        List<Particle> particles = new List<Particle>();

        public override IEnumerable<Particle> OperateOn(Particle p)
        {
            var repellerCandidate = p as ParticleRepeller;
            if (repellerCandidate == null)
            {
                this.particles.Add(p);
            }
            else
            {
                this.repellers.Add(repellerCandidate);
            }

            return base.OperateOn(p);
        }

        public override void TickEnded()
        {
            foreach (var repeller in this.repellers)
            {
                foreach (var particle in this.particles)
                {
                    int radius = (int)Math.Sqrt((repeller.Position.Col - particle.Position.Col) * (repeller.Position.Col - particle.Position.Col) + (repeller.Position.Row - particle.Position.Row) * (repeller.Position.Row - particle.Position.Row));

                    if (radius < repeller.Radius)
                    {
                        var currAcceleration = GetAccelerationFromRepellerToParticle(repeller, particle);

                        particle.Accelerate(currAcceleration);
                    }
                }
            }

            this.repellers.Clear();
            this.particles.Clear();
            base.TickEnded();
        }

        private static MatrixCoords GetAccelerationFromRepellerToParticle(ParticleRepeller repeller, Particle particle)
        {
            var currParticleToAttractorVector = repeller.Position - particle.Position;

            int pToAttrRow = currParticleToAttractorVector.Row;
            pToAttrRow = DecreaseVectorCoordToPower(repeller, pToAttrRow);

            int pToAttrCol = currParticleToAttractorVector.Col;
            pToAttrCol = DecreaseVectorCoordToPower(repeller, pToAttrCol);

            var currAcceleration = new MatrixCoords(-pToAttrRow, -pToAttrCol);
            return currAcceleration;
        }

        private static int DecreaseVectorCoordToPower(ParticleRepeller repeller, int rToParticleCoord)
        {
            if (Math.Abs(rToParticleCoord) > repeller.RepulsiveForce)
            {
                rToParticleCoord = (rToParticleCoord / (int)Math.Abs(rToParticleCoord)) * repeller.RepulsiveForce;
            }
            return rToParticleCoord;
        }
    }
}
