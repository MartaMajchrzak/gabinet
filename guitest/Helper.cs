
using System.Configuration; //referencja ktora pozwala na konfiguracje, otrzymanie CnnVal 


namespace guitest
{
    public static class Helper
        
    {
        public static string CnnVal(string name)
        {
           return ConfigurationManager.ConnectionStrings[name].ConnectionString;//za pomoca tej linijki dostajemi CnnVal
            //pozwala na komunikacje z sql
        }
    }
}
