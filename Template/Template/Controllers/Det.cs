using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Template.Models;

namespace Template.Controllers
{
    public class Det : Controller
    {
        private readonly ApplicationDbConext _db;

        public Det(ApplicationDbConext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var displaydata = _db.Details_Table.ToList();
            return View(displaydata);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Details d)
        {
            if (ModelState.IsValid)
            {
                _db.Add(d);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(d);
        }

        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var getdetails = await _db.Details_Table.FindAsync(id);
            return View(getdetails);
        }

        [HttpPost]

        public async Task<ActionResult> Edit(Details de)
        {
            if (ModelState.IsValid)
            {
                _db.Update(de);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(de);
        }

        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var getdetails = await _db.Details_Table.FindAsync(id);
            return View(getdetails);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(int id)
        {


            var getdetails = await _db.Details_Table.FindAsync(id);
            _db.Details_Table.Remove(getdetails);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}