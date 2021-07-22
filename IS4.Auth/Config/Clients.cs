using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS4.Auth.Config
{
    public class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "FirstClient",
                    ClientName = "Sample Client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = new List <Secret> { new Secret("client_secret".ToSha256())},
                    AllowedScopes = new List<string> {"invoices.write invoices.read"}
                }
            };
        }
    }
}
