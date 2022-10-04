using EntityFrameWork.Data;
using EntityFrameWork.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWork.Controllers
{
    public class HomeController : Controller
    {
        public  HomeController(AppDbContext context)
        {
            _context = context;
        }


        private readonly AppDbContext _context;
        public IActionResult Index()
        {
            List<slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }

        

        
    }
}
