using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace GuessingGame.Controllers
{
    public class GameModel
    {
        public GameModel() { }

        /// <summary>
        /// Returns the reply string to display for the player.
        /// </summary>
        /// <param name="guess">The number to compare to target.</param>
        /// <param name="target">The target number.</param>
        /// <returns>String outcome of comparison.</returns>
        public string CompareData(int guess, int target, ref bool success)
        {
            string ret = "";

            if (guess == target)
            {
                ret = "Congratulations!";
                success = true;
            }
            else if (guess > target)
            {
                ret = "Too high!";
            }
            else
            {
                ret = "Too low!";
            }
            return ret;
        }
    }
}