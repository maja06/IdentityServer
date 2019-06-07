using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using System.Threading.Tasks;
using IdentityModel;
using IdentityServer4.Test;

namespace IdentityServer
{
    internal class Users
    {
        public static List<TestUser> Get()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "5BE86359-073C-434B-AD2D-A3932222DABE",
                    Username = "scott",
                    Password = "password",
                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.Email, "scott@scottbrady91.com"),
                        new Claim(JwtClaimTypes.Role, "admin")
                    }
                },

                new TestUser
                {
                SubjectId = "2",
                Username = "bob",
                Password = "password",

                Claims = new []
                {
                    new Claim("name", "Bob"),
                    new Claim("website", "https://bob.com")
                }

                },


                new TestUser
                {
                    SubjectId = "6",
                    Username = "maja",
                    Password = "123456",
                    Claims = new List<Claim>
                    {
                        new Claim("name", "Maja"),
                        new Claim(JwtClaimTypes.Role, "user")
                    }
                }
            
            };
        }

    }
}
