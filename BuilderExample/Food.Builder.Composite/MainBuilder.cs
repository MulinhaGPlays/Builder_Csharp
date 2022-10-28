using Builder.Infra.Interfaces;
using Food.Builder.Composite.Ingredients;
using Food.Builder.Composite.Interfaces;
using Food.Builder.Composite.Prato;

namespace Food.Builder.Composite
{
    public class MainBuilder : IBuilderProtocol, IFoodBuilderProtocol
    {
        private FoodComposite food = new ();

        public void Reset() => this.food = new FoodComposite();

        public void MakePrincipal()
        {
            var Carne = new IngredientComposite("Carne", 5);
            var Cebola = new IngredientComposite("Cebola", 2);
            var Tempero = new IngredientComposite("Tempero", 3);
            this.food.AddAll(Carne, Cebola, Tempero);
            this.food.SetName("Carne Acebolada");
        }
        public void MakeIntermediare()
        {
            var Arroz = new IngredientComposite("Arroz", 2);
            this.food.Add(Arroz);
            this.food.SetName("Arroz Cozido");
        }
        public void MakeFinale()
        {
            var FeijaoTropeiro = new IngredientComposite("Feijão Tropeiro", 2);
            this.food.Add(FeijaoTropeiro);
            this.food.SetName("Meu Almoço");
        }
        public FoodComposite MakeParameters() => this.food;
    }
}
