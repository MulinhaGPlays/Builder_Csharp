using Food.Builder.Composite.Ingredients.Interfaces;

namespace Food.Builder.Composite.Interfaces
{
    public interface IFoodModelProtocol
    {
        private string Name { get => this.Name; }
        private List<IIngredientProtocol> Ingredients { get => Ingredients; }
    }
}
