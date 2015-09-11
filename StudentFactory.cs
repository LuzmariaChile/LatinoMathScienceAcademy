using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoMathScienceAcademy
{
    class StudentFactory
    {

        #region methods

        public Student Create(string firstName, string lastName, DateTime dob, int gradeLevel)
        {
            Student s = new Student();
            s.StudentID = Guid.NewGuid();
            s.Active = true;
            s.FirstName = firstName;
            s.LastName = lastName;
            s.GradeLevel = gradeLevel;
            s.DOB = dob;
            return s;
        }

        public Student Create(string firstName, string lastName, DateTime dob, int gradeLevel, Guid familyID)
        {
            Student s = new Student();
            s.StudentID = Guid.NewGuid();
            s.Active = true;
            s.FirstName = firstName;
            s.LastName = lastName;
            s.GradeLevel = gradeLevel;
            s.DOB = dob;
            s.FamilyID = familyID;
            return s;
        }

        #endregion

    }
}
