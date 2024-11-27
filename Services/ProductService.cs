using ECommerceWebApp.Models;
using System.Net.Http;
using System.Net.Http.Json;

public class ProductService
{
    private readonly HttpClient _httpClient;

    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Product>> GetProductsAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Product>>("api/Products");
    }

    public async Task<Product> GetProductByIdAsync(int id)
    {
        return await _httpClient.GetFromJsonAsync<Product>($"api/Products/{id}");
    }

    public async Task AddProductAsync(Product product)
    {
        await _httpClient.PostAsJsonAsync("api/Products", product);
    }

    public async Task UpdateProductAsync(int id, Product product)
    {
        await _httpClient.PutAsJsonAsync($"api/Products/{id}", product);
    }

    public async Task DeleteProductAsync(int id)
    {
        await _httpClient.DeleteAsync($"api/Products/{id}");
    }
}
