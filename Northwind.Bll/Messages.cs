using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public static class Messages
    {
        public static class Customer
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir Müşteri bulunamadı.";
                return "Böyle bir müşteri bulunamadı.";
            }
        }
    }
}
