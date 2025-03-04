﻿using Food.Builder.Composite.Ingredients.Interfaces;
using Food.Builder.Composite.Interfaces;

namespace Food.Builder.Composite.Prato.Interfaces
{
    public interface IFoodProtocol : IFoodModelProtocol, IFoodCompositeProtocol, IIngredientProtocol
    {
    }
}
