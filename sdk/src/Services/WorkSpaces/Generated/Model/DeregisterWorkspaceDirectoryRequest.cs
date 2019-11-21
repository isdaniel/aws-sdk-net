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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the DeregisterWorkspaceDirectory operation.
    /// Deregisters the specified directory. This operation is asynchronous and returns before
    /// the WorkSpace directory is deregistered. If any WorkSpaces are registered to this
    /// directory, you must remove them before you can deregister the directory.
    /// </summary>
    public partial class DeregisterWorkspaceDirectoryRequest : AmazonWorkSpacesRequest
    {
        private string _directoryId;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory. If any WorkSpaces are registered to this directory,
        /// you must remove them before you deregister the directory, or you will receive an OperationNotSupportedException
        /// error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=65)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

    }
}