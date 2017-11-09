using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    using Model;
    using Repository;
    using System.IO;

    public class HospitalRepository : IHospitalRepository
    {

        private List<Doctor> doctors = new List<Doctor>();
            
        #region IHospitalRepository Members

        public IEnumerable<Doctor> GetAll()
        {
            string[] lines = File.ReadAllText("Doctors.txt", Encoding.GetEncoding(1251)).Split('\n');        
            foreach (string line in lines)
            {
                Doctor new_doctor = new Doctor();
                if (line.Equals(string.Empty)) continue;                       
                string[] info = line.Split(' ');                           
                new_doctor.DoctorFirstName = info[0];                                       
                new_doctor.DoctorSecondName = info[1];
                new_doctor.DoctorCvalification = info[2];
                new_doctor.VisitCost = double.Parse(info[3]);
                new_doctor.DoctorWorkExperience = byte.Parse(info[4]);
                doctors.Add(new_doctor);                                       
            }
            return doctors;
        }

        public void Add(Doctor doctor)
        {
            doctors.Add(doctor);
        }

        #endregion
    }
}
