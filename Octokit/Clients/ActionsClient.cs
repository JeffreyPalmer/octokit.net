namespace Octokit
{
    public class ActionsClient : IActionsClient
    {
        public ActionsClient(ApiConnection apiConnection)
        {
            Workflow = new WorkflowsClient(apiConnection);
        }

        public IWorkflowsClient Workflow { get; private set; }
    }
}
