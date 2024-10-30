using System;
using Microsoft.AspNetCore.Mvc;
using Serwis.Models;

namespace Serwis.Controllers;

public class KlientController : Controller
    {
        private readonly SerwisKomputerowyContext Context;

        public KlientController(SerwisKomputerowyContext context)
        {
            Context = context;
        }

        public IActionResult Index()
        {
            var klienci = Context.Klienci.ToList();
            return View(klienci);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Klient klient)
        {
            if (ModelState.IsValid)
            {
                Context.Add(klient);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(klient);
        }
    }