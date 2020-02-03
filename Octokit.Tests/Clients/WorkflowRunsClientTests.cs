using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NSubstitute;
using Xunit;

namespace Octokit.Tests.Clients
{
    public class WorkflowRunsClientTests
    {
        public class TheCtor
        {
            [Fact]
            public void EnsuresNonNullArguments()
            {
                Assert.Throws<ArgumentNullException>(
                    () => new WorkflowRunsClient(null));
            }
        }


        public class TheGetMethod
        {
            [Fact]
            public async Task RequestsCorrectUrlWithRepositoryOwnerAndName()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new WorkflowRunsClient(connection);

                await client.Get("fake", "repo", 1);

                connection.Received().Get<WorkflowRun>(Arg.Is<Uri>(u => u.ToString() == "repos/fake/repo/actions/runs/1"));
            }

            [Fact]
            public async Task RequestsCorrectUrlWithRepositoryId()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new WorkflowRunsClient(connection);

                await client.Get(1, 2);

                connection.Received().Get<WorkflowRun>(Arg.Is<Uri>(u => u.ToString() == "repositories/1/actions/runs/2"));
            }

            [Fact]
            public async Task EnsuresNonNullArguments()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new WorkflowRunsClient(connection);

                await Assert.ThrowsAsync<ArgumentNullException>(() => client.Get(null, "name", 1));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.Get("owner", null, 1));
            }
        }

        public class TheGetAllForWorkflowIdMethod
        {
            [Fact]
            public async Task RequestsCorrectUrlWithRepositoryName()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new WorkflowRunsClient(connection);

                await client.GetAllForWorkflowId("fake", "repo", 1);

                connection.Received().GetAll<WorkflowRunsResponse>(Arg.Is<Uri>(u => u.ToString() == "repos/fake/repo/actions/workflows/1/runs"), Args.ApiOptions);
            }

            [Fact]
            public async Task RequestsCorrectUrlWithRepositoryId()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new WorkflowRunsClient(connection);

                await client.GetAllForWorkflowId(1, 2);

                connection.Received().GetAll<WorkflowRunsResponse>(Arg.Is<Uri>(u => u.ToString() == "repositories/1/actions/workflows/2/runs"), Args.ApiOptions);
            }

            [Fact]
            public async Task RequestsCorrectUrlWithRepositoryNameWithApiOptions()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new WorkflowRunsClient(connection);

                var options = new ApiOptions
                {
                    PageCount = 1,
                    StartPage = 1,
                    PageSize = 1
                };

                await client.GetAllForWorkflowId("fake", "repo", 1, options);

                connection.Received().GetAll<WorkflowRunsResponse>(Arg.Is<Uri>(u => u.ToString() == "repos/fake/repo/actions/workflows/1/runs"), options);
            }

            [Fact]
            public async Task RequestsCorrectUrlWithRepositoryIdWithApiOptions()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new WorkflowRunsClient(connection);

                var options = new ApiOptions
                {
                    PageCount = 1,
                    StartPage = 1,
                    PageSize = 1
                };

                await client.GetAllForWorkflowId(1, 2, options);

                connection.Received().GetAll<WorkflowRunsResponse>(Arg.Is<Uri>(u => u.ToString() == "repositories/1/actions/workflows/2/runs"), options);
            }

            [Fact]
            public async Task EnsuresNonNullArguments()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new WorkflowRunsClient(connection);

                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAllForWorkflowId(null, "name", 1));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAllForWorkflowId("owner", null, 1));

                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAllForWorkflowId(null, "name", 1, ApiOptions.None));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAllForWorkflowId("owner", null, 1, ApiOptions.None));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAllForWorkflowId("owner", "name", 1, (ApiOptions)null));

                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAllForWorkflowId(1, 2, (ApiOptions)null));

                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAllForWorkflowId("", "name", 1));
                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAllForWorkflowId("owner", "", 1));
                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAllForWorkflowId("", "name", 1, ApiOptions.None));
                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAllForWorkflowId("owner", "", 1, ApiOptions.None));
            }
        }


        public class TheGetAllForRepositoryMethod
        {
            [Fact]
            public async Task RequestsCorrectUrlWithRepositoryName()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new WorkflowRunsClient(connection);

                await client.GetAllForRepository("fake", "repo");

                connection.Received().GetAll<WorkflowRunsResponse>(Arg.Is<Uri>(u => u.ToString() == "repos/fake/repo/actions/runs"), Args.ApiOptions);
            }

            [Fact]
            public async Task RequestsCorrectUrlWithRepositoryId()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new WorkflowRunsClient(connection);

                await client.GetAllForRepository(1);

                connection.Received().GetAll<WorkflowRunsResponse>(Arg.Is<Uri>(u => u.ToString() == "repositories/1/actions/runs"), Args.ApiOptions);
            }

            [Fact]
            public async Task RequestsCorrectUrlWithRepositoryNameWithApiOptions()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new WorkflowRunsClient(connection);

                var options = new ApiOptions
                {
                    PageCount = 1,
                    StartPage = 1,
                    PageSize = 1
                };

                await client.GetAllForRepository("fake", "repo", options);

                connection.Received().GetAll<WorkflowRunsResponse>(Arg.Is<Uri>(u => u.ToString() == "repos/fake/repo/actions/runs"), options);
            }

            [Fact]
            public async Task RequestsCorrectUrlWithRepositoryIdWithApiOptions()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new WorkflowRunsClient(connection);

                var options = new ApiOptions
                {
                    PageCount = 1,
                    StartPage = 1,
                    PageSize = 1
                };

                await client.GetAllForRepository(1, options);

                connection.Received().GetAll<WorkflowRunsResponse>(Arg.Is<Uri>(u => u.ToString() == "repositories/1/actions/runs"), options);
            }

            [Fact]
            public async Task EnsuresNonNullArguments()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new WorkflowRunsClient(connection);

                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAllForRepository(null, "name"));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAllForRepository("owner", null));

                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAllForRepository(null, "name", ApiOptions.None));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAllForRepository("owner", null, ApiOptions.None));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAllForRepository("owner", "name", (ApiOptions)null));

                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAllForRepository(1, (ApiOptions)null));

                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAllForRepository("", "name"));
                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAllForRepository("owner", ""));
                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAllForRepository("", "name", ApiOptions.None));
                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAllForRepository("owner", "", ApiOptions.None));
            }
        }
    }
}
