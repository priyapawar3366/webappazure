using webappazure.Model;

namespace webappazure.Services
{
    public interface IProductService
    {
        List<Products> GetProducts();
    }
}