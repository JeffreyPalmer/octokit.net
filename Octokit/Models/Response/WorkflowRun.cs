using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Octokit
{
    public class WorkflowRun
    {
        public WorkflowRun()
        {
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
    }
}
