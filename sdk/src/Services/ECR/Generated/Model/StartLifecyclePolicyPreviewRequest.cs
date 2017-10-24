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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECR.Model
{
    /// <summary>
    /// Container for the parameters to the StartLifecyclePolicyPreview operation.
    /// Starts a preview of the specified lifecycle policy. This allows you to see the results
    /// before creating the lifecycle policy.
    /// </summary>
    public partial class StartLifecyclePolicyPreviewRequest : AmazonECRRequest
    {
        private string _lifecyclePolicyText;
        private string _registryId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property LifecyclePolicyText. 
        /// <para>
        /// The policy to be evaluated against. If you do not specify a policy, the current policy
        /// for the repository is used.
        /// </para>
        /// </summary>
        public string LifecyclePolicyText
        {
            get { return this._lifecyclePolicyText; }
            set { this._lifecyclePolicyText = value; }
        }

        // Check to see if LifecyclePolicyText property is set
        internal bool IsSetLifecyclePolicyText()
        {
            return this._lifecyclePolicyText != null;
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The AWS account ID associated with the registry that contains the repository. If you
        /// do not specify a registry, the default registry is assumed.
        /// </para>
        /// </summary>
        public string RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository to be evaluated.
        /// </para>
        /// </summary>
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

    }
}