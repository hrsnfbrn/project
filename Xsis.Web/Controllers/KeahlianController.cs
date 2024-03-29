﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xsis.Model;
using Xsis.Repo;

namespace Xsis.Web.Controllers
{
    public class KeahlianController : Controller
    {
        // GET: Keahlian
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tampil()
        {
            return Json(KeahlianRepo.GetAll(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        public ActionResult Save(Keahlian keahlian)
        {
            keahlian.created_by = Convert.ToInt64(Session["foo"]);
            if (KeahlianRepo.Createkeahlian(keahlian))
            {
                return Json(new { Simpan = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Simpan = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
            return View();
        }

        public ActionResult Edit(int ID)
        {
            return PartialView("_Edit");
        }

        public ActionResult AmbilData(int ID)
        {
            return Json(KeahlianRepo.GetByID(ID), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Delete(int ID)
        {
            if (KeahlianRepo.Deletekeahlian(ID)) //non static if ( KeahlianRepo.Deletekeahlian(ID))
            {
                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}