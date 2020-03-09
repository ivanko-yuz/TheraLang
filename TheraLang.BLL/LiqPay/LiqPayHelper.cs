using System;
using System.Linq;
using TheraLang.BLL.DataTransferObjects.Donations;

namespace TheraLang.BLL.LiqPay
{
    public static class LiqPayHelper
    {
        public static string ConvertToQueryString<T>(this T obj)
        {
            return string.Join("&", obj.GetType()
                .GetProperties()
                .Where(p => p.GetValue(obj) != null)
                .Select(p => $"{Uri.EscapeDataString(p.Name)}={Uri.EscapeDataString(p.GetValue(obj).ToString())}"));
        }
    }
}