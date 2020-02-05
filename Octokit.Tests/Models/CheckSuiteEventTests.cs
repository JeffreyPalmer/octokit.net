﻿using Octokit.Internal;
using Xunit;

namespace Octokit.Tests.Models
{
    public class CheckSuiteEventTests
    {
        [Fact]
        public void CanBeDeserialized()
        {
            const string json = "{\"action\":\"completed\",\"check_suite\":{\"id\":118578147,\"node_id\":\"MDEwOkNoZWNrU3VpdGUxMTg1NzgxNDc=\",\"head_branch\":\"changes\",\"head_sha\":\"ec26c3e57ca3a959ca5aad62de7213c562f8c821\",\"status\":\"completed\",\"conclusion\":\"success\",\"url\":\"https://api.github.com/repos/Codertocat/Hello-World/check-suites/118578147\",\"before\":\"6113728f27ae82c7b1a177c8d03f9e96e0adf246\",\"after\":\"ec26c3e57ca3a959ca5aad62de7213c562f8c821\",\"pull_requests\":[{\"url\":\"https://api.github.com/repos/Codertocat/Hello-World/pulls/2\",\"id\":279147437,\"number\":2,\"head\":{\"ref\":\"changes\",\"sha\":\"ec26c3e57ca3a959ca5aad62de7213c562f8c821\",\"repo\":{\"id\":186853002,\"url\":\"https://api.github.com/repos/Codertocat/Hello-World\",\"name\":\"Hello-World\"}},\"base\":{\"ref\":\"master\",\"sha\":\"f95f852bd8fca8fcc58a9a2d6c842781e32a215e\",\"repo\":{\"id\":186853002,\"url\":\"https://api.github.com/repos/Codertocat/Hello-World\",\"name\":\"Hello-World\"}}}],\"app\":{\"id\":29310,\"node_id\":\"MDM6QXBwMjkzMTA=\",\"owner\":{\"login\":\"Octocoders\",\"id\":38302899,\"node_id\":\"MDEyOk9yZ2FuaXphdGlvbjM4MzAyODk5\",\"avatar_url\":\"https://avatars1.githubusercontent.com/u/38302899?v=4\",\"gravatar_id\":\"\",\"url\":\"https://api.github.com/users/Octocoders\",\"html_url\":\"https://github.com/Octocoders\",\"followers_url\":\"https://api.github.com/users/Octocoders/followers\",\"following_url\":\"https://api.github.com/users/Octocoders/following{/other_user}\",\"gists_url\":\"https://api.github.com/users/Octocoders/gists{/gist_id}\",\"starred_url\":\"https://api.github.com/users/Octocoders/starred{/owner}{/repo}\",\"subscriptions_url\":\"https://api.github.com/users/Octocoders/subscriptions\",\"organizations_url\":\"https://api.github.com/users/Octocoders/orgs\",\"repos_url\":\"https://api.github.com/users/Octocoders/repos\",\"events_url\":\"https://api.github.com/users/Octocoders/events{/privacy}\",\"received_events_url\":\"https://api.github.com/users/Octocoders/received_events\",\"type\":\"Organization\",\"site_admin\":false},\"name\":\"octocoders-linter\",\"description\":\"\",\"external_url\":\"https://octocoders.io\",\"html_url\":\"https://github.com/apps/octocoders-linter\",\"created_at\":\"2019-04-19T19:36:24Z\",\"updated_at\":\"2019-04-19T19:36:56Z\",\"permissions\":{\"administration\":\"write\",\"checks\":\"write\",\"contents\":\"write\",\"deployments\":\"write\",\"issues\":\"write\",\"members\":\"write\",\"metadata\":\"read\",\"organization_administration\":\"write\",\"organization_hooks\":\"write\",\"organization_plan\":\"read\",\"organization_projects\":\"write\",\"organization_user_blocking\":\"write\",\"pages\":\"write\",\"pull_requests\":\"write\",\"repository_hooks\":\"write\",\"repository_projects\":\"write\",\"statuses\":\"write\",\"team_discussions\":\"write\",\"vulnerability_alerts\":\"read\"},\"events\":[]},\"created_at\":\"2019-05-15T15:20:31Z\",\"updated_at\":\"2019-05-15T15:21:14Z\",\"latest_check_runs_count\":1,\"check_runs_url\":\"https://api.github.com/repos/Codertocat/Hello-World/check-suites/118578147/check-runs\",\"head_commit\":{\"id\":\"ec26c3e57ca3a959ca5aad62de7213c562f8c821\",\"tree_id\":\"31b122c26a97cf9af023e9ddab94a82c6e77b0ea\",\"message\":\"Update README.md\",\"timestamp\":\"2019-05-15T15:20:30Z\",\"author\":{\"name\":\"Codertocat\",\"email\":\"21031067+Codertocat@users.noreply.github.com\"},\"committer\":{\"name\":\"Codertocat\",\"email\":\"21031067+Codertocat@users.noreply.github.com\"}}},\"repository\":{\"id\":186853002,\"node_id\":\"MDEwOlJlcG9zaXRvcnkxODY4NTMwMDI=\",\"name\":\"Hello-World\",\"full_name\":\"Codertocat/Hello-World\",\"private\":false,\"owner\":{\"login\":\"Codertocat\",\"id\":21031067,\"node_id\":\"MDQ6VXNlcjIxMDMxMDY3\",\"avatar_url\":\"https://avatars1.githubusercontent.com/u/21031067?v=4\",\"gravatar_id\":\"\",\"url\":\"https://api.github.com/users/Codertocat\",\"html_url\":\"https://github.com/Codertocat\",\"followers_url\":\"https://api.github.com/users/Codertocat/followers\",\"following_url\":\"https://api.github.com/users/Codertocat/following{/other_user}\",\"gists_url\":\"https://api.github.com/users/Codertocat/gists{/gist_id}\",\"starred_url\":\"https://api.github.com/users/Codertocat/starred{/owner}{/repo}\",\"subscriptions_url\":\"https://api.github.com/users/Codertocat/subscriptions\",\"organizations_url\":\"https://api.github.com/users/Codertocat/orgs\",\"repos_url\":\"https://api.github.com/users/Codertocat/repos\",\"events_url\":\"https://api.github.com/users/Codertocat/events{/privacy}\",\"received_events_url\":\"https://api.github.com/users/Codertocat/received_events\",\"type\":\"User\",\"site_admin\":false},\"html_url\":\"https://github.com/Codertocat/Hello-World\",\"description\":null,\"fork\":false,\"url\":\"https://api.github.com/repos/Codertocat/Hello-World\",\"forks_url\":\"https://api.github.com/repos/Codertocat/Hello-World/forks\",\"keys_url\":\"https://api.github.com/repos/Codertocat/Hello-World/keys{/key_id}\",\"collaborators_url\":\"https://api.github.com/repos/Codertocat/Hello-World/collaborators{/collaborator}\",\"teams_url\":\"https://api.github.com/repos/Codertocat/Hello-World/teams\",\"hooks_url\":\"https://api.github.com/repos/Codertocat/Hello-World/hooks\",\"issue_events_url\":\"https://api.github.com/repos/Codertocat/Hello-World/issues/events{/number}\",\"events_url\":\"https://api.github.com/repos/Codertocat/Hello-World/events\",\"assignees_url\":\"https://api.github.com/repos/Codertocat/Hello-World/assignees{/user}\",\"branches_url\":\"https://api.github.com/repos/Codertocat/Hello-World/branches{/branch}\",\"tags_url\":\"https://api.github.com/repos/Codertocat/Hello-World/tags\",\"blobs_url\":\"https://api.github.com/repos/Codertocat/Hello-World/git/blobs{/sha}\",\"git_tags_url\":\"https://api.github.com/repos/Codertocat/Hello-World/git/tags{/sha}\",\"git_refs_url\":\"https://api.github.com/repos/Codertocat/Hello-World/git/refs{/sha}\",\"trees_url\":\"https://api.github.com/repos/Codertocat/Hello-World/git/trees{/sha}\",\"statuses_url\":\"https://api.github.com/repos/Codertocat/Hello-World/statuses/{sha}\",\"languages_url\":\"https://api.github.com/repos/Codertocat/Hello-World/languages\",\"stargazers_url\":\"https://api.github.com/repos/Codertocat/Hello-World/stargazers\",\"contributors_url\":\"https://api.github.com/repos/Codertocat/Hello-World/contributors\",\"subscribers_url\":\"https://api.github.com/repos/Codertocat/Hello-World/subscribers\",\"subscription_url\":\"https://api.github.com/repos/Codertocat/Hello-World/subscription\",\"commits_url\":\"https://api.github.com/repos/Codertocat/Hello-World/commits{/sha}\",\"git_commits_url\":\"https://api.github.com/repos/Codertocat/Hello-World/git/commits{/sha}\",\"comments_url\":\"https://api.github.com/repos/Codertocat/Hello-World/comments{/number}\",\"issue_comment_url\":\"https://api.github.com/repos/Codertocat/Hello-World/issues/comments{/number}\",\"contents_url\":\"https://api.github.com/repos/Codertocat/Hello-World/contents/{+path}\",\"compare_url\":\"https://api.github.com/repos/Codertocat/Hello-World/compare/{base}...{head}\",\"merges_url\":\"https://api.github.com/repos/Codertocat/Hello-World/merges\",\"archive_url\":\"https://api.github.com/repos/Codertocat/Hello-World/{archive_format}{/ref}\",\"downloads_url\":\"https://api.github.com/repos/Codertocat/Hello-World/downloads\",\"issues_url\":\"https://api.github.com/repos/Codertocat/Hello-World/issues{/number}\",\"pulls_url\":\"https://api.github.com/repos/Codertocat/Hello-World/pulls{/number}\",\"milestones_url\":\"https://api.github.com/repos/Codertocat/Hello-World/milestones{/number}\",\"notifications_url\":\"https://api.github.com/repos/Codertocat/Hello-World/notifications{?since,all,participating}\",\"labels_url\":\"https://api.github.com/repos/Codertocat/Hello-World/labels{/name}\",\"releases_url\":\"https://api.github.com/repos/Codertocat/Hello-World/releases{/id}\",\"deployments_url\":\"https://api.github.com/repos/Codertocat/Hello-World/deployments\",\"created_at\":\"2019-05-15T15:19:25Z\",\"updated_at\":\"2019-05-15T15:21:14Z\",\"pushed_at\":\"2019-05-15T15:20:57Z\",\"git_url\":\"git://github.com/Codertocat/Hello-World.git\",\"ssh_url\":\"git@github.com:Codertocat/Hello-World.git\",\"clone_url\":\"https://github.com/Codertocat/Hello-World.git\",\"svn_url\":\"https://github.com/Codertocat/Hello-World\",\"homepage\":null,\"size\":0,\"stargazers_count\":0,\"watchers_count\":0,\"language\":\"Ruby\",\"has_issues\":true,\"has_projects\":true,\"has_downloads\":true,\"has_wiki\":true,\"has_pages\":true,\"forks_count\":0,\"mirror_url\":null,\"archived\":false,\"disabled\":false,\"open_issues_count\":2,\"license\":null,\"forks\":0,\"open_issues\":2,\"watchers\":0,\"default_branch\":\"master\"},\"sender\":{\"login\":\"Codertocat\",\"id\":21031067,\"node_id\":\"MDQ6VXNlcjIxMDMxMDY3\",\"avatar_url\":\"https://avatars1.githubusercontent.com/u/21031067?v=4\",\"gravatar_id\":\"\",\"url\":\"https://api.github.com/users/Codertocat\",\"html_url\":\"https://github.com/Codertocat\",\"followers_url\":\"https://api.github.com/users/Codertocat/followers\",\"following_url\":\"https://api.github.com/users/Codertocat/following{/other_user}\",\"gists_url\":\"https://api.github.com/users/Codertocat/gists{/gist_id}\",\"starred_url\":\"https://api.github.com/users/Codertocat/starred{/owner}{/repo}\",\"subscriptions_url\":\"https://api.github.com/users/Codertocat/subscriptions\",\"organizations_url\":\"https://api.github.com/users/Codertocat/orgs\",\"repos_url\":\"https://api.github.com/users/Codertocat/repos\",\"events_url\":\"https://api.github.com/users/Codertocat/events{/privacy}\",\"received_events_url\":\"https://api.github.com/users/Codertocat/received_events\",\"type\":\"User\",\"site_admin\":false}}";

            var serializer = new SimpleJsonSerializer();

            var payload = serializer.Deserialize<CheckSuiteEventPayload>(json);

            Assert.Equal("completed", payload.Action);
            Assert.Equal("ec26c3e57ca3a959ca5aad62de7213c562f8c821", payload.CheckSuite.HeadSha);
            Assert.Equal(CheckStatus.Completed, payload.CheckSuite.Status.Value);

            Assert.Equal(1, payload.CheckSuite.LatestCheckRunsCount);
            Assert.Equal("ec26c3e57ca3a959ca5aad62de7213c562f8c821", payload.CheckSuite.HeadCommit.Id);
            Assert.Equal("Update README.md", payload.CheckSuite.HeadCommit.Message);
            Assert.Equal("Codertocat", payload.CheckSuite.HeadCommit.Author.Name);
        }
    }
}
