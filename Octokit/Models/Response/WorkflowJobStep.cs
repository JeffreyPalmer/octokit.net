using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class WorkflowJobStep
    {
        public WorkflowJobStep()
        {
        }

        public WorkflowJobStep(string name, string status, string conclusion, int number, DateTimeOffset startedAt, DateTimeOffset completedAt)
        {
            Name = name;
            Status = status;
            Conclusion = conclusion;
            Number = number;
            StartedAt = startedAt;
            CompletedAt = completedAt;
        }

        public string Name { get; protected set; }

        // FIXME: should be an enum
        public string Status { get; protected set; }

        // FIXME: should be an enum
        public string Conclusion { get; protected set; }
        public int Number { get; protected set; }
        public DateTimeOffset StartedAt { get; protected set; }
        public DateTimeOffset CompletedAt { get; protected set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Name: {0}, Status: {1}, Number: {2}", Name, Status, Number);
    }
}
