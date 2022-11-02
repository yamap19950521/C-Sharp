using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;
using 練習MVC.Models;

namespace 練習MVC.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult ShowMembers() {
            var memberA = new Member() { Id = 1, Name = "小白", Age = 22 };
            var memberB = new Member() { Id = 2, Name = "小黑", Age = 22 };
            var memberC = new Member() { Id = 3, Name = "小黃", Age = 22 };
            var memberList = new List<Member>() { memberA, memberB, memberC };
            ViewBag.Members = memberList;
            return View();
        }


       // GET: Demo
        public ActionResult Index()
        {
            ViewData["Name"]="小白";
            ViewBag.Name = "小黑";
            TempData["Age"]=27;
            return RedirectToAction("ShowTempData");
        }

        [HttpGet] //Get為預設，可不寫
        public string ShowHelloWorld() {
            return "Hello world";
        }

 
        [HttpGet] //可省略
        public string ShowPrice(string product, string price) {
            return $"商品是:{product}，價格是:{price}";
        }

        public ActionResult ShowTempData() { 
            return View();
        }

   
   
    }
}