/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTrustedAdvisorCheckResult operation.
    /// Returns the results of the Trusted Advisor check that has the specified check ID.
    /// You can get the check IDs by calling the <a>DescribeTrustedAdvisorChecks</a> operation.
    /// 
    ///  
    /// <para>
    /// The response contains a <a>TrustedAdvisorCheckResult</a> object, which contains these
    /// three objects:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>TrustedAdvisorCategorySpecificSummary</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>TrustedAdvisorResourceDetail</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>TrustedAdvisorResourcesSummary</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// In addition, the response contains these fields:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>status</b> - The alert status of the check can be <code>ok</code> (green), <code>warning</code>
    /// (yellow), <code>error</code> (red), or <code>not_available</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>timestamp</b> - The time of the last refresh of the check.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>checkId</b> - The unique identifier for the check.
    /// </para>
    ///  </li> </ul> <note> <ul> <li> 
    /// <para>
    /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
    /// Amazon Web Services Support API. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you call the Amazon Web Services Support API from an account that does not have
    /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
    /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
    /// Web Services Support</a>.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class DescribeTrustedAdvisorCheckResultRequest : AmazonAWSSupportRequest
    {
        private string _checkId;
        private string _language;

        /// <summary>
        /// Gets and sets the property CheckId. 
        /// <para>
        /// The unique identifier for the Trusted Advisor check.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CheckId
        {
            get { return this._checkId; }
            set { this._checkId = value; }
        }

        // Check to see if CheckId property is set
        internal bool IsSetCheckId()
        {
            return this._checkId != null;
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The ISO 639-1 code for the language in which Amazon Web Services provides support.
        /// Amazon Web Services Support currently supports English ("en") and Japanese ("ja").
        /// Language parameters must be passed explicitly for operations that take them.
        /// </para>
        /// </summary>
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

    }
}