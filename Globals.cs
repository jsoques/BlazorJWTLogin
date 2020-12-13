using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTLogin
{

    public static class Globals
    {

        public static bool isLoggedIn = false;
        public static string access_token = "";
        public static string user_name = "";
        public static string status = "";
        public static string role = "";

    }

    public static class Endpoints
    {
        public static string aAPIBaseUrllocal = "https://localhost:6453/"; // 
        public static string aAPIBaseUrl = "https://localhost:6453/";
        public static string aAPISignInURL = Endpoints.aAPIBaseUrl + "api/users/login";
        public static string aAPIGetAllUsers = Endpoints.aAPIBaseUrl + "api/users";
        
    }

}
