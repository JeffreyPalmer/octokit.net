using System.Threading.Tasks;

namespace Octokit
{
    public interface IWorkflowRunsClient
    {
        Task<WorkflowRunsResponse> GetAllForWorkflowId(string owner, string name, long workflowId);
        Task<WorkflowRunsResponse> GetAllForWorkflowId(long repositoryId, long workflowId);

        Task<WorkflowRunsResponse> GetAllForWorkflowId(string owner, string name, long workflowId, ApiOptions options);
        Task<WorkflowRunsResponse> GetAllForWorkflowId(long repositoryId, long workflowId, ApiOptions options);

        Task<WorkflowRunsResponse> GetAllForRepository(string owner, string name);
        Task<WorkflowRunsResponse> GetAllForRepository(long repositoryId);

        Task<WorkflowRunsResponse> GetAllForRepository(string owner, string name, ApiOptions options);
        Task<WorkflowRunsResponse> GetAllForRepository(long repositoryId, ApiOptions options);

        Task<WorkflowRun> Get(string owner, string name, long runId);
        Task<WorkflowRun> Get(long repositoryId, long runId);

        Task<bool> ReRun(string owner, string name, long runId);

        Task<bool> ReRun(long repositoryId, long runId);

        Task<bool> Cancel(string owner, string name, long runId);

        Task<bool> Cancel(long repositoryId, long runId);

        Task<string> GetLogsUrl(string owner, string name, long runId);

        Task<string> GetLogsUrl(long repositoryId, long runId);

    }
}
