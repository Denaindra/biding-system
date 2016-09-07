using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AirTenderingSystem
{

    public class Items
   {
        private Database databse = new Database();
        private string itemname;
        private int quntity;
        private DateTime opendate;
        private DateTime enddate;
        private string categery;
        private string discription;
        private bool condition;
        public Items()
        {

        }

        private Items getitemdetails() {

            return this;
        }
        public void addItems(string itemname,DateTime opendate,DateTime closeingdate,string description,string categery,bool availability,int contity) {

            databse.additem(itemname,opendate,closeingdate,description,categery, availability, contity);
        }

        public DataTable getbesttender()
        {
           return databse.getBestSelleritems();
        }

        public bool Condition
        {
            get { return condition; }
            set { condition = value; }
        }

        public string Discription
        {
            get { return discription; }
            set { discription = value; }
        }

        public DataTable getrejectedsellers(int v)
        {
           return databse.getrejectedlist(v);
        }

        public string Categery
        {
            get { return categery; }
            set { categery = value; }
        }

        public DataTable getnoteligibelset(int v)
        {
            return databse.getuneligibelsellers(v);
        }

        public DateTime Enddate
        {
            get { return enddate; }
            set { enddate = value; }
        }

        public DateTime Opendate
        {
            get { return opendate; }
            set { opendate = value; }
        }

        public int Quentity
        {
            get { return quntity; }
            set { quntity = value; }
        }

        public string Itemname
        {
            get { return itemname; }
            set { itemname = value; }
        }
        public DataTable getlowestDiliverytime(int id) {
            return databse.getdiliverytime(id);
        }
        public void getbestSeller(int id) {
            databse.manupilatecitarea(id);
            databse.selectuserID();
        }
    }
}