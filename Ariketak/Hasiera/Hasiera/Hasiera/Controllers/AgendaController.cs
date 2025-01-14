﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hasiera.Models;

namespace Hasiera.Controllers
{
    //githubera igotzen den ikusteko
    public class AgendaController : Controller
    {
        // GET: AgendaController
        public ActionResult Index()
        {
            List<Kontaktua> lstKontaktuak = new List<Kontaktua>();

            Kontaktua kontaktua1 = new Kontaktua("13456765", "izaskun", "Kortabitarte");
            kontaktua1.Emaila = "ikortabitarte@uni.eus";
            lstKontaktuak.Add(kontaktua1);

            Kontaktua kontaktua2 = new Kontaktua("13452345", "pepe", "Fernandez");
            kontaktua2.Emaila = "pfernandez@uni.eus";
            lstKontaktuak.Add(kontaktua2);

            Kontaktua kontaktua3 = new Kontaktua("14567874", "jon", "Perez");
            kontaktua3.Emaila = "jperez@uni.eus";
            lstKontaktuak.Add(kontaktua3);

            Kontaktua kontaktua4 = new Kontaktua("143874", "Jon", "Suinaga");
            kontaktua4.Emaila = "jsuinaga@uni.eus";
            lstKontaktuak.Add(kontaktua4);

            return View(lstKontaktuak);
        }


        // GET: AgendaController/Details/5
        public ActionResult Details()
        {
            Kontaktua kontaktua = new Kontaktua("13456765", "izaskun", "Kortabitarte");
            kontaktua.Emaila = "ikortabitarte@uni.eus";
            return View(kontaktua);
        }


        // GET: AgendaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AgendaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AgendaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AgendaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AgendaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AgendaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
