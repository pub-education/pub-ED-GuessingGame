using GuessingGame.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;

namespace GuessingGame.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        [Route("/GuessingGame")]
        [Route("/")]
        [HttpGet]
        public IActionResult GuessingGame()
        {
            //string method = HttpContext.Request.Method;
            ViewData["topTen"] = Request.Cookies["topTen"];
            ViewBag.initialRun = true;
            ViewBag.endGame = false;
            ViewBag.response = "";
            ViewBag.showResult = false;
            Reset();
            return View();
        }

        [Route("/GuessingGame")]
        [HttpPost]
        public IActionResult GuessingGameData()
        {
            bool endGame = false;
            ViewBag.initialRun = false;
            ViewBag.response = HttpContext.Session.GetString("resultList");
            ViewBag.showResult = false;
            ViewBag.name = HttpContext.Session.GetString("_name");
            int tmp = (int)HttpContext.Session.GetInt32("_counter") + 1;
            ViewBag.counter = tmp;
            HttpContext.Session.SetInt32("_counter", tmp);

            string tmpResultList = HttpContext.Session.GetString("resultList");

            string name = (string)HttpContext.Session.GetString("_name");
            int target = (int)HttpContext.Session.GetInt32("_targetNumber");
            int guessNr;
            string strButton = HttpContext.Request.Form["callButton"];
            if (strButton == "newGame")
            {
                Reset();
                
            }
            else
            {
                try
                {
                    guessNr = Convert.ToInt32(HttpContext.Request.Form["guessedNumber"]);
                }
                catch (Exception ex)
                {
                    ViewBag.response = ex.Message;
                    guessNr = -1;
                }

                if (name == null)
                {
                    name = HttpContext.Request.Form["name"];
                    ViewBag.name = name;
                    HttpContext.Session.SetString("_name", name);
                }


                if (guessNr == target)
                {
                    ViewBag.response = "Congratulations!";
                    endGame = true;
                }
                else if (guessNr > target)
                {
                    ViewBag.response = "Too high!";
                }
                else
                {
                    ViewBag.response = "Too low!";
                }

                
            if (guessNr > 0)
            {
                if (tmpResultList.Length < 1)
                {
                    tmpResultList = ViewBag.response + ":" + guessNr.ToString();
                }
                else
                {
                    tmpResultList += "," + ViewBag.response + ":" + guessNr.ToString();
                }
            }
                HttpContext.Session.SetString("resultList", tmpResultList);
            if (endGame) EndGame(tmpResultList, tmp);
            }
            
                return View("GuessingGame");
            
        }


        public void Reset()
        {
            ViewBag.counter = 0;
            ViewBag.initialRun = true;
            var ran = new Random();
            int num = ran.Next(1, 100);
            HttpContext.Session.SetInt32("_targetNumber", num);
            HttpContext.Session.SetInt32("_counter", 0);
            HttpContext.Session.SetString("resultList", "");
        }

        public void EndGame(string results, int numbGuesses)
        {
            ViewBag.resultList = results;
            ViewBag.showResult = true;
            /*
            List<string> topTenList = new List<string>();
            string[] items = ViewData["topTen"].ToString().Split(",");
            int val;
            string[] tmpItems = new string[2];
            string tmpStr;
            foreach(string item in items)
            {
                tmpItems = item.Split(':');
                val = Convert.ToInt32(tmpItems[1]);
                if (topTenList.Count > 0)
                {
                    tmpStr = topTenList.Last();
                }
            }

            */

           // return View("GuessingGame");
        }

        
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
