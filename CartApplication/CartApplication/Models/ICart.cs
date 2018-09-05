using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartApplication.Models
{
    interface ICart
    {
        void AddItemIn(Items item);
        void remove( Items item);


    }
}
