using StokTakip.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BusinessLogic
{
    class PhoneRepo
    {
        public List<Phone> GetPhones()
        {
            List<Phone> list = new List<Phone>();
            DataTable dt = Program.SqlHelper.GetTable("exec GetPhones");
            foreach (DataRow row in dt.Rows)
            {
                Phone p = new Phone();
                p.ID = (int)row["ID"];
                p.ProductName = row["ProductName"].ToString();
                p.Price = (decimal)row["Price"];
                p.IMEI1 = row["IMEI1"].ToString();
                p.IMEI2 = row["IMEI2"].ToString();
                p.ModelCode = row["ModelCode"].ToString();
                p.Brand = new Brand();//nullRef Hatası
                p.Brand.BrandName = row["BrandName"].ToString();
                p.Brand.ID = (int)row["BID"];
                list.Add(p);
            }
            return list;
        }
        public List<PhoneViewModel> GetPhonesForDisplay()
        {
            List<PhoneViewModel> list = new List<PhoneViewModel>();
            DataTable dt = Program.SqlHelper.GetTable("exec GetPhones");
            foreach (DataRow row in dt.Rows)
            {
                PhoneViewModel p = new PhoneViewModel();
                p.ID = (int)row["ID"];
                p.Name = row["ProductName"].ToString();
                p.Price = ((decimal)row["Price"]).ToString("C");
                //p.IMEI1 = row["IMEI1"].ToString();
                //p.IMEI2 = row["IMEI2"].ToString();
                p.ModelCode = row["ModelCode"].ToString();
                p.Brand = row["BrandName"].ToString();
                list.Add(p);
            }
            return list;
        }
        public void InsertPhone(Phone newPhone)
        {
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "ProductName";
            p1.Value = newPhone.ProductName;
            SqlParameter p2 = new SqlParameter("Price", newPhone.Price);
            SqlParameter p3 = new SqlParameter("IMEI1", newPhone.IMEI1);
            SqlParameter p4 = new SqlParameter("IMEI2", newPhone.IMEI2);
            SqlParameter p5 = new SqlParameter("BrandID", newPhone.Brand.ID);
            SqlParameter p6 = new SqlParameter("ModelCode", newPhone.ModelCode);
            Program.SqlHelper.ExecutePro("InsertPhone",p1,p2,p3,p4,p5,p6);
        }
        public void DeletePhone(int phoneId)
        {
            Program.SqlHelper.ExecutePro("DeletePhone", phoneId);
        }
        public List<PhoneViewModel>SearchPhone(int BrandId=0,string ModelCode = "")
        {
            List<PhoneViewModel> list = new List<PhoneViewModel>();            
            var dt = Program.SqlHelper.GetTable("exec SearchPhone '"+BrandId + "','" + ModelCode + "'");
            foreach (DataRow item in dt.Rows)
            {
                PhoneViewModel p = new PhoneViewModel();
                p.Brand = item["BrandName"].ToString();
                p.Price = ((decimal)item["Price"]).ToString("C");
                p.ID = (int)item["ID"];
                p.ModelCode = item["ModelCode"].ToString();
                p.Name = item["ProductName"].ToString();
                list.Add(p);
            }
            return list;
        }
    }
}
