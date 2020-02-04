using System;

namespace Octokit.Reactive
{
    public interface IObservableWorkflowArtifactsClient
    {
        IObservable<WorkflowArtifactsResponse> GetAll(string owner, string name, long runId);
        IObservable<WorkflowArtifactsResponse> GetAll(long repositoryId, long runId);

        IObservable<WorkflowArtifact> Get(string owner, string name, long artifactId);
        IObservable<WorkflowArtifact> Get(long repositoryId, long artifactId);

        IObservable<string> DownloadUrl(string owner, string name, long artifactId);
        IObservable<string> DownloadUrl(long repositoryId, long artifactId);

        IObservable<bool> Delete(string name, string owner, long artifactId);
        IObservable<bool> Delete(long repositoryId, long artifactId);
    }
}
