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
    /// Container for the parameters to the DescribeAlarm operation.
    /// Retrieves information about an alarm.
    /// </summary>
    public partial class DescribeAlarmRequest : AmazonIoTEventsDataRequest
    {
        private string _alarmModelName;
        private string _keyValue;

        /// <summary>
        /// Gets and sets the property AlarmModelName. 
        /// <para>
        /// The name of the alarm model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string AlarmModelName
        {
            get { return this._alarmModelName; }
            set { this._alarmModelName = value; }
        }

        // Check to see if AlarmModelName property is set
        internal bool IsSetAlarmModelName()
        {
            return this._alarmModelName != null;
        }

        /// <summary>
        /// Gets and sets the property KeyValue. 
        /// <para>
        /// The value of the key used as a filter to select only the alarms associated with the
        /// <a href="https://docs.aws.amazon.com/iotevents/latest/apireference/API_CreateAlarmModel.html#iotevents-CreateAlarmModel-request-key">key</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string KeyValue
        {
            get { return this._keyValue; }
            set { this._keyValue = value; }
        }

        // Check to see if KeyValue property is set
        internal bool IsSetKeyValue()
        {
            return this._keyValue != null;
        }

    }
}