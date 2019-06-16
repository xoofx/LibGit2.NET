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
        /// Status flags for a single file.
        /// </summary>
        /// <remarks>
        /// A combination of these values will be returned to indicate the status of
        /// a file.  Status compares the working directory, the index, and the
        /// current HEAD of the repository.  The `GIT_STATUS_INDEX` set of flags
        /// represents the status of file in the index relative to the HEAD, and the
        /// `GIT_STATUS_WT` set of flags represent the status of the file in the
        /// working directory relative to the index.
        /// </remarks>
        [Flags]
        public enum git_status_t : int
        {
            GIT_STATUS_CURRENT = (int)0,
            
            GIT_STATUS_INDEX_NEW = (int)(1u<<0),
            
            GIT_STATUS_INDEX_MODIFIED = (int)(1u<<1),
            
            GIT_STATUS_INDEX_DELETED = (int)(1u<<2),
            
            GIT_STATUS_INDEX_RENAMED = (int)(1u<<3),
            
            GIT_STATUS_INDEX_TYPECHANGE = (int)(1u<<4),
            
            GIT_STATUS_WT_NEW = (int)(1u<<7),
            
            GIT_STATUS_WT_MODIFIED = (int)(1u<<8),
            
            GIT_STATUS_WT_DELETED = (int)(1u<<9),
            
            GIT_STATUS_WT_TYPECHANGE = (int)(1u<<10),
            
            GIT_STATUS_WT_RENAMED = (int)(1u<<11),
            
            GIT_STATUS_WT_UNREADABLE = (int)(1u<<12),
            
            GIT_STATUS_IGNORED = (int)(1u<<14),
            
            GIT_STATUS_CONFLICTED = (int)(1u<<15),
        }
        
        public const git_status_t GIT_STATUS_CURRENT = git_status_t.GIT_STATUS_CURRENT;
        
        public const git_status_t GIT_STATUS_INDEX_NEW = git_status_t.GIT_STATUS_INDEX_NEW;
        
        public const git_status_t GIT_STATUS_INDEX_MODIFIED = git_status_t.GIT_STATUS_INDEX_MODIFIED;
        
        public const git_status_t GIT_STATUS_INDEX_DELETED = git_status_t.GIT_STATUS_INDEX_DELETED;
        
        public const git_status_t GIT_STATUS_INDEX_RENAMED = git_status_t.GIT_STATUS_INDEX_RENAMED;
        
        public const git_status_t GIT_STATUS_INDEX_TYPECHANGE = git_status_t.GIT_STATUS_INDEX_TYPECHANGE;
        
        public const git_status_t GIT_STATUS_WT_NEW = git_status_t.GIT_STATUS_WT_NEW;
        
        public const git_status_t GIT_STATUS_WT_MODIFIED = git_status_t.GIT_STATUS_WT_MODIFIED;
        
        public const git_status_t GIT_STATUS_WT_DELETED = git_status_t.GIT_STATUS_WT_DELETED;
        
        public const git_status_t GIT_STATUS_WT_TYPECHANGE = git_status_t.GIT_STATUS_WT_TYPECHANGE;
        
        public const git_status_t GIT_STATUS_WT_RENAMED = git_status_t.GIT_STATUS_WT_RENAMED;
        
        public const git_status_t GIT_STATUS_WT_UNREADABLE = git_status_t.GIT_STATUS_WT_UNREADABLE;
        
        public const git_status_t GIT_STATUS_IGNORED = git_status_t.GIT_STATUS_IGNORED;
        
        public const git_status_t GIT_STATUS_CONFLICTED = git_status_t.GIT_STATUS_CONFLICTED;
        
        /// <summary>
        /// Select the files on which to report status.
        /// </summary>
        /// <remarks>
        /// With `git_status_foreach_ext`, this will control which changes get
        /// callbacks.  With `git_status_list_new`, these will control which
        /// changes are included in the list.- GIT_STATUS_SHOW_INDEX_AND_WORKDIR is the default.  This roughly
        /// matches `git status --porcelain` regarding which files are
        /// included and in what order.
        /// - GIT_STATUS_SHOW_INDEX_ONLY only gives status based on HEAD to index
        /// comparison, not looking at working directory changes.
        /// - GIT_STATUS_SHOW_WORKDIR_ONLY only gives status based on index to
        /// working directory comparison, not comparing the index to the HEAD.
        /// </remarks>
        public enum git_status_show_t : int
        {
            GIT_STATUS_SHOW_INDEX_AND_WORKDIR = (int)0,
            
            GIT_STATUS_SHOW_INDEX_ONLY = (int)1,
            
            GIT_STATUS_SHOW_WORKDIR_ONLY = (int)2,
        }
        
        public const git_status_show_t GIT_STATUS_SHOW_INDEX_AND_WORKDIR = git_status_show_t.GIT_STATUS_SHOW_INDEX_AND_WORKDIR;
        
        public const git_status_show_t GIT_STATUS_SHOW_INDEX_ONLY = git_status_show_t.GIT_STATUS_SHOW_INDEX_ONLY;
        
        public const git_status_show_t GIT_STATUS_SHOW_WORKDIR_ONLY = git_status_show_t.GIT_STATUS_SHOW_WORKDIR_ONLY;
        
        /// <summary>
        /// Flags to control status callbacks
        /// </summary>
        /// <remarks>
        /// - GIT_STATUS_OPT_INCLUDE_UNTRACKED says that callbacks should be made
        /// on untracked files.  These will only be made if the workdir files are
        /// included in the status "show" option.
        /// - GIT_STATUS_OPT_INCLUDE_IGNORED says that ignored files get callbacks.
        /// Again, these callbacks will only be made if the workdir files are
        /// included in the status "show" option.
        /// - GIT_STATUS_OPT_INCLUDE_UNMODIFIED indicates that callback should be
        /// made even on unmodified files.
        /// - GIT_STATUS_OPT_EXCLUDE_SUBMODULES indicates that submodules should be
        /// skipped.  This only applies if there are no pending typechanges to
        /// the submodule (either from or to another type).
        /// - GIT_STATUS_OPT_RECURSE_UNTRACKED_DIRS indicates that all files in
        /// untracked directories should be included.  Normally if an entire
        /// directory is new, then just the top-level directory is included (with
        /// a trailing slash on the entry name).  This flag says to include all
        /// of the individual files in the directory instead.
        /// - GIT_STATUS_OPT_DISABLE_PATHSPEC_MATCH indicates that the given path
        /// should be treated as a literal path, and not as a pathspec pattern.
        /// - GIT_STATUS_OPT_RECURSE_IGNORED_DIRS indicates that the contents of
        /// ignored directories should be included in the status.  This is like
        /// doing `git ls-files -o -i --exclude-standard` with core git.
        /// - GIT_STATUS_OPT_RENAMES_HEAD_TO_INDEX indicates that rename detection
        /// should be processed between the head and the index and enables
        /// the GIT_STATUS_INDEX_RENAMED as a possible status flag.
        /// - GIT_STATUS_OPT_RENAMES_INDEX_TO_WORKDIR indicates that rename
        /// detection should be run between the index and the working directory
        /// and enabled GIT_STATUS_WT_RENAMED as a possible status flag.
        /// - GIT_STATUS_OPT_SORT_CASE_SENSITIVELY overrides the native case
        /// sensitivity for the file system and forces the output to be in
        /// case-sensitive order
        /// - GIT_STATUS_OPT_SORT_CASE_INSENSITIVELY overrides the native case
        /// sensitivity for the file system and forces the output to be in
        /// case-insensitive order
        /// - GIT_STATUS_OPT_RENAMES_FROM_REWRITES indicates that rename detection
        /// should include rewritten files
        /// - GIT_STATUS_OPT_NO_REFRESH bypasses the default status behavior of
        /// doing a "soft" index reload (i.e. reloading the index data if the
        /// file on disk has been modified outside libgit2).
        /// - GIT_STATUS_OPT_UPDATE_INDEX tells libgit2 to refresh the stat cache
        /// in the index for files that are unchanged but have out of date stat
        /// information in the index.  It will result in less work being done on
        /// subsequent calls to get status.  This is mutually exclusive with the
        /// NO_REFRESH option.Calling `git_status_foreach()` is like calling the extended version
        /// with: GIT_STATUS_OPT_INCLUDE_IGNORED, GIT_STATUS_OPT_INCLUDE_UNTRACKED,
        /// and GIT_STATUS_OPT_RECURSE_UNTRACKED_DIRS.  Those options are bundled
        /// together as `GIT_STATUS_OPT_DEFAULTS` if you want them as a baseline.
        /// </remarks>
        [Flags]
        public enum git_status_opt_t : int
        {
            GIT_STATUS_OPT_INCLUDE_UNTRACKED = (int)(1u<<0),
            
            GIT_STATUS_OPT_INCLUDE_IGNORED = (int)(1u<<1),
            
            GIT_STATUS_OPT_INCLUDE_UNMODIFIED = (int)(1u<<2),
            
            GIT_STATUS_OPT_EXCLUDE_SUBMODULES = (int)(1u<<3),
            
            GIT_STATUS_OPT_RECURSE_UNTRACKED_DIRS = (int)(1u<<4),
            
            GIT_STATUS_OPT_DISABLE_PATHSPEC_MATCH = (int)(1u<<5),
            
            GIT_STATUS_OPT_RECURSE_IGNORED_DIRS = (int)(1u<<6),
            
            GIT_STATUS_OPT_RENAMES_HEAD_TO_INDEX = (int)(1u<<7),
            
            GIT_STATUS_OPT_RENAMES_INDEX_TO_WORKDIR = (int)(1u<<8),
            
            GIT_STATUS_OPT_SORT_CASE_SENSITIVELY = (int)(1u<<9),
            
            GIT_STATUS_OPT_SORT_CASE_INSENSITIVELY = (int)(1u<<10),
            
            GIT_STATUS_OPT_RENAMES_FROM_REWRITES = (int)(1u<<11),
            
            GIT_STATUS_OPT_NO_REFRESH = (int)(1u<<12),
            
            GIT_STATUS_OPT_UPDATE_INDEX = (int)(1u<<13),
            
            GIT_STATUS_OPT_INCLUDE_UNREADABLE = (int)(1u<<14),
            
            GIT_STATUS_OPT_INCLUDE_UNREADABLE_AS_UNTRACKED = (int)(1u<<15),
        }
        
        public const git_status_opt_t GIT_STATUS_OPT_INCLUDE_UNTRACKED = git_status_opt_t.GIT_STATUS_OPT_INCLUDE_UNTRACKED;
        
        public const git_status_opt_t GIT_STATUS_OPT_INCLUDE_IGNORED = git_status_opt_t.GIT_STATUS_OPT_INCLUDE_IGNORED;
        
        public const git_status_opt_t GIT_STATUS_OPT_INCLUDE_UNMODIFIED = git_status_opt_t.GIT_STATUS_OPT_INCLUDE_UNMODIFIED;
        
        public const git_status_opt_t GIT_STATUS_OPT_EXCLUDE_SUBMODULES = git_status_opt_t.GIT_STATUS_OPT_EXCLUDE_SUBMODULES;
        
        public const git_status_opt_t GIT_STATUS_OPT_RECURSE_UNTRACKED_DIRS = git_status_opt_t.GIT_STATUS_OPT_RECURSE_UNTRACKED_DIRS;
        
        public const git_status_opt_t GIT_STATUS_OPT_DISABLE_PATHSPEC_MATCH = git_status_opt_t.GIT_STATUS_OPT_DISABLE_PATHSPEC_MATCH;
        
        public const git_status_opt_t GIT_STATUS_OPT_RECURSE_IGNORED_DIRS = git_status_opt_t.GIT_STATUS_OPT_RECURSE_IGNORED_DIRS;
        
        public const git_status_opt_t GIT_STATUS_OPT_RENAMES_HEAD_TO_INDEX = git_status_opt_t.GIT_STATUS_OPT_RENAMES_HEAD_TO_INDEX;
        
        public const git_status_opt_t GIT_STATUS_OPT_RENAMES_INDEX_TO_WORKDIR = git_status_opt_t.GIT_STATUS_OPT_RENAMES_INDEX_TO_WORKDIR;
        
        public const git_status_opt_t GIT_STATUS_OPT_SORT_CASE_SENSITIVELY = git_status_opt_t.GIT_STATUS_OPT_SORT_CASE_SENSITIVELY;
        
        public const git_status_opt_t GIT_STATUS_OPT_SORT_CASE_INSENSITIVELY = git_status_opt_t.GIT_STATUS_OPT_SORT_CASE_INSENSITIVELY;
        
        public const git_status_opt_t GIT_STATUS_OPT_RENAMES_FROM_REWRITES = git_status_opt_t.GIT_STATUS_OPT_RENAMES_FROM_REWRITES;
        
        public const git_status_opt_t GIT_STATUS_OPT_NO_REFRESH = git_status_opt_t.GIT_STATUS_OPT_NO_REFRESH;
        
        public const git_status_opt_t GIT_STATUS_OPT_UPDATE_INDEX = git_status_opt_t.GIT_STATUS_OPT_UPDATE_INDEX;
        
        public const git_status_opt_t GIT_STATUS_OPT_INCLUDE_UNREADABLE = git_status_opt_t.GIT_STATUS_OPT_INCLUDE_UNREADABLE;
        
        public const git_status_opt_t GIT_STATUS_OPT_INCLUDE_UNREADABLE_AS_UNTRACKED = git_status_opt_t.GIT_STATUS_OPT_INCLUDE_UNREADABLE_AS_UNTRACKED;
        
        /// <summary>
        /// Options to control how `git_status_foreach_ext()` will issue callbacks.
        /// </summary>
        /// <remarks>
        /// This structure is set so that zeroing it out will give you relatively
        /// sane defaults.The `show` value is one of the `git_status_show_t` constants that
        /// control which files to scan and in what order.The `flags` value is an OR'ed combination of the `git_status_opt_t`
        /// values above.The `pathspec` is an array of path patterns to match (using
        /// fnmatch-style matching), or just an array of paths to match exactly if
        /// `GIT_STATUS_OPT_DISABLE_PATHSPEC_MATCH` is specified in the flags.The `baseline` is the tree to be used for comparison to the working directory
        /// and index; defaults to HEAD.
        /// </remarks>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public partial struct git_status_options
        {
            public uint version;
            
            public git_status_show_t show;
            
            public uint flags;
            
            public git_strarray pathspec;
            
            public git_tree baseline;
        }
        
        /// <summary>
        /// A status entry, providing the differences between the file as it exists
        /// in HEAD and the index, and providing the differences between the index
        /// and the working directory.
        /// </summary>
        /// <remarks>
        /// The `status` value provides the status flags for this file.The `head_to_index` value provides detailed information about the
        /// differences between the file in HEAD and the file in the index.The `index_to_workdir` value provides detailed information about the
        /// differences between the file in the index and the file in the
        /// working directory.
        /// </remarks>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public partial struct git_status_entry
        {
            public git_status_t status;
            
            public IntPtr head_to_index;
            
            public IntPtr index_to_workdir;
        }
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int git_status_cb([MarshalAs(UnmanagedType.LPUTF8Str)] string path, uint status_flags, IntPtr payload);
        
        /// <summary>
        /// Initialize git_status_options structure
        /// </summary>
        /// <param name="opts">The `git_status_options` struct to initialize.</param>
        /// <param name="version">The struct version; pass `GIT_STATUS_OPTIONS_VERSION`.</param>
        /// <returns>Zero on success; -1 on failure.</returns>
        /// <remarks>
        /// Initializes a `git_status_options` with default values. Equivalent to
        /// creating an instance with `GIT_STATUS_OPTIONS_INIT`.
        /// </remarks>
        public static git_result git_status_init_options(ref git_status_options opts, uint version)
        {
            var __result__ = git_status_init_options__(ref opts, version).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_status_init_options", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_status_init_options__(ref git_status_options opts, uint version);
        
        /// <summary>
        /// Gather file statuses and run a callback for each one.
        /// </summary>
        /// <param name="repo">A repository object</param>
        /// <param name="callback">The function to call on each file</param>
        /// <param name="payload">Pointer to pass through to callback function</param>
        /// <returns>0 on success, non-zero callback return value, or error code</returns>
        /// <remarks>
        /// The callback is passed the path of the file, the status (a combination of
        /// the `git_status_t` values above) and the `payload` data pointer passed
        /// into this function.If the callback returns a non-zero value, this function will stop looping
        /// and return that value to caller.
        /// </remarks>
        public static git_result git_status_foreach(git_repository repo, git_status_cb callback, IntPtr payload)
        {
            var __result__ = git_status_foreach__(repo, callback, payload).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_status_foreach", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_status_foreach__(git_repository repo, git_status_cb callback, IntPtr payload);
        
        /// <summary>
        /// Gather file status information and run callbacks as requested.
        /// </summary>
        /// <param name="repo">Repository object</param>
        /// <param name="opts">Status options structure</param>
        /// <param name="callback">The function to call on each file</param>
        /// <param name="payload">Pointer to pass through to callback function</param>
        /// <returns>0 on success, non-zero callback return value, or error code</returns>
        /// <remarks>
        /// This is an extended version of the `git_status_foreach()` API that
        /// allows for more granular control over which paths will be processed and
        /// in what order.  See the `git_status_options` structure for details
        /// about the additional controls that this makes available.Note that if a `pathspec` is given in the `git_status_options` to filter
        /// the status, then the results from rename detection (if you enable it) may
        /// not be accurate.  To do rename detection properly, this must be called
        /// with no `pathspec` so that all files can be considered.
        /// </remarks>
        public static git_result git_status_foreach_ext(git_repository repo, in git_status_options opts, git_status_cb callback, IntPtr payload)
        {
            var __result__ = git_status_foreach_ext__(repo, opts, callback, payload).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_status_foreach_ext", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_status_foreach_ext__(git_repository repo, in git_status_options opts, git_status_cb callback, IntPtr payload);
        
        /// <summary>
        /// Get file status for a single file.
        /// </summary>
        /// <param name="status_flags">Output combination of git_status_t values for file</param>
        /// <param name="repo">A repository object</param>
        /// <param name="path">The exact path to retrieve status for relative to the
        /// repository working directory</param>
        /// <returns>0 on success, GIT_ENOTFOUND if the file is not found in the HEAD,
        /// index, and work tree, GIT_EAMBIGUOUS if `path` matches multiple files
        /// or if it refers to a folder, and -1 on other errors.</returns>
        /// <remarks>
        /// This tries to get status for the filename that you give.  If no files
        /// match that name (in either the HEAD, index, or working directory), this
        /// returns GIT_ENOTFOUND.If the name matches multiple files (for example, if the `path` names a
        /// directory or if running on a case- insensitive filesystem and yet the
        /// HEAD has two entries that both match the path), then this returns
        /// GIT_EAMBIGUOUS because it cannot give correct results.This does not do any sort of rename detection.  Renames require a set of
        /// targets and because of the path filtering, there is not enough
        /// information to check renames correctly.  To check file status with rename
        /// detection, there is no choice but to do a full `git_status_list_new` and
        /// scan through looking for the path that you are interested in.
        /// </remarks>
        public static git_result git_status_file(ref uint status_flags, git_repository repo, [MarshalAs(UnmanagedType.LPUTF8Str)] string path)
        {
            var __result__ = git_status_file__(ref status_flags, repo, path).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_status_file", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_status_file__(ref uint status_flags, git_repository repo, [MarshalAs(UnmanagedType.LPUTF8Str)] string path);
        
        /// <summary>
        /// Gather file status information and populate the `git_status_list`.
        /// </summary>
        /// <param name="@out">Pointer to store the status results in</param>
        /// <param name="repo">Repository object</param>
        /// <param name="opts">Status options structure</param>
        /// <returns>0 on success or error code</returns>
        /// <remarks>
        /// Note that if a `pathspec` is given in the `git_status_options` to filter
        /// the status, then the results from rename detection (if you enable it) may
        /// not be accurate.  To do rename detection properly, this must be called
        /// with no `pathspec` so that all files can be considered.
        /// </remarks>
        public static git_result git_status_list_new(out git_status_list @out, git_repository repo, in git_status_options opts)
        {
            var __result__ = git_status_list_new__(out @out, repo, opts).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_status_list_new", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_status_list_new__(out git_status_list @out, git_repository repo, in git_status_options opts);
        
        /// <summary>
        /// Gets the count of status entries in this list.
        /// </summary>
        /// <param name="statuslist">Existing status list object</param>
        /// <returns>the number of status entries</returns>
        /// <remarks>
        /// If there are no changes in status (at least according the options given
        /// when the status list was created), this can return 0.
        /// </remarks>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern size_t git_status_list_entrycount(git_status_list statuslist);
        
        /// <summary>
        /// Get a pointer to one of the entries in the status list.
        /// </summary>
        /// <param name="statuslist">Existing status list object</param>
        /// <param name="idx">Position of the entry</param>
        /// <returns>Pointer to the entry; NULL if out of bounds</returns>
        /// <remarks>
        /// The entry is not modifiable and should not be freed.
        /// </remarks>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern ref readonly git_status_entry git_status_byindex(git_status_list statuslist, size_t idx);
        
        /// <summary>
        /// Free an existing status list
        /// </summary>
        /// <param name="statuslist">Existing status list object</param>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void git_status_list_free(git_status_list statuslist);
        
        /// <summary>
        /// Test if the ignore rules apply to a given file.
        /// </summary>
        /// <param name="ignored">Boolean returning 0 if the file is not ignored, 1 if it is</param>
        /// <param name="repo">A repository object</param>
        /// <param name="path">The file to check ignores for, rooted at the repo's workdir.</param>
        /// <returns>0 if ignore rules could be processed for the file (regardless
        /// of whether it exists or not), or an error 
        /// &lt;
        /// 0 if they could not.</returns>
        /// <remarks>
        /// This function checks the ignore rules to see if they would apply to the
        /// given file.  This indicates if the file would be ignored regardless of
        /// whether the file is already in the index or committed to the repository.One way to think of this is if you were to do "git add ." on the
        /// directory containing the file, would it be added or not?
        /// </remarks>
        public static git_result git_status_should_ignore(ref int ignored, git_repository repo, [MarshalAs(UnmanagedType.LPUTF8Str)] string path)
        {
            var __result__ = git_status_should_ignore__(ref ignored, repo, path).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_status_should_ignore", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_status_should_ignore__(ref int ignored, git_repository repo, [MarshalAs(UnmanagedType.LPUTF8Str)] string path);
    }
}
