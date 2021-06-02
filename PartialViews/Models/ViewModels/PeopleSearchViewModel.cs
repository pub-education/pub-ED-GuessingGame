using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViews.Models.ViewModels
{
    public class PeopleSearchViewModel
    {
        public Persons ListData { get; set; }
        public string Title { get; set; }
        public string Header { get; set; }
    }
}
