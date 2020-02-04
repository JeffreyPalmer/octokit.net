using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class WorkflowRun
    {
        public WorkflowRun()
        {
        }

        public WorkflowRun(long id, string headBranch, string headSha, int runNumber, long checkSuiteId, string @event, string status, StringEnum<CheckConclusion>? conclusion, string url, string htmlUrl, IReadOnlyList<PullRequest> pullRequests, DateTimeOffset createdAt, DateTimeOffset updatedAt, HeadCommit headCommit)
        {
            Id = id;
            HeadBranch = headBranch;
            HeadSha = headSha;
            RunNumber = runNumber;
            CheckSuiteId = checkSuiteId;
            Event = @event;
            Status = status;
            Conclusion = conclusion;
            Url = url;
            HtmlUrl = htmlUrl;
            PullRequests = pullRequests;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            HeadCommit = headCommit;
        }

        public long Id { get; protected set; }
        public string HeadBranch { get; protected set; }
        public string HeadSha { get; protected set; }
        public int RunNumber { get; protected set; }
        public long CheckSuiteId { get; protected set; }
        public string Event { get; protected set; }
        public string Status { get; protected set; }

        // FIXME: Should probably be check suite conclusion? What is the actual type for this? CheckConclusion seems wrong. Perhaps Conclusion?
        public StringEnum<CheckConclusion>? Conclusion { get; protected set; }
        public string Url { get; protected set; }
        public string HtmlUrl { get; protected set; }
        public IReadOnlyList<PullRequest> PullRequests { get; protected set; }
        public DateTimeOffset CreatedAt { get; protected set; }
        public DateTimeOffset UpdatedAt { get; protected set; }
        public HeadCommit HeadCommit { get; protected set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Id: {0}, HeadBranch: {1}, HeadSha: {2}, CheckSuiteId: {3}, Conclusion: {4}", Id, HeadBranch, HeadSha, CheckSuiteId, Conclusion);
    }
}
