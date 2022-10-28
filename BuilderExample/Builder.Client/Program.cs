using Food.Builder.Composite.Ingredients;
using Food.Builder.Director;

var builder = new Director();

builder.SetBuilder(name: "Mistureba", amount: 3); // ou builder.setBuilder().InicializeBuilder();

// var food = builder.InicializeBuilder(iniciarComPadroes: true) Inicia com os métodos do builder, para escolher os parâmetros que o programa vai iniciar
var food = builder.InicializeBuilder(iniciarComPadroes: true).MakeParameters(); // Método de customização

Console.WriteLine($"O nome atual é {food.GetName()}");
Console.WriteLine($"A quantidade atual é {food.GetAmount()}");

food.SetName("Comida"); // Alterar nome
food.SetAmount(1); // Alterar quantidade de pratos feitos

Console.WriteLine($"O nome atual é {food.GetName()}"); // Retorna o nome da comida
Console.WriteLine($"A quantidade atual é {food.GetAmount()}"); // Retorna a quantidade da comida que foi feita

Console.WriteLine($"A quantidade de ingredientes usados foi {food.GetIngredientsAmount()}"); // Retorna a quantidade de ingredientes usados

food.GetIngredients().ForEach(i => Console.WriteLine($"{i} foi utilizado para este prato")); // Retorna uma lista de ingredientes

var Cebola = new IngredientComposite("Cebola", 5); // Cria um novo ingrediente
var TomateCereja = new IngredientComposite("TomateCereja", 14); // Cria um novo ingrediente

food.Add(Cebola); // Adiciona um ingrediente porr vez

Console.WriteLine($"A quantidade de ingredientes usados foi {food.GetIngredientsAmount()}");
food.GetIngredients().ForEach(i => Console.WriteLine($"{i} foi utilizado para este prato"));

food.AddAll(Cebola, TomateCereja); // Adicionar vários ingredientes por vez

Console.WriteLine($"A quantidade de ingredientes usados foi {food.GetIngredientsAmount()}");
food.GetIngredients().ForEach(i => Console.WriteLine($"{i} foi utilizado para este prato"));

// tambem poderia fazer assim:
// builder.SetBuilder().InicializeBuilder(true).MakePrincipal().MakeIntermediare().MakeFinale().MakeParameters();