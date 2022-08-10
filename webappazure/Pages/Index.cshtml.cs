using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webappazure.Model;
using webappazure.Services;

namespace webappazure.Pages
{
    public class IndexModel : PageModel
    {

        public List<Products> productlist;
        public void OnGet()
        {
            ProductService productService = new ProductService();
            productlist = productService.GetProducts();
        }
    }
}