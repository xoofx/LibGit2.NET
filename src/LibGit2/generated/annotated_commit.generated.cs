//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;

namespace LibGit2
{
    using System.Runtime.InteropServices;
    
    public static partial class libgit2
    {
        /// <summary>
        /// Creates a `git_annotated_commit` from the given reference.
        /// The resulting git_annotated_commit must be freed with
        /// `git_annotated_commit_free`.
        /// </summary>
        /// <param name="@out">pointer to store the git_annotated_commit result in</param>
        /// <param name="repo">repository that contains the given reference</param>
        /// <param name="@ref">reference to use to lookup the git_annotated_commit</param>
        /// <returns>0 on success or error code</returns>
        public static git_result git_annotated_commit_from_ref(out git_annotated_commit @out, git_repository repo, git_reference @ref)
        {
            var __result__ = git_annotated_commit_from_ref__(out @out, repo, @ref).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_annotated_commit_from_ref", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_annotated_commit_from_ref__(out git_annotated_commit @out, git_repository repo, git_reference @ref);
        
        /// <summary>
        /// Creates a `git_annotated_commit` from the given fetch head data.
        /// The resulting git_annotated_commit must be freed with
        /// `git_annotated_commit_free`.
        /// </summary>
        /// <param name="@out">pointer to store the git_annotated_commit result in</param>
        /// <param name="repo">repository that contains the given commit</param>
        /// <param name="branch_name">name of the (remote) branch</param>
        /// <param name="remote_url">url of the remote</param>
        /// <param name="id">the commit object id of the remote branch</param>
        /// <returns>0 on success or error code</returns>
        public static git_result git_annotated_commit_from_fetchhead(out git_annotated_commit @out, git_repository repo, [MarshalAs(UnmanagedType.LPUTF8Str)] string branch_name, [MarshalAs(UnmanagedType.LPUTF8Str)] string remote_url, in git_oid id)
        {
            var __result__ = git_annotated_commit_from_fetchhead__(out @out, repo, branch_name, remote_url, id).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_annotated_commit_from_fetchhead", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_annotated_commit_from_fetchhead__(out git_annotated_commit @out, git_repository repo, [MarshalAs(UnmanagedType.LPUTF8Str)] string branch_name, [MarshalAs(UnmanagedType.LPUTF8Str)] string remote_url, in git_oid id);
        
        /// <summary>
        /// Creates a `git_annotated_commit` from the given commit id.
        /// The resulting git_annotated_commit must be freed with
        /// `git_annotated_commit_free`.
        /// </summary>
        /// <param name="@out">pointer to store the git_annotated_commit result in</param>
        /// <param name="repo">repository that contains the given commit</param>
        /// <param name="id">the commit object id to lookup</param>
        /// <returns>0 on success or error code</returns>
        /// <remarks>
        /// An annotated commit contains information about how it was
        /// looked up, which may be useful for functions like merge or
        /// rebase to provide context to the operation.  For example,
        /// conflict files will include the name of the source or target
        /// branches being merged.  It is therefore preferable to use the
        /// most specific function (eg `git_annotated_commit_from_ref`)
        /// instead of this one when that data is known.
        /// </remarks>
        public static git_result git_annotated_commit_lookup(out git_annotated_commit @out, git_repository repo, in git_oid id)
        {
            var __result__ = git_annotated_commit_lookup__(out @out, repo, id).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_annotated_commit_lookup", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_annotated_commit_lookup__(out git_annotated_commit @out, git_repository repo, in git_oid id);
        
        /// <summary>
        /// Creates a `git_annotated_comit` from a revision string.
        /// </summary>
        /// <param name="@out">pointer to store the git_annotated_commit result in</param>
        /// <param name="repo">repository that contains the given commit</param>
        /// <param name="revspec">the extended sha syntax string to use to lookup the commit</param>
        /// <returns>0 on success or error code</returns>
        /// <remarks>
        /// See `man gitrevisions`, or
        /// http://git-scm.com/docs/git-rev-parse.html#_specifying_revisions for
        /// information on the syntax accepted.
        /// </remarks>
        public static git_result git_annotated_commit_from_revspec(out git_annotated_commit @out, git_repository repo, [MarshalAs(UnmanagedType.LPUTF8Str)] string revspec)
        {
            var __result__ = git_annotated_commit_from_revspec__(out @out, repo, revspec).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_annotated_commit_from_revspec", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_annotated_commit_from_revspec__(out git_annotated_commit @out, git_repository repo, [MarshalAs(UnmanagedType.LPUTF8Str)] string revspec);
        
        /// <summary>
        /// Gets the commit ID that the given `git_annotated_commit` refers to.
        /// </summary>
        /// <param name="commit">the given annotated commit</param>
        /// <returns>commit id</returns>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern ref readonly git_oid git_annotated_commit_id(git_annotated_commit commit);
        
        /// <summary>
        /// Get the refname that the given `git_annotated_commit` refers to.
        /// </summary>
        /// <param name="commit">the given annotated commit</param>
        /// <returns>ref name.</returns>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        [return:MarshalAs(UnmanagedType.LPUTF8Str)]
        public static extern string git_annotated_commit_ref(git_annotated_commit commit);
        
        /// <summary>
        /// Frees a `git_annotated_commit`.
        /// </summary>
        /// <param name="commit">annotated commit to free</param>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void git_annotated_commit_free(git_annotated_commit commit);
    }
}
