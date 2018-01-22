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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the UpdateStream operation.
    /// </summary>
    public partial class UpdateStreamResponse : AmazonWebServiceResponse
    {
        private string _description;
        private string _streamArn;
        private string _streamId;
        private int? _streamVersion;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the stream.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property StreamArn. 
        /// <para>
        /// The stream ARN.
        /// </para>
        /// </summary>
        public string StreamArn
        {
            get { return this._streamArn; }
            set { this._streamArn = value; }
        }

        // Check to see if StreamArn property is set
        internal bool IsSetStreamArn()
        {
            return this._streamArn != null;
        }

        /// <summary>
        /// Gets and sets the property StreamId. 
        /// <para>
        /// The stream ID.
        /// </para>
        /// </summary>
        public string StreamId
        {
            get { return this._streamId; }
            set { this._streamId = value; }
        }

        // Check to see if StreamId property is set
        internal bool IsSetStreamId()
        {
            return this._streamId != null;
        }

        /// <summary>
        /// Gets and sets the property StreamVersion. 
        /// <para>
        /// The stream version.
        /// </para>
        /// </summary>
        public int StreamVersion
        {
            get { return this._streamVersion.GetValueOrDefault(); }
            set { this._streamVersion = value; }
        }

        // Check to see if StreamVersion property is set
        internal bool IsSetStreamVersion()
        {
            return this._streamVersion.HasValue; 
        }

    }
}