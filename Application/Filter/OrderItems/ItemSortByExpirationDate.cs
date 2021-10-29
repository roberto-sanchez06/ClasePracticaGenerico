using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Inventories;

namespace AppCore.Filter.OrderItems
{
    public class ItemSortByExpirationDate : IComparer<Item>
    {
        public int Compare(Item x, Item y)
        {
            return x.ExpirationDate.CompareTo(y.ExpirationDate);
        }
    }
}
