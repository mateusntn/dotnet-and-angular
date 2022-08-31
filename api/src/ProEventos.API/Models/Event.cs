using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.API.Models
{
    public class Event
    {
        public int Id {get;set;}
        public string Local {get;set;}
        public DateTime Date {get;set;}
        public string Title { get; set; }
        public int AmountPeople { get; set; }
        public string UrlImage { get; set; }
        public string Lot { get; set; }
    }
}