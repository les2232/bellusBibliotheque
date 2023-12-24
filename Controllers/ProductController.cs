using bellusBibliotheca2.Models;
using bellusBibliotheca2.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bellusBibliotheca2.Controllers
{
    public class ProductController : Controller
    {
        private Repository<SkincareItem> data { get; set; }
        public ProductController(BellusContext ctx) => data = new Repository<SkincareItem>(ctx);

        public RedirectToActionResult Index() => RedirectToAction("List");

        [Route("[controller]s")]
        public ViewResult List()
        {
            var products = data.List(new QueryOptions<SkincareItem> { OrderBy = p => p.ExpirationDate });
            return View(products);
        }

        [HttpGet]
        public ViewResult Add()
        {
            ViewBag.Action = "Add";
            return View("AddEdit", new SkincareItem());
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var product = data.Get(id);
            return View("AddEdit", product);
        }

        [HttpPost]
        public IActionResult Save(SkincareItem product)
        {
            string message = string.Empty;
            if (ModelState.IsValid)
            {
                if (product.Serial == 0)
                {
                    data.Insert(product);
                    message = product.Name + " was added.";
                }
                else
                {
                    data.Update(product);
                    message = product.Name + " was updated.";
                }
                data.Save();
                TempData["message"] = message;
                return RedirectToAction("List");
            }
            else
            {
                if (product.Serial == 0)
                {
                    ViewBag.Action = "Add";
                }
                else
                {
                    ViewBag.Action = "Edit";
                }
                return View(product);
            }
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var product = data.Get(id);
            return View(product);
        }

        [HttpPost]
        public RedirectToActionResult Delete(SkincareItem product)
        {
            data.Delete(product);
            data.Save();
            TempData["message"] = product.Name + " was deleted.";
            return RedirectToAction("List");
        }

        public IActionResult Manage()
        {
            return View();
        }
        public  IActionResult SearchFor()
        {
            return View();
        }

    }
}