/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.WAFV2.Model;
using Amazon.WAFV2.Model.Internal.MarshallTransformations;
using Amazon.WAFV2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.WAFV2
{
    /// <summary>
    /// Implementation for accessing WAFV2
    ///
    /// <note> 
    /// <para>
    /// This is the latest version of the <b>AWS WAF</b> API, released in November, 2019.
    /// The names of the entities that you use to access this API, like endpoints and namespaces,
    /// all have the versioning information added, like "V2" or "v2", to distinguish from
    /// the prior version. We recommend migrating your resources to this version, because
    /// it has a number of significant improvements.
    /// </para>
    ///  
    /// <para>
    /// If you used AWS WAF prior to this release, you can't use this AWS WAFV2 API to access
    /// any AWS WAF resources that you created before. You can access your old rules, web
    /// ACLs, and other AWS WAF resources only through the AWS WAF Classic APIs. The AWS WAF
    /// Classic APIs have retained the prior names, endpoints, and namespaces. 
    /// </para>
    ///  
    /// <para>
    /// For information, including how to migrate your AWS WAF resources to this version,
    /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// AWS WAF is a web application firewall that lets you monitor the HTTP and HTTPS requests
    /// that are forwarded to Amazon CloudFront, an Amazon API Gateway API, or an Application
    /// Load Balancer. AWS WAF also lets you control access to your content. Based on conditions
    /// that you specify, such as the IP addresses that requests originate from or the values
    /// of query strings, API Gateway, CloudFront, or the Application Load Balancer responds
    /// to requests either with the requested content or with an HTTP 403 status code (Forbidden).
    /// You also can configure CloudFront to return a custom error page when a request is
    /// blocked.
    /// </para>
    ///  
    /// <para>
    /// This API guide is for developers who need detailed information about AWS WAF API actions,
    /// data types, and errors. For detailed information about AWS WAF features and an overview
    /// of how to use AWS WAF, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS
    /// WAF Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// You can make API calls using the endpoints listed in <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#waf_region">AWS
    /// Service Endpoints for AWS WAF</a>. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For regional applications, you can use any of the endpoints in the list. A regional
    /// application can be an Application Load Balancer (ALB) or an API Gateway stage. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For AWS CloudFront applications, you must use the API endpoint listed for US East
    /// (N. Virginia): us-east-1.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Alternatively, you can use one of the AWS SDKs to access an API that's tailored to
    /// the programming language or platform that you're using. For more information, see
    /// <a href="http://aws.amazon.com/tools/#SDKs">AWS SDKs</a>.
    /// </para>
    ///  
    /// <para>
    /// We currently provide two versions of the AWS WAF API: this API and the prior versions,
    /// the classic AWS WAF APIs. This new API provides the same functionality as the older
    /// versions, with the following major improvements:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You use one API for both global and regional applications. Where you need to distinguish
    /// the scope, you specify a <code>Scope</code> parameter and set it to <code>CLOUDFRONT</code>
    /// or <code>REGIONAL</code>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can define a Web ACL or rule group with a single API call, and update it with
    /// a single call. You define all rule specifications in JSON format, and pass them to
    /// your rule group or Web ACL API calls.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The limits AWS WAF places on the use of rules more closely reflects the cost of running
    /// each type of rule. Rule groups include capacity settings, so you know the maximum
    /// cost of a rule group when you use it.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonWAFV2Client : AmazonServiceClient, IAmazonWAFV2
    {
        private static IServiceMetadata serviceMetadata = new AmazonWAFV2Metadata();
        
        #region Constructors

#if NETSTANDARD
    
        /// <summary>
        /// Constructs AmazonWAFV2Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonWAFV2Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWAFV2Config()) { }

        /// <summary>
        /// Constructs AmazonWAFV2Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonWAFV2Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWAFV2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonWAFV2Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonWAFV2Client Configuration Object</param>
        public AmazonWAFV2Client(AmazonWAFV2Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonWAFV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonWAFV2Client(AWSCredentials credentials)
            : this(credentials, new AmazonWAFV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonWAFV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWAFV2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonWAFV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWAFV2Client with AWS Credentials and an
        /// AmazonWAFV2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonWAFV2Client Configuration Object</param>
        public AmazonWAFV2Client(AWSCredentials credentials, AmazonWAFV2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWAFV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonWAFV2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWAFV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonWAFV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWAFV2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWAFV2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonWAFV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWAFV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonWAFV2Client Configuration Object</param>
        public AmazonWAFV2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonWAFV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWAFV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonWAFV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWAFV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonWAFV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWAFV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWAFV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWAFV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWAFV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonWAFV2Client Configuration Object</param>
        public AmazonWAFV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonWAFV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AssociateWebACL

        internal virtual AssociateWebACLResponse AssociateWebACL(AssociateWebACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWebACLResponseUnmarshaller.Instance;

            return Invoke<AssociateWebACLResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Associates a Web ACL with a regional application resource, to protect the resource.
        /// A regional application can be an Application Load Balancer (ALB) or an API Gateway
        /// stage. 
        /// </para>
        ///  
        /// <para>
        /// For AWS CloudFront, you can associate the Web ACL by providing the <code>Id</code>
        /// of the <a>WebACL</a> to the CloudFront API call <code>UpdateDistribution</code>. For
        /// information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/AssociateWebACL">REST API Reference for AssociateWebACL Operation</seealso>
        public virtual Task<AssociateWebACLResponse> AssociateWebACLAsync(AssociateWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateWebACLResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CheckCapacity

        internal virtual CheckCapacityResponse CheckCapacity(CheckCapacityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckCapacityResponseUnmarshaller.Instance;

            return Invoke<CheckCapacityResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the web ACL capacity unit (WCU) requirements for a specified scope and set
        /// of rules. You can use this to check the capacity requirements for the rules you want
        /// to use in a <a>RuleGroup</a> or <a>WebACL</a>. 
        /// </para>
        ///  
        /// <para>
        /// AWS WAF uses WCUs to calculate and control the operating resources that are used to
        /// run your rules, rule groups, and web ACLs. AWS WAF calculates capacity differently
        /// for each rule type, to reflect the relative cost of each rule. Simple rules that cost
        /// little to run use fewer WCUs than more complex rules that use more processing power.
        /// Rule group capacity is fixed at creation, which helps users plan their web ACL WCU
        /// usage when they use a rule group. The WCU limit for web ACLs is 1,500. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckCapacity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CheckCapacity service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// AWS WAF couldn’t perform the operation because the resource that you requested isn’t
        /// valid. Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CheckCapacity">REST API Reference for CheckCapacity Operation</seealso>
        public virtual Task<CheckCapacityResponse> CheckCapacityAsync(CheckCapacityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckCapacityResponseUnmarshaller.Instance;

            return InvokeAsync<CheckCapacityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateIPSet

        internal virtual CreateIPSetResponse CreateIPSet(CreateIPSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIPSetResponseUnmarshaller.Instance;

            return Invoke<CreateIPSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates an <a>IPSet</a>, which you use to identify web requests that originate from
        /// specific IP addresses or ranges of IP addresses. For example, if you're receiving
        /// a lot of requests from a ranges of IP addresses, you can configure AWS WAF to block
        /// them using an IPSet that lists those IP addresses. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        public virtual Task<CreateIPSetResponse> CreateIPSetAsync(CreateIPSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIPSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIPSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRegexPatternSet

        internal virtual CreateRegexPatternSetResponse CreateRegexPatternSet(CreateRegexPatternSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegexPatternSetResponseUnmarshaller.Instance;

            return Invoke<CreateRegexPatternSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>RegexPatternSet</a> per the specifications provided.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegexPatternSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRegexPatternSet">REST API Reference for CreateRegexPatternSet Operation</seealso>
        public virtual Task<CreateRegexPatternSetResponse> CreateRegexPatternSetAsync(CreateRegexPatternSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegexPatternSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRegexPatternSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRuleGroup

        internal virtual CreateRuleGroupResponse CreateRuleGroup(CreateRuleGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleGroupResponseUnmarshaller.Instance;

            return Invoke<CreateRuleGroupResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>RuleGroup</a> per the specifications provided. 
        /// </para>
        ///  
        /// <para>
        ///  A rule group defines a collection of rules to inspect and control web requests that
        /// you can use in a <a>WebACL</a>. When you create a rule group, you define an immutable
        /// capacity limit. If you update a rule group, you must stay within the capacity. This
        /// allows others to reuse the rule group with confidence in its capacity requirements.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRuleGroup">REST API Reference for CreateRuleGroup Operation</seealso>
        public virtual Task<CreateRuleGroupResponse> CreateRuleGroupAsync(CreateRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRuleGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWebACL

        internal virtual CreateWebACLResponse CreateWebACL(CreateWebACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebACLResponseUnmarshaller.Instance;

            return Invoke<CreateWebACLResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>WebACL</a> per the specifications provided.
        /// </para>
        ///  
        /// <para>
        ///  A Web ACL defines a collection of rules to use to inspect and control web requests.
        /// Each rule has an action defined (allow, block, or count) for requests that match the
        /// statement of the rule. In the Web ACL, you assign a default action to take (allow,
        /// block) for any request that does not match any of the rules. The rules in a Web ACL
        /// can be a combination of the types <a>Rule</a>, <a>RuleGroup</a>, and managed rule
        /// group. You can associate a Web ACL with one or more AWS resources to protect. The
        /// resources can be Amazon CloudFront, an Amazon API Gateway API, or an Application Load
        /// Balancer. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// AWS WAF couldn’t perform the operation because the resource that you requested isn’t
        /// valid. Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateWebACL">REST API Reference for CreateWebACL Operation</seealso>
        public virtual Task<CreateWebACLResponse> CreateWebACLAsync(CreateWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWebACLResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIPSet

        internal virtual DeleteIPSetResponse DeleteIPSet(DeleteIPSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIPSetResponseUnmarshaller.Instance;

            return Invoke<DeleteIPSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the specified <a>IPSet</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        public virtual Task<DeleteIPSetResponse> DeleteIPSetAsync(DeleteIPSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIPSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIPSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLoggingConfiguration

        internal virtual DeleteLoggingConfigurationResponse DeleteLoggingConfiguration(DeleteLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteLoggingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the <a>LoggingConfiguration</a> from the specified web ACL.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLoggingConfiguration service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteLoggingConfiguration">REST API Reference for DeleteLoggingConfiguration Operation</seealso>
        public virtual Task<DeleteLoggingConfigurationResponse> DeleteLoggingConfigurationAsync(DeleteLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoggingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLoggingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRegexPatternSet

        internal virtual DeleteRegexPatternSetResponse DeleteRegexPatternSet(DeleteRegexPatternSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegexPatternSetResponseUnmarshaller.Instance;

            return Invoke<DeleteRegexPatternSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the specified <a>RegexPatternSet</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegexPatternSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRegexPatternSet">REST API Reference for DeleteRegexPatternSet Operation</seealso>
        public virtual Task<DeleteRegexPatternSetResponse> DeleteRegexPatternSetAsync(DeleteRegexPatternSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegexPatternSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRegexPatternSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRuleGroup

        internal virtual DeleteRuleGroupResponse DeleteRuleGroup(DeleteRuleGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleGroupResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the specified <a>RuleGroup</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRuleGroup">REST API Reference for DeleteRuleGroup Operation</seealso>
        public virtual Task<DeleteRuleGroupResponse> DeleteRuleGroupAsync(DeleteRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRuleGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWebACL

        internal virtual DeleteWebACLResponse DeleteWebACL(DeleteWebACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebACLResponseUnmarshaller.Instance;

            return Invoke<DeleteWebACLResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the specified <a>WebACL</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// AWS WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteWebACL">REST API Reference for DeleteWebACL Operation</seealso>
        public virtual Task<DeleteWebACLResponse> DeleteWebACLAsync(DeleteWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWebACLResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeManagedRuleGroup

        internal virtual DescribeManagedRuleGroupResponse DescribeManagedRuleGroup(DescribeManagedRuleGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeManagedRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeManagedRuleGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeManagedRuleGroupResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Provides high-level information for a managed rule group, including descriptions of
        /// the rules. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeManagedRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// AWS WAF couldn’t perform the operation because the resource that you requested isn’t
        /// valid. Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DescribeManagedRuleGroup">REST API Reference for DescribeManagedRuleGroup Operation</seealso>
        public virtual Task<DescribeManagedRuleGroupResponse> DescribeManagedRuleGroupAsync(DescribeManagedRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeManagedRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeManagedRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeManagedRuleGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateWebACL

        internal virtual DisassociateWebACLResponse DisassociateWebACL(DisassociateWebACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWebACLResponseUnmarshaller.Instance;

            return Invoke<DisassociateWebACLResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Disassociates a Web ACL from a regional application resource. A regional application
        /// can be an Application Load Balancer (ALB) or an API Gateway stage. 
        /// </para>
        ///  
        /// <para>
        /// For AWS CloudFront, you can disassociate the Web ACL by providing an empty <code>WebACLId</code>
        /// in the CloudFront API call <code>UpdateDistribution</code>. For information, see <a
        /// href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DisassociateWebACL">REST API Reference for DisassociateWebACL Operation</seealso>
        public virtual Task<DisassociateWebACLResponse> DisassociateWebACLAsync(DisassociateWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateWebACLResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIPSet

        internal virtual GetIPSetResponse GetIPSet(GetIPSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIPSetResponseUnmarshaller.Instance;

            return Invoke<GetIPSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the specified <a>IPSet</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        public virtual Task<GetIPSetResponse> GetIPSetAsync(GetIPSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIPSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetIPSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLoggingConfiguration

        internal virtual GetLoggingConfigurationResponse GetLoggingConfiguration(GetLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetLoggingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>LoggingConfiguration</a> for the specified web ACL.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLoggingConfiguration service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetLoggingConfiguration">REST API Reference for GetLoggingConfiguration Operation</seealso>
        public virtual Task<GetLoggingConfigurationResponse> GetLoggingConfigurationAsync(GetLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoggingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetLoggingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRateBasedStatementManagedKeys

        internal virtual GetRateBasedStatementManagedKeysResponse GetRateBasedStatementManagedKeys(GetRateBasedStatementManagedKeysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRateBasedStatementManagedKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRateBasedStatementManagedKeysResponseUnmarshaller.Instance;

            return Invoke<GetRateBasedStatementManagedKeysResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the keys that are currently blocked by a rate-based rule. The maximum number
        /// of managed keys that can be blocked for a single rate-based rule is 10,000. If more
        /// than 10,000 addresses exceed the rate limit, those with the highest rates are blocked.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRateBasedStatementManagedKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRateBasedStatementManagedKeys service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRateBasedStatementManagedKeys">REST API Reference for GetRateBasedStatementManagedKeys Operation</seealso>
        public virtual Task<GetRateBasedStatementManagedKeysResponse> GetRateBasedStatementManagedKeysAsync(GetRateBasedStatementManagedKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRateBasedStatementManagedKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRateBasedStatementManagedKeysResponseUnmarshaller.Instance;

            return InvokeAsync<GetRateBasedStatementManagedKeysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRegexPatternSet

        internal virtual GetRegexPatternSetResponse GetRegexPatternSet(GetRegexPatternSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegexPatternSetResponseUnmarshaller.Instance;

            return Invoke<GetRegexPatternSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the specified <a>RegexPatternSet</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegexPatternSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRegexPatternSet">REST API Reference for GetRegexPatternSet Operation</seealso>
        public virtual Task<GetRegexPatternSetResponse> GetRegexPatternSetAsync(GetRegexPatternSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegexPatternSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetRegexPatternSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRuleGroup

        internal virtual GetRuleGroupResponse GetRuleGroup(GetRuleGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleGroupResponseUnmarshaller.Instance;

            return Invoke<GetRuleGroupResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the specified <a>RuleGroup</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRuleGroup">REST API Reference for GetRuleGroup Operation</seealso>
        public virtual Task<GetRuleGroupResponse> GetRuleGroupAsync(GetRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetRuleGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSampledRequests

        internal virtual GetSampledRequestsResponse GetSampledRequests(GetSampledRequestsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSampledRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSampledRequestsResponseUnmarshaller.Instance;

            return Invoke<GetSampledRequestsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Gets detailed information about a specified number of requests--a sample--that AWS
        /// WAF randomly selects from among the first 5,000 requests that your AWS resource received
        /// during a time range that you choose. You can specify a sample size of up to 500 requests,
        /// and you can specify any time range in the previous three hours.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetSampledRequests</code> returns a time range, which is usually the time range
        /// that you specified. However, if your resource (such as a CloudFront distribution)
        /// received 5,000 requests before the specified time range elapsed, <code>GetSampledRequests</code>
        /// returns an updated time range. This new time range indicates the actual period during
        /// which AWS WAF selected the requests in the sample.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSampledRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSampledRequests service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetSampledRequests">REST API Reference for GetSampledRequests Operation</seealso>
        public virtual Task<GetSampledRequestsResponse> GetSampledRequestsAsync(GetSampledRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSampledRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSampledRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSampledRequestsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWebACL

        internal virtual GetWebACLResponse GetWebACL(GetWebACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebACLResponseUnmarshaller.Instance;

            return Invoke<GetWebACLResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the specified <a>WebACL</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACL">REST API Reference for GetWebACL Operation</seealso>
        public virtual Task<GetWebACLResponse> GetWebACLAsync(GetWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<GetWebACLResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWebACLForResource

        internal virtual GetWebACLForResourceResponse GetWebACLForResource(GetWebACLForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWebACLForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebACLForResourceResponseUnmarshaller.Instance;

            return Invoke<GetWebACLForResourceResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the <a>WebACL</a> for the specified resource. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACLForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebACLForResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACLForResource">REST API Reference for GetWebACLForResource Operation</seealso>
        public virtual Task<GetWebACLForResourceResponse> GetWebACLForResourceAsync(GetWebACLForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWebACLForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebACLForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetWebACLForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAvailableManagedRuleGroups

        internal virtual ListAvailableManagedRuleGroupsResponse ListAvailableManagedRuleGroups(ListAvailableManagedRuleGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAvailableManagedRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableManagedRuleGroupsResponseUnmarshaller.Instance;

            return Invoke<ListAvailableManagedRuleGroupsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of managed rule groups that are available for you to use. This
        /// list includes all AWS managed rule groups and the AWS Marketplace managed rule groups
        /// that you're subscribed to.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableManagedRuleGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAvailableManagedRuleGroups service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAvailableManagedRuleGroups">REST API Reference for ListAvailableManagedRuleGroups Operation</seealso>
        public virtual Task<ListAvailableManagedRuleGroupsResponse> ListAvailableManagedRuleGroupsAsync(ListAvailableManagedRuleGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAvailableManagedRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableManagedRuleGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAvailableManagedRuleGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIPSets

        internal virtual ListIPSetsResponse ListIPSets(ListIPSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIPSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIPSetsResponseUnmarshaller.Instance;

            return Invoke<ListIPSetsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of <a>IPSetSummary</a> objects for the IP sets that you manage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIPSets service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        public virtual Task<ListIPSetsResponse> ListIPSetsAsync(ListIPSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIPSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIPSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIPSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLoggingConfigurations

        internal virtual ListLoggingConfigurationsResponse ListLoggingConfigurations(ListLoggingConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLoggingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLoggingConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListLoggingConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of your <a>LoggingConfiguration</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLoggingConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLoggingConfigurations service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListLoggingConfigurations">REST API Reference for ListLoggingConfigurations Operation</seealso>
        public virtual Task<ListLoggingConfigurationsResponse> ListLoggingConfigurationsAsync(ListLoggingConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLoggingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLoggingConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLoggingConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRegexPatternSets

        internal virtual ListRegexPatternSetsResponse ListRegexPatternSets(ListRegexPatternSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRegexPatternSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegexPatternSetsResponseUnmarshaller.Instance;

            return Invoke<ListRegexPatternSetsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of <a>RegexPatternSetSummary</a> objects for the regex pattern
        /// sets that you manage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegexPatternSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegexPatternSets service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRegexPatternSets">REST API Reference for ListRegexPatternSets Operation</seealso>
        public virtual Task<ListRegexPatternSetsResponse> ListRegexPatternSetsAsync(ListRegexPatternSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRegexPatternSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegexPatternSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRegexPatternSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourcesForWebACL

        internal virtual ListResourcesForWebACLResponse ListResourcesForWebACL(ListResourcesForWebACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcesForWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesForWebACLResponseUnmarshaller.Instance;

            return Invoke<ListResourcesForWebACLResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of the Amazon Resource Names (ARNs) for the regional resources
        /// that are associated with the specified web ACL. If you want the list of AWS CloudFront
        /// resources, use the AWS CloudFront call <code>ListDistributionsByWebACLId</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourcesForWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListResourcesForWebACL">REST API Reference for ListResourcesForWebACL Operation</seealso>
        public virtual Task<ListResourcesForWebACLResponse> ListResourcesForWebACLAsync(ListResourcesForWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcesForWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesForWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourcesForWebACLResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRuleGroups

        internal virtual ListRuleGroupsResponse ListRuleGroups(ListRuleGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleGroupsResponseUnmarshaller.Instance;

            return Invoke<ListRuleGroupsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of <a>RuleGroupSummary</a> objects for the rule groups that you
        /// manage. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRuleGroups service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRuleGroups">REST API Reference for ListRuleGroups Operation</seealso>
        public virtual Task<ListRuleGroupsResponse> ListRuleGroupsAsync(ListRuleGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRuleGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the <a>TagInfoForResource</a> for the specified resource. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWebACLs

        internal virtual ListWebACLsResponse ListWebACLs(ListWebACLsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebACLsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebACLsResponseUnmarshaller.Instance;

            return Invoke<ListWebACLsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of <a>WebACLSummary</a> objects for the web ACLs that you manage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebACLs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWebACLs service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListWebACLs">REST API Reference for ListWebACLs Operation</seealso>
        public virtual Task<ListWebACLsResponse> ListWebACLsAsync(ListWebACLsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebACLsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebACLsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWebACLsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutLoggingConfiguration

        internal virtual PutLoggingConfigurationResponse PutLoggingConfiguration(PutLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutLoggingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Enables the specified <a>LoggingConfiguration</a>, to start logging from a web ACL,
        /// according to the configuration provided.
        /// </para>
        ///  
        /// <para>
        /// You can access information about all traffic that AWS WAF inspects using the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create an Amazon Kinesis Data Firehose. 
        /// </para>
        ///  
        /// <para>
        /// Create the data firehose with a PUT source and in the region that you are operating.
        /// If you are capturing logs for Amazon CloudFront, always create the firehose in US
        /// East (N. Virginia). 
        /// </para>
        ///  <note> 
        /// <para>
        /// Do not create the data firehose using a <code>Kinesis stream</code> as your source.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Associate that firehose to your web ACL using a <code>PutLoggingConfiguration</code>
        /// request.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you successfully enable logging using a <code>PutLoggingConfiguration</code>
        /// request, AWS WAF will create a service linked role with the necessary permissions
        /// to write logs to the Amazon Kinesis Data Firehose. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
        /// Web ACL Traffic Information</a> in the <i>AWS WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLoggingConfiguration service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFServiceLinkedRoleErrorException">
        /// AWS WAF is not able to access the service linked role. This can be caused by a previous
        /// <code>PutLoggingConfiguration</code> request, which can lock the service linked role
        /// for about 20 seconds. Please try your request again. The service linked role can also
        /// be locked by a previous <code>DeleteServiceLinkedRole</code> request, which can lock
        /// the role for 15 minutes or more. If you recently made a call to <code>DeleteServiceLinkedRole</code>,
        /// wait at least 15 minutes and try the request again. If you receive this same exception
        /// again, you will have to wait additional time until the role is unlocked.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutLoggingConfiguration">REST API Reference for PutLoggingConfiguration Operation</seealso>
        public virtual Task<PutLoggingConfigurationResponse> PutLoggingConfigurationAsync(PutLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLoggingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutLoggingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Associates tags with the specified AWS resource. Tags are key:value pairs that you
        /// can associate with AWS resources. For example, the tag key might be "customer" and
        /// the tag value might be "companyA." You can specify one or more tags to add to each
        /// container. You can add up to 50 tags to each AWS resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Disassociates tags from an AWS resource. Tags are key:value pairs that you can associate
        /// with AWS resources. For example, the tag key might be "customer" and the tag value
        /// might be "companyA." You can specify one or more tags to add to each container. You
        /// can add up to 50 tags to each AWS resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateIPSet

        internal virtual UpdateIPSetResponse UpdateIPSet(UpdateIPSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIPSetResponseUnmarshaller.Instance;

            return Invoke<UpdateIPSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates the specified <a>IPSet</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        public virtual Task<UpdateIPSetResponse> UpdateIPSetAsync(UpdateIPSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIPSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIPSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRegexPatternSet

        internal virtual UpdateRegexPatternSetResponse UpdateRegexPatternSet(UpdateRegexPatternSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegexPatternSetResponseUnmarshaller.Instance;

            return Invoke<UpdateRegexPatternSetResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates the specified <a>RegexPatternSet</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegexPatternSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRegexPatternSet">REST API Reference for UpdateRegexPatternSet Operation</seealso>
        public virtual Task<UpdateRegexPatternSetResponse> UpdateRegexPatternSetAsync(UpdateRegexPatternSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegexPatternSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRegexPatternSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRuleGroup

        internal virtual UpdateRuleGroupResponse UpdateRuleGroup(UpdateRuleGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateRuleGroupResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates the specified <a>RuleGroup</a>.
        /// </para>
        ///  
        /// <para>
        ///  A rule group defines a collection of rules to inspect and control web requests that
        /// you can use in a <a>WebACL</a>. When you create a rule group, you define an immutable
        /// capacity limit. If you update a rule group, you must stay within the capacity. This
        /// allows others to reuse the rule group with confidence in its capacity requirements.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRuleGroup">REST API Reference for UpdateRuleGroup Operation</seealso>
        public virtual Task<UpdateRuleGroupResponse> UpdateRuleGroupAsync(UpdateRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRuleGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWebACL

        internal virtual UpdateWebACLResponse UpdateWebACL(UpdateWebACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWebACLResponseUnmarshaller.Instance;

            return Invoke<UpdateWebACLResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates the specified <a>WebACL</a>.
        /// </para>
        ///  
        /// <para>
        ///  A Web ACL defines a collection of rules to use to inspect and control web requests.
        /// Each rule has an action defined (allow, block, or count) for requests that match the
        /// statement of the rule. In the Web ACL, you assign a default action to take (allow,
        /// block) for any request that does not match any of the rules. The rules in a Web ACL
        /// can be a combination of the types <a>Rule</a>, <a>RuleGroup</a>, and managed rule
        /// group. You can associate a Web ACL with one or more AWS resources to protect. The
        /// resources can be Amazon CloudFront, an Amazon API Gateway API, or an Application Load
        /// Balancer. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// AWS WAF couldn’t perform the operation because the resource that you requested isn’t
        /// valid. Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateWebACL">REST API Reference for UpdateWebACL Operation</seealso>
        public virtual Task<UpdateWebACLResponse> UpdateWebACLAsync(UpdateWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWebACLResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}