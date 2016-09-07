using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AirTenderingSystem
{

    public class Database
    {
        private SqlConnection conn;
        private SqlCommand com;
        private string sql;
      
        private int Warantee;
        private double price;
        private int dilivarydate;
        private int bestTenderID;

        internal DataTable getallhistry()
        {
            DataTable tabl = new DataTable();
            try
            {
                sql = "select * from History";
                conn.Open();
                com = new SqlCommand(sql, conn);
                SqlDataAdapter Sda = new SqlDataAdapter();
                Sda.SelectCommand = com;
                Sda.Fill(tabl);
                com.Dispose();
                conn.Close();
                return tabl;
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
            return tabl;
        }

        //  private Items items=new Items();
        public Database()
        {
            conn = new SqlConnection("Data Source=GAYANDENAINDRA;Initial Catalog=AireCraftTender;Integrated Security=True");
        }
        public void UserRegister(string username, string password, string email, int UserType)
        {
            try
            {
                sql = "INSERT INTO Users(username,password,email,usertype) VALUES (@username,@password,@email,@usertype)";
                conn.Open();
                com = new SqlCommand(sql, conn);
                com.Connection = conn;
                com.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                com.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                com.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                com.Parameters.Add("@usertype", SqlDbType.Bit).Value = UserType;
                com.ExecuteNonQuery();
                com.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
        }
        public void addnoteligibelseelers(string username,int itemid,int warantee,double price,double freight,int diliverydate)
        {
            try
            {
                sql = "INSERT INTO notEligibleSupllyers(username,applydate,itemID) VALUES (@username,@applydate,@itemID)";
                conn.Open();
                com = new SqlCommand(sql, conn);
                com.Connection = conn;
                com.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                com.Parameters.Add("@applydate", SqlDbType.Date).Value = DateTime.Now;
                com.Parameters.Add("@warantee", SqlDbType.Int).Value = warantee;
                com.Parameters.Add("@freightcost", SqlDbType.Float).Value = freight;
                com.Parameters.Add("@itemID", SqlDbType.Int).Value = itemid;
                com.Parameters.Add("@price", SqlDbType.Float).Value = price;
                com.Parameters.Add("@diliverydates", SqlDbType.Int).Value = diliverydate;
                com.ExecuteNonQuery();
                com.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
        }

        public void removeit(int id)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                sql = "Delete from itemdetails where itemId='" + id+ "'";
                conn.Open();
                adapter.DeleteCommand = conn.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;
                adapter.DeleteCommand.ExecuteNonQuery();
                conn.Close();
                adapter.Dispose();
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
        }

        public void addtohistoyitem(string itemname, int id, string username)
        {
            try
            {
                sql = "INSERT INTO History(itemid,itemname,finaldate,username) VALUES (@itemid,@itemname,@finaldate,@username)";
                conn.Open();
                com = new SqlCommand(sql, conn);
                com.Connection = conn;
                com.Parameters.Add("@itemid", SqlDbType.Int).Value = id;
                com.Parameters.Add("@itemname", SqlDbType.VarChar).Value = itemname;
                com.Parameters.Add("@finaldate", SqlDbType.Date).Value = DateTime.Now;
                com.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                com.ExecuteNonQuery();
                com.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
        }

        public DataTable getuneligibelsellers(int v)
        {
            DataTable tabl = new DataTable();
            try
            {
                sql = "SELECT *FROM notEligibleSupllyers where egID=@egID";
                conn.Open();
                com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("egID", v);
                SqlDataAdapter Sda = new SqlDataAdapter();
                Sda.SelectCommand = com;
                Sda.Fill(tabl);
                com.Dispose();
                conn.Close();
                return tabl;
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
            return tabl;
        }
        public DataTable gethistory(string username) {
            DataTable tabl = new DataTable();
            try
            {
                sql = "SELECT *FROM History where username=@username";
                conn.Open();
                com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("username", username);
                SqlDataAdapter Sda = new SqlDataAdapter();
                Sda.SelectCommand = com;
                Sda.Fill(tabl);
                com.Dispose();
                conn.Close();
                return tabl;
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
            return tabl;

        }
        public user gettopsellerdetails(string username) {
            user topseller = new user();
            try
            {
                sql = "Select * from Users Where Username=@username";
                conn.Open();
                com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("username", username);
                SqlDataReader dred = com.ExecuteReader();

                while (dred.Read())
                {
                    topseller.Email = Convert.ToString(dred["email"].ToString());
                    topseller.Username = Convert.ToString(dred["username"].ToString());
                    topseller.Userid = Int32.Parse(dred["userID"].ToString());
                }
                com.Dispose();
                conn.Close();

                return topseller;
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
                return topseller;
            }



        }
        public DataTable getrejectedlist(int v)
        {
            DataTable tabl = new DataTable();
            try
            {
                sql = "SELECT *FROM TenderDetails WHERE itemID =@id";
                conn.Open();
                com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("id", v);
                SqlDataAdapter Sda = new SqlDataAdapter();
                Sda.SelectCommand = com;
                Sda.Fill(tabl);
                com.Dispose();
                conn.Close();
                return tabl;
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
            return tabl;
        }
        public DataTable geteligibelSet(int v)
        {
            DataTable tabl = new DataTable();
            try
            {
                sql = "SELECT *FROM TenderDetails WHERE itemID =@id";
                conn.Open();
                com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("id", v);
                SqlDataAdapter Sda = new SqlDataAdapter();
                Sda.SelectCommand = com;
                Sda.Fill(tabl);
                com.Dispose();
                conn.Close();
                return tabl;
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
            return tabl;
        }
        public void addnewTnders(string username, DateTime todate, int itemid, int warantee, double price)
        {
            try
            {
                sql = "INSERT INTO EligibleSupllyers(username,applydate,Deliverydate,price,Warantee,itemID) VALUES (@username,@applydate,@Deliverydate,@price,@Warantee,@itemID)";
                conn.Open();
                com = new SqlCommand(sql, conn);
                com.Connection = conn;
                com.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                com.Parameters.Add("@applydate", SqlDbType.Date).Value = todate;
                com.Parameters.Add("@price", SqlDbType.Float).Value = price;
                com.Parameters.Add("@Warantee", SqlDbType.Int).Value = warantee;
                com.Parameters.Add("@itemID", SqlDbType.Int).Value = itemid;
                com.ExecuteNonQuery();
                com.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
        }

        public DataTable supplaerlist()
        {
            DataTable tabl = new DataTable();
            try
            {
                sql = "select username from Users where usertype=0";
                conn.Open();
                com = new SqlCommand(sql, conn);
                SqlDataAdapter Sda = new SqlDataAdapter();
                Sda.SelectCommand = com;
                Sda.Fill(tabl);
                com.Dispose();
                conn.Close();
                return tabl;
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
            return tabl;
        }

        public DataTable getuserdetails(string v)
        {
            DataTable tabl = new DataTable();
            try
            {
                sql = "select * from Users where username=@username";
                conn.Open();
                com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("username", v);
                SqlDataAdapter Sda = new SqlDataAdapter();
                Sda.SelectCommand = com;
                Sda.Fill(tabl);
                com.Dispose();
                conn.Close();
                return tabl;
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
            return tabl;
        }

        public void additem(string itemname, DateTime OpeningDate, DateTime closeingdate, string description, string categery, bool availablity, int quntity)
        {
            try
            {
                sql = "INSERT INTO itemdetails(itemname,OpeningDate,closeingdate,description,categery,availability,quntity) VALUES (@itemname,@opendate,@closedate,@description,@catgery,@avaialbility,@quntity)";
                conn.Open();
                com = new SqlCommand(sql, conn);
                com.Connection = conn;
                com.Parameters.Add("@itemname", SqlDbType.VarChar).Value = itemname;
                com.Parameters.Add("@opendate", SqlDbType.DateTime).Value = OpeningDate;
                com.Parameters.Add("@closedate", SqlDbType.DateTime).Value = closeingdate;
                com.Parameters.Add("@description", SqlDbType.VarChar).Value = description;
                com.Parameters.Add("@catgery", SqlDbType.VarChar).Value = categery;
                com.Parameters.Add("@avaialbility", SqlDbType.Bit).Value = availablity;
                com.Parameters.Add("@quntity", SqlDbType.Int).Value = quntity;
                com.ExecuteNonQuery();
                com.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
        }

        public void selectuserID()
        {
            if (price == Warantee && Warantee == dilivarydate)
            {
                bestTenderID = Warantee;
            }
            else if (price == dilivarydate) {
                bestTenderID = dilivarydate;
            } else if (Warantee == price) {
                bestTenderID = Warantee;
            } else if (dilivarydate == Warantee) {
                bestTenderID = dilivarydate;
            }
        }
        public DataTable getBestSelleritems()
        {
            DataTable tabl = new DataTable();
            try
            {  
                sql = "select * from TenderDetails where tenderID=@id";
                conn.Open();
                com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("id", bestTenderID);
                SqlDataAdapter Sda = new SqlDataAdapter();
                Sda.SelectCommand = com;
                Sda.Fill(tabl);
                com.Dispose();
                conn.Close();
                return tabl;
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
            return tabl;
        }
        public DataTable gettenderdetails() {

            DataTable tabl = new DataTable();
            try
            {
                sql = " select top 1 * from TenderDetails where DelivaeryDate = (select min(DelivaeryDate) from TenderDetails)";
                conn.Open();
                com = new SqlCommand(sql, conn);
                SqlDataAdapter Sda = new SqlDataAdapter();
                Sda.SelectCommand = com;
                Sda.Fill(tabl);
                com.Dispose();
                conn.Close();
                return tabl;
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
            return tabl;
        }

        public void manupilatecitarea(int itemid)
        {
            try
            {
                sql = "select top 1 * from TenderDetails where Waranntee = (select max(Waranntee) from TenderDetails where itemID=@itemid)";
                conn.Open();
                com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("itemid", itemid);
                SqlDataReader dred = com.ExecuteReader();

                while (dred.Read())
                {
                    Warantee = Convert.ToInt32(dred["tenderID"].ToString());
                }
                com.Dispose();
                conn.Close();

                sql = "select top 1 * from TenderDetails where prices = (select min(prices) from TenderDetails where itemID=@itemid)";
                conn.Open();
                com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("itemid", itemid);
                SqlDataReader dreds = com.ExecuteReader();

                while (dreds.Read())
                {
                    price = Convert.ToInt32(dreds["tenderID"].ToString());
                }
                com.Dispose();
                conn.Close();

                sql = "select top 1 * from TenderDetails where DelivaeryDate = (select min(DelivaeryDate) from TenderDetails where itemID=@itemid)";
                conn.Open();
                com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("itemid", itemid);
                SqlDataReader ddilivery = com.ExecuteReader();

                while (ddilivery.Read())
                {
                    dilivarydate = Convert.ToInt32(ddilivery["tenderID"].ToString());
                }
                com.Dispose();
                conn.Close();
            }
            catch (Exception ex) {
                string a = ex.ToString();
            }
        }

        public DataTable getdiliverytime(int id)
        {
            DataTable tabl = new DataTable();
            try
            {
                sql = "select top 1 * from TenderDetails where DelivaeryDate = (select min(DelivaeryDate) from TenderDetails where itemID=@id)";
                conn.Open();
                com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("id", id);
                SqlDataAdapter Sda = new SqlDataAdapter();
                Sda.SelectCommand = com;
                Sda.Fill(tabl);
                com.Dispose();
                conn.Close();       
                return tabl;

            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
            return tabl;
        }

        public bool getUserType(string username)
        {
             int a = 0;
            bool type = false;
            try
            {
                sql = "Select usertype from Users Where username=@username";
                conn.Open();
                com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("username", username);
                SqlDataReader dred = com.ExecuteReader();
                while (dred.Read())
                {
                    type = Convert.ToBoolean(dred["UserType"].ToString());
                }
                com.Dispose();
                conn.Close();

                if (type)  //admin
                {
                    a = 0;
                    return true;
                }
                else  ///customer
                {
                    a = 0;
                    return false;
                }
            }
            catch (Exception ex)
            {
                string wqw = ex.ToString();
                return false;
            }
        }
        public bool chheckUserlogin(string username, string password)
        {
            int temp = 0;
            try
            {
                sql = "Select count(*) from Users Where username=@username and password=@password";
                conn.Open();
                com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("username", username);
                com.Parameters.AddWithValue("password", password);
                temp = (int)com.ExecuteScalar();
                com.Dispose();
                conn.Close();

                if (temp == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
            return false;
        }
        public DataTable AvailablegetItemlists() {
            DataTable tabl = new DataTable();
            try
            {
                sql = "select  itemId,description,OpeningDate,closeingdate,itemname,quntity,categery from ItemDetails";
                conn.Open();
                com = new SqlCommand(sql, conn);
                SqlDataAdapter Sda = new SqlDataAdapter();
                Sda.SelectCommand = com;
                Sda.Fill(tabl);
                com.Dispose();
                conn.Close();
                return tabl;

            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
            return tabl;

        }
        public void addnewTnders(string username,int ItemID,DateTime Todate, int warantee, double price, int DeliveryDate,double FreightCost) {
            try
            {
                sql = "INSERT INTO TenderDetails(username,itemID,applydate,prices,DelivaeryDate,Waranntee,FreightCost) VALUES (@username,@itemID,@applydate,@prices,@DelivaeryDate,@Waranntee,@FreightCost)";
                conn.Open();
                com = new SqlCommand(sql, conn);
                com.Connection = conn;
                com.Parameters.Add("@applydate", SqlDbType.DateTime).Value = Todate;
                com.Parameters.Add("@prices", SqlDbType.Float).Value = price;
                com.Parameters.Add("@DelivaeryDate", SqlDbType.Int).Value = DeliveryDate;
                com.Parameters.Add("@Waranntee", SqlDbType.Int).Value = warantee;
                com.Parameters.Add("@itemID", SqlDbType.Int).Value = ItemID;
                com.Parameters.Add("@username", SqlDbType.VarChar).Value = username;  //FreightCost
                com.Parameters.Add("@FreightCost", SqlDbType.Float).Value = FreightCost;
                com.ExecuteNonQuery();
                com.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
        }
        public string getitemdetails(int itemId) {
            string name = null;
            try
            {
                sql = "select itemname from itemdetails where itemId= @itemId";
                conn.Open();
                com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("@itemId", itemId);
                SqlDataReader dred = com.ExecuteReader();
                while (dred.Read())
                {
                    name = Convert.ToString(dred["itemname"].ToString());
                }
                com.Dispose();
                conn.Close();
                return name;
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
                return name;
            }

        }

    }
}