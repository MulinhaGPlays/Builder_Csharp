using Food.Builder.Composite.Ingredients;
using Food.Builder.Composite.Interfaces;
using Food.Builder.Composite.Prato;
using Food.Builder.Composite.Prato.Interfaces;

namespace Food.Builder.Composite
{
    public class FoodBuilder : IFoodBuilderProtocol
    {
        private FoodComposite food = new ();

        public IFoodBuilderProtocol Reset() 
        {
            this.food = new FoodComposite();
            return this;
        }

        public IFoodBuilderProtocol MakePrincipal()
        {
            var Carne = new IngredientComposite("Carne", 5);
            var Cebola = new IngredientComposite("Cebola", 2);
            var Tempero = new IngredientComposite("Tempero", 3);
            var BifeAcebolado = new FoodComposite("Bife Acebolado", 1, Carne, Cebola, Tempero);
            this.food.Add(BifeAcebolado);
            return this;
        }
        public IFoodBuilderProtocol MakeIntermediare()
        {
            var Arroz = new IngredientComposite("Arroz", 2);
            var ArrozCozido = new FoodComposite("Arroz Cozido", 1, Arroz);
            this.food.Add(ArrozCozido);
            return this;
        }
        public IFoodBuilderProtocol MakeFinale()
        {
            var Feijao = new IngredientComposite("Feijão", 8);
            var Linguica = new IngredientComposite("Linguica", 12);
            var Verduras = new IngredientComposite("Verduras", 16);
            var FeijaoTropeiro = new FoodComposite("Feijão Tropeiro", 1, Feijao, Linguica, Verduras);
            this.food.Add(FeijaoTropeiro);
            return this;
        }
        public IFoodProtocol MakeParameters() => this.food;
    }
}
