using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace SCA.Autenticacao
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> Ids =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };


        public static IEnumerable<ApiResource> Apis =>
             new List<ApiResource>
         {
            new ApiResource("apiAtivos", "API Ativos")
         };

        public static IEnumerable<Client> Clients =>
        new List<Client>
        {
            new Client
            {
                ClientId = "client",

                // no interactive user, use the clientid/secret for authentication
                AllowedGrantTypes = GrantTypes.ClientCredentials,

                // secret for authentication
                ClientSecrets =
                {
                    new Secret("secret".Sha256())
                },

                // scopes that client has access to
                AllowedScopes = { "apiAtivos" }
            },
                // interactive ASP.NET Core MVC client
                new Client
                {
                     ClientId = "mvc",
                ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.Code,
                    RequireConsent = false,
                    RequirePkce = true,

                    // where to redirect to after login
                    RedirectUris = { "http://host.docker.internal:8000/signin-oidc" },

                    // where to redirect to after logout
                    PostLogoutRedirectUris = { "http://host.docker.internal:8000/signout-callback-oidc" },
                     AllowedScopes = new List<string>
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                }
            }
        };


    }
}
