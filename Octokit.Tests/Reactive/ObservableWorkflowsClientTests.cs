using System;
using System.Reactive.Threading.Tasks;
using System.Threading.Tasks;
using NSubstitute;
using Octokit.Reactive;
using Xunit;
using System.Reactive.Linq;

namespace Octokit.Tests.Reactive
{
    public class ObservableWorkflowsClientTests
    {
        public class TheCtor
        {
            [Fact]
            public void EnsuresNonNullArguments()
            {
                Assert.Throws<ArgumentNullException>(() => new ObservableWorkflowsClient(null));
            }
        }

        public class TheGetAllMethod
        {
            [Fact]
            public async Task EnsuresNonEmptyArguments()
            {
                var githubClient = Substitute.For<IGitHubClient>();
                var client = new ObservableWorkflowsClient(githubClient);
                var options = new ApiOptions();

                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAll("", "name", options).ToTask());
                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAll("owner", "", options).ToTask());
            }

            [Fact]
            public async Task EnsuresNonNullArguments()
            {
                var githubClient = Substitute.For<IGitHubClient>();
                var client = new ObservableWorkflowsClient(githubClient);
                var options = new ApiOptions();

                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAll(null, "name", options).ToTask());
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAll("owner", null, options).ToTask());
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAll("owner", "name", null).ToTask());
            }

            [Fact]
            public void GetsCorrectUrl()
            {
                var githubClient = Substitute.For<IGitHubClient>();
                var client = new ObservableWorkflowsClient(githubClient);
                var options = new ApiOptions();

                client.GetAll("fake", "repo", options);
                githubClient.Received().Action.Workflow.GetAll("fake", "repo", options);
            }
        }
    }
}
