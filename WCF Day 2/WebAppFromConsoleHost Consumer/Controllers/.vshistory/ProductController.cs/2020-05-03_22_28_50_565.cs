using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppFromConsoleHost_Consumer.ServiceStoreReference;

namespace WebAppFromConsoleHost_Consumer.Controllers
{
    public class ProductController : Controller
    {
        ProductsServiceClient client = new ProductsServiceClient("BasicHttpBinding_IProductsService");
        // GET: Product
        public ActionResult Index()
        {            
            return View(client.GetProducts());
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View(client.GetProduct(id));
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                // TODO: Add insert logic here
                client.AddProduct(product);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View(client.GetProduct(id));
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            try
            {
                // TODO: Add update logic here
                client.EditProduct(product);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View(client.GetProduct(id));
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
