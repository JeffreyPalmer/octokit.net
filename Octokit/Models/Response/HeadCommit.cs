using System;
using System.Diagnostics;
using System.Globalization;

namespace Octokit
{
    // FIXME: Not sure if this should be here but it's only ever used inside of this class, and it's fairly useless elsewhere
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class HeadCommitUser
    {
        public HeadCommitUser()
        {
        }

        public HeadCommitUser(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string Name { get; protected set; }
        public string Email { get; protected set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Name: {0}, Email: {1}", Name, Email);
    }


    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class HeadCommit
    {
        public HeadCommit()
        {
        }

        public HeadCommit(string id, string treeId, string message, DateTimeOffset timestamp, HeadCommitUser author, HeadCommitUser committer)
        {
            Id = id;
            TreeId = treeId;
            Message = message;
            Timestamp = timestamp;
            Author = author;
            Committer = committer;
        }

        public string Id { get; protected set; }

        public string TreeId { get; protected set; }

        public string Message { get; protected set; }

        public DateTimeOffset Timestamp { get; protected set; }

        public HeadCommitUser Author { get; protected set; }

        public HeadCommitUser Committer { get; protected set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Id: {0}, Message: {1}, Timestamp: {2}", Id, Message, Timestamp);
    }
}
