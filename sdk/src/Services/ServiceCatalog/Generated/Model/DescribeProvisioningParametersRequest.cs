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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeProvisioningParameters operation.
    /// Provides information about parameters required to provision a specified product in
    /// a specified manner. Use this operation to obtain the list of <code>ProvisioningArtifactParameters</code>
    /// parameters available to call the <a>ProvisionProduct</a> operation for the specified
    /// product.
    /// 
    ///  
    /// <para>
    /// If the output contains a TagOption key with an empty list of values, there is a TagOption
    /// conflict for that key. The end user cannot take action to fix the conflict, and launch
    /// is not blocked. In subsequent calls to the <code>ProvisionProduct</code> operation,
    /// do not include conflicted TagOption keys as tags. Calls to <code>ProvisionProduct</code>
    /// with empty TagOption values cause the error "Parameter validation failed: Missing
    /// required parameter in Tags[<i>N</i>]:<i>Value</i> ". Calls to <code>ProvisionProduct</code>
    /// with conflicted TagOption keys automatically tag the provisioned product with the
    /// conflicted keys with the value "<code>sc-tagoption-conflict-portfolioId-productId</code>".
    /// </para>
    /// </summary>
    public partial class DescribeProvisioningParametersRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private string _pathId;
        private string _productId;
        private string _provisioningArtifactId;

        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>en</code> - English (default)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>jp</code> - Japanese
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>zh</code> - Chinese
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string AcceptLanguage
        {
            get { return this._acceptLanguage; }
            set { this._acceptLanguage = value; }
        }

        // Check to see if AcceptLanguage property is set
        internal bool IsSetAcceptLanguage()
        {
            return this._acceptLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property PathId. 
        /// <para>
        /// The identifier of the path for this product's provisioning. This value is optional
        /// if the product has a default path, and is required if there is more than one path
        /// for the specified product.
        /// </para>
        /// </summary>
        public string PathId
        {
            get { return this._pathId; }
            set { this._pathId = value; }
        }

        // Check to see if PathId property is set
        internal bool IsSetPathId()
        {
            return this._pathId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product identifier.
        /// </para>
        /// </summary>
        public string ProductId
        {
            get { return this._productId; }
            set { this._productId = value; }
        }

        // Check to see if ProductId property is set
        internal bool IsSetProductId()
        {
            return this._productId != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactId. 
        /// <para>
        /// The provisioning artifact identifier for this product. This is sometimes referred
        /// to as the product version.
        /// </para>
        /// </summary>
        public string ProvisioningArtifactId
        {
            get { return this._provisioningArtifactId; }
            set { this._provisioningArtifactId = value; }
        }

        // Check to see if ProvisioningArtifactId property is set
        internal bool IsSetProvisioningArtifactId()
        {
            return this._provisioningArtifactId != null;
        }

    }
}