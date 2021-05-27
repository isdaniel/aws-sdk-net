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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEventsData.Model
{
    /// <summary>
    /// Contains information about alarm state changes.
    /// </summary>
    public partial class SystemEvent
    {
        private EventType _eventType;
        private StateChangeConfiguration _stateChangeConfiguration;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The event type. If the value is <code>STATE_CHANGE</code>, the event contains information
        /// about alarm state changes.
        /// </para>
        /// </summary>
        public EventType EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property StateChangeConfiguration. 
        /// <para>
        /// Contains the configuration information of alarm state changes.
        /// </para>
        /// </summary>
        public StateChangeConfiguration StateChangeConfiguration
        {
            get { return this._stateChangeConfiguration; }
            set { this._stateChangeConfiguration = value; }
        }

        // Check to see if StateChangeConfiguration property is set
        internal bool IsSetStateChangeConfiguration()
        {
            return this._stateChangeConfiguration != null;
        }

    }
}