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
    public class LigacoesController : Controller
    {
        private FaleMaisContext db = new FaleMaisContext();

        // GET: Ligacoes
        public async Task<ActionResult> Index()
        {
            return View(await db.Ligacoes.ToListAsync());
        }

        // GET: Ligacoes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ligacao ligacao = await db.Ligacoes.FindAsync(id);
            if (ligacao == null)
            {
                return HttpNotFound();
            }
            return View(ligacao);
        }

        // GET: Ligacoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ligacoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Origem,Destino,Tempo,Plano,ValorMinuto")] Ligacao ligacao)
        {
            if (ModelState.IsValid)
            {
                db.Ligacoes.Add(ligacao);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(ligacao);
        }

        // GET: Ligacoes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ligacao ligacao = await db.Ligacoes.FindAsync(id);
            if (ligacao == null)
            {
                return HttpNotFound();
            }
            return View(ligacao);
        }

        // POST: Ligacoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Origem,Destino,Tempo,Plano,ValorMinuto")] Ligacao ligacao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ligacao).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ligacao);
        }

        // GET: Ligacoes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ligacao ligacao = await db.Ligacoes.FindAsync(id);
            if (ligacao == null)
            {
                return HttpNotFound();
            }
            return View(ligacao);
        }

        // POST: Ligacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Ligacao ligacao = await db.Ligacoes.FindAsync(id);
            db.Ligacoes.Remove(ligacao);
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
