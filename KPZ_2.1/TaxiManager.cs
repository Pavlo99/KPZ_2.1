using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_2._1
{
    class TaxiManager
    {
        
        private List<Passanger> PassangerList { get; set; }
        private List<Driver> DriverList { get; set; }

        public TaxiManager(List<Passanger> passangerList, List<Driver> driverList)
        {
            PassangerList = passangerList;
            DriverList = driverList;
        }


    }
}
