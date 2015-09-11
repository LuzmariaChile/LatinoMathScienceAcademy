using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoMathScienceAcademy
{
    /// <summary>
    /// students is one of the main classes for the academy
    /// </summary>
    class Student
    {
        /// <summary>
        /// 
        /// </summary>

        #region properties

        public Guid StudentID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DOB { get; set; }

        public int GradeLevel { get; set; }

        public bool Active { get; set; }

        public Guid FamilyID { get; set; }


        #endregion

        #region methods

        



        #endregion

    }



}
