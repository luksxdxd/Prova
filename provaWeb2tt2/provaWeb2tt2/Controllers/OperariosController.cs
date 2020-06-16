using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using provaWeb2tt2.Models;

namespace provaWeb2tt2.Controllers
{
    public class OperariosController : Controller
    {
        private Context db = new Context();

        // GET: Operarios
        public ActionResult Index()
        {
            return View(db.Operarios.ToList());
        }

        // GET: Operarios/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operario operario = db.Operarios.Find(id);
            if (operario == null)
            {
                return HttpNotFound();
            }
            return View(operario);
        }

        // GET: Operarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Operarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nome,Sexo,Endereco,DataN,CarteraT,Fonef,Fonec,Email")] Operario operario)
        {
            if (ModelState.IsValid)
            {
                db.Operarios.Add(operario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(operario);
        }

        // GET: Operarios/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operario operario = db.Operarios.Find(id);
            if (operario == null)
            {
                return HttpNotFound();
            }
            return View(operario);
        }

        // POST: Operarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Nome,Sexo,Endereco,DataN,CarteraT,Fonef,Fonec,Email")] Operario operario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(operario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(operario);
        }

        // GET: Operarios/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operario operario = db.Operarios.Find(id);
            if (operario == null)
            {
                return HttpNotFound();
            }
            return View(operario);
        }

        // POST: Operarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Operario operario = db.Operarios.Find(id);
            db.Operarios.Remove(operario);
            db.SaveChanges();
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
