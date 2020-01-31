namespace Octokit.Reactive
{
    public class ObservableActionsClient : IObservableActionsClient
    {
        public ObservableActionsClient(IGitHubClient client)
        {
            Ensure.ArgumentNotNull(client, nameof(client));

            Workflow = new ObservableWorkflowsClient(client);
        }

        public IObservableWorkflowsClient Workflow { get; private set; }
    }
}
