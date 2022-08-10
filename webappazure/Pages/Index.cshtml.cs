using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webappazure.Model;
using webappazure.Services;

namespace webappazure.Pages
{
    public class IndexModel : PageModel
    {

        private readonly IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public List<Products> Products;
        public void OnGet()
        {
            Products = _productService.GetProducts();

        }
        
    }
}