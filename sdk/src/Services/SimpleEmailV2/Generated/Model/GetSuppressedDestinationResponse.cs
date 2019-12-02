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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Information about the suppressed email destination.
    /// </summary>
    public partial class GetSuppressedDestinationResponse : AmazonWebServiceResponse
    {
        private SuppressedDestination _suppressedDestination;

        /// <summary>
        /// Gets and sets the property SuppressedDestination. 
        /// <para>
        /// An object containing information about the suppressed email destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SuppressedDestination SuppressedDestination
        {
            get { return this._suppressedDestination; }
            set { this._suppressedDestination = value; }
        }

        // Check to see if SuppressedDestination property is set
        internal bool IsSetSuppressedDestination()
        {
            return this._suppressedDestination != null;
        }

    }
}