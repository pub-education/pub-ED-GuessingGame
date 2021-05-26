
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

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
        /// <summary>
        /// Adds the new entry to the TopTen list in the right order.
        /// </summary>
        /// <param name="oldList">The present list.</param>
        /// <param name="newEntry">The new entry to fit into the list.</param>
        /// <returns>JSON serialized string that can be loaded into the cookie storage.</returns>
        public string AddScoreToTopTen(string oldList, string newEntry)
        {

            /* Serialize and deserialize the list*/
            /* if (HttpContext.Session.Get<DateTime>(SessionKeyTime) == default)
             {
                 HttpContext.Session.Set<DateTime>(SessionKeyTime, currentTime);
             }
            */
            List<string> listing = new List<string>();
            string[] newValue = newEntry.Split(':');
            int tmpInt1, tmpInt2, highIndex, lowIndex;
            string[] items = new string[2];

            try
            {
                tmpInt2 = Convert.ToInt32(newValue[1]);
            }
            catch (Exception ex)
            {
                // Not a good way of handling the error if the second part of newEntry doesn't 
                // contain a value but it will do here. Should have been a custom Exception 
                // handled in the calling function.
                return ex.Message;
            }

            if (!(oldList == ":" || oldList == ""))
            {
                listing = JsonConvert.DeserializeObject<List<string>>(oldList);
            }

            highIndex = -1;
            lowIndex = -1;
            for (int i = 0; i < listing.Count; i++)
            {
                items = listing[i].Split(':');
                tmpInt1 = Convert.ToInt32(items[1]);

                if (tmpInt1 == tmpInt2)
                {
                    highIndex = i;
                }
                else if (tmpInt1 > tmpInt2)
                {
                    highIndex = i;
                }
                else
                {
                    lowIndex = i;
                }
            }
            if (highIndex != -1 && lowIndex != -1)
            {
                listing.Insert(lowIndex, newEntry);
            }
            else if (highIndex == -1)
            {
                listing.Insert(0, newEntry);
            }
            else
            {
                listing.Add(newEntry);
            }

            while(listing.Count > 10)
            {
                listing.RemoveAt(listing.Count - 1);
            }

            return JsonConvert.SerializeObject(listing);
        }

        public int CalculatePoints(int count, int target)
        {
            double res = 10000 * Math.PI/ Math.Pow((double)count, 3);
            return (int)Math.Round(res);
        }
    }
}
    /*
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, List<string> value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default : JsonSerializer.Deserialize<T>(value);
        }
    }
    */
