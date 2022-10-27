using Food.Builder.Composite.Ingredients;
using Food.Builder.Composite.Prato;

namespace Food.Builder.Composite.Interfaces
{
    public interface IFoodBuilderProtocol
    {
        public FoodComposite MakeParameters();
    }
}
