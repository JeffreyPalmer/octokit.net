using System;

namespace Octokit
{
    // FIXME: Not sure if this should be here but it's only ever used inside of this class, and it's fairly useless elsewhere
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
    }


    public class HeadCommit
    {
        public HeadCommit()
        {
        }

        public HeadCommit(long id, string treeId, string message, DateTimeOffset timestamp, HeadCommitUser author, HeadCommitUser committer)
        {
            Id = id;
            TreeId = treeId;
            Message = message;
            Timestamp = timestamp;
            Author = author;
            Committer = committer;
        }

        public long Id { get; protected set; }

        public string TreeId { get; protected set; }

        public string Message { get; protected set; }

        public DateTimeOffset Timestamp { get; protected set; }

        public HeadCommitUser Author { get; protected set; }

        public HeadCommitUser Committer { get; protected set; }

    }



}
