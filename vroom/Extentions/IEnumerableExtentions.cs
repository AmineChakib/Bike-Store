﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vroom.Extentions
{
    public static class IEnumerableExtentions
    {

        public static IEnumerable<SelectListItem> ToSelectListItem<T>(this IEnumerable<T> Items)
        {
            List<SelectListItem> List = new List<SelectListItem>();
            SelectListItem sli = new SelectListItem
            {
                Text = "----Select----",
                Value = "0"
            };
            List.Add(sli);
            foreach (var Item in Items)
            {
                sli = new SelectListItem
                {
                    Text = Item.GetPropertyValue("Name"),
                    Value = Item.GetPropertyValue("Id"),
                    //Selected=Item.GetPropertyValue("Id").Equals(selectedValue.ToString())
                    //Text = Item.GetType().GetProperty("Name").GetValue(Item,null).ToString(),
                    //Value = Item.GetType().GetProperty("Id").GetValue(Item,null).ToString()
                };
                List.Add(sli);
            }
            return List;
        }
    }
}
