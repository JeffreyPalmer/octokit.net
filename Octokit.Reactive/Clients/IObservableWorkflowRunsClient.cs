using System;
namespace Octokit.Reactive
{
    public interface IObservableWorkflowRunsClient
    {
        IObservable<WorkflowRunsResponse> GetAllForWorkflowId(string owner, string name, long workflowId);
        IObservable<WorkflowRunsResponse> GetAllForWorkflowId(long repositoryId, long workflowId);

        IObservable<WorkflowRunsResponse> GetAllForWorkflowId(string owner, string name, long workflowId, ApiOptions options);
        IObservable<WorkflowRunsResponse> GetAllForWorkflowId(long repositoryId, long workflowId, ApiOptions options);

        IObservable<WorkflowRunsResponse> GetAllForRepository(string owner, string name);
        IObservable<WorkflowRunsResponse> GetAllForRepository(long repositoryId);

        IObservable<WorkflowRunsResponse> GetAllForRepository(string owner, string name, ApiOptions options);
        IObservable<WorkflowRunsResponse> GetAllForRepository(long repositoryId, ApiOptions options);

        IObservable<WorkflowRun> Get(string owner, string name, long runId);
        IObservable<WorkflowRun> Get(long repositoryId, long runId);

        IObservable<bool> ReRun(string owner, string name, long runId);

        IObservable<bool> ReRun(long repositoryId, long runId);

        IObservable<bool> Cancel(string owner, string name, long runId);

        IObservable<bool> Cancel(long repositoryId, long runId);

        IObservable<string> GetLogsUrl(string owner, string name, long runId);

        IObservable<string> GetLogsUrl(long repositoryId, long runId);


    }
}
