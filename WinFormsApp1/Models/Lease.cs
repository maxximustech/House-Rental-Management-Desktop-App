using System.Data.SqlClient;

using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.General;
using static WinFormsApp1.Models.Apartment;

namespace WinFormsApp1.Models
{
    public class Lease
    {
        int id;
        int apartmentId;
        int tenantId;
        double price;
        string transactionRef; 
        DateTime validTill;
        public Lease(string id,string apartmentId,string tenantId,string price,string transactionRef,DateTime validTill)
        {
            if(!Int32.TryParse(id, out this.id))
            {
                this.id = 0;
            }
            if (!Int32.TryParse(apartmentId, out this.apartmentId))
            {
                this.apartmentId = 0;
            }
            if (!Int32.TryParse(tenantId, out this.tenantId))
            {
                this.tenantId = 0;
            }
            if (!Double.TryParse(price, out this.price))
            {
                this.price = 0;
            }
            this.transactionRef = transactionRef;
            this.validTill = validTill;
        }
        public class LeaseInfo
        {
            public int Id { get; set; }
            public int ApartmentId { get; set; }
            public int TenantId { get; set; }
            public double Price { get; set; }
            public string? TransactionRef { get; set; }
            public string? Status { get; set; }
            public DateTime? ValidTill { get; set; }
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
        }
        public bool Create()
        {
            try
            {
                if (this.apartmentId <= 0)
                {
                    MessageBox.Show("Please add a valid apartment");
                    return false;
                }
                var apartment = Apartment.FetchById(this.apartmentId);
                if(apartment == null)
                {
                    MessageBox.Show("Apartment could not be found");
                    return false;
                }
                if (apartment.status == "Unavailable")
                {
                    MessageBox.Show("This apartment is unavailable");
                    return false;
                }
                if (apartment.status == "Leased")
                {
                    MessageBox.Show("This apartment has been leased");
                    return false;
                }
                if (this.tenantId <= 0)
                {
                    MessageBox.Show("Please add a valid tenant");
                    return false;
                }
                var tenant = Tenant.FetchById(this.tenantId);
                if (tenant == null)
                {
                    MessageBox.Show("Tenant could not be found");
                    return false;
                }
                if (this.price <= 0)
                {
                    MessageBox.Show("Please add a valid price");
                    return false;
                }
                if (this.transactionRef.Trim() == null)
                {
                    MessageBox.Show("Please add a valid transaction reference");
                    return false;
                }
                var lease = FetchByKey("transactionRef", this.transactionRef);
                if (lease.Count > 0)
                {
                    MessageBox.Show("This transaction reference has been used already");
                    return false;
                }
                if(DateTime.Now > this.validTill)
                {
                    MessageBox.Show("Expiration date cannot be earlier than the current date");
                    return false;
                }
                string sql = @"INSERT INTO lease(apartmentId,tenantId,price,transactionRef,validTill,status)
                                VALUES ('"+ this.apartmentId.ToString() + "', '"+ this.tenantId.ToString() + "', '"+ this.price.ToString() + "', '"+ this.transactionRef.ToString() + "', CAST('"+ this.validTill.ToString("MM/dd/yyyy HH:mm") + "' AS DateTime),'Active');";
                SqlCommand cmd = AppConnection.RunCommand(sql);
                cmd.ExecuteNonQuery();
                Apartment.UpdateStatus(this.apartmentId,"Leased");
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("Create: " + e.Message);
                return false;
            }
        }
        public static void RunValidity()
        {
            try
            {
                string sql = "SELECT * FROM lease WHERE validTill <= getdate() AND status = 'Active';";
                SqlCommand cmd = AppConnection.RunCommand(sql);
                SqlDataReader dr = cmd.ExecuteReader();
                var ids = new List<string>();
                string nsql = "";
                while (dr.Read())
                {
                    nsql += "UPDATE lease SET status = 'Expired', updatedAt = getdate() WHERE id = '" + dr.GetInt32("id").ToString() + "';UPDATE apartment SET status = 'Available', updatedAt = getdate() WHERE id = '" + dr.GetInt32("apartmentId").ToString() + "';";
                }
                dr.Close();
                if(nsql != "")
                {
                    SqlCommand ncmd = AppConnection.RunCommand(nsql);
                    ncmd.ExecuteNonQuery();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Error running validity check on lease records: "+e.Message);
            }
        }
        public static LeaseInfo? FetchById(int id) 
        {
            try
            {
                var lease = FetchByKey("id", id.ToString());
                if (lease.Count > 0)
                {
                    return lease[0];
                }
                return null;
            }
            catch(Exception e)
            {
                MessageBox.Show("FetchById: " + e.Message);
                return null;
            }
        }
        public static List<LeaseInfo> FetchAll()
        {
            var lease = new List<LeaseInfo>();
            try
            {
                lease = FetchByKey("id", "",true);
                return lease;
            }
            catch (Exception e)
            {
                MessageBox.Show("FetchById: " + e.Message);
                return lease;
            }
        }
        private static List<LeaseInfo> FetchByKey(string key, string value, bool all = false, int limit = 0)
        {
            var info = new List<LeaseInfo>();
            try
            {
                string sql = "SELECT * FROM lease WHERE "+key+" = '" + value + "';";
                if (all)
                {
                    string l = "";
                    if(limit > 0)
                    {
                        l = " LIMIT " + l;
                    }
                    sql = "SELECT * FROM lease ORDER BY id DESC"+l+";";
                }
                SqlCommand cmd = AppConnection.RunCommand(sql);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var tInfo = new LeaseInfo
                    {
                        Id = dr.GetInt32("id"),
                        ApartmentId = dr.GetInt32("apartmentId"),
                        TenantId = dr.GetInt32("tenantId"),
                        Price = dr.GetDouble("price"),
                        TransactionRef = dr.GetString("transactionRef"),
                        Status = dr.GetString("status"),
                        ValidTill = dr.GetDateTime("validTill"),//DateTime.ParseExact(dr.GetString("validTill"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                        CreatedAt = dr.GetDateTime("createdAt"),//DateTime.ParseExact(dr.GetString("createdAt"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                        UpdatedAt = dr.GetDateTime("updatedAt")//DateTime.ParseExact(dr.GetString("updatedAt"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                    };
                    info.Add(tInfo);
                }
                dr.Close();
                return info;
            }
            catch (Exception e)
            {
                MessageBox.Show("FetchByKey: " + e.Message);
                return info;
            }
        }
    }
}
