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

        // TODO: implement
        // IWorkflowJobsClient WorkflowJob { get; }

        // TODO: implement
        // IWorkflowRunsClient WorkflowRun { get; }
    }
}
