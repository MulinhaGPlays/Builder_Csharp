using Builder.Domain.Entidades;

namespace Builder.Domain
{
    public class MealBox : IMealCompositeProtocol
    {
        public List<Meal> Meals = new();

        public int GetPrice() => Meals.Sum(x => x.GetPrice());

        public List<int> GetPrices()
        {
            List<int> meals = new();
            Meals.ForEach(meal => meals.Add(meal.GetPrice()));
            return meals;
        } 

        public void Add(params Meal[] meals)
        {
            foreach (var meal in meals) Meals.Add(meal);
        }
            
    }
}
