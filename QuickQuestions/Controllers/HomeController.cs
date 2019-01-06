﻿using QuickQuestions.DAL;
using QuickQuestions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuickQuestions.Controllers
{
    public class HomeController : Controller
    {
        private QuizContext db = new QuizContext();

        public ActionResult Index()
        {
            Category category = new Category { CategoryId = 1, CategoryName = "JavaScript" };
            db.Categories.Add(category);
            db.SaveChanges();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}