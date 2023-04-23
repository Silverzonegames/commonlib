using Silverzone.CommonLib.Ex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silverzone.CommonLib.Auth
{
    public static class AuthManager
    {
        /// <summary>
        /// A holder of all possible authentication types <br></br>
        /// DatabaseAuthType: Authenticate against a stantard self-hosted auth database <br></br>
        /// AdFsAuthType: Authenticate against Actide Directory Federation Services server <br></br>
        /// OpenIdAuthType: Authenticate against an OpenID compatible application <br></br>
        /// AzureAdAuthType: Authenticate against Azure AD <br></br>
        /// Default: Should not be used
        /// </summary>
        public enum AuthType
        {
            DatabaseAuthType,
            AdFsAuthType,
            OpenIdAuthType,
            AzureAdAuthType,
            Default
        }

        internal static void Authenticate (string authServerUrl, string token, AuthType aType, bool useSSL)
        {
            if (!useSSL) throw new CLibEx.InsecureAuthException();
            if (token == null || authServerUrl == null || aType == AuthType.Default) throw new CLibEx.MissingOrNullAuthArgumentException();
        }
        /// <summary>
        /// SecurityException Authenticate to a remote database/provider as anon <br></br>
        /// Requires DatabaseAuthType
        /// </summary>
        /// <param name="authServerUrl"></param>
        /// <param name="atype"></param>
        /// <param name="useSSL"></param>
        /// <exception cref="CLibEx.InvalidAnonAuthEndpointException"></exception>
        internal static void SeDebugAuthenticateAnon(string authServerUrl, AuthType atype, bool useSSL)
        {
            if (atype != AuthType.DatabaseAuthType) throw new CLibEx.InvalidAnonAuthEndpointException();   
        }
    }
}
