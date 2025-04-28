using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormSecretSanta.Service
{
    public static class AppCulture
    {
        public static void SetCulture(string cultureCode)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureCode);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureCode);
        }
    }
}
