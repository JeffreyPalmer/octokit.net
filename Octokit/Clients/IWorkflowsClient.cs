using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Octokit
{
    public interface IWorkflowsClient
    {
        Task<WorkflowsResponse> GetAll(string owner, string name);

        Task<WorkflowsResponse> GetAll(long repositoryId);

        Task<WorkflowsResponse> GetAll(string owner, string name, ApiOptions options);

        Task<WorkflowsResponse> GetAll(long repositoryId, ApiOptions options);
    }
}
