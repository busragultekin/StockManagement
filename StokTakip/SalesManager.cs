using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
    public class SalesManager
    {
        public static DataTable GetProducts(string q = null)
        {
            if (q == null)
                return Program.SqlHelper.GetTable(@"exec GetAvailableProducts");
            else
                return Program.SqlHelper.GetTable(@"exec GetAvailableProducts'"+q+"'");
        }
     //   public static void SellProducts(List<Product> products)
        //{

        //}
    }
}
