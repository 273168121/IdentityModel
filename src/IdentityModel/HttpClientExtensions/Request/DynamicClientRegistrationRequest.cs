﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using IdentityModel.Client;

namespace IdentityModel.HttpClientExtensions
{
    /// <summary>
    /// Request for dynamic client registration
    /// </summary>
    /// <seealso cref="IdentityModel.HttpClientExtensions.Request" />
    public class DynamicClientRegistrationRequest : Request
    {
        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets the registration request.
        /// </summary>
        /// <value>
        /// The registration request.
        /// </value>
        public RegistrationRequest RegistrationRequest  { get; set; }
    }
}