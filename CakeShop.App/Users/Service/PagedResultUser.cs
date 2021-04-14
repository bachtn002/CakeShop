using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeShop.Service.Users.Service
{
    public class PagedResultUser<T>
    {
        private List<T> items;

        public List<T> Items { get => items; set => items = value; }
    }
}
