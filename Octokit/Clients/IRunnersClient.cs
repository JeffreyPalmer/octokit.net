using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Octokit
{
    public interface IRunnersClient
    {
        Task<IReadOnlyList<RunnerDownload>> GetAllDownloads(string owner, string name);
        Task<IReadOnlyList<RunnerDownload>> GetAllDownloads(long repositoryId);

        Task<RunnerRegistrationToken> CreateRegistrationToken(string owner, string name);
        Task<RunnerRegistrationToken> CreateRegistrationToken(long repositoryId);

        Task<IReadOnlyList<Runner>> GetAll(string owner, string name);
        Task<IReadOnlyList<Runner>> GetAll(long repositoryId);

        Task<Runner> Get(string owner, string name, long runnerId);
        Task<Runner> Get(long repositoryId, long runnerId);

        Task<RunnerRemoveToken> CreateRemoveToken(string owner, string name);
        Task<RunnerRemoveToken> CreateRemoveToken(long repositoryId);

        Task<bool> Remove(string owner, string name, long runnerId);
        Task<bool> Remove(long repositoryId, long runnerId);

    }
}
