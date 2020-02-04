using System;
using System.Diagnostics;
using System.Globalization;

// FIXME: What is this project's policy on generic types, inheritence, etc?
// we could create a Token base class or generic and have specific types for various operations, but I am non sure what's best for based on established practice.

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class RunnerRegistrationToken
    {
        public RunnerRegistrationToken() { }

        public RunnerRegistrationToken(string token, DateTimeOffset expiresAt)
        {
            Token = token;
            ExpiresAt = expiresAt;
        }

        /// <summary>
        /// The access token
        /// </summary>
        public string Token { get; protected set; }

        /// <summary>
        /// The expiration date
        /// </summary>
        public DateTimeOffset ExpiresAt { get; protected set; }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "Token: {0}, ExpiresAt: {1}", Token, ExpiresAt);
            }
        }
    }
}
