using Demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo1.Controllers
{
    public class D1Controller : Controller
    {
        // GET: D1
        public ActionResult Index()
        {
            return View();
        }

        public String Action1()
        {
            return "String returned by Action1";
        }
        public ActionResult Action2()
        {

            return View();
        }
        public ActionResult Action3()
        {
            ViewBag.Message = "Data passed to action3 using viewbag";
            return View();
        }
        public ActionResult Action4()
        {
            ViewData["M"] = "Data passed to action4 using viewdata";
            return View();
        }

        public ActionResult Action5()
        {

            ViewBag.Message = "View fetches data itself, wrong approach";
            return View();
        }
        public ActionResult Action6()
        {

            ViewBag.Message = "View receives data as model from action, right approach";
            //DB fetch simulation 
            Member m = new Member()
            {
                FirstName = "Yagnesh",
                LastName = " Parekh",
                MembershipID = 102,
                MembershipType = "Platinum"
            };
            return View(m);
        }


        public ActionResult Action7()
        {
            ViewBag.Message = "View receives data as list from action, right approach";

            //DB Simulation
            List<Member> members = new List<Member>();

            members.Add(new Member()
            {
                FirstName = "Yag",
                LastName = "Parekh",
                MembershipID = 101,
                MembershipType = "Gold"
            });
            members.Add(new Member()
            {
                FirstName = "Yan",
                LastName = "Limbachiya",
                MembershipID = 102,
                MembershipType = "Silver"
            });
            members.Add(new Member()
            {
                FirstName = "Moti",
                LastName = "Parekh",
                MembershipID = 103,
                MembershipType = "Platinum"
            });

            return View(members);
        }

        public ActionResult Action8()
        {
            ViewBag.Message = "View receiving from VM(View Model)";
            ReportEODVM rvm = new ReportEODVM();
            //db simulation : fetch top game of today
            Game game = new Game()
            {
                Title = "Mario",
                Price = 10
            };
            rvm.topGame = game;

            //db simulation fetch today's new members
            List<Member> members = new List<Member>();
            members.Add(new Member() { FirstName = "Naruto", LastName = "Uchiha", MembershipID = 109, MembershipType = "Silver" });
            members.Add(new Member() { FirstName = "Sasuke", LastName = "Uzumaki", MembershipID = 109, MembershipType = "Silver" });
            members.Add(new Member() { FirstName = "Sakura", LastName = "Hanuro", MembershipID = 109, MembershipType = "Silver" });
            rvm.newMembers = members;

            return View(rvm);

        }
    }
}