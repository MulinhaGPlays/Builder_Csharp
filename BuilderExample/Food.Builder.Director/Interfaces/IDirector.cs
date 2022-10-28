using Food.Builder.Composite;

namespace Food.Builder.Director.Interfaces
{
    public interface IDirector
    {
        public Director SetBuilder(string name = "", int amount = 1);
        public FoodBuilder InicializeBuilder(bool iniciarComPadroes);
    }
}
