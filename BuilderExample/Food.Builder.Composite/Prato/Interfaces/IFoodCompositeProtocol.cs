using Food.Builder.Composite.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Builder.Composite.Prato.Interfaces
{
    public interface IFoodCompositeProtocol
    {
        public int GetIngredientsAmount();
        public List<string> GetIngredients();
        public void SetName(string name);
        public void Add(IngredientComposite ingredient);
        public void AddAll(params IngredientComposite[] ingredients);
    }
}
