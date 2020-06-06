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
            new ApiResource(
                name:"apiAtivos",
                displayName: "API Ativos",
                claimTypes: new[] { "sub" }),

            new ApiResource(
                name:"apiCompliance",
                displayName: "API Compliance",
                claimTypes: new[] { "sub" }),

            new ApiResource(
                name:"apiInteligenciaNegocio",
                displayName: "API Inteligência de Negócio",
                claimTypes: new[] { "sub" }),

            new ApiResource(
                name:"apiMonitoramento",
                displayName: "API Monitoramento",
                claimTypes: new[] { "sub" }),

            new ApiResource(
                name:"apiSeguranca",
                displayName: "API Segurança",
                claimTypes: new[] { "sub" }),

            new ApiResource(
                name:"apiProcessoMinerario",
                displayName: "API Processo Minerário",
                claimTypes: new[] { "sub" })
        };

        //novo
        //public static IEnumerable<ApiResource> GetApis()
        //{
        //    return new[]
        //    {
        //        // simple API with a single scope (in this case the scope name is the same as the api name)
        //        new ApiResource("api1", "Some API 1"),

        //        // expanded version if more control is needed
        //        new ApiResource
        //        {
        //            Name = "apiCompliance",

        //            // secret for using introspection endpoint
        //            ApiSecrets =
        //            {
        //                new Secret("secret".Sha256())
        //            },

        //            // include the following using claims in access token (in addition to subject id)
        //            UserClaims = { JwtClaimTypes.Name, JwtClaimTypes.Email },

        //            // this API defines two scopes
        //            Scopes =
        //            {
        //                new Scope()
        //                {
        //                    Name = "apiCompliance.full_access",
        //                    DisplayName = "Full access to API 2",
        //                },
        //                new Scope
        //                {
        //                    Name = "apiCompliance.read_only",
        //                    DisplayName = "Read only access to API 2"
        //                }
        //            }
        //        }
        //    };
        //}
        //fim novo

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
                AllowedScopes = { "apiAtivos", "apiCompliance","apiInteligenciaNegocio","apiSeguranca",
                        "apiMonitoramento", "apiProcessoMinerario", "openid", "profile" },
                UserCodeType = "Admiinistrador"

                //AllowOfflineAccess = false
            },
                // interactive ASP.NET Core MVC client
                new Client
                {
                    ClientId = "mvc",
                    ClientName = "MVC Client",
                    AllowedGrantTypes = GrantTypes.Hybrid,
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    //AllowedGrantTypes = GrantTypes.Hybrid,
                    //RequireConsent = false,
                    //RequirePkce = true,
                
                    // where to redirect to after login
                    RedirectUris = { "http://192.168.1.102:8000/signin-oidc" },

                    // where to redirect to after logout
                    PostLogoutRedirectUris = { "http://192.168.1.102:8000/signout-callback-oidc" },

                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "apiAtivos", "apiCompliance","apiInteligenciaNegocio","apiSeguranca",
                        "apiMonitoramento", "apiProcessoMinerario"
                    },
                    AllowOfflineAccess = true
                }
        };

        
    }
}
