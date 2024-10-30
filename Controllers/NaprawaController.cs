using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Serwis.Models;

namespace Serwis.Controllers;

public class NaprawaController : Controller
{
        private readonly SerwisKomputerowyContext Context;

        public NaprawaController(SerwisKomputerowyContext context)
        {
            Context = context;
        }

        public IActionResult Index()
        {
            var naprawy = Context.Naprawy.Include(x => x.Serwis).ToList();
            return View(naprawy);
        }

        public IActionResult Create()
        {
            ViewBag.Serwisy = new SelectList(Context.Serwisy.ToList(), "Id", "Nazwa");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Naprawa naprawa)
        {
            if (ModelState.IsValid)
            {
                Context.Add(naprawa);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Serwisy = new SelectList(Context.Serwisy.ToList(), "Id", "Nazwa");
            return View(naprawa);
        }

    }