using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AirTenderingSystem
{

    public class user
    {
       private Database database = new Database();
       public user() {

        }
        private int userid;
        private string username;
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public int Userid
        {
            get { return userid; }
            set { userid = value; }
        }

        public bool login(string username,string password) {
           return database.chheckUserlogin(username,password);
        }
        public bool usertype(string username) {
           return database.getUserType(username);
        }
        public void sellerRegistration(string username,string password,string email) {
            database.UserRegister(username,password,email,0);
        }
        public void addNoteligibelsellers(string username,int itemid,int warantee,double price,double freight,int diliverydate) {
            database.addnoteligibelseelers(username,itemid,warantee,price,freight,diliverydate);
        }

        public DataTable gettenderuserdetails(string v)
        {
            return database.getuserdetails(v);
        }
        public DataTable getuserist() {
            return database.supplaerlist();

        }
        public void adminregistration(string username, string password, string email) {
            database.UserRegister(username, password, email, 1);
        }
        public user gettopseller(string username) {
            return database.gettopsellerdetails(username);
        }
    }
}