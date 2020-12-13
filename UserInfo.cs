using System;
using System.IdentityModel.Tokens.Jwt;
using Newtonsoft.Json;
public static class UserInfo
{
    public static string User { get; set; }

    public static string Status { get; set; }

    public static string Role { get; set; }

    public static string Token { get; set; }

    public static void Reset()
    {
        User = "";
        Token = "";
        Status = "";
    }

    public static bool Validate(string jwttoken)
    {
        return ValidateJWT(jwttoken);
    }

    private static bool ValidateJWT(string jwttoken)
    {
        var rv = false;
        var handler = new JwtSecurityTokenHandler();
        var token = handler.ReadJwtToken(jwttoken);
        Console.WriteLine("JWT Token {0}", token);
        var rightnow = DateTime.Now;
        Console.WriteLine("RightNow {0}", rightnow);
        Console.WriteLine("JWT Valid to {0}", token.ValidTo);
        rv = (token.ValidTo >= rightnow);
        if (!rv)
        {
            Reset();
        }
        Console.WriteLine("----------------------");
        var payload = JsonConvert.SerializeObject(token.Payload);
        var jwtuser = JsonConvert.DeserializeObject<jwtUser>(payload);
        Console.WriteLine(jwtuser.email);
        Console.WriteLine(jwtuser.status);
        Console.WriteLine(jwtuser.role);
        User = jwtuser.email;
        Status = jwtuser.status;
        Role = jwtuser.role;
        Token = jwttoken;
        return rv;
    }


    private class jwtUser
    {
        public string email { get; set; }

        public string status { get; set; }

        public string role { get; set; }

    }
}


