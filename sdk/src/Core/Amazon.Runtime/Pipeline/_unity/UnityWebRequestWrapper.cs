using System;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.Networking;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Wraps UnityWebRequest. Rewritten to use the Unity 2017 UnityWebRequest
    /// </summary>
    public class UnityWebRequestWrapper : IDisposable
    {
        UnityWebRequest instance;
        DownloadHandlerBufferWrapper downloadHandler;
        UploadHandlerRawWrapper uploadHandler;

        /// <summary>
        /// Create an instance of UnityWebRequestWrapper
        /// </summary>
        public UnityWebRequestWrapper()
        {
            if (!AWSConfigs.UnityWebRequestInitialized)
            {
                throw new InvalidOperationException("UnityWebRequest is not supported in the current version of unity");
            }
            instance = new UnityWebRequest { chunkedTransfer = false };
        }

        /// <summary>
        /// Create an instance of UnityWebRequestWrapper
        /// </summary>
        /// <param name="url">Url of the request</param>
        /// <param name="method">The HTTP Methods</param>
        public UnityWebRequestWrapper(string url, string method)
        {
            instance = new UnityWebRequest(url, method) { chunkedTransfer = false };
        }

        /// <summary>
        /// Create an instance of UnityWebRequestWrapper
        /// </summary>
        /// <param name="url">Url of the request</param>
        /// <param name="method">The HTTP Methods</param>
        /// <param name="downloadHandler">Instance of <see cref="DownloadHandlerBufferWrapper"/></param>
        /// <param name="uploadHandler">Instance of <see cref="UploadHandlerRawWrapper"/></param>
        public UnityWebRequestWrapper(string url, string method, DownloadHandlerBufferWrapper downloadHandler, UploadHandlerRawWrapper uploadHandler)
        {
            if (downloadHandler == null)
            {
                throw new ArgumentNullException(nameof(downloadHandler));
            }

            if (uploadHandler == null)
            {
                throw new ArgumentNullException(nameof(uploadHandler));
            }

            instance = new UnityWebRequest(url, method, downloadHandler.Instance, uploadHandler.Instance) { chunkedTransfer = false };
        }

        /// <summary>
        /// A flag that indicates is the UnityWebRequest is supported or not.
        /// </summary>
        internal static bool IsUnityWebRequestSupported => true;

        /// <summary>
        /// Get and Sets an instance of Download Handler
        /// </summary>
        public DownloadHandlerBufferWrapper DownloadHandler
        {
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                instance.downloadHandler = value.Instance;
                downloadHandler = value;
            }
            get => downloadHandler;
        }

        /// <summary>
        /// Gets and Sets an instance of Upload Handler
        /// </summary>
        public UploadHandlerRawWrapper UploadHandler
        {
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                instance.uploadHandler = value.Instance;
                uploadHandler = value;
            }
            get => uploadHandler;
        }

        /// <summary>
        /// Set the request Header
        /// </summary>
        /// <param name="key">the header key</param>
        /// <param name="value">the header value</param>
        public void SetRequestHeader(string key, string value)
        {
            instance.SetRequestHeader(key, value);
        }

        /// <summary>
        /// Make the http call
        /// </summary>
        /// <returns></returns>
        public AsyncOperation Send()
        {
            return instance.SendWebRequest();
        }

        /// <summary>
        /// Boolean value indicating if the http operation is complete
        /// </summary>
        public bool IsDone => instance.isDone;

        /// <summary>
        /// The download progress
        /// </summary>
        public float DownloadProgress => instance.downloadProgress;

        /// <summary>
        /// The upload Progress
        /// </summary>
        public float UploadProgress => instance.uploadProgress;

        /// <summary>
        /// Number of bytes downloaded
        /// </summary>
        public ulong DownloadedBytes => instance.downloadedBytes;

        /// <summary>
        /// The response headers
        /// </summary>
        public Dictionary<string, string> ResponseHeaders => instance.GetResponseHeaders();

        /// <summary>
        /// The http status code
        /// </summary>
        public HttpStatusCode? StatusCode
        {
            get
            {
                if (instance.responseCode == -1)
                {
                    return null;
                }
                return (HttpStatusCode)instance.responseCode;
            }
        }

        /// <summary>
        /// returns if the http operation ended with an error
        /// </summary>
        public bool IsError => instance.isNetworkError;

        /// <summary>
        /// returns the error string in case the http operation ended with an error
        /// </summary>
        public string Error => instance.error;

        #region IDisposable Support

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            if (instance == null)
            {
                return;
            }
            instance.Dispose();
            instance = null;
        }

        #endregion
    }

    public class DownloadHandlerBufferWrapper : IDisposable
    {
        /// <summary>
        /// Instance of <see cref="UnityEngine.Networking.DownloadHandlerBuffer"/>
        /// </summary>
        public DownloadHandlerBuffer Instance { get; private set; }

        /// <summary>
        /// Creates an new instance of <see cref="DownloadHandlerBufferWrapper"/>
        /// </summary>
        public DownloadHandlerBufferWrapper()
        {
            Instance = new DownloadHandlerBuffer();
        }

        /// <summary>
        /// Returns the response data as a array of bytes
        /// </summary>
        public byte[] Data => Instance.data;

        #region IDisposable Support

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            if (Instance == null)
            {
                return;
            }
            Instance.Dispose();
            Instance = null;
        }

        #endregion
    }

    public class UploadHandlerRawWrapper : IDisposable
    {
        /// <summary>
        /// Instance of <see cref="UnityEngine.Networking.UploadHandlerRaw"/>
        /// </summary>
        public UploadHandlerRaw Instance { get; private set; }

        /// <summary>
        /// Creates an instance of <see cref="UploadHandlerRawWrapper"/>
        /// </summary>
        /// <param name="data"></param>
        public UploadHandlerRawWrapper(byte[] data)
        {
            Instance = new UploadHandlerRaw(data);
        }

        #region IDisposable Support

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            if (Instance == null)
            {
                return;
            }
            Instance.Dispose();
            Instance = null;
        }

        #endregion
    }
}