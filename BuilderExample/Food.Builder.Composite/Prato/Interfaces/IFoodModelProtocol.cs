using Food.Builder.Composite.Ingredients;

namespace Food.Builder.Composite.Interfaces
{
    public interface IFoodModelProtocol
    {
        public string Name { get; }
        private List<IngredientComposite> Ingredients { get => Ingredients; }
    }
}
