using System;
using System.Collections.Generic;

namespace Octokit.Reactive
{
    public interface IObservableRunnersClient
    {
        IObservable<IReadOnlyList<RunnerDownload>> GetAllDownloads(string owner, string name);
        IObservable<IReadOnlyList<RunnerDownload>> GetAllDownloads(long repositoryId);

        IObservable<RunnerRegistrationToken> CreateRegistrationToken(string owner, string name);
        IObservable<RunnerRegistrationToken> CreateRegistrationToken(long repositoryId);

        IObservable<IReadOnlyList<Runner>> GetAll(string owner, string name);
        IObservable<IReadOnlyList<Runner>> GetAll(long repositoryId);

        IObservable<Runner> Get(string owner, string name, long runnerId);
        IObservable<Runner> Get(long repositoryId, long runnerId);

        IObservable<RunnerRemoveToken> CreateRemoveToken(string owner, string name);
        IObservable<RunnerRemoveToken> CreateRemoveToken(long repositoryId);

        IObservable<bool> Remove(string owner, string name, long runnerId);
        IObservable<bool> Remove(long repositoryId, long runnerId);

    }
}
