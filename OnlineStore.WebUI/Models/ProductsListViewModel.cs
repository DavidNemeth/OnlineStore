using OnlineStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.WebUI.HtmlHelpers;

namespace OnlineStore.WebUI.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable <Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
