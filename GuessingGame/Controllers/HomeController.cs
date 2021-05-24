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
        private GameModel _gameModel;
        public HomeController()
        {
            this._gameModel = new GameModel();
            this.MaxTarget = 100;
            this.MinTarget = 1;
        }

        /// <summary>
        /// Maximum for the random target number.
        /// </summary>
        public int MaxTarget { get; set; }

        /// <summary>
        /// Minimum for the random target number.
        /// </summary>
        public int MinTarget { get; set; }


        /// <summary>
        /// Entry point of a new game.
        /// </summary>
        /// <returns>IActionResult View</returns>
        [Route("/GuessingGame")]
        [Route("/")]
        [HttpGet]
        public IActionResult GuessingGame()
        {
            DataManager(false);
            SetTargetNumber();

            return View();
        }

        /// <summary>
        /// Entry point for new request from GuessingGame page.
        /// </summary>
        /// <returns>IActionResuolt View</returns>
        [Route("/GuessingGame")]
        [HttpPost]
        public IActionResult GuessingGameData()
        {
            bool success = false;
            string tmp = "";
            DataManager(true);
            if (ViewBag.buttonName == "submit")
            {
                if ((int)ViewBag.guess < 0)
                {
                    ViewBag.message = "No number provided.";
                    HttpContext.Session.SetInt32("_counter", (int)ViewBag.counter);
                    return View("GuessingGameError");
                }
                else
                {
                    ViewBag.message = this._gameModel.CompareData((int)ViewBag.guess, (int)ViewBag.targetNumber, ref success);

                    if (ViewBag.guessList == null)
                    {
                        tmp = ViewBag.guess + ":" + ViewBag.message;
                    }
                    else
                    {
                        tmp = ViewBag.guessList + "," + ViewBag.guess + ":" + ViewBag.message;
                    }
                    HttpContext.Session.SetString("_guessList", tmp);
                    if (success)
                    {
                        return View("GuessingGameResult");
                    }
                    else
                    {
                        return View("GuessingGame");
                    }
                }
            }
            else if (ViewBag.buttonName == "newGame")
            {
                DataManager(false);
                return View("GuessingGame");
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Creates a new random target number and loads that into ViewBag.targetNumber and
        /// in Session("targetNumber").
        /// </summary>
        private void SetTargetNumber()
        {
            Random random = new Random();
            ViewBag.targetNumber = random.Next(MinTarget, MaxTarget);
            HttpContext.Session.SetInt32("_targetNumber", (int)ViewBag.targetNumber);
        }

        /// <summary>
        /// Recovering data from the session state and other cookies.
        /// Feeding data into ViewBag and ViewData objects.
        /// Advances the guess counter.
        /// </summary>
        /// <param name="postRequest">
        /// true if request method was post.
        /// false also serves as a reset.
        /// </param>
        private void DataManager(bool postRequest)
        {
            string tmp;
            ViewBag.name = Request.Cookies["playerName"] != null ? (string)Request.Cookies["playerName"] : "";
            ViewBag.topTen = Request.Cookies["topTen"] != null ? (string)Request.Cookies["topTen"] : "";

            if (postRequest)
            {
                ViewBag.buttonName = HttpContext.Request.Form["callButton"];
                ViewBag.targetNumber = HttpContext.Session.GetInt32("_targetNumber").HasValue ? (int)HttpContext.Session.GetInt32("_targetNumber") : -1;
                ViewBag.counter = HttpContext.Session.GetInt32("_counter").HasValue ? (int)HttpContext.Session.GetInt32("_counter") : -1;
                tmp = HttpContext.Request.Form["guessedNumber"];
                    ViewBag.guess = tmp != "" ? Convert.ToInt32(tmp) : -1;
                if (ViewBag.name == "")
                {
                    ViewBag.name = HttpContext.Request.Form["name"];
                }
            }
            else
            {
                ViewBag.counter = 0;
                HttpContext.Session.SetString("_guessList", "");
            }

            HttpContext.Session.SetInt32("_counter", (int)ViewBag.counter + 1);
        }

        private void GameGuessList()
        {

        }

        private void Reset()
        {

        }
    }
}


/*namespace GuessingGame.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private GuessingGame _gameModel = new GuessingGame();

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
                _gameModel.Reset(HttpContext.Session);
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

           

           // return View("GuessingGame");
        }

        
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
*/