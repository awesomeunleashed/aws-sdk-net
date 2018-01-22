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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// A gateway response of a given response type and status code, with optional response
    /// parameters and mapping templates.
    /// 
    ///  <div class="remarks"> For more information about valid gateway response types, see
    /// <a href="http://docs.aws.amazon.com/apigateway/latest/developerguide/supported-gateway-response-types.html">Gateway
    /// Response Types Supported by API Gateway</a> <div class="example"> <h4>Example: Get
    /// a Gateway Response of a given response type</h4> <h5>Request</h5> 
    /// <para>
    /// This example shows how to get a gateway response of the <code>MISSING_AUTHENTICATION_TOKEN</code>
    /// type.
    /// </para>
    ///  <pre><code>GET /restapis/o81lxisefl/gatewayresponses/MISSING_AUTHENTICATION_TOKEN
    /// HTTP/1.1 Host: beta-apigateway.us-east-1.amazonaws.com Content-Type: application/json
    /// X-Amz-Date: 20170503T202516Z Authorization: AWS4-HMAC-SHA256 Credential={access-key-id}/20170503/us-east-1/apigateway/aws4_request,
    /// SignedHeaders=content-type;host;x-amz-date, Signature=1b52460e3159c1a26cff29093855d50ea141c1c5b937528fecaf60f51129697a
    /// Cache-Control: no-cache Postman-Token: 3b2a1ce9-c848-2e26-2e2f-9c2caefbed45 </code></pre>
    /// 
    /// <para>
    /// The response type is specified as a URL path.
    /// </para>
    ///  <h5>Response</h5> 
    /// <para>
    /// The successful operation returns the <code>200 OK</code> status code and a payload
    /// similar to the following:
    /// </para>
    ///  <pre><code>{ "_links": { "curies": { "href": "http://docs.aws.amazon.com/apigateway/latest/developerguide/restapi-gatewayresponse-{rel}.html",
    /// "name": "gatewayresponse", "templated": true }, "self": { "href": "/restapis/o81lxisefl/gatewayresponses/MISSING_AUTHENTICATION_TOKEN"
    /// }, "gatewayresponse:delete": { "href": "/restapis/o81lxisefl/gatewayresponses/MISSING_AUTHENTICATION_TOKEN"
    /// }, "gatewayresponse:put": { "href": "/restapis/o81lxisefl/gatewayresponses/{response_type}",
    /// "templated": true }, "gatewayresponse:update": { "href": "/restapis/o81lxisefl/gatewayresponses/MISSING_AUTHENTICATION_TOKEN"
    /// } }, "defaultResponse": false, "responseParameters": { "gatewayresponse.header.x-request-path":
    /// "method.request.path.petId", "gatewayresponse.header.Access-Control-Allow-Origin":
    /// "&apos;a.b.c&apos;", "gatewayresponse.header.x-request-query": "method.request.querystring.q",
    /// "gatewayresponse.header.x-request-header": "method.request.header.Accept" }, "responseTemplates":
    /// { "application/json": "{\n \"message\": $context.error.messageString,\n \"type\":
    /// \"$context.error.responseType\",\n \"stage\": \"$context.stage\",\n \"resourcePath\":
    /// \"$context.resourcePath\",\n \"stageVariables.a\": \"$stageVariables.a\",\n \"statusCode\":
    /// \"&apos;404&apos;\"\n}" }, "responseType": "MISSING_AUTHENTICATION_TOKEN", "statusCode":
    /// "404" }</code></pre> 
    /// <para>
    /// 
    /// </para>
    ///  </div> </div> <div class="seeAlso"> <a href="http://docs.aws.amazon.com/apigateway/latest/developerguide/customize-gateway-responses.html">Customize
    /// Gateway Responses</a> </div>
    /// </summary>
    public partial class PutGatewayResponseResponse : AmazonWebServiceResponse
    {
        private bool? _defaultResponse;
        private Dictionary<string, string> _responseParameters = new Dictionary<string, string>();
        private Dictionary<string, string> _responseTemplates = new Dictionary<string, string>();
        private GatewayResponseType _responseType;
        private string _statusCode;

        /// <summary>
        /// Gets and sets the property DefaultResponse. 
        /// <para>
        /// A Boolean flag to indicate whether this <a>GatewayResponse</a> is the default gateway
        /// response (<code>true</code>) or not (<code>false</code>). A default gateway response
        /// is one generated by API Gateway without any customization by an API developer. 
        /// </para>
        /// </summary>
        public bool DefaultResponse
        {
            get { return this._defaultResponse.GetValueOrDefault(); }
            set { this._defaultResponse = value; }
        }

        // Check to see if DefaultResponse property is set
        internal bool IsSetDefaultResponse()
        {
            return this._defaultResponse.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResponseParameters. 
        /// <para>
        /// Response parameters (paths, query strings and headers) of the <a>GatewayResponse</a>
        /// as a string-to-string map of key-value pairs.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ResponseParameters
        {
            get { return this._responseParameters; }
            set { this._responseParameters = value; }
        }

        // Check to see if ResponseParameters property is set
        internal bool IsSetResponseParameters()
        {
            return this._responseParameters != null && this._responseParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResponseTemplates. 
        /// <para>
        /// Response templates of the <a>GatewayResponse</a> as a string-to-string map of key-value
        /// pairs.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ResponseTemplates
        {
            get { return this._responseTemplates; }
            set { this._responseTemplates = value; }
        }

        // Check to see if ResponseTemplates property is set
        internal bool IsSetResponseTemplates()
        {
            return this._responseTemplates != null && this._responseTemplates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResponseType. 
        /// <para>
        /// The response type of the associated <a>GatewayResponse</a>. Valid values are <ul><li>ACCESS_DENIED</li><li>API_CONFIGURATION_ERROR</li><li>AUTHORIZER_FAILURE</li><li>
        /// AUTHORIZER_CONFIGURATION_ERROR</li><li>BAD_REQUEST_PARAMETERS</li><li>BAD_REQUEST_BODY</li><li>DEFAULT_4XX</li><li>DEFAULT_5XX</li><li>EXPIRED_TOKEN</li><li>INVALID_SIGNATURE</li><li>INTEGRATION_FAILURE</li><li>INTEGRATION_TIMEOUT</li><li>INVALID_API_KEY</li><li>MISSING_AUTHENTICATION_TOKEN</li><li>
        /// QUOTA_EXCEEDED</li><li>REQUEST_TOO_LARGE</li><li>RESOURCE_NOT_FOUND</li><li>THROTTLED</li><li>UNAUTHORIZED</li><li>UNSUPPORTED_MEDIA_TYPES</li></ul>
        /// 
        /// </para>
        /// </summary>
        public GatewayResponseType ResponseType
        {
            get { return this._responseType; }
            set { this._responseType = value; }
        }

        // Check to see if ResponseType property is set
        internal bool IsSetResponseType()
        {
            return this._responseType != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The HTTP status code for this <a>GatewayResponse</a>.
        /// </para>
        /// </summary>
        public string StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

    }
}