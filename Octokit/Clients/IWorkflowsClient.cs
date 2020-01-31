using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Octokit
{
    public interface IWorkflowsClient
    {
        Task<IReadOnlyList<Workflow>> GetAll(string owner, string name);

        Task<IReadOnlyList<Workflow>> GetAll(long repositoryId);

        Task<IReadOnlyList<Workflow>> GetAll(string owner, string name, ApiOptions options);

        Task<IReadOnlyList<Workflow>> GetAll(long repositoryId, ApiOptions options);
    }
}
