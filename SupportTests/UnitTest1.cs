namespace SupportTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
    
    // [Test]
    // public async Task GetAllProductsAsync_ShouldReturnAllProducts()
    // {
    //     var testProducts = GetTestProducts();
    //     var controller = new SimpleProductController(testProducts);
    //
    //     var result = await controller.GetAllProductsAsync() as List<Product>;
    //     Assert.AreEqual(testProducts.Count, result.Count);
    // }
    //
    // [Test]
    // public void GetProduct_ShouldReturnCorrectProduct()
    // {
    //     var testProducts = GetTestProducts();
    //     var controller = new SimpleProductController(testProducts);
    //
    //     var result = controller.GetProduct(4) as OkNegotiatedContentResult<Product>;
    //     Assert.IsNotNull(result);
    //     Assert.AreEqual(testProducts[3].Name, result.Content.Name);
    // }
}