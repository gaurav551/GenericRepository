using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using genericRepo.Models;
using genericRepo.Repository;


namespace genericRepo.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var products = _productRepository.GetAll();
            var prds = _productRepository.GetBy(x=>x.ProductName == "abc" && x.Id == 1);

            return View(products);
        }

        public IActionResult Detail(int id){
            var product = _productRepository.GetSingle(x=>x.Id == id);
            return View(product);
        }
         public IActionResult Edit(int id){
            var product = _productRepository.GetSingle(x=>x.Id == id);
            return View(product);
        }

        public IActionResult Create(Product product){
            _productRepository.Create(product);
        return RedirectToAction(nameof(Index));
        }
        public IActionResult New()
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            _productRepository.Remove(x=>x.Id==id);
            return RedirectToAction(nameof(Index));

        }
        [HttpPost]
          public IActionResult Update(Product product){
            _productRepository.Update(product);
        return RedirectToAction(nameof(Index));
          }
    }s
}
