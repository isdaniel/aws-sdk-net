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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteRecoveryInstance operation.
    /// Deletes a single Recovery Instance by ID. This deletes the Recovery Instance resource
    /// from Elastic Disaster Recovery. The Recovery Instance must be disconnected first in
    /// order to delete it.
    /// </summary>
    public partial class DeleteRecoveryInstanceRequest : AmazonDrsRequest
    {
        private string _recoveryInstanceID;

        /// <summary>
        /// Gets and sets the property RecoveryInstanceID. 
        /// <para>
        /// RThe ID of the Recovery Instance to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=19)]
        public string RecoveryInstanceID
        {
            get { return this._recoveryInstanceID; }
            set { this._recoveryInstanceID = value; }
        }

        // Check to see if RecoveryInstanceID property is set
        internal bool IsSetRecoveryInstanceID()
        {
            return this._recoveryInstanceID != null;
        }

    }
}