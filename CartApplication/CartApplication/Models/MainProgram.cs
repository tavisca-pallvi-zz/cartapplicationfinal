using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace CartApplication.Models
{
    public class MainProgram
    {
        //created a cart
        Cart cart = new Cart();
        
        void mainfun()
        {
            Console.WriteLine("hi");
            char c = Console.ReadKey().KeyChar;
            Items item = new Items();
            cart.AddItemIn(item);
            cart.remove(item);
            cart.SetCashPayment();
            //cart.SetCardPayment();
            cart.CheckOut(item);
            


        }
    }

    }
}