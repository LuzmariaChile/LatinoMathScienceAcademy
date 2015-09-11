using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoMathScienceAcademy
{
    class Lesson
    {
        public Guid LessonID { get; set; }

        public string Name { get; set; }

        public int GradeLevel { get; set; }

        public string Subject { get; set; }
        
        public List<Book> Books { get; set; }

    }


}
