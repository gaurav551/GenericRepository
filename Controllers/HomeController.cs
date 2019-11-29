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
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
           

            return View();
        }

        public IActionResult Detail(int id){
           
            return View();
        }

        public IActionResult Create(){
          
        return View();
        }
    }
}
