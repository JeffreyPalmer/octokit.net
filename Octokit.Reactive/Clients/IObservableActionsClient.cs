namespace Octokit.Reactive
{
    public interface IObservableActionsClient
    {
        IObservableWorkflowArtifactsClient Artifact { get; }

        IObservableSecretsClient Secret { get; }

        IObservableRunnersClient Runner { get ; }

        IObservableWorkflowsClient Workflow { get; }
        IObservableWorkflowRunsClient WorkflowRun { get; }
        IObservableWorkflowJobsClient WorkflowJob { get; }
    }
}
