using System;
using System.Reactive.Threading.Tasks;
using Octokit.Reactive.Internal;

namespace Octokit.Reactive
{
    public class ObservableWorkflowRunsClient : IObservableWorkflowRunsClient
    {
        readonly IConnection _connection;
        readonly IWorkflowRunsClient _client;

        public ObservableWorkflowRunsClient(IGitHubClient client)
        {
            Ensure.ArgumentNotNull(client, nameof(client));

            _connection = client.Connection;
            _client = client.Action.WorkflowRun;
        }


        public IObservable<WorkflowRunsResponse> GetAllForWorkflowId(string owner, string name, long workflowId)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));

            return GetAllForWorkflowId(owner, name, workflowId, ApiOptions.None);
        }

        public IObservable<WorkflowRunsResponse> GetAllForWorkflowId(long repositoryId, long workflowId)
        {
            return GetAllForWorkflowId(repositoryId, workflowId, ApiOptions.None);
        }

        public IObservable<WorkflowRunsResponse> GetAllForWorkflowId(string owner, string name, long workflowId, ApiOptions options)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));
            Ensure.ArgumentNotNull(options, nameof(options));

            return _connection.GetAndFlattenAllPages<WorkflowRunsResponse>(ApiUrls.WorkflowRuns(owner, name, workflowId), options);
        }

        public IObservable<WorkflowRunsResponse> GetAllForWorkflowId(long repositoryId, long workflowId, ApiOptions options)
        {
            Ensure.ArgumentNotNull(options, nameof(options));

            return _connection.GetAndFlattenAllPages<WorkflowRunsResponse>(ApiUrls.WorkflowRuns(repositoryId, workflowId), options);
        }

        public IObservable<WorkflowRunsResponse> GetAllForRepository(string owner, string name)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));

            return GetAllForRepository(owner, name, ApiOptions.None);
        }

        public IObservable<WorkflowRunsResponse> GetAllForRepository(long repositoryId)
        {
            return GetAllForRepository(repositoryId, ApiOptions.None);
        }

        public IObservable<WorkflowRunsResponse> GetAllForRepository(string owner, string name, ApiOptions options)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));
            Ensure.ArgumentNotNull(options, nameof(options));

            return _connection.GetAndFlattenAllPages<WorkflowRunsResponse>(ApiUrls.WorkflowRunsForRepository(owner, name), options);
        }

        public IObservable<WorkflowRunsResponse> GetAllForRepository(long repositoryId, ApiOptions options)
        {
            Ensure.ArgumentNotNull(options, nameof(options));

            return _connection.GetAndFlattenAllPages<WorkflowRunsResponse>(ApiUrls.WorkflowRunsForRepository(repositoryId), options);
        }


        public IObservable<WorkflowRun> Get(string owner, string name, long runId)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));

            return _client.Get(owner, name, runId).ToObservable();
        }

        public IObservable<WorkflowRun> Get(long repositoryId, long runId)
        {
            return _client.Get(repositoryId, runId).ToObservable();
        }

        public IObservable<bool> ReRun(string owner, string name, long runId)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));

            return _client.ReRun(owner, name, runId).ToObservable();
        }

        public IObservable<bool> ReRun(long repositoryId, long runId)
        {
            return _client.ReRun(repositoryId, runId).ToObservable();
        }


        public IObservable<bool> Cancel(string owner, string name, long runId)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));

            return _client.Cancel(owner, name, runId).ToObservable();
        }

        public IObservable<bool> Cancel(long repositoryId, long runId)
        {
            return _client.Cancel(repositoryId, runId).ToObservable();
        }

        public IObservable<string> GetLogsUrl(string owner, string name, long runId)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));

            return _client.GetLogsUrl(owner, name, runId).ToObservable();
        }

        public IObservable<string> GetLogsUrl(long repositoryId, long runId)
        {
            return _client.GetLogsUrl(repositoryId, runId).ToObservable();
        }

    }
}