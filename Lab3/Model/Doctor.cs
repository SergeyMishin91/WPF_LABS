using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
  public class Doctor
    {
        public string DoctorFirstName { get; set; }
        public string DoctorSecondName { get; set; }
        public string DoctorCvalification { get; set; }
        public double VisitCost { get; set; }
        public byte DoctorWorkExperience { get; set; }

        //public int CompareTo(object obj)
        //{
        //    Doctor temp = obj as Doctor;
        //    if (!temp.Equals(null))
        //        return this.VisitCost.CompareTo(temp.VisitCost);
        //    else
        //        throw new ArgumentException();
        //}

        public string ToFile()
        {               
            return DoctorFirstName + " " + DoctorSecondName + " " + DoctorCvalification + " " + VisitCost + " " + DoctorWorkExperience;
        }


    }
}
