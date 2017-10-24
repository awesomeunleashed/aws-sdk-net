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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CloudWatch.Model;
using Amazon.CloudWatch.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudWatch
{
    /// <summary>
    /// Implementation for accessing CloudWatch
    ///
    /// Amazon CloudWatch monitors your Amazon Web Services (AWS) resources and the applications
    /// you run on AWS in real time. You can use CloudWatch to collect and track metrics,
    /// which are the variables you want to measure for your resources and applications.
    /// 
    ///  
    /// <para>
    /// CloudWatch alarms send notifications or automatically change the resources you are
    /// monitoring based on rules that you define. For example, you can monitor the CPU usage
    /// and disk reads and writes of your Amazon EC2 instances. Then, use this data to determine
    /// whether you should launch additional instances to handle increased load. You can also
    /// use this data to stop under-used instances to save money.
    /// </para>
    ///  
    /// <para>
    /// In addition to monitoring the built-in metrics that come with AWS, you can monitor
    /// your own custom metrics. With CloudWatch, you gain system-wide visibility into resource
    /// utilization, application performance, and operational health.
    /// </para>
    /// </summary>
    public partial class AmazonCloudWatchClient : AmazonServiceClient, IAmazonCloudWatch
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudWatchClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCloudWatchClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudWatchConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudWatchConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCloudWatchClient Configuration Object</param>
        public AmazonCloudWatchClient(AmazonCloudWatchConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudWatchClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudWatchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudWatchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Credentials and an
        /// AmazonCloudWatchClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudWatchClient Configuration Object</param>
        public AmazonCloudWatchClient(AWSCredentials credentials, AmazonCloudWatchConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudWatchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudWatchConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudWatchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudWatchClient Configuration Object</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudWatchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudWatchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudWatchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudWatchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudWatchClient Configuration Object</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudWatchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  DeleteAlarms


        /// <summary>
        /// Deletes the specified alarms. In the event of an error, no alarms are deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlarms service method.</param>
        /// 
        /// <returns>The response from the DeleteAlarms service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.ResourceNotFoundException">
        /// The named resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DeleteAlarms">REST API Reference for DeleteAlarms Operation</seealso>
        public virtual DeleteAlarmsResponse DeleteAlarms(DeleteAlarmsRequest request)
        {
            var marshaller = new DeleteAlarmsRequestMarshaller();
            var unmarshaller = DeleteAlarmsResponseUnmarshaller.Instance;

            return Invoke<DeleteAlarmsRequest,DeleteAlarmsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlarms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlarms operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DeleteAlarms">REST API Reference for DeleteAlarms Operation</seealso>
        public virtual Task<DeleteAlarmsResponse> DeleteAlarmsAsync(DeleteAlarmsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAlarmsRequestMarshaller();
            var unmarshaller = DeleteAlarmsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAlarmsRequest,DeleteAlarmsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDashboards


        /// <summary>
        /// Deletes all dashboards that you specify. You may specify up to 100 dashboards to delete.
        /// If there is an error during this call, no dashboards are deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboards service method.</param>
        /// 
        /// <returns>The response from the DeleteDashboards service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.DashboardNotFoundErrorException">
        /// The specified dashboard does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DeleteDashboards">REST API Reference for DeleteDashboards Operation</seealso>
        public virtual DeleteDashboardsResponse DeleteDashboards(DeleteDashboardsRequest request)
        {
            var marshaller = new DeleteDashboardsRequestMarshaller();
            var unmarshaller = DeleteDashboardsResponseUnmarshaller.Instance;

            return Invoke<DeleteDashboardsRequest,DeleteDashboardsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDashboards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboards operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DeleteDashboards">REST API Reference for DeleteDashboards Operation</seealso>
        public virtual Task<DeleteDashboardsResponse> DeleteDashboardsAsync(DeleteDashboardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDashboardsRequestMarshaller();
            var unmarshaller = DeleteDashboardsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDashboardsRequest,DeleteDashboardsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAlarmHistory


        /// <summary>
        /// Retrieves the history for the specified alarm. You can filter the results by date
        /// range or item type. If an alarm name is not specified, the histories for all alarms
        /// are returned.
        /// 
        ///  
        /// <para>
        /// CloudWatch retains the history of an alarm even if you delete the alarm.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAlarmHistory service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarmHistory">REST API Reference for DescribeAlarmHistory Operation</seealso>
        public virtual DescribeAlarmHistoryResponse DescribeAlarmHistory()
        {
            return DescribeAlarmHistory(new DescribeAlarmHistoryRequest());
        }


        /// <summary>
        /// Retrieves the history for the specified alarm. You can filter the results by date
        /// range or item type. If an alarm name is not specified, the histories for all alarms
        /// are returned.
        /// 
        ///  
        /// <para>
        /// CloudWatch retains the history of an alarm even if you delete the alarm.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmHistory service method.</param>
        /// 
        /// <returns>The response from the DescribeAlarmHistory service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarmHistory">REST API Reference for DescribeAlarmHistory Operation</seealso>
        public virtual DescribeAlarmHistoryResponse DescribeAlarmHistory(DescribeAlarmHistoryRequest request)
        {
            var marshaller = new DescribeAlarmHistoryRequestMarshaller();
            var unmarshaller = DescribeAlarmHistoryResponseUnmarshaller.Instance;

            return Invoke<DescribeAlarmHistoryRequest,DescribeAlarmHistoryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieves the history for the specified alarm. You can filter the results by date
        /// range or item type. If an alarm name is not specified, the histories for all alarms
        /// are returned.
        /// 
        ///  
        /// <para>
        /// CloudWatch retains the history of an alarm even if you delete the alarm.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAlarmHistory service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarmHistory">REST API Reference for DescribeAlarmHistory Operation</seealso>
        public virtual Task<DescribeAlarmHistoryResponse> DescribeAlarmHistoryAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAlarmHistoryAsync(new DescribeAlarmHistoryRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarmHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarmHistory">REST API Reference for DescribeAlarmHistory Operation</seealso>
        public virtual Task<DescribeAlarmHistoryResponse> DescribeAlarmHistoryAsync(DescribeAlarmHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAlarmHistoryRequestMarshaller();
            var unmarshaller = DescribeAlarmHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAlarmHistoryRequest,DescribeAlarmHistoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAlarms


        /// <summary>
        /// Retrieves the specified alarms. If no alarms are specified, all alarms are returned.
        /// Alarms can be retrieved by using only a prefix for the alarm name, the alarm state,
        /// or a prefix for any action.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAlarms service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarms">REST API Reference for DescribeAlarms Operation</seealso>
        public virtual DescribeAlarmsResponse DescribeAlarms()
        {
            return DescribeAlarms(new DescribeAlarmsRequest());
        }


        /// <summary>
        /// Retrieves the specified alarms. If no alarms are specified, all alarms are returned.
        /// Alarms can be retrieved by using only a prefix for the alarm name, the alarm state,
        /// or a prefix for any action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarms service method.</param>
        /// 
        /// <returns>The response from the DescribeAlarms service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarms">REST API Reference for DescribeAlarms Operation</seealso>
        public virtual DescribeAlarmsResponse DescribeAlarms(DescribeAlarmsRequest request)
        {
            var marshaller = new DescribeAlarmsRequestMarshaller();
            var unmarshaller = DescribeAlarmsResponseUnmarshaller.Instance;

            return Invoke<DescribeAlarmsRequest,DescribeAlarmsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieves the specified alarms. If no alarms are specified, all alarms are returned.
        /// Alarms can be retrieved by using only a prefix for the alarm name, the alarm state,
        /// or a prefix for any action.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAlarms service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarms">REST API Reference for DescribeAlarms Operation</seealso>
        public virtual Task<DescribeAlarmsResponse> DescribeAlarmsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAlarmsAsync(new DescribeAlarmsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarms operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarms">REST API Reference for DescribeAlarms Operation</seealso>
        public virtual Task<DescribeAlarmsResponse> DescribeAlarmsAsync(DescribeAlarmsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAlarmsRequestMarshaller();
            var unmarshaller = DescribeAlarmsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAlarmsRequest,DescribeAlarmsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAlarmsForMetric


        /// <summary>
        /// Retrieves the alarms for the specified metric. To filter the results, specify a statistic,
        /// period, or unit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmsForMetric service method.</param>
        /// 
        /// <returns>The response from the DescribeAlarmsForMetric service method, as returned by CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarmsForMetric">REST API Reference for DescribeAlarmsForMetric Operation</seealso>
        public virtual DescribeAlarmsForMetricResponse DescribeAlarmsForMetric(DescribeAlarmsForMetricRequest request)
        {
            var marshaller = new DescribeAlarmsForMetricRequestMarshaller();
            var unmarshaller = DescribeAlarmsForMetricResponseUnmarshaller.Instance;

            return Invoke<DescribeAlarmsForMetricRequest,DescribeAlarmsForMetricResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarmsForMetric operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmsForMetric operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarmsForMetric">REST API Reference for DescribeAlarmsForMetric Operation</seealso>
        public virtual Task<DescribeAlarmsForMetricResponse> DescribeAlarmsForMetricAsync(DescribeAlarmsForMetricRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAlarmsForMetricRequestMarshaller();
            var unmarshaller = DescribeAlarmsForMetricResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAlarmsForMetricRequest,DescribeAlarmsForMetricResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableAlarmActions


        /// <summary>
        /// Disables the actions for the specified alarms. When an alarm's actions are disabled,
        /// the alarm actions do not execute when the alarm state changes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableAlarmActions service method.</param>
        /// 
        /// <returns>The response from the DisableAlarmActions service method, as returned by CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DisableAlarmActions">REST API Reference for DisableAlarmActions Operation</seealso>
        public virtual DisableAlarmActionsResponse DisableAlarmActions(DisableAlarmActionsRequest request)
        {
            var marshaller = new DisableAlarmActionsRequestMarshaller();
            var unmarshaller = DisableAlarmActionsResponseUnmarshaller.Instance;

            return Invoke<DisableAlarmActionsRequest,DisableAlarmActionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableAlarmActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAlarmActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DisableAlarmActions">REST API Reference for DisableAlarmActions Operation</seealso>
        public virtual Task<DisableAlarmActionsResponse> DisableAlarmActionsAsync(DisableAlarmActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableAlarmActionsRequestMarshaller();
            var unmarshaller = DisableAlarmActionsResponseUnmarshaller.Instance;

            return InvokeAsync<DisableAlarmActionsRequest,DisableAlarmActionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableAlarmActions


        /// <summary>
        /// Enables the actions for the specified alarms.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableAlarmActions service method.</param>
        /// 
        /// <returns>The response from the EnableAlarmActions service method, as returned by CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/EnableAlarmActions">REST API Reference for EnableAlarmActions Operation</seealso>
        public virtual EnableAlarmActionsResponse EnableAlarmActions(EnableAlarmActionsRequest request)
        {
            var marshaller = new EnableAlarmActionsRequestMarshaller();
            var unmarshaller = EnableAlarmActionsResponseUnmarshaller.Instance;

            return Invoke<EnableAlarmActionsRequest,EnableAlarmActionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableAlarmActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAlarmActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/EnableAlarmActions">REST API Reference for EnableAlarmActions Operation</seealso>
        public virtual Task<EnableAlarmActionsResponse> EnableAlarmActionsAsync(EnableAlarmActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableAlarmActionsRequestMarshaller();
            var unmarshaller = EnableAlarmActionsResponseUnmarshaller.Instance;

            return InvokeAsync<EnableAlarmActionsRequest,EnableAlarmActionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDashboard


        /// <summary>
        /// Displays the details of the dashboard that you specify.
        /// 
        ///  
        /// <para>
        /// To copy an existing dashboard, use <code>GetDashboard</code>, and then use the data
        /// returned within <code>DashboardBody</code> as the template for the new dashboard when
        /// you call <code>PutDashboard</code> to create the copy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDashboard service method.</param>
        /// 
        /// <returns>The response from the GetDashboard service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.DashboardNotFoundErrorException">
        /// The specified dashboard does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetDashboard">REST API Reference for GetDashboard Operation</seealso>
        public virtual GetDashboardResponse GetDashboard(GetDashboardRequest request)
        {
            var marshaller = new GetDashboardRequestMarshaller();
            var unmarshaller = GetDashboardResponseUnmarshaller.Instance;

            return Invoke<GetDashboardRequest,GetDashboardResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDashboard operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetDashboard">REST API Reference for GetDashboard Operation</seealso>
        public virtual Task<GetDashboardResponse> GetDashboardAsync(GetDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDashboardRequestMarshaller();
            var unmarshaller = GetDashboardResponseUnmarshaller.Instance;

            return InvokeAsync<GetDashboardRequest,GetDashboardResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetMetricStatistics


        /// <summary>
        /// Gets statistics for the specified metric.
        /// 
        ///  
        /// <para>
        /// The maximum number of data points returned from a single call is 1,440. If you request
        /// more than 1,440 data points, CloudWatch returns an error. To reduce the number of
        /// data points, you can narrow the specified time range and make multiple requests across
        /// adjacent time ranges, or you can increase the specified period. Data points are not
        /// returned in chronological order.
        /// </para>
        ///  
        /// <para>
        /// CloudWatch aggregates data points based on the length of the period that you specify.
        /// For example, if you request statistics with a one-hour period, CloudWatch aggregates
        /// all data points with time stamps that fall within each one-hour period. Therefore,
        /// the number of values aggregated by CloudWatch is larger than the number of data points
        /// returned.
        /// </para>
        ///  
        /// <para>
        /// CloudWatch needs raw data points to calculate percentile statistics. If you publish
        /// data using a statistic set instead, you can only retrieve percentile statistics for
        /// this data if one of the following conditions is true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The SampleCount value of the statistic set is 1.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Min and the Max values of the statistic set are equal.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon CloudWatch retains metric data as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Data points with a period of less than 60 seconds are available for 3 hours. These
        /// data points are high-resolution metrics and are available only for custom metrics
        /// that have been defined with a <code>StorageResolution</code> of 1.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data points with a period of 60 seconds (1-minute) are available for 15 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data points with a period of 300 seconds (5-minute) are available for 63 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data points with a period of 3600 seconds (1 hour) are available for 455 days (15
        /// months).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Data points that are initially published with a shorter period are aggregated together
        /// for long-term storage. For example, if you collect data using a period of 1 minute,
        /// the data remains available for 15 days with 1-minute resolution. After 15 days, this
        /// data is still available, but is aggregated and retrievable only with a resolution
        /// of 5 minutes. After 63 days, the data is further aggregated and is available with
        /// a resolution of 1 hour.
        /// </para>
        ///  
        /// <para>
        /// CloudWatch started retaining 5-minute and 1-hour metric data as of July 9, 2016.
        /// </para>
        ///  
        /// <para>
        /// For information about metrics and dimensions supported by AWS services, see the <a
        /// href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CW_Support_For_AWS.html">Amazon
        /// CloudWatch Metrics and Dimensions Reference</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricStatistics service method.</param>
        /// 
        /// <returns>The response from the GetMetricStatistics service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterCombinationException">
        /// Parameters were used together that cannot be used together.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is required is missing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetMetricStatistics">REST API Reference for GetMetricStatistics Operation</seealso>
        public virtual GetMetricStatisticsResponse GetMetricStatistics(GetMetricStatisticsRequest request)
        {
            var marshaller = new GetMetricStatisticsRequestMarshaller();
            var unmarshaller = GetMetricStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetMetricStatisticsRequest,GetMetricStatisticsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMetricStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMetricStatistics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetMetricStatistics">REST API Reference for GetMetricStatistics Operation</seealso>
        public virtual Task<GetMetricStatisticsResponse> GetMetricStatisticsAsync(GetMetricStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetMetricStatisticsRequestMarshaller();
            var unmarshaller = GetMetricStatisticsResponseUnmarshaller.Instance;

            return InvokeAsync<GetMetricStatisticsRequest,GetMetricStatisticsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDashboards


        /// <summary>
        /// Returns a list of the dashboards for your account. If you include <code>DashboardNamePrefix</code>,
        /// only those dashboards with names starting with the prefix are listed. Otherwise, all
        /// dashboards in your account are listed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards service method.</param>
        /// 
        /// <returns>The response from the ListDashboards service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        public virtual ListDashboardsResponse ListDashboards(ListDashboardsRequest request)
        {
            var marshaller = new ListDashboardsRequestMarshaller();
            var unmarshaller = ListDashboardsResponseUnmarshaller.Instance;

            return Invoke<ListDashboardsRequest,ListDashboardsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDashboards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        public virtual Task<ListDashboardsResponse> ListDashboardsAsync(ListDashboardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDashboardsRequestMarshaller();
            var unmarshaller = ListDashboardsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDashboardsRequest,ListDashboardsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListMetrics


        /// <summary>
        /// List the specified metrics. You can use the returned metrics with <a>GetMetricStatistics</a>
        /// to obtain statistical data.
        /// 
        ///  
        /// <para>
        /// Up to 500 results are returned for any one call. To retrieve additional results, use
        /// the returned token with subsequent calls.
        /// </para>
        ///  
        /// <para>
        /// After you create a metric, allow up to fifteen minutes before the metric appears.
        /// Statistics about the metric, however, are available sooner using <a>GetMetricStatistics</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListMetrics service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListMetrics">REST API Reference for ListMetrics Operation</seealso>
        public virtual ListMetricsResponse ListMetrics()
        {
            return ListMetrics(new ListMetricsRequest());
        }


        /// <summary>
        /// List the specified metrics. You can use the returned metrics with <a>GetMetricStatistics</a>
        /// to obtain statistical data.
        /// 
        ///  
        /// <para>
        /// Up to 500 results are returned for any one call. To retrieve additional results, use
        /// the returned token with subsequent calls.
        /// </para>
        ///  
        /// <para>
        /// After you create a metric, allow up to fifteen minutes before the metric appears.
        /// Statistics about the metric, however, are available sooner using <a>GetMetricStatistics</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMetrics service method.</param>
        /// 
        /// <returns>The response from the ListMetrics service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListMetrics">REST API Reference for ListMetrics Operation</seealso>
        public virtual ListMetricsResponse ListMetrics(ListMetricsRequest request)
        {
            var marshaller = new ListMetricsRequestMarshaller();
            var unmarshaller = ListMetricsResponseUnmarshaller.Instance;

            return Invoke<ListMetricsRequest,ListMetricsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// List the specified metrics. You can use the returned metrics with <a>GetMetricStatistics</a>
        /// to obtain statistical data.
        /// 
        ///  
        /// <para>
        /// Up to 500 results are returned for any one call. To retrieve additional results, use
        /// the returned token with subsequent calls.
        /// </para>
        ///  
        /// <para>
        /// After you create a metric, allow up to fifteen minutes before the metric appears.
        /// Statistics about the metric, however, are available sooner using <a>GetMetricStatistics</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMetrics service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListMetrics">REST API Reference for ListMetrics Operation</seealso>
        public virtual Task<ListMetricsResponse> ListMetricsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListMetricsAsync(new ListMetricsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the ListMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMetrics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListMetrics">REST API Reference for ListMetrics Operation</seealso>
        public virtual Task<ListMetricsResponse> ListMetricsAsync(ListMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListMetricsRequestMarshaller();
            var unmarshaller = ListMetricsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMetricsRequest,ListMetricsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutDashboard


        /// <summary>
        /// Creates a dashboard if it does not already exist, or updates an existing dashboard.
        /// If you update a dashboard, the entire contents are replaced with what you specify
        /// here.
        /// 
        ///  
        /// <para>
        /// You can have up to 500 dashboards per account. All dashboards in your account are
        /// global, not region-specific.
        /// </para>
        ///  
        /// <para>
        /// A simple way to create a dashboard using <code>PutDashboard</code> is to copy an existing
        /// dashboard. To copy an existing dashboard using the console, you can load the dashboard
        /// and then use the View/edit source command in the Actions menu to display the JSON
        /// block for that dashboard. Another way to copy a dashboard is to use <code>GetDashboard</code>,
        /// and then use the data returned within <code>DashboardBody</code> as the template for
        /// the new dashboard when you call <code>PutDashboard</code>.
        /// </para>
        ///  
        /// <para>
        /// When you create a dashboard with <code>PutDashboard</code>, a good practice is to
        /// add a text widget at the top of the dashboard with a message that the dashboard was
        /// created by script and should not be changed in the console. This message could also
        /// point console users to the location of the <code>DashboardBody</code> script or the
        /// CloudFormation template used to create the dashboard.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDashboard service method.</param>
        /// 
        /// <returns>The response from the PutDashboard service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.DashboardInvalidInputErrorException">
        /// Some part of the dashboard data is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutDashboard">REST API Reference for PutDashboard Operation</seealso>
        public virtual PutDashboardResponse PutDashboard(PutDashboardRequest request)
        {
            var marshaller = new PutDashboardRequestMarshaller();
            var unmarshaller = PutDashboardResponseUnmarshaller.Instance;

            return Invoke<PutDashboardRequest,PutDashboardResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDashboard operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutDashboard">REST API Reference for PutDashboard Operation</seealso>
        public virtual Task<PutDashboardResponse> PutDashboardAsync(PutDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutDashboardRequestMarshaller();
            var unmarshaller = PutDashboardResponseUnmarshaller.Instance;

            return InvokeAsync<PutDashboardRequest,PutDashboardResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutMetricAlarm


        /// <summary>
        /// Creates or updates an alarm and associates it with the specified metric. Optionally,
        /// this operation can associate one or more Amazon SNS resources with the alarm.
        /// 
        ///  
        /// <para>
        /// When this operation creates an alarm, the alarm state is immediately set to <code>INSUFFICIENT_DATA</code>.
        /// The alarm is evaluated and its state is set appropriately. Any actions associated
        /// with the state are then executed.
        /// </para>
        ///  
        /// <para>
        /// When you update an existing alarm, its state is left unchanged, but the update completely
        /// overwrites the previous configuration of the alarm.
        /// </para>
        ///  
        /// <para>
        /// If you are an IAM user, you must have Amazon EC2 permissions for some operations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ec2:DescribeInstanceStatus</code> and <code>ec2:DescribeInstances</code> for
        /// all alarms on EC2 instance status metrics
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:StopInstances</code> for alarms with stop actions
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:TerminateInstances</code> for alarms with terminate actions
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:DescribeInstanceRecoveryAttribute</code> and <code>ec2:RecoverInstances</code>
        /// for alarms with recover actions
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you have read/write permissions for Amazon CloudWatch but not for Amazon EC2, you
        /// can still create an alarm, but the stop or terminate actions are not performed. However,
        /// if you are later granted the required permissions, the alarm actions that you created
        /// earlier are performed.
        /// </para>
        ///  
        /// <para>
        /// If you are using an IAM role (for example, an EC2 instance profile), you cannot stop
        /// or terminate the instance using alarm actions. However, you can still see the alarm
        /// state and perform any other actions such as Amazon SNS notifications or Auto Scaling
        /// policies.
        /// </para>
        ///  
        /// <para>
        /// If you are using temporary security credentials granted using AWS STS, you cannot
        /// stop or terminate an EC2 instance using alarm actions.
        /// </para>
        ///  
        /// <para>
        /// You must create at least one stop, terminate, or reboot alarm using either the Amazon
        /// EC2 or CloudWatch consoles to create the <b>EC2ActionsAccess</b> IAM role. After this
        /// IAM role is created, you can create stop, terminate, or reboot alarms using a command-line
        /// interface or API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricAlarm service method.</param>
        /// 
        /// <returns>The response from the PutMetricAlarm service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.LimitExceededException">
        /// The quota for alarms for this customer has already been reached.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutMetricAlarm">REST API Reference for PutMetricAlarm Operation</seealso>
        public virtual PutMetricAlarmResponse PutMetricAlarm(PutMetricAlarmRequest request)
        {
            var marshaller = new PutMetricAlarmRequestMarshaller();
            var unmarshaller = PutMetricAlarmResponseUnmarshaller.Instance;

            return Invoke<PutMetricAlarmRequest,PutMetricAlarmResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricAlarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetricAlarm operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutMetricAlarm">REST API Reference for PutMetricAlarm Operation</seealso>
        public virtual Task<PutMetricAlarmResponse> PutMetricAlarmAsync(PutMetricAlarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutMetricAlarmRequestMarshaller();
            var unmarshaller = PutMetricAlarmResponseUnmarshaller.Instance;

            return InvokeAsync<PutMetricAlarmRequest,PutMetricAlarmResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutMetricData


        /// <summary>
        /// Publishes metric data points to Amazon CloudWatch. CloudWatch associates the data
        /// points with the specified metric. If the specified metric does not exist, CloudWatch
        /// creates the metric. When CloudWatch creates a metric, it can take up to fifteen minutes
        /// for the metric to appear in calls to <a>ListMetrics</a>.
        /// 
        ///  
        /// <para>
        /// Each <code>PutMetricData</code> request is limited to 40 KB in size for HTTP POST
        /// requests.
        /// </para>
        ///  
        /// <para>
        /// Although the <code>Value</code> parameter accepts numbers of type <code>Double</code>,
        /// CloudWatch rejects values that are either too small or too large. Values must be in
        /// the range of 8.515920e-109 to 1.174271e+108 (Base 10) or 2e-360 to 2e360 (Base 2).
        /// In addition, special values (for example, NaN, +Infinity, -Infinity) are not supported.
        /// </para>
        ///  
        /// <para>
        /// You can use up to 10 dimensions per metric to further clarify what data the metric
        /// collects. For more information about specifying dimensions, see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/publishingMetrics.html">Publishing
        /// Metrics</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Data points with time stamps from 24 hours ago or longer can take at least 48 hours
        /// to become available for <a>GetMetricStatistics</a> from the time they are submitted.
        /// </para>
        ///  
        /// <para>
        /// CloudWatch needs raw data points to calculate percentile statistics. If you publish
        /// data using a statistic set instead, you can only retrieve percentile statistics for
        /// this data if one of the following conditions is true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The SampleCount value of the statistic set is 1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Min and the Max values of the statistic set are equal
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData service method.</param>
        /// 
        /// <returns>The response from the PutMetricData service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterCombinationException">
        /// Parameters were used together that cannot be used together.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is required is missing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutMetricData">REST API Reference for PutMetricData Operation</seealso>
        public virtual PutMetricDataResponse PutMetricData(PutMetricDataRequest request)
        {
            var marshaller = new PutMetricDataRequestMarshaller();
            var unmarshaller = PutMetricDataResponseUnmarshaller.Instance;

            return Invoke<PutMetricDataRequest,PutMetricDataResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutMetricData">REST API Reference for PutMetricData Operation</seealso>
        public virtual Task<PutMetricDataResponse> PutMetricDataAsync(PutMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutMetricDataRequestMarshaller();
            var unmarshaller = PutMetricDataResponseUnmarshaller.Instance;

            return InvokeAsync<PutMetricDataRequest,PutMetricDataResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetAlarmState


        /// <summary>
        /// Temporarily sets the state of an alarm for testing purposes. When the updated state
        /// differs from the previous value, the action configured for the appropriate state is
        /// invoked. For example, if your alarm is configured to send an Amazon SNS message when
        /// an alarm is triggered, temporarily changing the alarm state to <code>ALARM</code>
        /// sends an SNS message. The alarm returns to its actual state (often within seconds).
        /// Because the alarm state change happens quickly, it is typically only visible in the
        /// alarm's <b>History</b> tab in the Amazon CloudWatch console or through <a>DescribeAlarmHistory</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetAlarmState service method.</param>
        /// 
        /// <returns>The response from the SetAlarmState service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidFormatException">
        /// Data was not syntactically valid JSON.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.ResourceNotFoundException">
        /// The named resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/SetAlarmState">REST API Reference for SetAlarmState Operation</seealso>
        public virtual SetAlarmStateResponse SetAlarmState(SetAlarmStateRequest request)
        {
            var marshaller = new SetAlarmStateRequestMarshaller();
            var unmarshaller = SetAlarmStateResponseUnmarshaller.Instance;

            return Invoke<SetAlarmStateRequest,SetAlarmStateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetAlarmState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetAlarmState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/SetAlarmState">REST API Reference for SetAlarmState Operation</seealso>
        public virtual Task<SetAlarmStateResponse> SetAlarmStateAsync(SetAlarmStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetAlarmStateRequestMarshaller();
            var unmarshaller = SetAlarmStateResponseUnmarshaller.Instance;

            return InvokeAsync<SetAlarmStateRequest,SetAlarmStateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}