using Exercice2_ASP_MVC.Data;
using Exercice2_ASP_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercice2_ASP_MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Product> products = FakeDB.Products;

            return View(products);
        }
        public IActionResult Detail(string reference)
        {
            Product product = FakeDB.Products.SingleOrDefault(p => p.Reference == reference);

            if (product == null)
                return NotFound();

            return View(product);
        }
        public IActionResult Remove(string reference)
        {
            FakeDB.Products.Remove(FakeDB.Products.SingleOrDefault(p => p.Reference == reference));

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Add()
        {
            return View(new ProductForm());
        }
        [HttpPost]
        public IActionResult Add([FromForm] ProductForm productForm)
        {
            if (!(FakeDB.Products.SingleOrDefault(p => p.Reference == productForm.Reference) is null))
            {
                ModelState.AddModelError(productForm.Reference, "La réference existe déja");
            }
            if (!ModelState.IsValid)
            {
                return View(productForm);
            }
            else
            {
                FakeDB.Products.Add
                    (
                    new Product
                    {
                        Name = productForm.Name,
                        Description = productForm.Description,
                        Price = productForm.Price?? 0,
                        Reduction = productForm.Reduction,
                        Reference = productForm.Reference,
                        QuantityInStock = productForm.QuantityInStock ?? 0
                    }
                    );
                return RedirectToAction(nameof(Index));
            }
        }
        public IActionResult AddStock(string reference)
        {
            Product product = FakeDB.Products.SingleOrDefault(p => p.Reference == reference);
            product.QuantityInStock++;
            return RedirectToAction(nameof(Index));
        }
        public IActionResult RemoveStock(string reference)
        {
            Product product = FakeDB.Products.SingleOrDefault(p => p.Reference == reference);
            if (product.QuantityInStock > 0)
                product.QuantityInStock--;
            return RedirectToAction(nameof(Index));
        }
    }
}
