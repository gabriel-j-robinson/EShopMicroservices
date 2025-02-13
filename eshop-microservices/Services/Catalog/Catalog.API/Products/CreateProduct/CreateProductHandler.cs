namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Cagegory, string Description, string ImageFile, decimal Price);
    public record CreateProductResult(Guid Id);

    internal class CreateProductCommandHandler
    {

    }
}
