using Builder.Infra.Interfaces;
using Food.Builder.Composite.Prato.Interfaces;

namespace Food.Builder.Composite.Interfaces
{
    public interface IFoodBuilderProtocol : IBuilderProtocol<IFoodBuilderProtocol>
    {
        public IFoodProtocol MakeParameters();
    }
}
