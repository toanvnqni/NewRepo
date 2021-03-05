using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HopDongCSHT.DAO;
using HopDongCSHT.HDContext;

namespace HopDongCSHT.Controllers
{
    public class HopDongController : Controller
    {
        private CSHT_QNHEntities db = new CSHT_QNHEntities();

        // GET: HopDong
        public ActionResult Index()
        {
            return View(db.HopDongs.ToList());
        }

        // GET: HopDong/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HopDong hopDong = db.HopDongs.Find(id);
            HopDongDAO dao = new HopDongDAO();
            ViewBag.LstFile = dao.DetailsHD(id);
            if (hopDong == null)
            {
                return HttpNotFound();
            }
            return View(hopDong);
        }

        // GET: HopDong/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HopDong/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,SoHopDong,Ten_HD,LoaiHD,CSHT_DiaChi,Ten_A,A_DiaChi,A_DienThoai,A_MST,A_DaiDien,A_ChucVu,ThoiGianThue,TuNgay,DenNgay,DonGia")] HopDong hopDong)
        {
            if (ModelState.IsValid)
            {
                db.HopDongs.Add(hopDong);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hopDong);
        }

        // GET: HopDong/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HopDong hopDong = db.HopDongs.Find(id);
            if (hopDong == null)
            {
                return HttpNotFound();
            }
            return View(hopDong);
        }

        // POST: HopDong/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,SoHopDong,Ten_HD,LoaiHD,CSHT_DiaChi,Ten_A,A_DiaChi,A_DienThoai,A_MST,A_DaiDien,A_ChucVu,ThoiGianThue,TuNgay,DenNgay,DonGia")] HopDong hopDong)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hopDong).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hopDong);
        }

        // GET: HopDong/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HopDong hopDong = db.HopDongs.Find(id);
            if (hopDong == null)
            {
                return HttpNotFound();
            }
            return View(hopDong);
        }

        // POST: HopDong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HopDong hopDong = db.HopDongs.Find(id);
            db.HopDongs.Remove(hopDong);
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
