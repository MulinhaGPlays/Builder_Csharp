using Builder.Infra.Interfaces;
using Food.Builder.Composite.Ingredients;
using Food.Builder.Composite.Interfaces;
using Food.Builder.Composite.Prato.Interfaces;

namespace Food.Builder.Composite.Prato
{
    public class FoodComposite : IFoodProtocol
    {
        public string Name { get; set; }
        public List<IngredientComposite> Ingredients { get; set; }

        public FoodComposite(string name = "", params IngredientComposite[] ingredients)
        {
            this.Name = name;
            this.Ingredients = new ();
            foreach (var ingredient in ingredients) this.Ingredients.Add(ingredient);
        }

        public void SetName(string name) => this.Name = name;

        public int GetIngredientsAmount() => this.Ingredients.Sum(i => i.Amount);
        public List<string> GetIngredients()
        {
            List<string> ListIngredients = new();
            this.Ingredients.ForEach(i => ListIngredients.Add(i.Name));
            return ListIngredients;
        }
        public void Add(IngredientComposite ingredient) => this.Ingredients.Add(ingredient);
        public void AddAll(params IngredientComposite[] ingredients)
        {
            foreach (var ingredient in ingredients)
                this.Ingredients.Add(ingredient);
        }
    }
}
