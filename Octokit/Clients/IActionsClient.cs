namespace Octokit
{
    public interface IActionsClient
    {
        // TODO: implement
        // IArtifactsClient Artifact { get; }
        // TODO: implement
        // ISecretsClient Secret { get; }

        // TODO: implement
        // IRunnersClient Runner { get; }
        IWorkflowsClient Workflow { get; }

        IWorkflowJobsClient WorkflowJob { get; }

        IWorkflowRunsClient WorkflowRun { get; }
    }
}
