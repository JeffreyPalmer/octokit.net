using System;
namespace Octokit.Reactive
{
    public interface IObservableWorkflowsClient
    {
        IObservable<Workflow> GetAll(string owner, string name);
        IObservable<Workflow> GetAll(long repositoryId);

        IObservable<Workflow> GetAll(string owner, string name, ApiOptions options);
        IObservable<Workflow> GetAll(long repositoryId, ApiOptions options);
    }
}
