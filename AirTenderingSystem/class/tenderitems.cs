using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirTenderingSystem
{

    public class tenderitems
    {
        public tenderitems() {

        }

        private date applydate;
        private int warantee;
        private double price;
        private int deliveryDate;
        private int contectnumber;
        private DateTime todate;
        private Database databse = new Database();
        private date today = new date();

        public DateTime Todate
        {
            get { return todate; }
            set { todate = value; }
        }
      
        public void applyDenter(string username,int ItemID,int warantee,double price,int DeliveryDate, double bFreightCost) {
            Todate = today.getcurrentDate();
            databse.addnewTnders(username,ItemID,Todate, warantee,price,DeliveryDate,bFreightCost);
        }

        public void eligibleapplyDenter(string username, int itemID, int warntee, double price)
        {
            Todate = today.getcurrentDate();
            databse.addnewTnders(username, Todate, itemID, warantee, price);
        }

        public void removeitem(int id)
        {
            databse.removeit(id);
        }

        public void addtohistory(string itemname,int id, string username)
        {
            databse.addtohistoyitem(itemname,id,username);
        }

        public int Contectnumber
        {
            get { return contectnumber; }
            set { contectnumber = value; }
        }

        public int DeliveryDates
        {
            get { return deliveryDate; }
            set { deliveryDate = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Warantee
        {
            get { return warantee; }
            set { warantee = value; }
        }

        public date Applydate
        {
            get { return applydate; }
            set { applydate = value; }
        }
        public string getitemnameselected(int id) {
            return databse.getitemdetails(id);
        }
    }
}