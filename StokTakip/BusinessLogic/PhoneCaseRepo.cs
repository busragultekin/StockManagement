using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BusinessLogic
{
    class PhoneCaseRepo
    {
        public List<PhoneCase> GetPhoneCases()
        {
            List<PhoneCase> list = new List<PhoneCase>();
            DataTable dt = Program.SqlHelper.GetTable("Select * From PhoneCase");
            foreach (DataRow row in dt.Rows)
            {
                PhoneCase p = new PhoneCase();
                p.ID = (int)row["ID"];
                p.ProductName = row["ProductName"].ToString();
                p.Price = (decimal)row["Price"];
                p.CaseColor =(CaseColor) row["CaseColor"];
                p.Quantity = (int)row["Quantity"];
                list.Add(p);
            }
            return list;
        }
        public void InsertPhoneCase(PhoneCase newPhoneCase)
        {
            SqlParameter p1 = new SqlParameter("ProductName", newPhoneCase.ProductName);
            SqlParameter p2 = new SqlParameter("Price", newPhoneCase.Price);
            SqlParameter p3 = new SqlParameter("CaseColor", (int)newPhoneCase.CaseColor);
            SqlParameter p4 = new SqlParameter("Quantity", newPhoneCase.Quantity);
            Program.SqlHelper.ExecutePro("InsertPhoneCases", p1, p2, p3, p4);
        }
        public void AddStockToPhoneCase(int id,int qty)
        {
            SqlParameter p1 = new SqlParameter("id", id);
            SqlParameter p2 = new SqlParameter("qty", qty);
            Program.SqlHelper.ExecutePro("AddStock", p1,p2);
        }
        public void Delete(int id)
        {
            Program.SqlHelper.ExecutePro("DeletePhoneCase", id);
        }

    }
}
