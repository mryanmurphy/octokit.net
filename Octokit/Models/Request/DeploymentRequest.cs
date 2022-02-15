using System.Diagnostics;
using System.Globalization;
using Octokit.Internal;

namespace Octokit
{
    /// <summary>
    /// Details to filter list of deployments, such as by environment or task
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class DeploymentListFilter : RequestParameters
    {
        /// <summary>
        /// The SHA recorded at creation time.
        /// </summary>
        [Parameter(Key = "sha")]
        public string Sha { get; set; }

        /// <summary>
        /// The name of the ref. This can be a branch, tag, or SHA.
        /// </summary>
        [Parameter(Key = "ref")]
        public string Ref { get; set; }

        /// <summary>
        /// The name of the task for the deployment (e.g., deploy or deploy:migrations).
        /// </summary>
        [Parameter(Key = "task")]
        public string Task { get; set; }

        /// <summary>
        /// The name of the environment that was deployed to (e.g., staging or production).
        /// </summary>
        [Parameter(Key = "environment")]
        public string Environment { get; set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Sha: {0}, Ref: {1}, Task: {2}, Environment: {3}", Sha, Ref, Task, Environment);
    }
}
