using System;
using System.Reactive.Threading.Tasks;
using Octokit.Reactive.Internal;

namespace Octokit.Reactive
{
    public class ObservableWorkflowsClient : IObservableWorkflowsClient
    {
        readonly IConnection _connection;
        readonly IWorkflowsClient _workflow;

        public ObservableWorkflowsClient(IGitHubClient client)
        {
            Ensure.ArgumentNotNull(client, nameof(client));

            _connection = client.Connection;
            _workflow = client.Action.Workflow;
        }

        public IObservable<Workflow> GetAll(string owner, string name)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));

            return GetAll(owner, name, ApiOptions.None);
        }

        public IObservable<Workflow> GetAll(long repositoryId)
        {
            throw new NotImplementedException();
        }

        public IObservable<Workflow> GetAll(string owner, string name, ApiOptions options)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));
            Ensure.ArgumentNotNull(options, nameof(options));

            return _connection.GetAndFlattenAllPages<Workflow>(ApiUrls.Workflows(owner, name), options);
        }

        public IObservable<Workflow> GetAll(long repositoryId, ApiOptions options)
        {
            Ensure.ArgumentNotNull(options, nameof(options));

            return _connection.GetAndFlattenAllPages<Workflow>(ApiUrls.Workflows(repositoryId), options);
        }
    }
}
