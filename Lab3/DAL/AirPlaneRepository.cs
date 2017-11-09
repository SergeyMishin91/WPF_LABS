using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    using Model;
    using Repository;
   public   class AirPlaneRepository:IAirPlaneRepository
    {

       private List<Doctor> lst=new List<Doctor>()
                                      {
                                          new Doctor(){Id = 1, Title = "tu-134", Fuel = 12, Passangers = 100},
                                          new Doctor(){Id = 2, Title = "tu-154", Fuel = 15, Passangers = 110}
                                      }; 
        #region IAirPlaneRepository Members

        public IEnumerable<Doctor> GetAll()
        {
            return lst;
        }

        public void Add(Doctor airPlane)
        {
            lst.Add(airPlane);
        }

        #endregion
    }
}
