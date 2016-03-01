﻿using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Azure;
using System.Linq;


namespace Apprenda.SaaSGrid.Addons.Azure
{
    public static class CertificateAuthenticationHelper
    {
        public static CertificateCloudCredentials GetCredentials(string subscriptionId, string base64Encodedcert)
        { 
            return new CertificateCloudCredentials(subscriptionId, new X509Certificate2(Convert.FromBase64String(base64Encodedcert)));
        }// => new CertificateCloudCredentials(subscriptionId, new X509Certificate2(Convert.FromBase64String(base64Encodedcert)));
    }
}
