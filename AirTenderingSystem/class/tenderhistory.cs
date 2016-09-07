using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AirTenderingSystem
{

    public class tenderhistory
     {
        private Database database = new Database();
        public tenderhistory() {


        }
        public DataTable gethistory(string username) {

            return database.gethistory(username);
        }

        internal DataTable gethistory()
        {
          return  database.getallhistry();
        }
    }


}