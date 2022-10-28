using Food.Builder.Composite.Ingredients.Interfaces;

namespace Food.Builder.Composite.Interfaces
{
    public interface IFoodModelProtocol
    {
        public string Name { get; }
        private List<IIngredientModelProtocol> Ingredients { get => Ingredients; }
    }
}
