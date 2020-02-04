using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Octokit
{
    public interface IWorkflowArtifactsClient
    {
        Task<WorkflowArtifactsResponse> GetAll(string owner, string name, long runId);
        Task<WorkflowArtifactsResponse> GetAll(long repositoryId, long runId);

        Task<WorkflowArtifact> Get(string owner, string name, long artifactId);
        Task<WorkflowArtifact> Get(long repositoryId, long artifactId);

        Task<string> DownloadUrl(string owner, string name, long artifactId);
        Task<string> DownloadUrl(long repositoryId, long artifactId);

        Task<bool> Delete(string name, string owner, long artifactId);
        Task<bool> Delete(long repositoryId, long artifactId);
    }
}
