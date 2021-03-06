﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Net;
using System.Runtime.Serialization;
using ServiceStack;

namespace Services.MessageContracts
{
    /// <summary>
    /// Defines the Create request for the 'AccessTokens' resource.
    /// </summary>
    [DataContract]
    [Route(@"/token", @"POST", 
        Summary = @"Requests a new access_token or refresh_token for the specified username", 
        Notes = @"")]
    [Api(Description = @"Manages the AccessTokens resource")]
    [ApiResponse(HttpStatusCode.OK, @"The request succeeded")]
    [ApiResponse(HttpStatusCode.BadRequest, @"The request was formed incorrectly. The request fields are either missing, or the values are invalid for this request")]
    [ApiResponse(HttpStatusCode.NotFound, @"The requested resource does not exist, or the current user may not have access to it")]
    [ApiResponse(HttpStatusCode.Conflict, @"The posted resource may already exist, and cannot be duplicated")]
    [ApiResponse(HttpStatusCode.InternalServerError, @"An unexpected error occured in the service while performing this operation")]
    [ApiResponse(HttpStatusCode.Unauthorized, @"You are not authorized to complete this request. Either you don't have the rights to access this resource for this request, or you have not provided the required Bearer token in the request to be identifed for this request")]
    public partial class CreateAccessToken : IReturn<CreateAccessTokenResponse>
    {
        /// <summary>
        /// Gets or sets the granttype of the AccessToken
        /// </summary>
        [ApiMember(Description = "The GrantType of the AccessToken. ", IsRequired = true)]
        [DataMember(Name = "grant_type")]
        public System.String GrantType { get; set; }

        /// <summary>
        /// Gets or sets the scope of the AccessToken
        /// </summary>
        [ApiMember(Description = "The Scope of the AccessToken. ", IsRequired = false)]
        [DataMember(Name = "scope")]
        public System.String Scope { get; set; }

        /// <summary>
        /// Gets or sets the username of the AccessToken
        /// </summary>
        [ApiMember(Description = "The Username of the AccessToken. ", IsRequired = false)]
        [DataMember(Name = "username")]
        public System.String Username { get; set; }

        /// <summary>
        /// Gets or sets the password of the AccessToken
        /// </summary>
        [ApiMember(Description = "The Password of the AccessToken. ", IsRequired = false)]
        [DataMember(Name = "password")]
        public System.String Password { get; set; }

        /// <summary>
        /// Gets or sets the refreshtoken of the AccessToken
        /// </summary>
        [ApiMember(Description = "The RefreshToken of the AccessToken. ", IsRequired = false)]
        [DataMember(Name = "refresh_token")]
        public System.String RefreshToken { get; set; }

    }
}
