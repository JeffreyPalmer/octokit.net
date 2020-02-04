namespace Octokit.Reactive
{
    public interface IObservableActionsClient
    {
        IObservableWorkflowsClient Workflow { get; }
        IObservableWorkflowRunsClient WorkflowRun { get; }
    }
}
