using System;
using System.Collections.Generic;

namespace Octokit.Reactive
{
    public interface IObservableSecretsClient
    {
        IObservable<PublicKey> GetPublicKey(string owner, string name);
        IObservable<PublicKey> GetPublicKey(long repositoryId);

        IObservable<IReadOnlyList<SecretsResponse>> GetAll(string owner, string name);
        IObservable<IReadOnlyList<SecretsResponse>> GetAll(long repositoryId);

        IObservable<Secret> Get(string owner, string name, string secretName);
        IObservable<Secret> Get(long repositoryId, string secretName);

        IObservable<bool> Create(string owner, string name, string secretName, SecretRequest secretRequest);
        IObservable<bool> Create(long repositoryId, string secretName, SecretRequest secretRequest);
        IObservable<bool> Update(string owner, string name, string secretName, SecretRequest secretRequest);
        IObservable<bool> Update(long repositoryId, string secretName, SecretRequest secretRequest);

        IObservable<bool> Delete(string owner, string name, string secretName);
        IObservable<bool> Delete(long repositoryId, string secretName);

    }
}
