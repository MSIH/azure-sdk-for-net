// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Quantum.Models
{
    /// <summary> Azure Active Directory info. </summary>
    public partial class ProviderPropertiesAad
    {
        /// <summary> Initializes a new instance of ProviderPropertiesAad. </summary>
        internal ProviderPropertiesAad()
        {
        }

        /// <summary> Initializes a new instance of ProviderPropertiesAad. </summary>
        /// <param name="applicationId"> Provider's application id. </param>
        /// <param name="tenantId"> Provider's tenant id. </param>
        internal ProviderPropertiesAad(string applicationId, Guid? tenantId)
        {
            ApplicationId = applicationId;
            TenantId = tenantId;
        }

        /// <summary> Provider's application id. </summary>
        public string ApplicationId { get; }
        /// <summary> Provider's tenant id. </summary>
        public Guid? TenantId { get; }
    }
}
