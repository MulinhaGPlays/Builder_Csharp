using Food.Builder.Composite.Ingredients.Interfaces;
using Food.Builder.Composite.Prato.Interfaces;

namespace Food.Builder.Composite.Prato
{
    public class FoodComposite : IFoodProtocol
    {
        private string Name { get; set; }
        private int Amount { get; set; }
        private List<IIngredientProtocol> Ingredients { get; set; }

        public FoodComposite(string name = "", int amount = 1, params IIngredientProtocol[] ingredients)
        {
            this.Amount = amount;
            this.Name = name;
            this.Ingredients = new List<IIngredientProtocol>();
            foreach (var ingredient in ingredients) 
                this.Ingredients.Add(ingredient);
        }

        public void SetName(string name) => this.Name = name;

        public void SetAmount(int amount) => this.Amount = amount;

        public string GetName() => this.Name;

        public int GetAmount() => this.Amount;

        public int GetIngredientsAmount() => this.Ingredients.Sum(i => i.GetAmount());

        public List<string> GetIngredients()
        {
            List<string> ListIngredients = new();
            this.Ingredients.ForEach(i => ListIngredients.Add(i.GetName()));
            return ListIngredients;
        }

        public void Add(IIngredientProtocol ingredient) => this.Ingredients.Add(ingredient);

        public void AddAll(params IIngredientProtocol[] ingredients)
        {
            foreach (var ingredient in ingredients) 
                this.Ingredients.Add(ingredient);
        }
    }
}
