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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes an availability zone.
    /// </summary>
    public partial class AvailabilityZone
    {
        private string _name;
        private List<SupportedPlatform> _supportedPlatforms = new List<SupportedPlatform>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the availability zone.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedPlatforms.
        /// </summary>
        public List<SupportedPlatform> SupportedPlatforms
        {
            get { return this._supportedPlatforms; }
            set { this._supportedPlatforms = value; }
        }

        // Check to see if SupportedPlatforms property is set
        internal bool IsSetSupportedPlatforms()
        {
            return this._supportedPlatforms != null && this._supportedPlatforms.Count > 0; 
        }

    }
}