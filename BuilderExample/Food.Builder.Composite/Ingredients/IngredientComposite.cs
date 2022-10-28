using Food.Builder.Composite.Ingredients.Interfaces;

namespace Food.Builder.Composite.Ingredients
{
    public class IngredientComposite : IIngredientModelProtocol
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public IngredientComposite(string name, int amount)
        {
            this.Name = name;
            this.Amount = amount;
        }
    }
}
