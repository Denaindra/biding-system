using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirTenderingSystem
{

    public class date
    {
        public date() {

        }

        public DateTime getcurrentDate()
        {
            DateTime localDate = DateTime.Now;
            return  DateTime.Parse((localDate.ToLocalTime().ToString("MM/dd/yyyy hh:mm tt")));
        }
    }
}