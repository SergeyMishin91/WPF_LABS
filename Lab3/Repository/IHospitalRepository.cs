using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    using Model;
  public  interface IHospitalRepository
  {
      IEnumerable<Doctor> GetAll();
      void Add(Doctor doctor);
  }
}
