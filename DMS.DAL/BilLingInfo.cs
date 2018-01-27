using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.DAL
{
    public enum PaymentType
    {
        cash,
        card,
        other
    }
   public class BilLingInfo
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; }

        public PaymentType PayT { get; set; }
        public string DiscripBill { get; set; }

    }
}
