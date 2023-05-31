using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Common
{
    public class PagedResultDto<T> : PagedResultBase
    {
        public List<T> Items { set; get; }
    }
}
