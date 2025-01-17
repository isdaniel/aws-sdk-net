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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Summary information for users or groups in your Amazon Web Services SSO identity source
    /// with granted access to your Amazon Kendra experience. You can create an Amazon Kendra
    /// experience such as a search application. For more information on creating a search
    /// application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
    /// a search experience with no code</a>.
    /// </summary>
    public partial class ExperienceEntitiesSummary
    {
        private EntityDisplayData _displayData;
        private string _entityId;
        private EntityType _entityType;

        /// <summary>
        /// Gets and sets the property DisplayData. 
        /// <para>
        /// Information about the user entity.
        /// </para>
        /// </summary>
        public EntityDisplayData DisplayData
        {
            get { return this._displayData; }
            set { this._displayData = value; }
        }

        // Check to see if DisplayData property is set
        internal bool IsSetDisplayData()
        {
            return this._displayData != null;
        }

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The identifier of a user or group in your Amazon Web Services SSO identity source.
        /// For example, a user ID could be an email.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=47)]
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// Shows the type as <code>User</code> or <code>Group</code>.
        /// </para>
        /// </summary>
        public EntityType EntityType
        {
            get { return this._entityType; }
            set { this._entityType = value; }
        }

        // Check to see if EntityType property is set
        internal bool IsSetEntityType()
        {
            return this._entityType != null;
        }

    }
}