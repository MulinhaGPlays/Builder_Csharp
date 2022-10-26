using Builder.Domain;

var builder = new MainDishBuilder();

builder.MakeMeal();
Console.WriteLine(builder.GetPrice());

builder.Reset();

builder.MakeBeverage();
Console.WriteLine(builder.GetPrice());