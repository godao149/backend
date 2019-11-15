using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProvaBackEnd.Models;
using ProvaBackEnd.Models.Entities;

namespace ProvaBackEnd.Controllers
{
    public class ValoresController : Controller
    {
        private FaleMaisContext db = new FaleMaisContext();

        // GET: Valores
        public async Task<ActionResult> Index()
        {
            return View(await db.Valores.ToListAsync());
        }

        // GET: Valores/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Valor valor = await db.Valores.FindAsync(id);
            if (valor == null)
            {
                return HttpNotFound();
            }
            return View(valor);
        }

        // GET: Valores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Valores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Origem,Destino,ValorMin")] Valor valor)
        {
            if (ModelState.IsValid)
            {
                db.Valores.Add(valor);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(valor);
        }

        // GET: Valores/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Valor valor = await db.Valores.FindAsync(id);
            if (valor == null)
            {
                return HttpNotFound();
            }
            return View(valor);
        }

        // POST: Valores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Origem,Destino,ValorMin")] Valor valor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(valor).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(valor);
        }

        // GET: Valores/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Valor valor = await db.Valores.FindAsync(id);
            if (valor == null)
            {
                return HttpNotFound();
            }
            return View(valor);
        }

        // POST: Valores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Valor valor = await db.Valores.FindAsync(id);
            db.Valores.Remove(valor);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
