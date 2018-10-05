using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hr_management.Models;

namespace hr_management.ViewModel
{
    public class Multiple
    {
        public IEnumerable<Policy> pol { get; set; }
        public IEnumerable<ConstructorRequest>  conreq {get; set;}

        public IEnumerable<Item> item { get; set; }
    }
}