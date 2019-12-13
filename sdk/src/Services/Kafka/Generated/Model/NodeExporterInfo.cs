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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Indicates whether you want to enable or disable the Node Exporter.
    /// </summary>
    public partial class NodeExporterInfo
    {
        private bool? _enabledInBroker;

        /// <summary>
        /// Gets and sets the property EnabledInBroker.             
        /// <para>
        /// Indicates whether you want to enable or disable the Node Exporter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool EnabledInBroker
        {
            get { return this._enabledInBroker.GetValueOrDefault(); }
            set { this._enabledInBroker = value; }
        }

        // Check to see if EnabledInBroker property is set
        internal bool IsSetEnabledInBroker()
        {
            return this._enabledInBroker.HasValue; 
        }

    }
}