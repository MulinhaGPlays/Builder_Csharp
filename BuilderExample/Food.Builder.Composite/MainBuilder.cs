using Builder.Infra.Interfaces;
using Food.Builder.Composite.Ingredients;
using Food.Builder.Composite.Prato;

namespace Food.Builder.Composite
{
    public class MainBuilder : IBuilderProtocol
    {
        private FoodComposite food = new ();

        void IBuilderProtocol.Reset() => this.food = new FoodComposite();

        void IBuilderProtocol.MakePrincipal()
        {
            var Carne = new IngredientComposite("Carne", 5);
            var Cebola = new IngredientComposite("Cebola", 2);
            var Tempero = new IngredientComposite("Tempero", 3);
            this.food.AddAll(Carne, Cebola, Tempero);
        }
        void IBuilderProtocol.MakeIntermediare()
        {
            var Arroz = new IngredientComposite("Arroz", 2);
            this.food.Add(Arroz);
        }

        void IBuilderProtocol.MakeFinale()
        {
            var FeijaoTropeiro = new IngredientComposite("Feijão Tropeiro", 2);
            this.food.Add(FeijaoTropeiro);
            this.food.SetName("Meu Almoço");
        }
    }
}
