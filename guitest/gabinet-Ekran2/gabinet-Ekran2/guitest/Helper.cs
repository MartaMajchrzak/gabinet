using System;
using System.Collections.Generic;
using System.Configuration; //referencja ktora pozwala na konfiguracje, otrzymanie CnnVal 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guitest
{
    public static class Helper
        
    {
        public static string CnnVal(string name)
        {
           return ConfigurationManager.ConnectionStrings[name].ConnectionString;//za pomoca tej linijki dostajemi CnnVal
            //pozwala na komunikacje z sql, idziemy do app config
        }
    }
}
