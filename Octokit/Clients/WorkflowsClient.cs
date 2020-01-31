using System.Collections.Generic;
using System.Threading.Tasks;

namespace Octokit
{
    public class WorkflowsClient : ApiClient, IWorkflowsClient
    {
        public WorkflowsClient(IApiConnection apiConnection)
            : base(apiConnection)
        {
        }

        public Task<IReadOnlyList<Workflow>> GetAll(string owner, string name)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));

            return GetAll(owner, name, ApiOptions.None);
        }

        public Task<IReadOnlyList<Workflow>> GetAll(long repositoryId)
        {
            return GetAll(repositoryId, ApiOptions.None);
        }

        public Task<IReadOnlyList<Workflow>> GetAll(string owner, string name, ApiOptions options)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));
            Ensure.ArgumentNotNull(options, nameof(options));

            return ApiConnection.GetAll<Workflow>(ApiUrls.Workflows(owner, name), options);
        }

        public Task<IReadOnlyList<Workflow>> GetAll(long repositoryId, ApiOptions options)
        {
            Ensure.ArgumentNotNull(options, nameof(options));

            return ApiConnection.GetAll<Workflow>(ApiUrls.Workflows(repositoryId), options);
        }

    }
}
