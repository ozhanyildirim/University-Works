using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.WebPages;
using WebProje.Models;


namespace WebProje.Controllers
{
    public class AdminMakaleController : Controller
    {
        forumdb db = new forumdb();
        // GET: AdminMakale
        public ActionResult Index()
        {

            var makales = db.Fora.ToList();
            

            return View(makales);
        }

        // GET: AdminMakale/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminMakale/Create
      public ActionResult Create()
        {
            ViewBag.KategoriId = new SelectList(db.Kategoris, "KategoriId", "KategoriAdi");
            return View();
        }

        // POST: AdminMakale/Create
        [HttpPost]
        public ActionResult Create(Forumm forum, string etiketler, HttpPostedFileBase Foto)
        {
            if (ModelState.IsValid)
            {
                if (Foto != null)
                {

                    WebImage img = new WebImage(Foto.InputStream);
                    FileInfo fotoinfo = new FileInfo(Foto.FileName);

                    string newfoto = Guid.NewGuid().ToString() + fotoinfo.Extension;
                    img.Resize(800, 350);
                    img.Save("~/Uploads/MakaleFoto/" + newfoto);
                    forum.Foto = "~/Uploads/MakaleFoto/" + newfoto;

                   

                }
                db.Fora.Add(forum);

               db.SaveChanges();
                if (etiketler != null)

                {
                    string[] etiketdizi = etiketler.Split(',');
                    foreach (var i in etiketdizi)
                    {
                        var yenietiket = new Ticket { EtiketAdi = i };
                        db.Tickets.Add(yenietiket);
                        forum.Tickets.Add(yenietiket);
                    }
                }
               
                
                return RedirectToAction("Index");
            }
             
                return View(forum);
            
        }///


        // GET: AdminMakale/Edit/5
        public ActionResult Edit(int id)
        {
            var makale = db.Fora.Where(m => m.ForumId == id).SingleOrDefault(); 
            if (makale==null)
            {
                return HttpNotFound();

            }
            ViewBag.KategoriId = new SelectList(db.Kategoris, "KategoriId", "KategoriAdi", makale.KategoriId);
            return View(makale);
        }

        // POST: AdminMakale/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, HttpPostedFileBase Foto,Forumm makale)

        {
            try
            {
                var makales = db.Fora.Where(m => m.ForumId == id).SingleOrDefault();
                
                if(Foto!=null)
                {
                    if (System.IO.File.Exists(Server.MapPath(makales.Foto)))
                    {
                        System.IO.File.Delete(Server.MapPath(makales.Foto));

                    }

                    WebImage img = new WebImage(Foto.InputStream);
                    FileInfo fotoinfo = new FileInfo(Foto.FileName);

                    string newfoto = Guid.NewGuid().ToString() + fotoinfo.Extension;
                    img.Resize(800, 350);
                    img.Save("~/Uploads/MakaleFoto/" + newfoto);
                    makales.Foto = "~/Uploads/MakaleFoto/" + newfoto;
                    makales.Baslik = makale.Baslik;
                    makales.Icerik = makale.Icerik;
                    makales.KategoriId = makale.KategoriId;
                    db.SaveChanges();

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminMakale/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminMakale/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
