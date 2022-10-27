using Food.Builder.Composite;
using Food.Builder.Composite.Ingredients;
using Food.Builder.Director;

var director = new Director();
var builder = new MainBuilder();

var tomate = new IngredientComposite("tomate", 5);
var cebola = new IngredientComposite("cebola", 2);
var Alface = new IngredientComposite("Alface", 3);
var carne = new IngredientComposite("Carne", 1);


builder.MakeParameters();
builder.MakeParameters().AddAll(tomate, cebola, Alface, carne);

builder.MakeParameters().SetName("Sanduiche");

Console.WriteLine(builder.MakeParameters().Name);

builder.MakeParameters().GetIngredients().ForEach(i => Console.WriteLine(i));

Console.WriteLine(builder.MakeParameters().GetIngredientsAmount());