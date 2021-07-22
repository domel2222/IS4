using IdentityModel;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS4.Auth.Config
{
    public class Resources
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResource
                {
                    Name = "role",
                    UserClaims = new List<string> { "role"}
                }
            };
        }


        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource
                {
                    Name = "invoices",
                    DisplayName = "Invoices",
                    Description = "Invoices",
                    Scopes = new List<string> {"invoices.read", "invoices.write"},
                    ApiSecrets = new List<Secret> { new Secret("client_secret".ToSha256())}
                }
            };
        }
    }
}
