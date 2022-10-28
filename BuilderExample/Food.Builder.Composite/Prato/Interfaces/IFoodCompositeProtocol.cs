using Food.Builder.Composite.Ingredients.Interfaces;

namespace Food.Builder.Composite.Prato.Interfaces
{
    public interface IFoodCompositeProtocol
    {
        public int GetIngredientsAmount();
        public List<string> GetIngredients();
        public void SetName(string name);
        public void Add(IIngredientModelProtocol ingredient);
        public void AddAll(params IIngredientModelProtocol[] ingredients);
    }
}
