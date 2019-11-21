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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A tag for a column in a TagColumnOperation. This is a variant type structure. No more
    /// than one of the attributes should be non-null for this structure to be valid.
    /// </summary>
    public partial class ColumnTag
    {
        private GeoSpatialDataRole _columnGeographicRole;

        /// <summary>
        /// Gets and sets the property ColumnGeographicRole. 
        /// <para>
        /// A geospatial role for a column.
        /// </para>
        /// </summary>
        public GeoSpatialDataRole ColumnGeographicRole
        {
            get { return this._columnGeographicRole; }
            set { this._columnGeographicRole = value; }
        }

        // Check to see if ColumnGeographicRole property is set
        internal bool IsSetColumnGeographicRole()
        {
            return this._columnGeographicRole != null;
        }

    }
}