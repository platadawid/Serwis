using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Serwis.Models;

namespace Serwis.Controllers;

 public class SerwisController : Controller
    {
        private readonly SerwisKomputerowyContext Context;

        public SerwisController(SerwisKomputerowyContext context)
        {
            Context = context;
        }

        public IActionResult Index()
        {
            var serwisy = Context.Serwisy.Include(s => s.Klient).ToList();
            return View(serwisy);
        }

        
        public IActionResult Details(int id)
        {
            var serwiss = Context.Serwisy.Include(x => x.Klient).FirstOrDefault(x => x.Id == id);
            return View(serwiss);
        }

        public IActionResult Create()
        {
            ViewBag.Klienci = new SelectList(
                Context.Klienci
                    .Select(k => new { k.Id, FullName = k.Imie + " " + k.Nazwisko })
                    .ToList(),
                "Id", 
                "FullName"
            );
            return View();
        }

        [HttpPost]
        public IActionResult Create(Serwiss serwis)
        {
            if (ModelState.IsValid)
            {
                Context.Add(serwis);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Klienci = new SelectList(
                Context.Klienci
                    .Select(k => new { k.Id, FullName = k.Imie + " " + k.Nazwisko })
                    .ToList(),
                "Id", 
                "FullName"
            );
            return View(serwis);
        }

        public IActionResult Edit(int? id)
        {
            ViewBag.Klienci = new SelectList(
                Context.Klienci
                    .Select(k => new { k.Id, FullName = k.Imie + " " + k.Nazwisko })
                    .ToList(),
                "Id", 
                "FullName"
            );

            var serwis = Context.Serwisy.Find(id);
            if (serwis == null) return NotFound();

            return View(serwis);
        }

        [HttpPost]
        public IActionResult Edit(int id, Serwiss serwis)
        {
            if (id != serwis.Id) return NotFound();

            if (ModelState.IsValid)
            {
                var serwiss = Context.Serwisy.FirstOrDefault(x => x.Id == id);
                serwiss.Opis = serwis.Opis;
                serwiss.DataZgloszenia = serwis.DataZgloszenia;
                serwiss.Nazwa = serwis.Nazwa;
                serwiss.KlientId = serwis.KlientId;

                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(serwis);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            var serwis = Context.Serwisy.Include(x => x.Klient).FirstOrDefault(x => x.Id == id);
            if (serwis == null) return NotFound();

            return View(serwis);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var serwis = Context.Serwisy.Find(id);
            Context.Serwisy.Remove(serwis);
            Context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }