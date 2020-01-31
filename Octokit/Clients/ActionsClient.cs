namespace Octokit
{
    public class ActionsClient : IActionsClient
    {
        public ActionsClient(ApiConnection apiConnection)
        {
            // Workflow = new WorkflowsClient(apiConnection);
            Workflow = new Workflow(apiConnection);
        }

        public IWorkflowsClient Workflow { get; private set; }
    }
}
