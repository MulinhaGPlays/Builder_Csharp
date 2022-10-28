using Food.Builder.Composite.Ingredients.Interfaces;

namespace Food.Builder.Composite.Ingredients
{
    public class IngredientComposite : IIngredientProtocol
    {
        private string Name { get; set; }
        private int Amount { get; set; }

        public IngredientComposite(string name, int amount)
        {
            this.Name = name;
            this.Amount = amount;
        }

        public string GetName() => this.Name;
        public int GetAmount() => this.Amount;
    }
}
