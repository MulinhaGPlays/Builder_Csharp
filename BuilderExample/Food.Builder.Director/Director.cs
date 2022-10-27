using Food.Builder.Composite;
using Food.Builder.Director.Interfaces;

namespace Food.Builder.Director
{
    public class Director : IDirector
    {
        private readonly MainBuilder builder = new();
        
        public Director SetBuilder()
        {
            builder.Reset();
            return this;
        }
        
        public Director InicializeBuilder()
        {
            builder.MakePrincipal();
            builder.MakeIntermediare();
            builder.MakeFinale();
            return this;
        }
    }
}
