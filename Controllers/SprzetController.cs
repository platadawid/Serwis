using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Serwis.Models;

namespace Serwis.Controllers;

    public class SprzetController : Controller
    {
        private readonly SerwisKomputerowyContext Context;

        public SprzetController(SerwisKomputerowyContext context)
        {
            Context = context;
        }

        public IActionResult Index()
        {
            var sprzety = Context.Sprzety.Include(x => x.Serwis).ToList();
            return View(sprzety);
        }

        public IActionResult Create()
        {
            ViewBag.Serwisy = new SelectList(Context.Serwisy.ToList(), "Id", "Nazwa");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Sprzet sprzet)
        {
            if (ModelState.IsValid)
            {
                Context.Add(sprzet);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(sprzet);
        }
    }