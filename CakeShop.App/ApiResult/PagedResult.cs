using System.Collections.Generic;

namespace CakeShop.Service.ApiResult
{
    public class PagedResult<T>
    {
        public List<T> Items { set; get; }
    }
}
