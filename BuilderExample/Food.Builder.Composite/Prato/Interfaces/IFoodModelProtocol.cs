using Food.Builder.Composite.Ingredients;

namespace Food.Builder.Composite.Interfaces
{
    public interface IFoodModelProtocol
    {
        public string Name { get; set; }
        public List<IngredientComposite> Ingredients { get; set; }
    }
}
