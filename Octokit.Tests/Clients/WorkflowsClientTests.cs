using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NSubstitute;
using Xunit;

namespace Octokit.Tests.Clients
{
    public class WorkflowsClientTests
    {
        public class TheCtor
        {
            [Fact]
            public void EnsuresNonNullArguments()
            {
                Assert.Throws<ArgumentNullException>(
                    () => new WorkflowsClient(null));
            }
        }


        // public class TheGetMethod
        // {
        //     [Fact]
        //     public async Task RequestsCorrectUrl()
        //     {
        //         var connection = Substitute.For<IApiConnection>();
        //         var client = new WorkflowsClient(connection);

        //         await client.Get("fake", "repo", "reference");

        //         connection.Received().Get<GitHubCommit>(Arg.Is<Uri>(u => u.ToString() == "repos/fake/repo/commits/reference"));
        //     }

        //     [Fact]
        //     public async Task RequestsCorrectUrlWithRepositoryId()
        //     {
        //         var connection = Substitute.For<IApiConnection>();
        //         var client = new WorkflowsClient(connection);

        //         await client.Get(1, "reference");

        //         connection.Received().Get<GitHubCommit>(Arg.Is<Uri>(u => u.ToString() == "repositories/1/commits/reference"));
        //     }

        //     [Fact]
        //     public async Task EnsuresNonNullArguments()
        //     {
        //         var connection = Substitute.For<IApiConnection>();
        //         var client = new WorkflowsClient(connection);

        //         await Assert.ThrowsAsync<ArgumentNullException>(() => client.Get(null, "name", "reference"));
        //         await Assert.ThrowsAsync<ArgumentNullException>(() => client.Get("owner", null, "reference"));
        //         await Assert.ThrowsAsync<ArgumentNullException>(() => client.Get("owner", "name", null));

        //         await Assert.ThrowsAsync<ArgumentNullException>(() => client.Get(1, null));

        //         await Assert.ThrowsAsync<ArgumentException>(() => client.Get("", "name", "reference"));
        //         await Assert.ThrowsAsync<ArgumentException>(() => client.Get("owner", "", "reference"));
        //         await Assert.ThrowsAsync<ArgumentException>(() => client.Get("owner", "name", ""));

        //         await Assert.ThrowsAsync<ArgumentException>(() => client.Get(1, ""));
        //     }
        // }

        public class TheGetAllMethod
        {
            [Fact]
            public async Task RequestsCorrectUrl()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new WorkflowsClient(connection);

                await client.GetAll("fake", "repo");

                connection.Received().GetAll<WorkflowsResponse>(Arg.Is<Uri>(u => u.ToString() == "repos/fake/repo/actions/workflows"), Args.ApiOptions);
            }

            [Fact]
            public async Task RequestsCorrectUrlWithRepositoryId()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new WorkflowsClient(connection);

                await client.GetAll(1);

                connection.Received().GetAll<WorkflowsResponse>(Arg.Is<Uri>(u => u.ToString() == "repositories/1/actions/workflows"), Args.ApiOptions);
            }

            [Fact]
            public async Task RequestsCorrectUrlWithApiOptions()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new WorkflowsClient(connection);

                var options = new ApiOptions
                {
                    PageCount = 1,
                    StartPage = 1,
                    PageSize = 1
                };

                await client.GetAll("fake", "repo", options);

                connection.Received().GetAll<WorkflowsResponse>(Arg.Is<Uri>(u => u.ToString() == "repos/fake/repo/actions/workflows"), options);
            }

            [Fact]
            public async Task RequestsCorrectUrlWithRepositoryIdWithApiOptions()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new WorkflowsClient(connection);

                var options = new ApiOptions
                {
                    PageCount = 1,
                    StartPage = 1,
                    PageSize = 1
                };

                await client.GetAll(1, options);

                connection.Received().GetAll<WorkflowsResponse>(Arg.Is<Uri>(u => u.ToString() == "repositories/1/actions/workflows"), options);
            }

            [Fact]
            public async Task EnsuresNonNullArguments()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new WorkflowsClient(connection);

                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAll(null, "name"));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAll("owner", null));

                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAll(null, "name", ApiOptions.None));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAll("owner", null, ApiOptions.None));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAll("owner", "name", (ApiOptions)null));

                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAll(1, (ApiOptions)null));

                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAll("", "name"));
                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAll("owner", ""));
                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAll("", "name", ApiOptions.None));
                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAll("owner", "", ApiOptions.None));
            }
        }
    }
}
