using System.Collections.Generic;

namespace CakeShop.Service.Users.Model
{
    public class PagedResult<T>
    {
        public List<T> Items { set; get; }
    }
}
