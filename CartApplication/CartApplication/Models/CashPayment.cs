using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CartApplication.Models
{
    public class CashPayment:Ipayment
    {
        private int cardNo;
        private int expirydate;
        private int cvv;

        public void paymentMethod(Items item)
        {

        }
    }
}