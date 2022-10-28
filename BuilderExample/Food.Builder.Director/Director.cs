using Food.Builder.Composite;
using Food.Builder.Director.Interfaces;

namespace Food.Builder.Director
{
    public class Director : IDirector
    {
        private readonly FoodBuilder builder = new();

        public Director SetBuilder(string name = "", int amount = 1)
        {
            builder.Reset();
            builder.MakeParameters().SetName(name);
            builder.MakeParameters().SetAmount(amount);
            return this;
        }
        
        public FoodBuilder InicializeBuilder(bool iniciarComPadroes)
        {
            if (iniciarComPadroes)
            {
                builder.MakePrincipal();
                builder.MakeIntermediare();
                builder.MakeFinale();
            } 
            return builder;
        }
    }
}
