using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Octokit
{
    public interface ISecretsClient
    {
        Task<PublicKey> GetPublicKey(string owner, string name);
        Task<PublicKey> GetPublicKey(long repositoryId);

        Task<IReadOnlyList<SecretsResponse>> GetAll(string owner, string name);
        Task<IReadOnlyList<SecretsResponse>> GetAll(long repositoryId);

        Task<Secret> Get(string owner, string name, string secretName);
        Task<Secret> Get(long repositoryId, string secretName);

        Task<bool> Create(string owner, string name, string secretName, SecretRequest secretRequest);
        Task<bool> Create(long repositoryId, string secretName, SecretRequest secretRequest);
        Task<bool> Update(string owner, string name, string secretName, SecretRequest secretRequest);
        Task<bool> Update(long repositoryId, string secretName, SecretRequest secretRequest);

        Task<bool> Delete(string owner, string name, string secretName);
        Task<bool> Delete(long repositoryId, string secretName);

    }
}
