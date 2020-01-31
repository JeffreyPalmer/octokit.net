using System;
using System.Linq;
using System.Threading.Tasks;

namespace Octokit
{
    public class WorkflowsClient : ApiClient, IWorkflowsClient
    {
        public WorkflowsClient(IApiConnection apiConnection)
            : base(apiConnection)
        {
        }

        public Task<WorkflowsResponse> GetAll(string owner, string name)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));

            return GetAll(owner, name, ApiOptions.None);
        }

        public Task<WorkflowsResponse> GetAll(long repositoryId)
        {
            return GetAll(repositoryId, ApiOptions.None);
        }

        public async Task<WorkflowsResponse> GetAll(string owner, string name, ApiOptions options)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));
            Ensure.ArgumentNotNull(options, nameof(options));

            var results = await ApiConnection.GetAll<WorkflowsResponse>(ApiUrls.Workflows(owner, name), options).ConfigureAwait(false);
            return new WorkflowsResponse(
                results.Count > 0 ? results.Max(x => x.TotalCount) : 0,
                results.SelectMany(x => x.Workflows).ToList());
        }

        public async Task<WorkflowsResponse> GetAll(long repositoryId, ApiOptions options)
        {
            Ensure.ArgumentNotNull(options, nameof(options));

            var results = await ApiConnection.GetAll<WorkflowsResponse>(ApiUrls.Workflows(repositoryId), options).ConfigureAwait(false);
            return new WorkflowsResponse(
                results.Count > 0 ? results.Max(x => x.TotalCount) : 0,
                results.SelectMany(x => x.Workflows).ToList());
        }

    }
}
