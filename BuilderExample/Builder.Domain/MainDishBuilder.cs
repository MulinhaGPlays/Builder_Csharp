using Builder.Domain.Entidades;
using Builder.Domain.Interfaces;

namespace Builder.Domain
{
    public class MainDishBuilder : IMealBuilderProtocol
    {
        public MealBox _meal = new();

        public void Reset() => _meal = new MealBox();

        public void MakeMeal()
        {
            var arroz = new Meal("arroz", 20);
            var macarrao = new Meal("macarrao", 70);
            var tomate = new Meal("tomate", 40);
            _meal.Add(arroz, tomate, macarrao);
        }
        public void MakeBeverage()
        {
            var Bebida = new Meal("Bebida", 10);
            _meal.Add(Bebida);
        }
        public void MakeDessert()
        {
            var Sobremesa = new Meal("Sobremesa", 10);
            _meal.Add(Sobremesa);
        }
        public MealBox GetMeal() => _meal;

        public int GetPrice() => _meal.GetPrice();
    }
}
