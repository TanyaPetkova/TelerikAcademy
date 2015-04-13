namespace ParticleSystem
{
    using System.Collections.Generic;

    public interface IParticle
    {
        MatrixCoords Position
        {
            get;
        }
    
        IEnumerable<IParticle> Update();

        bool Exists
        {
            get;
        }
    }
}
