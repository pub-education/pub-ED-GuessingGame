using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PartialViews.Models;


namespace PartialViews.Models.ViewModels
{
    public class PeopleDetailsViewModel
    {
        public string Title { get; set; }
        public string Header { get; set; }
        public Persons ListData
        {
            get
            {
                return DataModel.GetTempData();
            }
        }
    }
}
