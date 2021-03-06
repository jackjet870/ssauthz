﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Net;
using Common.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.MessageContracts;
using ServiceStack;
using Testing.Common;

namespace Services.IntTests
{
    /// <summary>
    /// Tests the <see cref="AccessTokens"/> service interface class.
    /// </summary>
    /// <remarks>
    /// These tests are verifying basic service connectivity, things like:
    /// 1. Request validation
    /// 2. Basic request and responses.
    /// 3. Handling of exceptions from service.
    /// 4. Returning correct HTTP response codes.
    /// </remarks>
    public partial class AccessTokensSpec
    {
        private static readonly IAssertion Assert = new Assertion();
        private const string RestRoutedNotFoundPartialMessage = "None of the given rest routes matches";

        [TestClass]
        public partial class GivenTheAccessTokensService : GivenTheAccessTokensServiceBase { }

        [TestClass]
        public abstract class GivenTheAccessTokensServiceBase : IntegrationTest
        {
            [TestInitialize]
            public virtual void Initialize()
            {
                base.InitializeContext();
            }

            [TestMethod, TestCategory("Integration")]
            public virtual void WhenPostCreateAccessTokenWithNullRequest_ThenThrowsNullReference()
            {
                Assert.Throws<NullReferenceException>(() =>
                    Client.Post((CreateAccessToken)null));
            }

            [TestMethod, TestCategory("Integration")]
            public virtual void WhenPostCreateAccessTokenWithEmptyRequest_ThenThrowsBadRequest()
            {
                Assert.Throws<InvalidOperationException>(HttpErrorCode.FromHttpStatusCode(HttpStatusCode.BadRequest), () =>
                    Client.Post(new CreateAccessToken()));
            }

            [TestMethod, TestCategory("Integration")]
            public virtual void WhenPostCreateAccessToken_ThenCreatesResource()
            {
                var result = Client.Post<HttpWebResponse>(this.MakeCreateAccessToken());

                Assert.Equal(HttpStatusCode.Created, result.StatusCode);
                Assert.True(new Uri(result.GetResponseHeader(HttpHeaders.Location)).LocalPath.StartsWith(result.ResponseUri.LocalPath.WithTrailingSlash()));
            }


            protected virtual CreateAccessToken MakeCreateAccessToken()
            {
                return new CreateAccessToken();
            }

        }
    }
}