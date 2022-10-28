namespace Food.Builder.Composite.Ingredients.Interfaces
{
    public interface IIngredientModelProtocol
    {
        string Name { get => this.Name; }
        int Amount { get => this.Amount; }
    }
}
