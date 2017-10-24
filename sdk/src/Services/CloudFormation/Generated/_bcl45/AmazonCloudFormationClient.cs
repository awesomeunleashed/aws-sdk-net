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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CloudFormation.Model;
using Amazon.CloudFormation.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFormation
{
    /// <summary>
    /// Implementation for accessing CloudFormation
    ///
    /// AWS CloudFormation 
    /// <para>
    /// AWS CloudFormation allows you to create and manage AWS infrastructure deployments
    /// predictably and repeatedly. You can use AWS CloudFormation to leverage AWS products,
    /// such as Amazon Elastic Compute Cloud, Amazon Elastic Block Store, Amazon Simple Notification
    /// Service, Elastic Load Balancing, and Auto Scaling to build highly-reliable, highly
    /// scalable, cost-effective applications without creating or configuring the underlying
    /// AWS infrastructure.
    /// </para>
    ///  
    /// <para>
    /// With AWS CloudFormation, you declare all of your resources and dependencies in a template
    /// file. The template defines a collection of resources as a single unit called a stack.
    /// AWS CloudFormation creates and deletes all member resources of the stack together
    /// and manages all dependencies between the resources for you.
    /// </para>
    ///  
    /// <para>
    /// For more information about AWS CloudFormation, see the <a href="http://aws.amazon.com/cloudformation/">AWS
    /// CloudFormation Product Page</a>.
    /// </para>
    ///  
    /// <para>
    /// Amazon CloudFormation makes use of other AWS products. If you need additional technical
    /// information about a specific AWS product, you can find the product's technical documentation
    /// at <a href="http://docs.aws.amazon.com/">docs.aws.amazon.com</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCloudFormationClient : AmazonServiceClient, IAmazonCloudFormation
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudFormationClient with the credentials loaded from the application's
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
        public AmazonCloudFormationClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFormationConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with the credentials loaded from the application's
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
        public AmazonCloudFormationClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFormationConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(AmazonCloudFormationConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudFormationClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFormationClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudFormationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Credentials and an
        /// AmazonCloudFormationClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(AWSCredentials credentials, AmazonCloudFormationConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFormationConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFormationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudFormationConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFormationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFormationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudFormationConfig clientConfig)
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

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.CloudFormation.Internal.ProcessRequestHandler());
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

        
        #region  CancelUpdateStack


        /// <summary>
        /// Cancels an update on the specified stack. If the call completes successfully, the
        /// stack rolls back the update and reverts to the previous stack configuration.
        /// 
        ///  <note> 
        /// <para>
        /// You can cancel only stacks that are in the UPDATE_IN_PROGRESS state.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelUpdateStack service method.</param>
        /// 
        /// <returns>The response from the CancelUpdateStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CancelUpdateStack">REST API Reference for CancelUpdateStack Operation</seealso>
        public virtual CancelUpdateStackResponse CancelUpdateStack(CancelUpdateStackRequest request)
        {
            var marshaller = new CancelUpdateStackRequestMarshaller();
            var unmarshaller = CancelUpdateStackResponseUnmarshaller.Instance;

            return Invoke<CancelUpdateStackRequest,CancelUpdateStackResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelUpdateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelUpdateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CancelUpdateStack">REST API Reference for CancelUpdateStack Operation</seealso>
        public virtual Task<CancelUpdateStackResponse> CancelUpdateStackAsync(CancelUpdateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelUpdateStackRequestMarshaller();
            var unmarshaller = CancelUpdateStackResponseUnmarshaller.Instance;

            return InvokeAsync<CancelUpdateStackRequest,CancelUpdateStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ContinueUpdateRollback


        /// <summary>
        /// For a specified stack that is in the <code>UPDATE_ROLLBACK_FAILED</code> state, continues
        /// rolling it back to the <code>UPDATE_ROLLBACK_COMPLETE</code> state. Depending on the
        /// cause of the failure, you can manually <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/troubleshooting.html#troubleshooting-errors-update-rollback-failed">
        /// fix the error</a> and continue the rollback. By continuing the rollback, you can return
        /// your stack to a working state (the <code>UPDATE_ROLLBACK_COMPLETE</code> state), and
        /// then try to update the stack again.
        /// 
        ///  
        /// <para>
        /// A stack goes into the <code>UPDATE_ROLLBACK_FAILED</code> state when AWS CloudFormation
        /// cannot roll back all changes after a failed stack update. For example, you might have
        /// a stack that is rolling back to an old database instance that was deleted outside
        /// of AWS CloudFormation. Because AWS CloudFormation doesn't know the database was deleted,
        /// it assumes that the database instance still exists and attempts to roll back to it,
        /// causing the update rollback to fail.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ContinueUpdateRollback service method.</param>
        /// 
        /// <returns>The response from the ContinueUpdateRollback service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ContinueUpdateRollback">REST API Reference for ContinueUpdateRollback Operation</seealso>
        public virtual ContinueUpdateRollbackResponse ContinueUpdateRollback(ContinueUpdateRollbackRequest request)
        {
            var marshaller = new ContinueUpdateRollbackRequestMarshaller();
            var unmarshaller = ContinueUpdateRollbackResponseUnmarshaller.Instance;

            return Invoke<ContinueUpdateRollbackRequest,ContinueUpdateRollbackResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ContinueUpdateRollback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ContinueUpdateRollback operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ContinueUpdateRollback">REST API Reference for ContinueUpdateRollback Operation</seealso>
        public virtual Task<ContinueUpdateRollbackResponse> ContinueUpdateRollbackAsync(ContinueUpdateRollbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ContinueUpdateRollbackRequestMarshaller();
            var unmarshaller = ContinueUpdateRollbackResponseUnmarshaller.Instance;

            return InvokeAsync<ContinueUpdateRollbackRequest,ContinueUpdateRollbackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateChangeSet


        /// <summary>
        /// Creates a list of changes that will be applied to a stack so that you can review the
        /// changes before executing them. You can create a change set for a stack that doesn't
        /// exist or an existing stack. If you create a change set for a stack that doesn't exist,
        /// the change set shows all of the resources that AWS CloudFormation will create. If
        /// you create a change set for an existing stack, AWS CloudFormation compares the stack's
        /// information with the information that you submit in the change set and lists the differences.
        /// Use change sets to understand which resources AWS CloudFormation will create or change,
        /// and how it will change resources in an existing stack, before you create or update
        /// a stack.
        /// 
        ///  
        /// <para>
        /// To create a change set for a stack that doesn't exist, for the <code>ChangeSetType</code>
        /// parameter, specify <code>CREATE</code>. To create a change set for an existing stack,
        /// specify <code>UPDATE</code> for the <code>ChangeSetType</code> parameter. After the
        /// <code>CreateChangeSet</code> call successfully completes, AWS CloudFormation starts
        /// creating the change set. To check the status of the change set or to review it, use
        /// the <a>DescribeChangeSet</a> action.
        /// </para>
        ///  
        /// <para>
        /// When you are satisfied with the changes the change set will make, execute the change
        /// set by using the <a>ExecuteChangeSet</a> action. AWS CloudFormation doesn't make changes
        /// until you execute the change set.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChangeSet service method.</param>
        /// 
        /// <returns>The response from the CreateChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InsufficientCapabilitiesException">
        /// The template contains resources with capabilities that weren't specified in the Capabilities
        /// parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information on stack set limitations, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-limitations.html">Limitations
        /// of StackSets</a>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">REST API Reference for CreateChangeSet Operation</seealso>
        public virtual CreateChangeSetResponse CreateChangeSet(CreateChangeSetRequest request)
        {
            var marshaller = new CreateChangeSetRequestMarshaller();
            var unmarshaller = CreateChangeSetResponseUnmarshaller.Instance;

            return Invoke<CreateChangeSetRequest,CreateChangeSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChangeSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">REST API Reference for CreateChangeSet Operation</seealso>
        public virtual Task<CreateChangeSetResponse> CreateChangeSetAsync(CreateChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateChangeSetRequestMarshaller();
            var unmarshaller = CreateChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateChangeSetRequest,CreateChangeSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateStack


        /// <summary>
        /// Creates a stack as specified in the template. After the call completes successfully,
        /// the stack creation starts. You can check the status of the stack via the <a>DescribeStacks</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStack service method.</param>
        /// 
        /// <returns>The response from the CreateStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InsufficientCapabilitiesException">
        /// The template contains resources with capabilities that weren't specified in the Capabilities
        /// parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information on stack set limitations, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-limitations.html">Limitations
        /// of StackSets</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStack">REST API Reference for CreateStack Operation</seealso>
        public virtual CreateStackResponse CreateStack(CreateStackRequest request)
        {
            var marshaller = new CreateStackRequestMarshaller();
            var unmarshaller = CreateStackResponseUnmarshaller.Instance;

            return Invoke<CreateStackRequest,CreateStackResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStack">REST API Reference for CreateStack Operation</seealso>
        public virtual Task<CreateStackResponse> CreateStackAsync(CreateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStackRequestMarshaller();
            var unmarshaller = CreateStackResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStackRequest,CreateStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateStackInstances


        /// <summary>
        /// Creates stack instances for the specified accounts, within the specified regions.
        /// A stack instance refers to a stack in a specific account and region. <code>Accounts</code>
        /// and <code>Regions</code> are required parameters—you must specify at least one account
        /// and one region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStackInstances service method.</param>
        /// 
        /// <returns>The response from the CreateStackInstances service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information on stack set limitations, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-limitations.html">Limitations
        /// of StackSets</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationIdAlreadyExistsException">
        /// The specified operation ID already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this stack set since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackInstances">REST API Reference for CreateStackInstances Operation</seealso>
        public virtual CreateStackInstancesResponse CreateStackInstances(CreateStackInstancesRequest request)
        {
            var marshaller = new CreateStackInstancesRequestMarshaller();
            var unmarshaller = CreateStackInstancesResponseUnmarshaller.Instance;

            return Invoke<CreateStackInstancesRequest,CreateStackInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStackInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStackInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackInstances">REST API Reference for CreateStackInstances Operation</seealso>
        public virtual Task<CreateStackInstancesResponse> CreateStackInstancesAsync(CreateStackInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStackInstancesRequestMarshaller();
            var unmarshaller = CreateStackInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStackInstancesRequest,CreateStackInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateStackSet


        /// <summary>
        /// Creates a stack set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStackSet service method.</param>
        /// 
        /// <returns>The response from the CreateStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CreatedButModifiedException">
        /// The specified resource exists, but has been changed.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information on stack set limitations, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-limitations.html">Limitations
        /// of StackSets</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.NameAlreadyExistsException">
        /// The specified name is already in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackSet">REST API Reference for CreateStackSet Operation</seealso>
        public virtual CreateStackSetResponse CreateStackSet(CreateStackSetRequest request)
        {
            var marshaller = new CreateStackSetRequestMarshaller();
            var unmarshaller = CreateStackSetResponseUnmarshaller.Instance;

            return Invoke<CreateStackSetRequest,CreateStackSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStackSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStackSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackSet">REST API Reference for CreateStackSet Operation</seealso>
        public virtual Task<CreateStackSetResponse> CreateStackSetAsync(CreateStackSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStackSetRequestMarshaller();
            var unmarshaller = CreateStackSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStackSetRequest,CreateStackSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteChangeSet


        /// <summary>
        /// Deletes the specified change set. Deleting change sets ensures that no one executes
        /// the wrong change set.
        /// 
        ///  
        /// <para>
        /// If the call successfully completes, AWS CloudFormation successfully deleted the change
        /// set.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChangeSet service method.</param>
        /// 
        /// <returns>The response from the DeleteChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidChangeSetStatusException">
        /// The specified change set can't be used to update the stack. For example, the change
        /// set status might be <code>CREATE_IN_PROGRESS</code>, or the stack status might be
        /// <code>UPDATE_IN_PROGRESS</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteChangeSet">REST API Reference for DeleteChangeSet Operation</seealso>
        public virtual DeleteChangeSetResponse DeleteChangeSet(DeleteChangeSetRequest request)
        {
            var marshaller = new DeleteChangeSetRequestMarshaller();
            var unmarshaller = DeleteChangeSetResponseUnmarshaller.Instance;

            return Invoke<DeleteChangeSetRequest,DeleteChangeSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChangeSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteChangeSet">REST API Reference for DeleteChangeSet Operation</seealso>
        public virtual Task<DeleteChangeSetResponse> DeleteChangeSetAsync(DeleteChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteChangeSetRequestMarshaller();
            var unmarshaller = DeleteChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChangeSetRequest,DeleteChangeSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteStack


        /// <summary>
        /// Deletes a specified stack. Once the call completes successfully, stack deletion starts.
        /// Deleted stacks do not show up in the <a>DescribeStacks</a> API if the deletion has
        /// been completed successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack service method.</param>
        /// 
        /// <returns>The response from the DeleteStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        public virtual DeleteStackResponse DeleteStack(DeleteStackRequest request)
        {
            var marshaller = new DeleteStackRequestMarshaller();
            var unmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return Invoke<DeleteStackRequest,DeleteStackResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        public virtual Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteStackRequestMarshaller();
            var unmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStackRequest,DeleteStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteStackInstances


        /// <summary>
        /// Deletes stack instances for the specified accounts, in the specified regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStackInstances service method.</param>
        /// 
        /// <returns>The response from the DeleteStackInstances service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationIdAlreadyExistsException">
        /// The specified operation ID already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this stack set since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStackInstances">REST API Reference for DeleteStackInstances Operation</seealso>
        public virtual DeleteStackInstancesResponse DeleteStackInstances(DeleteStackInstancesRequest request)
        {
            var marshaller = new DeleteStackInstancesRequestMarshaller();
            var unmarshaller = DeleteStackInstancesResponseUnmarshaller.Instance;

            return Invoke<DeleteStackInstancesRequest,DeleteStackInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStackInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStackInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStackInstances">REST API Reference for DeleteStackInstances Operation</seealso>
        public virtual Task<DeleteStackInstancesResponse> DeleteStackInstancesAsync(DeleteStackInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteStackInstancesRequestMarshaller();
            var unmarshaller = DeleteStackInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStackInstancesRequest,DeleteStackInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteStackSet


        /// <summary>
        /// Deletes a stack set. Before you can delete a stack set, all of its member stack instances
        /// must be deleted. For more information about how to do this, see <a>DeleteStackInstances</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStackSet service method.</param>
        /// 
        /// <returns>The response from the DeleteStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotEmptyException">
        /// You can't yet delete this stack set, because it still contains one or more stack instances.
        /// Delete all stack instances from the stack set before deleting the stack set.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStackSet">REST API Reference for DeleteStackSet Operation</seealso>
        public virtual DeleteStackSetResponse DeleteStackSet(DeleteStackSetRequest request)
        {
            var marshaller = new DeleteStackSetRequestMarshaller();
            var unmarshaller = DeleteStackSetResponseUnmarshaller.Instance;

            return Invoke<DeleteStackSetRequest,DeleteStackSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStackSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStackSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStackSet">REST API Reference for DeleteStackSet Operation</seealso>
        public virtual Task<DeleteStackSetResponse> DeleteStackSetAsync(DeleteStackSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteStackSetRequestMarshaller();
            var unmarshaller = DeleteStackSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStackSetRequest,DeleteStackSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountLimits


        /// <summary>
        /// Retrieves your account's AWS CloudFormation limits, such as the maximum number of
        /// stacks that you can create in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public virtual DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request)
        {
            var marshaller = new DescribeAccountLimitsRequestMarshaller();
            var unmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountLimitsRequest,DescribeAccountLimitsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public virtual Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(DescribeAccountLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAccountLimitsRequestMarshaller();
            var unmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountLimitsRequest,DescribeAccountLimitsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeChangeSet


        /// <summary>
        /// Returns the inputs for the change set and a list of changes that AWS CloudFormation
        /// will make if you execute the change set. For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks-changesets.html">Updating
        /// Stacks Using Change Sets</a> in the AWS CloudFormation User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChangeSet service method.</param>
        /// 
        /// <returns>The response from the DescribeChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <code>ListChangeSets</code> action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeChangeSet">REST API Reference for DescribeChangeSet Operation</seealso>
        public virtual DescribeChangeSetResponse DescribeChangeSet(DescribeChangeSetRequest request)
        {
            var marshaller = new DescribeChangeSetRequestMarshaller();
            var unmarshaller = DescribeChangeSetResponseUnmarshaller.Instance;

            return Invoke<DescribeChangeSetRequest,DescribeChangeSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChangeSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeChangeSet">REST API Reference for DescribeChangeSet Operation</seealso>
        public virtual Task<DescribeChangeSetResponse> DescribeChangeSetAsync(DescribeChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeChangeSetRequestMarshaller();
            var unmarshaller = DescribeChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeChangeSetRequest,DescribeChangeSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackEvents


        /// <summary>
        /// Returns all stack related events for a specified stack in reverse chronological order.
        /// For more information about a stack's event history, go to <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/concept-stack.html">Stacks</a>
        /// in the AWS CloudFormation User Guide.
        /// 
        ///  <note> 
        /// <para>
        /// You can list events for stacks that have failed to create or have been deleted by
        /// specifying the unique stack identifier (stack ID).
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeStackEvents service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackEvents">REST API Reference for DescribeStackEvents Operation</seealso>
        public virtual DescribeStackEventsResponse DescribeStackEvents(DescribeStackEventsRequest request)
        {
            var marshaller = new DescribeStackEventsRequestMarshaller();
            var unmarshaller = DescribeStackEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeStackEventsRequest,DescribeStackEventsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackEvents">REST API Reference for DescribeStackEvents Operation</seealso>
        public virtual Task<DescribeStackEventsResponse> DescribeStackEventsAsync(DescribeStackEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackEventsRequestMarshaller();
            var unmarshaller = DescribeStackEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackEventsRequest,DescribeStackEventsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackInstance


        /// <summary>
        /// Returns the stack instance that's associated with the specified stack set, AWS account,
        /// and region.
        /// 
        ///  
        /// <para>
        /// For a list of stack instances that are associated with a specific stack set, use <a>ListStackInstances</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackInstance service method.</param>
        /// 
        /// <returns>The response from the DescribeStackInstance service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackInstanceNotFoundException">
        /// The specified stack instance doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackInstance">REST API Reference for DescribeStackInstance Operation</seealso>
        public virtual DescribeStackInstanceResponse DescribeStackInstance(DescribeStackInstanceRequest request)
        {
            var marshaller = new DescribeStackInstanceRequestMarshaller();
            var unmarshaller = DescribeStackInstanceResponseUnmarshaller.Instance;

            return Invoke<DescribeStackInstanceRequest,DescribeStackInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackInstance">REST API Reference for DescribeStackInstance Operation</seealso>
        public virtual Task<DescribeStackInstanceResponse> DescribeStackInstanceAsync(DescribeStackInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackInstanceRequestMarshaller();
            var unmarshaller = DescribeStackInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackInstanceRequest,DescribeStackInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackResource


        /// <summary>
        /// Returns a description of the specified resource in the specified stack.
        /// 
        ///  
        /// <para>
        /// For deleted stacks, DescribeStackResource returns resource information for up to 90
        /// days after the stack has been deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResource service method.</param>
        /// 
        /// <returns>The response from the DescribeStackResource service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResource">REST API Reference for DescribeStackResource Operation</seealso>
        public virtual DescribeStackResourceResponse DescribeStackResource(DescribeStackResourceRequest request)
        {
            var marshaller = new DescribeStackResourceRequestMarshaller();
            var unmarshaller = DescribeStackResourceResponseUnmarshaller.Instance;

            return Invoke<DescribeStackResourceRequest,DescribeStackResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResource">REST API Reference for DescribeStackResource Operation</seealso>
        public virtual Task<DescribeStackResourceResponse> DescribeStackResourceAsync(DescribeStackResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackResourceRequestMarshaller();
            var unmarshaller = DescribeStackResourceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackResourceRequest,DescribeStackResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackResources


        /// <summary>
        /// Returns AWS resource descriptions for running and deleted stacks. If <code>StackName</code>
        /// is specified, all the associated resources that are part of the stack are returned.
        /// If <code>PhysicalResourceId</code> is specified, the associated resources of the stack
        /// that the resource belongs to are returned.
        /// 
        ///  <note> 
        /// <para>
        /// Only the first 100 resources will be returned. If your stack has more resources than
        /// this, you should use <code>ListStackResources</code> instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// For deleted stacks, <code>DescribeStackResources</code> returns resource information
        /// for up to 90 days after the stack has been deleted.
        /// </para>
        ///  
        /// <para>
        /// You must specify either <code>StackName</code> or <code>PhysicalResourceId</code>,
        /// but not both. In addition, you can specify <code>LogicalResourceId</code> to filter
        /// the returned result. For more information about resources, the <code>LogicalResourceId</code>
        /// and <code>PhysicalResourceId</code>, go to the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/">AWS
        /// CloudFormation User Guide</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// A <code>ValidationError</code> is returned if you specify both <code>StackName</code>
        /// and <code>PhysicalResourceId</code> in the same request.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResources service method.</param>
        /// 
        /// <returns>The response from the DescribeStackResources service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResources">REST API Reference for DescribeStackResources Operation</seealso>
        public virtual DescribeStackResourcesResponse DescribeStackResources(DescribeStackResourcesRequest request)
        {
            var marshaller = new DescribeStackResourcesRequestMarshaller();
            var unmarshaller = DescribeStackResourcesResponseUnmarshaller.Instance;

            return Invoke<DescribeStackResourcesRequest,DescribeStackResourcesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResources">REST API Reference for DescribeStackResources Operation</seealso>
        public virtual Task<DescribeStackResourcesResponse> DescribeStackResourcesAsync(DescribeStackResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackResourcesRequestMarshaller();
            var unmarshaller = DescribeStackResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackResourcesRequest,DescribeStackResourcesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStacks


        /// <summary>
        /// Returns the description for the specified stack; if no stack name was specified, then
        /// it returns the description for all the stacks created.
        /// 
        ///  <note> 
        /// <para>
        /// If the stack does not exist, an <code>AmazonCloudFormationException</code> is returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        public virtual DescribeStacksResponse DescribeStacks()
        {
            return DescribeStacks(new DescribeStacksRequest());
        }


        /// <summary>
        /// Returns the description for the specified stack; if no stack name was specified, then
        /// it returns the description for all the stacks created.
        /// 
        ///  <note> 
        /// <para>
        /// If the stack does not exist, an <code>AmazonCloudFormationException</code> is returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks service method.</param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        public virtual DescribeStacksResponse DescribeStacks(DescribeStacksRequest request)
        {
            var marshaller = new DescribeStacksRequestMarshaller();
            var unmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return Invoke<DescribeStacksRequest,DescribeStacksResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the description for the specified stack; if no stack name was specified, then
        /// it returns the description for all the stacks created.
        /// 
        ///  <note> 
        /// <para>
        /// If the stack does not exist, an <code>AmazonCloudFormationException</code> is returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        public virtual Task<DescribeStacksResponse> DescribeStacksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeStacksAsync(new DescribeStacksRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        public virtual Task<DescribeStacksResponse> DescribeStacksAsync(DescribeStacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStacksRequestMarshaller();
            var unmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStacksRequest,DescribeStacksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackSet


        /// <summary>
        /// Returns the description of the specified stack set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSet service method.</param>
        /// 
        /// <returns>The response from the DescribeStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackSet">REST API Reference for DescribeStackSet Operation</seealso>
        public virtual DescribeStackSetResponse DescribeStackSet(DescribeStackSetRequest request)
        {
            var marshaller = new DescribeStackSetRequestMarshaller();
            var unmarshaller = DescribeStackSetResponseUnmarshaller.Instance;

            return Invoke<DescribeStackSetRequest,DescribeStackSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackSet">REST API Reference for DescribeStackSet Operation</seealso>
        public virtual Task<DescribeStackSetResponse> DescribeStackSetAsync(DescribeStackSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackSetRequestMarshaller();
            var unmarshaller = DescribeStackSetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackSetRequest,DescribeStackSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackSetOperation


        /// <summary>
        /// Returns the description of the specified stack set operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSetOperation service method.</param>
        /// 
        /// <returns>The response from the DescribeStackSetOperation service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackSetOperation">REST API Reference for DescribeStackSetOperation Operation</seealso>
        public virtual DescribeStackSetOperationResponse DescribeStackSetOperation(DescribeStackSetOperationRequest request)
        {
            var marshaller = new DescribeStackSetOperationRequestMarshaller();
            var unmarshaller = DescribeStackSetOperationResponseUnmarshaller.Instance;

            return Invoke<DescribeStackSetOperationRequest,DescribeStackSetOperationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackSetOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSetOperation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackSetOperation">REST API Reference for DescribeStackSetOperation Operation</seealso>
        public virtual Task<DescribeStackSetOperationResponse> DescribeStackSetOperationAsync(DescribeStackSetOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackSetOperationRequestMarshaller();
            var unmarshaller = DescribeStackSetOperationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackSetOperationRequest,DescribeStackSetOperationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EstimateTemplateCost


        /// <summary>
        /// Returns the estimated monthly cost of a template. The return value is an AWS Simple
        /// Monthly Calculator URL with a query string that describes the resources required to
        /// run the template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EstimateTemplateCost service method.</param>
        /// 
        /// <returns>The response from the EstimateTemplateCost service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/EstimateTemplateCost">REST API Reference for EstimateTemplateCost Operation</seealso>
        public virtual EstimateTemplateCostResponse EstimateTemplateCost(EstimateTemplateCostRequest request)
        {
            var marshaller = new EstimateTemplateCostRequestMarshaller();
            var unmarshaller = EstimateTemplateCostResponseUnmarshaller.Instance;

            return Invoke<EstimateTemplateCostRequest,EstimateTemplateCostResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EstimateTemplateCost operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EstimateTemplateCost operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/EstimateTemplateCost">REST API Reference for EstimateTemplateCost Operation</seealso>
        public virtual Task<EstimateTemplateCostResponse> EstimateTemplateCostAsync(EstimateTemplateCostRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EstimateTemplateCostRequestMarshaller();
            var unmarshaller = EstimateTemplateCostResponseUnmarshaller.Instance;

            return InvokeAsync<EstimateTemplateCostRequest,EstimateTemplateCostResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ExecuteChangeSet


        /// <summary>
        /// Updates a stack using the input information that was provided when the specified change
        /// set was created. After the call successfully completes, AWS CloudFormation starts
        /// updating the stack. Use the <a>DescribeStacks</a> action to view the status of the
        /// update.
        /// 
        ///  
        /// <para>
        /// When you execute a change set, AWS CloudFormation deletes all other change sets associated
        /// with the stack because they aren't valid for the updated stack.
        /// </para>
        ///  
        /// <para>
        /// If a stack policy is associated with the stack, AWS CloudFormation enforces the policy
        /// during the update. You can't specify a temporary stack policy that overrides the current
        /// policy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteChangeSet service method.</param>
        /// 
        /// <returns>The response from the ExecuteChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <code>ListChangeSets</code> action.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InsufficientCapabilitiesException">
        /// The template contains resources with capabilities that weren't specified in the Capabilities
        /// parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidChangeSetStatusException">
        /// The specified change set can't be used to update the stack. For example, the change
        /// set status might be <code>CREATE_IN_PROGRESS</code>, or the stack status might be
        /// <code>UPDATE_IN_PROGRESS</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ExecuteChangeSet">REST API Reference for ExecuteChangeSet Operation</seealso>
        public virtual ExecuteChangeSetResponse ExecuteChangeSet(ExecuteChangeSetRequest request)
        {
            var marshaller = new ExecuteChangeSetRequestMarshaller();
            var unmarshaller = ExecuteChangeSetResponseUnmarshaller.Instance;

            return Invoke<ExecuteChangeSetRequest,ExecuteChangeSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteChangeSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ExecuteChangeSet">REST API Reference for ExecuteChangeSet Operation</seealso>
        public virtual Task<ExecuteChangeSetResponse> ExecuteChangeSetAsync(ExecuteChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ExecuteChangeSetRequestMarshaller();
            var unmarshaller = ExecuteChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<ExecuteChangeSetRequest,ExecuteChangeSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetStackPolicy


        /// <summary>
        /// Returns the stack policy for a specified stack. If a stack doesn't have a policy,
        /// a null value is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStackPolicy service method.</param>
        /// 
        /// <returns>The response from the GetStackPolicy service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetStackPolicy">REST API Reference for GetStackPolicy Operation</seealso>
        public virtual GetStackPolicyResponse GetStackPolicy(GetStackPolicyRequest request)
        {
            var marshaller = new GetStackPolicyRequestMarshaller();
            var unmarshaller = GetStackPolicyResponseUnmarshaller.Instance;

            return Invoke<GetStackPolicyRequest,GetStackPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStackPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStackPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetStackPolicy">REST API Reference for GetStackPolicy Operation</seealso>
        public virtual Task<GetStackPolicyResponse> GetStackPolicyAsync(GetStackPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetStackPolicyRequestMarshaller();
            var unmarshaller = GetStackPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetStackPolicyRequest,GetStackPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTemplate


        /// <summary>
        /// Returns the template body for a specified stack. You can get the template for running
        /// or deleted stacks.
        /// 
        ///  
        /// <para>
        /// For deleted stacks, GetTemplate returns the template for up to 90 days after the stack
        /// has been deleted.
        /// </para>
        ///  <note> 
        /// <para>
        ///  If the template does not exist, a <code>ValidationError</code> is returned. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <code>ListChangeSets</code> action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        public virtual GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            var marshaller = new GetTemplateRequestMarshaller();
            var unmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return Invoke<GetTemplateRequest,GetTemplateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        public virtual Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTemplateRequestMarshaller();
            var unmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetTemplateRequest,GetTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTemplateSummary


        /// <summary>
        /// Returns information about a new or existing template. The <code>GetTemplateSummary</code>
        /// action is useful for viewing parameter information, such as default parameter values
        /// and parameter types, before you create or update a stack or stack set.
        /// 
        ///  
        /// <para>
        /// You can use the <code>GetTemplateSummary</code> action when you submit a template,
        /// or you can get template information for a stack set, or a running or deleted stack.
        /// </para>
        ///  
        /// <para>
        /// For deleted stacks, <code>GetTemplateSummary</code> returns the template information
        /// for up to 90 days after the stack has been deleted. If the template does not exist,
        /// a <code>ValidationError</code> is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateSummary service method.</param>
        /// 
        /// <returns>The response from the GetTemplateSummary service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetTemplateSummary">REST API Reference for GetTemplateSummary Operation</seealso>
        public virtual GetTemplateSummaryResponse GetTemplateSummary(GetTemplateSummaryRequest request)
        {
            var marshaller = new GetTemplateSummaryRequestMarshaller();
            var unmarshaller = GetTemplateSummaryResponseUnmarshaller.Instance;

            return Invoke<GetTemplateSummaryRequest,GetTemplateSummaryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTemplateSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateSummary operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetTemplateSummary">REST API Reference for GetTemplateSummary Operation</seealso>
        public virtual Task<GetTemplateSummaryResponse> GetTemplateSummaryAsync(GetTemplateSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTemplateSummaryRequestMarshaller();
            var unmarshaller = GetTemplateSummaryResponseUnmarshaller.Instance;

            return InvokeAsync<GetTemplateSummaryRequest,GetTemplateSummaryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListChangeSets


        /// <summary>
        /// Returns the ID and status of each active change set for a stack. For example, AWS
        /// CloudFormation lists change sets that are in the <code>CREATE_IN_PROGRESS</code> or
        /// <code>CREATE_PENDING</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangeSets service method.</param>
        /// 
        /// <returns>The response from the ListChangeSets service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListChangeSets">REST API Reference for ListChangeSets Operation</seealso>
        public virtual ListChangeSetsResponse ListChangeSets(ListChangeSetsRequest request)
        {
            var marshaller = new ListChangeSetsRequestMarshaller();
            var unmarshaller = ListChangeSetsResponseUnmarshaller.Instance;

            return Invoke<ListChangeSetsRequest,ListChangeSetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChangeSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChangeSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListChangeSets">REST API Reference for ListChangeSets Operation</seealso>
        public virtual Task<ListChangeSetsResponse> ListChangeSetsAsync(ListChangeSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListChangeSetsRequestMarshaller();
            var unmarshaller = ListChangeSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListChangeSetsRequest,ListChangeSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListExports


        /// <summary>
        /// Lists all exported output values in the account and region in which you call this
        /// action. Use this action to see the exported output values that you can import into
        /// other stacks. To import values, use the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-importvalue.html">
        /// <code>Fn::ImportValue</code> </a> function. 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-exports.html">
        /// AWS CloudFormation Export Stack Output Values</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExports service method.</param>
        /// 
        /// <returns>The response from the ListExports service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListExports">REST API Reference for ListExports Operation</seealso>
        public virtual ListExportsResponse ListExports(ListExportsRequest request)
        {
            var marshaller = new ListExportsRequestMarshaller();
            var unmarshaller = ListExportsResponseUnmarshaller.Instance;

            return Invoke<ListExportsRequest,ListExportsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListExports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExports operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListExports">REST API Reference for ListExports Operation</seealso>
        public virtual Task<ListExportsResponse> ListExportsAsync(ListExportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListExportsRequestMarshaller();
            var unmarshaller = ListExportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListExportsRequest,ListExportsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListImports


        /// <summary>
        /// Lists all stacks that are importing an exported output value. To modify or remove
        /// an exported output value, first use this action to see which stacks are using it.
        /// To see the exported output values in your account, see <a>ListExports</a>. 
        /// 
        ///  
        /// <para>
        /// For more information about importing an exported output value, see the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-importvalue.html">
        /// <code>Fn::ImportValue</code> </a> function. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImports service method.</param>
        /// 
        /// <returns>The response from the ListImports service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListImports">REST API Reference for ListImports Operation</seealso>
        public virtual ListImportsResponse ListImports(ListImportsRequest request)
        {
            var marshaller = new ListImportsRequestMarshaller();
            var unmarshaller = ListImportsResponseUnmarshaller.Instance;

            return Invoke<ListImportsRequest,ListImportsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListImports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImports operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListImports">REST API Reference for ListImports Operation</seealso>
        public virtual Task<ListImportsResponse> ListImportsAsync(ListImportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListImportsRequestMarshaller();
            var unmarshaller = ListImportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListImportsRequest,ListImportsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListStackInstances


        /// <summary>
        /// Returns summary information about stack instances that are associated with the specified
        /// stack set. You can filter for stack instances that are associated with a specific
        /// AWS account name or region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackInstances service method.</param>
        /// 
        /// <returns>The response from the ListStackInstances service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackInstances">REST API Reference for ListStackInstances Operation</seealso>
        public virtual ListStackInstancesResponse ListStackInstances(ListStackInstancesRequest request)
        {
            var marshaller = new ListStackInstancesRequestMarshaller();
            var unmarshaller = ListStackInstancesResponseUnmarshaller.Instance;

            return Invoke<ListStackInstancesRequest,ListStackInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStackInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackInstances">REST API Reference for ListStackInstances Operation</seealso>
        public virtual Task<ListStackInstancesResponse> ListStackInstancesAsync(ListStackInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStackInstancesRequestMarshaller();
            var unmarshaller = ListStackInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackInstancesRequest,ListStackInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListStackResources


        /// <summary>
        /// Returns descriptions of all resources of the specified stack.
        /// 
        ///  
        /// <para>
        /// For deleted stacks, ListStackResources returns resource information for up to 90 days
        /// after the stack has been deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackResources service method.</param>
        /// 
        /// <returns>The response from the ListStackResources service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackResources">REST API Reference for ListStackResources Operation</seealso>
        public virtual ListStackResourcesResponse ListStackResources(ListStackResourcesRequest request)
        {
            var marshaller = new ListStackResourcesRequestMarshaller();
            var unmarshaller = ListStackResourcesResponseUnmarshaller.Instance;

            return Invoke<ListStackResourcesRequest,ListStackResourcesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStackResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackResources">REST API Reference for ListStackResources Operation</seealso>
        public virtual Task<ListStackResourcesResponse> ListStackResourcesAsync(ListStackResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStackResourcesRequestMarshaller();
            var unmarshaller = ListStackResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackResourcesRequest,ListStackResourcesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListStacks


        /// <summary>
        /// Returns the summary information for stacks whose status matches the specified StackStatusFilter.
        /// Summary information for stacks that have been deleted is kept for 90 days after the
        /// stack is deleted. If no StackStatusFilter is specified, summary information for all
        /// stacks is returned (including existing stacks and stacks that have been deleted).
        /// </summary>
        /// 
        /// <returns>The response from the ListStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStacks">REST API Reference for ListStacks Operation</seealso>
        public virtual ListStacksResponse ListStacks()
        {
            return ListStacks(new ListStacksRequest());
        }


        /// <summary>
        /// Returns the summary information for stacks whose status matches the specified StackStatusFilter.
        /// Summary information for stacks that have been deleted is kept for 90 days after the
        /// stack is deleted. If no StackStatusFilter is specified, summary information for all
        /// stacks is returned (including existing stacks and stacks that have been deleted).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStacks service method.</param>
        /// 
        /// <returns>The response from the ListStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStacks">REST API Reference for ListStacks Operation</seealso>
        public virtual ListStacksResponse ListStacks(ListStacksRequest request)
        {
            var marshaller = new ListStacksRequestMarshaller();
            var unmarshaller = ListStacksResponseUnmarshaller.Instance;

            return Invoke<ListStacksRequest,ListStacksResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the summary information for stacks whose status matches the specified StackStatusFilter.
        /// Summary information for stacks that have been deleted is kept for 90 days after the
        /// stack is deleted. If no StackStatusFilter is specified, summary information for all
        /// stacks is returned (including existing stacks and stacks that have been deleted).
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStacks">REST API Reference for ListStacks Operation</seealso>
        public virtual Task<ListStacksResponse> ListStacksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListStacksAsync(new ListStacksRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the ListStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStacks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStacks">REST API Reference for ListStacks Operation</seealso>
        public virtual Task<ListStacksResponse> ListStacksAsync(ListStacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStacksRequestMarshaller();
            var unmarshaller = ListStacksResponseUnmarshaller.Instance;

            return InvokeAsync<ListStacksRequest,ListStacksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListStackSetOperationResults


        /// <summary>
        /// Returns summary information about the results of a stack set operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetOperationResults service method.</param>
        /// 
        /// <returns>The response from the ListStackSetOperationResults service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetOperationResults">REST API Reference for ListStackSetOperationResults Operation</seealso>
        public virtual ListStackSetOperationResultsResponse ListStackSetOperationResults(ListStackSetOperationResultsRequest request)
        {
            var marshaller = new ListStackSetOperationResultsRequestMarshaller();
            var unmarshaller = ListStackSetOperationResultsResponseUnmarshaller.Instance;

            return Invoke<ListStackSetOperationResultsRequest,ListStackSetOperationResultsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStackSetOperationResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetOperationResults operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetOperationResults">REST API Reference for ListStackSetOperationResults Operation</seealso>
        public virtual Task<ListStackSetOperationResultsResponse> ListStackSetOperationResultsAsync(ListStackSetOperationResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStackSetOperationResultsRequestMarshaller();
            var unmarshaller = ListStackSetOperationResultsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackSetOperationResultsRequest,ListStackSetOperationResultsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListStackSetOperations


        /// <summary>
        /// Returns summary information about operations performed on a stack set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetOperations service method.</param>
        /// 
        /// <returns>The response from the ListStackSetOperations service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetOperations">REST API Reference for ListStackSetOperations Operation</seealso>
        public virtual ListStackSetOperationsResponse ListStackSetOperations(ListStackSetOperationsRequest request)
        {
            var marshaller = new ListStackSetOperationsRequestMarshaller();
            var unmarshaller = ListStackSetOperationsResponseUnmarshaller.Instance;

            return Invoke<ListStackSetOperationsRequest,ListStackSetOperationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStackSetOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetOperations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetOperations">REST API Reference for ListStackSetOperations Operation</seealso>
        public virtual Task<ListStackSetOperationsResponse> ListStackSetOperationsAsync(ListStackSetOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStackSetOperationsRequestMarshaller();
            var unmarshaller = ListStackSetOperationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackSetOperationsRequest,ListStackSetOperationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListStackSets


        /// <summary>
        /// Returns summary information about stack sets that are associated with the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSets service method.</param>
        /// 
        /// <returns>The response from the ListStackSets service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSets">REST API Reference for ListStackSets Operation</seealso>
        public virtual ListStackSetsResponse ListStackSets(ListStackSetsRequest request)
        {
            var marshaller = new ListStackSetsRequestMarshaller();
            var unmarshaller = ListStackSetsResponseUnmarshaller.Instance;

            return Invoke<ListStackSetsRequest,ListStackSetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStackSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSets">REST API Reference for ListStackSets Operation</seealso>
        public virtual Task<ListStackSetsResponse> ListStackSetsAsync(ListStackSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStackSetsRequestMarshaller();
            var unmarshaller = ListStackSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackSetsRequest,ListStackSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetStackPolicy


        /// <summary>
        /// Sets a stack policy for a specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetStackPolicy service method.</param>
        /// 
        /// <returns>The response from the SetStackPolicy service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SetStackPolicy">REST API Reference for SetStackPolicy Operation</seealso>
        public virtual SetStackPolicyResponse SetStackPolicy(SetStackPolicyRequest request)
        {
            var marshaller = new SetStackPolicyRequestMarshaller();
            var unmarshaller = SetStackPolicyResponseUnmarshaller.Instance;

            return Invoke<SetStackPolicyRequest,SetStackPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetStackPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetStackPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SetStackPolicy">REST API Reference for SetStackPolicy Operation</seealso>
        public virtual Task<SetStackPolicyResponse> SetStackPolicyAsync(SetStackPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetStackPolicyRequestMarshaller();
            var unmarshaller = SetStackPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<SetStackPolicyRequest,SetStackPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SignalResource


        /// <summary>
        /// Sends a signal to the specified resource with a success or failure status. You can
        /// use the SignalResource API in conjunction with a creation policy or update policy.
        /// AWS CloudFormation doesn't proceed with a stack creation or update until resources
        /// receive the required number of signals or the timeout period is exceeded. The SignalResource
        /// API is useful in cases where you want to send signals from anywhere other than an
        /// Amazon EC2 instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignalResource service method.</param>
        /// 
        /// <returns>The response from the SignalResource service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SignalResource">REST API Reference for SignalResource Operation</seealso>
        public virtual SignalResourceResponse SignalResource(SignalResourceRequest request)
        {
            var marshaller = new SignalResourceRequestMarshaller();
            var unmarshaller = SignalResourceResponseUnmarshaller.Instance;

            return Invoke<SignalResourceRequest,SignalResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SignalResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignalResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SignalResource">REST API Reference for SignalResource Operation</seealso>
        public virtual Task<SignalResourceResponse> SignalResourceAsync(SignalResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SignalResourceRequestMarshaller();
            var unmarshaller = SignalResourceResponseUnmarshaller.Instance;

            return InvokeAsync<SignalResourceRequest,SignalResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopStackSetOperation


        /// <summary>
        /// Stops an in-progress operation on a stack set and its associated stack instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopStackSetOperation service method.</param>
        /// 
        /// <returns>The response from the StopStackSetOperation service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/StopStackSetOperation">REST API Reference for StopStackSetOperation Operation</seealso>
        public virtual StopStackSetOperationResponse StopStackSetOperation(StopStackSetOperationRequest request)
        {
            var marshaller = new StopStackSetOperationRequestMarshaller();
            var unmarshaller = StopStackSetOperationResponseUnmarshaller.Instance;

            return Invoke<StopStackSetOperationRequest,StopStackSetOperationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopStackSetOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopStackSetOperation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/StopStackSetOperation">REST API Reference for StopStackSetOperation Operation</seealso>
        public virtual Task<StopStackSetOperationResponse> StopStackSetOperationAsync(StopStackSetOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopStackSetOperationRequestMarshaller();
            var unmarshaller = StopStackSetOperationResponseUnmarshaller.Instance;

            return InvokeAsync<StopStackSetOperationRequest,StopStackSetOperationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateStack


        /// <summary>
        /// Updates a stack as specified in the template. After the call completes successfully,
        /// the stack update starts. You can check the status of the stack via the <a>DescribeStacks</a>
        /// action.
        /// 
        ///  
        /// <para>
        /// To get a copy of the template for an existing stack, you can use the <a>GetTemplate</a>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For more information about creating an update template, updating a stack, and monitoring
        /// the progress of the update, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks.html">Updating
        /// a Stack</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack service method.</param>
        /// 
        /// <returns>The response from the UpdateStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InsufficientCapabilitiesException">
        /// The template contains resources with capabilities that weren't specified in the Capabilities
        /// parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        public virtual UpdateStackResponse UpdateStack(UpdateStackRequest request)
        {
            var marshaller = new UpdateStackRequestMarshaller();
            var unmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return Invoke<UpdateStackRequest,UpdateStackResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        public virtual Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateStackRequestMarshaller();
            var unmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStackRequest,UpdateStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateStackSet


        /// <summary>
        /// Updates the stack set and <i>all</i> associated stack instances.
        /// 
        ///  
        /// <para>
        /// Even if the stack set operation created by updating the stack set fails (completely
        /// or partially, below or above a specified failure tolerance), the stack set is updated
        /// with your changes. Subsequent <a>CreateStackInstances</a> calls on the specified stack
        /// set use the updated stack set.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStackSet service method.</param>
        /// 
        /// <returns>The response from the UpdateStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationIdAlreadyExistsException">
        /// The specified operation ID already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this stack set since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStackSet">REST API Reference for UpdateStackSet Operation</seealso>
        public virtual UpdateStackSetResponse UpdateStackSet(UpdateStackSetRequest request)
        {
            var marshaller = new UpdateStackSetRequestMarshaller();
            var unmarshaller = UpdateStackSetResponseUnmarshaller.Instance;

            return Invoke<UpdateStackSetRequest,UpdateStackSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStackSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStackSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStackSet">REST API Reference for UpdateStackSet Operation</seealso>
        public virtual Task<UpdateStackSetResponse> UpdateStackSetAsync(UpdateStackSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateStackSetRequestMarshaller();
            var unmarshaller = UpdateStackSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStackSetRequest,UpdateStackSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateTerminationProtection


        /// <summary>
        /// Updates termination protection for the specified stack. If a user attempts to delete
        /// a stack with termination protection enabled, the operation fails and the stack remains
        /// unchanged. For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-protect-stacks.html">Protecting
        /// a Stack From Being Deleted</a> in the <i>AWS CloudFormation User Guide</i>.
        /// 
        ///  
        /// <para>
        ///  For <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-nested-stacks.html">nested
        /// stacks</a>, termination protection is set on the root stack and cannot be changed
        /// directly on the nested stack.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTerminationProtection service method.</param>
        /// 
        /// <returns>The response from the UpdateTerminationProtection service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateTerminationProtection">REST API Reference for UpdateTerminationProtection Operation</seealso>
        public virtual UpdateTerminationProtectionResponse UpdateTerminationProtection(UpdateTerminationProtectionRequest request)
        {
            var marshaller = new UpdateTerminationProtectionRequestMarshaller();
            var unmarshaller = UpdateTerminationProtectionResponseUnmarshaller.Instance;

            return Invoke<UpdateTerminationProtectionRequest,UpdateTerminationProtectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTerminationProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTerminationProtection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateTerminationProtection">REST API Reference for UpdateTerminationProtection Operation</seealso>
        public virtual Task<UpdateTerminationProtectionResponse> UpdateTerminationProtectionAsync(UpdateTerminationProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateTerminationProtectionRequestMarshaller();
            var unmarshaller = UpdateTerminationProtectionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTerminationProtectionRequest,UpdateTerminationProtectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ValidateTemplate


        /// <summary>
        /// Validates a specified template. AWS CloudFormation first checks if the template is
        /// valid JSON. If it isn't, AWS CloudFormation checks if the template is valid YAML.
        /// If both these checks fail, AWS CloudFormation returns a template validation error.
        /// </summary>
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ValidateTemplate">REST API Reference for ValidateTemplate Operation</seealso>
        public virtual ValidateTemplateResponse ValidateTemplate()
        {
            return ValidateTemplate(new ValidateTemplateRequest());
        }


        /// <summary>
        /// Validates a specified template. AWS CloudFormation first checks if the template is
        /// valid JSON. If it isn't, AWS CloudFormation checks if the template is valid YAML.
        /// If both these checks fail, AWS CloudFormation returns a template validation error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateTemplate service method.</param>
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ValidateTemplate">REST API Reference for ValidateTemplate Operation</seealso>
        public virtual ValidateTemplateResponse ValidateTemplate(ValidateTemplateRequest request)
        {
            var marshaller = new ValidateTemplateRequestMarshaller();
            var unmarshaller = ValidateTemplateResponseUnmarshaller.Instance;

            return Invoke<ValidateTemplateRequest,ValidateTemplateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Validates a specified template. AWS CloudFormation first checks if the template is
        /// valid JSON. If it isn't, AWS CloudFormation checks if the template is valid YAML.
        /// If both these checks fail, AWS CloudFormation returns a template validation error.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ValidateTemplate">REST API Reference for ValidateTemplate Operation</seealso>
        public virtual Task<ValidateTemplateResponse> ValidateTemplateAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ValidateTemplateAsync(new ValidateTemplateRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the ValidateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ValidateTemplate">REST API Reference for ValidateTemplate Operation</seealso>
        public virtual Task<ValidateTemplateResponse> ValidateTemplateAsync(ValidateTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ValidateTemplateRequestMarshaller();
            var unmarshaller = ValidateTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<ValidateTemplateRequest,ValidateTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}