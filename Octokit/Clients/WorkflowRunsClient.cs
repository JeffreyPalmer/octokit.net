using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Octokit.Internal;

namespace Octokit
{
    public class WorkflowRunsClient : ApiClient, IWorkflowRunsClient
    {
        public WorkflowRunsClient(IApiConnection apiConnection)
            : base(apiConnection)
        {
        }

        public Task<WorkflowRunsResponse> GetAllForRepository(string owner, string name)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));

            return GetAllForRepository(owner, name, ApiOptions.None);
        }

        public Task<WorkflowRunsResponse> GetAllForRepository(string owner, string name, ApiOptions options)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));
            Ensure.ArgumentNotNull(options, nameof(options));

            return RequestAndReturnWorkflowRunsResponse(ApiUrls.WorkflowRunsForRepository(owner, name), options);
        }

        public Task<WorkflowRunsResponse> GetAllForRepository(long repositoryId)
        {
            return GetAllForRepository(repositoryId, ApiOptions.None);
        }

        public Task<WorkflowRunsResponse> GetAllForRepository(long repositoryId, ApiOptions options)
        {
            Ensure.ArgumentNotNull(options, nameof(options));

            return RequestAndReturnWorkflowRunsResponse(ApiUrls.WorkflowRunsForRepository(repositoryId), options);
        }

        public Task<WorkflowRunsResponse> GetAllForWorkflowId(string owner, string name, long workflowId)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));

            return GetAllForWorkflowId(owner, name, workflowId, ApiOptions.None);
        }

        public Task<WorkflowRunsResponse> GetAllForWorkflowId(string owner, string name, long workflowId, ApiOptions options)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));
            Ensure.ArgumentNotNull(options, nameof(options));

            return RequestAndReturnWorkflowRunsResponse(ApiUrls.WorkflowRuns(owner, name, workflowId), options);
        }

        public Task<WorkflowRunsResponse> GetAllForWorkflowId(long repositoryId, long workflowId)
        {
            return GetAllForWorkflowId(repositoryId, workflowId, ApiOptions.None);
        }

        public Task<WorkflowRunsResponse> GetAllForWorkflowId(long repositoryId, long workflowId, ApiOptions options)
        {
            Ensure.ArgumentNotNull(options, nameof(options));

            return RequestAndReturnWorkflowRunsResponse(ApiUrls.WorkflowRuns(repositoryId, workflowId), options);
        }

        public Task<WorkflowRun> Get(string owner, string name, long runId)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));

            return ApiConnection.Get<WorkflowRun>(ApiUrls.WorkflowRun(owner, name, runId));
        }

        public Task<WorkflowRun> Get(long repositoryId, long runId)
        {
            return ApiConnection.Get<WorkflowRun>(ApiUrls.WorkflowRun(repositoryId, runId));
        }


        public async Task<bool> ReRun(string owner, string name, long runId)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));

            var httpStatusCode = await Connection.Post(ApiUrls.WorkflowRunReRun(owner, name, runId)).ConfigureAwait(false);
            // FIXME: This logic (copied from CheckSuitesClient) seems suspect - the final boolean result will never return anything other than true
            // FIXME: How are clients expected to check for failures? via exception handling or result testing?
            if (httpStatusCode != HttpStatusCode.Created)
            {
                throw new ApiException("Invalid status code returned. Expected a 201", httpStatusCode);
            }
            return httpStatusCode == HttpStatusCode.Created;
        }

        public async Task<bool> ReRun(long repositoryId, long runId)
        {
            var httpStatusCode = await Connection.Post(ApiUrls.WorkflowRunReRun(repositoryId, runId)).ConfigureAwait(false);
            // FIXME: This logic seems suspect - the final boolean result will never return anything other than true
            // FIXME: How are clients expected to check for failures? via exception handling or result testing?
            if (httpStatusCode != HttpStatusCode.Created)
            {
                throw new ApiException("Invalid status code returned. Expected a 201", httpStatusCode);
            }
            return httpStatusCode == HttpStatusCode.Created;
        }


        public async Task<bool> Cancel(string owner, string name, long runId)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));

            var httpStatusCode = await Connection.Post(ApiUrls.WorkflowRunCancel(owner, name, runId)).ConfigureAwait(false);
            // FIXME: This logic seems suspect - the final boolean result will never return anything other than true
            // FIXME: How are clients expected to check for failures? via exception handling or result testing?
            if (httpStatusCode != HttpStatusCode.Accepted)
            {
                throw new ApiException("Invalid status code returned. Expected a 202", httpStatusCode);
            }
            return httpStatusCode == HttpStatusCode.Accepted;
        }

        public async Task<bool> Cancel(long repositoryId, long runId)
        {
            var httpStatusCode = await Connection.Post(ApiUrls.WorkflowRunCancel(repositoryId, runId)).ConfigureAwait(false);
            // FIXME: This logic seems suspect - the final boolean result will never return anything other than true
            // FIXME: How are clients expected to check for failures? via exception handling or result testing?
            if (httpStatusCode != HttpStatusCode.Accepted)
            {
                throw new ApiException("Invalid status code returned. Expected a 202", httpStatusCode);
            }
            return httpStatusCode == HttpStatusCode.Accepted;
        }

        public async Task<string> GetLogsUrl(string owner, string name, long runId)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));

            // FIXME: Is this idiomatic?
            var response = await Connection.Get<object>(ApiUrls.WorkflowRunLogs(owner, name, runId), null, null).ConfigureAwait(false);
            var statusCode = response.HttpResponse.StatusCode;
            if (statusCode != HttpStatusCode.Found)
            {
                throw new ApiException("Invalid status code returned. Expected a 302", statusCode);
            }
            return response.HttpResponse.Headers.SafeGet("Location");
        }

        public async Task<string> GetLogsUrl(long repositoryId, long runId)
        {
            var response = await Connection.Get<object>(ApiUrls.WorkflowRunLogs(repositoryId, runId), null, null).ConfigureAwait(false);
            var statusCode = response.HttpResponse.StatusCode;
            if (statusCode != HttpStatusCode.Found)
            {
                throw new ApiException("Invalid status code returned. Expected a 302", statusCode);
            }
            return response.HttpResponse.Headers.SafeGet("Location");
        }

        // Private support methods
        private async Task<WorkflowRunsResponse> RequestAndReturnWorkflowRunsResponse(Uri uri, ApiOptions options)
        {
            var results = await ApiConnection.GetAll<WorkflowRunsResponse>(uri, options);
            return new WorkflowRunsResponse(
                results.Count > 0 ? results.Max(x => x.TotalCount) : 0,
                results.SelectMany(x => x.WorkflowRuns).ToList());
        }
    }
}