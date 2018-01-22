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
    /// Container for the parameters to the SetV2LoggingOptions operation.
    /// Sets the logging options for the V2 logging service.
    /// </summary>
    public partial class SetV2LoggingOptionsRequest : AmazonIoTRequest
    {
        private LogLevel _defaultLogLevel;
        private bool? _disableAllLogs;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property DefaultLogLevel. 
        /// <para>
        /// The default logging level.
        /// </para>
        /// </summary>
        public LogLevel DefaultLogLevel
        {
            get { return this._defaultLogLevel; }
            set { this._defaultLogLevel = value; }
        }

        // Check to see if DefaultLogLevel property is set
        internal bool IsSetDefaultLogLevel()
        {
            return this._defaultLogLevel != null;
        }

        /// <summary>
        /// Gets and sets the property DisableAllLogs. 
        /// <para>
        /// Set to true to disable all logs, otherwise set to false.
        /// </para>
        /// </summary>
        public bool DisableAllLogs
        {
            get { return this._disableAllLogs.GetValueOrDefault(); }
            set { this._disableAllLogs = value; }
        }

        // Check to see if DisableAllLogs property is set
        internal bool IsSetDisableAllLogs()
        {
            return this._disableAllLogs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The role ARN that allows IoT to write to Cloudwatch logs.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}