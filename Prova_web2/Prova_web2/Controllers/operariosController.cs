using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Prova_web2.Models;

namespace Prova_web2.Controllers
{
    public class operariosController : Controller
    {
        private context db = new context();

        // GET: operarios
        public ActionResult Index()
        {
            return View(db.operarios.ToList());
        }

        // GET: operarios/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            operario operario = db.operarios.Find(id);
            if (operario == null)
            {
                return HttpNotFound();
            }
            return View(operario);
        }

        // GET: operarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: operarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nome,Sexo,Endereco,DataN,CarteraT,Fonef,Fonec,Email")] operario operario)
        {
            if (ModelState.IsValid)
            {
                db.operarios.Add(operario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(operario);
        }

        // GET: operarios/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            operario operario = db.operarios.Find(id);
            if (operario == null)
            {
                return HttpNotFound();
            }
            return View(operario);
        }

        // POST: operarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Nome,Sexo,Endereco,DataN,CarteraT,Fonef,Fonec,Email")] operario operario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(operario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(operario);
        }

        // GET: operarios/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            operario operario = db.operarios.Find(id);
            if (operario == null)
            {
                return HttpNotFound();
            }
            return View(operario);
        }

        // POST: operarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            operario operario = db.operarios.Find(id);
            db.operarios.Remove(operario);
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
