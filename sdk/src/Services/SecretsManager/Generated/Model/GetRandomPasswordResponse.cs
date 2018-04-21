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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// This is the response object from the GetRandomPassword operation.
    /// </summary>
    public partial class GetRandomPasswordResponse : AmazonWebServiceResponse
    {
        private string _randomPassword;

        /// <summary>
        /// Gets and sets the property RandomPassword. 
        /// <para>
        /// A string with the generated password.
        /// </para>
        /// </summary>
        public string RandomPassword
        {
            get { return this._randomPassword; }
            set { this._randomPassword = value; }
        }

        // Check to see if RandomPassword property is set
        internal bool IsSetRandomPassword()
        {
            return this._randomPassword != null;
        }

    }
}