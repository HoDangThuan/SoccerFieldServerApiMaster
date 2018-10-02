using Microsoft.IdentityModel.Tokens;
using System;

namespace SoccerFieldServer.api.Providers
{
    public class TokenProviderOptions
    {
        public string Path { get; set; } = "/token"; //line 1

        public TimeSpan Expiration { get; set; } = TimeSpan.FromDays(+1); //line 2

        public SigningCredentials SigningCredentials { get; set; }//line 3
    }
}
