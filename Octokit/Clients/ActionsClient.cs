namespace Octokit
{
    public class ActionsClient : IActionsClient
    {
        public ActionsClient(ApiConnection apiConnection)
        {
            Workflow = new WorkflowsClient(apiConnection);
            WorkflowRun = new WorkflowRunsClient(apiConnection);
        }

        public IWorkflowsClient Workflow { get; private set; }

        public IWorkflowRunsClient WorkflowRun { get; private set; }
    }
}
