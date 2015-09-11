using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoMathScienceAcademy
{
    class Book
    {
        public string ISBN { get; set; }

        public Guid BookID { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public DateTime DatePublished { get; set; }

    }
}
