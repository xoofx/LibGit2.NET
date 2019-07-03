//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;

namespace GitLib
{
    using System.Runtime.InteropServices;
    
    public static partial class libgit2
    {
        /// <summary>
        /// Checkout behavior flags
        /// </summary>
        /// <remarks>
        /// In libgit2, checkout is used to update the working directory and index
        /// to match a target tree.  Unlike git checkout, it does not move the HEAD
        /// commit for you - use `git_repository_set_head` or the like to do that.Checkout looks at (up to) four things: the "target" tree you want to
        /// check out, the "baseline" tree of what was checked out previously, the
        /// working directory for actual files, and the index for staged changes.You give checkout one of three strategies for update:- `GIT_CHECKOUT_NONE` is a dry-run strategy that checks for conflicts,
        /// etc., but doesn't make any actual changes.- `GIT_CHECKOUT_FORCE` is at the opposite extreme, taking any action to
        /// make the working directory match the target (including potentially
        /// discarding modified files).- `GIT_CHECKOUT_SAFE` is between these two options, it will only make
        /// modifications that will not lose changes.|  target == baseline   |  target != baseline  |
        /// ---------------------|-----------------------|----------------------|
        /// workdir == baseline |       no action       |  create, update, or  |
        /// |                       |     delete file      |
        /// ---------------------|-----------------------|----------------------|
        /// workdir exists and  |       no action       |   conflict (notify   |
        /// is != baseline    | notify dirty MODIFIED | and cancel checkout) |
        /// ---------------------|-----------------------|----------------------|
        /// workdir missing,   | notify dirty DELETED  |     create file      |
        /// baseline present   |                       |                      |
        /// ---------------------|-----------------------|----------------------|To emulate `git checkout`, use `GIT_CHECKOUT_SAFE` with a checkout
        /// notification callback (see below) that displays information about dirty
        /// files.  The default behavior will cancel checkout on conflicts.To emulate `git checkout-index`, use `GIT_CHECKOUT_SAFE` with a
        /// notification callback that cancels the operation if a dirty-but-existing
        /// file is found in the working directory.  This core git command isn't
        /// quite "force" but is sensitive about some types of changes.To emulate `git checkout -f`, use `GIT_CHECKOUT_FORCE`.There are some additional flags to modify the behavior of checkout:- GIT_CHECKOUT_ALLOW_CONFLICTS makes SAFE mode apply safe file updates
        /// even if there are conflicts (instead of cancelling the checkout).- GIT_CHECKOUT_REMOVE_UNTRACKED means remove untracked files (i.e. not
        /// in target, baseline, or index, and not ignored) from the working dir.- GIT_CHECKOUT_REMOVE_IGNORED means remove ignored files (that are also
        /// untracked) from the working directory as well.- GIT_CHECKOUT_UPDATE_ONLY means to only update the content of files that
        /// already exist.  Files will not be created nor deleted.  This just skips
        /// applying adds, deletes, and typechanges.- GIT_CHECKOUT_DONT_UPDATE_INDEX prevents checkout from writing the
        /// updated files' information to the index.- Normally, checkout will reload the index and git attributes from disk
        /// before any operations.  GIT_CHECKOUT_NO_REFRESH prevents this reload.- Unmerged index entries are conflicts.  GIT_CHECKOUT_SKIP_UNMERGED skips
        /// files with unmerged index entries instead.  GIT_CHECKOUT_USE_OURS and
        /// GIT_CHECKOUT_USE_THEIRS to proceed with the checkout using either the
        /// stage 2 ("ours") or stage 3 ("theirs") version of files in the index.- GIT_CHECKOUT_DONT_OVERWRITE_IGNORED prevents ignored files from being
        /// overwritten.  Normally, files that are ignored in the working directory
        /// are not considered "precious" and may be overwritten if the checkout
        /// target contains that file.- GIT_CHECKOUT_DONT_REMOVE_EXISTING prevents checkout from removing
        /// files or folders that fold to the same name on case insensitive
        /// filesystems.  This can cause files to retain their existing names
        /// and write through existing symbolic links.
        /// </remarks>
        [Flags]
        public enum git_checkout_strategy_t : int
        {
            /// <summary>
            /// default is a dry run, no actual updates
            /// </summary>
            GIT_CHECKOUT_NONE = (int)0,
            
            /// <summary>
            /// Allow safe updates that cannot overwrite uncommitted data
            /// </summary>
            GIT_CHECKOUT_SAFE = (int)(1u<<0),
            
            /// <summary>
            /// Allow all updates to force working directory to look like index
            /// </summary>
            GIT_CHECKOUT_FORCE = (int)(1u<<1),
            
            /// <summary>
            /// Allow checkout to recreate missing files
            /// </summary>
            GIT_CHECKOUT_RECREATE_MISSING = (int)(1u<<2),
            
            /// <summary>
            /// Allow checkout to make safe updates even if conflicts are found
            /// </summary>
            GIT_CHECKOUT_ALLOW_CONFLICTS = (int)(1u<<4),
            
            /// <summary>
            /// Remove untracked files not in index (that are not ignored)
            /// </summary>
            GIT_CHECKOUT_REMOVE_UNTRACKED = (int)(1u<<5),
            
            /// <summary>
            /// Remove ignored files not in index
            /// </summary>
            GIT_CHECKOUT_REMOVE_IGNORED = (int)(1u<<6),
            
            /// <summary>
            /// Only update existing files, don't create new ones
            /// </summary>
            GIT_CHECKOUT_UPDATE_ONLY = (int)(1u<<7),
            
            /// <summary>
            /// Normally checkout updates index entries as it goes; this stops that.
            /// Implies `GIT_CHECKOUT_DONT_WRITE_INDEX`.
            /// </summary>
            GIT_CHECKOUT_DONT_UPDATE_INDEX = (int)(1u<<8),
            
            /// <summary>
            /// Don't refresh index/config/etc before doing checkout
            /// </summary>
            GIT_CHECKOUT_NO_REFRESH = (int)(1u<<9),
            
            /// <summary>
            /// Allow checkout to skip unmerged files
            /// </summary>
            GIT_CHECKOUT_SKIP_UNMERGED = (int)(1u<<10),
            
            /// <summary>
            /// For unmerged files, checkout stage 2 from index
            /// </summary>
            GIT_CHECKOUT_USE_OURS = (int)(1u<<11),
            
            /// <summary>
            /// For unmerged files, checkout stage 3 from index
            /// </summary>
            GIT_CHECKOUT_USE_THEIRS = (int)(1u<<12),
            
            /// <summary>
            /// Treat pathspec as simple list of exact match file paths
            /// </summary>
            GIT_CHECKOUT_DISABLE_PATHSPEC_MATCH = (int)(1u<<13),
            
            /// <summary>
            /// Ignore directories in use, they will be left empty
            /// </summary>
            GIT_CHECKOUT_SKIP_LOCKED_DIRECTORIES = (int)(1u<<18),
            
            /// <summary>
            /// Don't overwrite ignored files that exist in the checkout target
            /// </summary>
            GIT_CHECKOUT_DONT_OVERWRITE_IGNORED = (int)(1u<<19),
            
            /// <summary>
            /// Write normal merge files for conflicts
            /// </summary>
            GIT_CHECKOUT_CONFLICT_STYLE_MERGE = (int)(1u<<20),
            
            /// <summary>
            /// Include common ancestor data in diff3 format files for conflicts
            /// </summary>
            GIT_CHECKOUT_CONFLICT_STYLE_DIFF3 = (int)(1u<<21),
            
            /// <summary>
            /// Don't overwrite existing files or folders
            /// </summary>
            GIT_CHECKOUT_DONT_REMOVE_EXISTING = (int)(1u<<22),
            
            /// <summary>
            /// Normally checkout writes the index upon completion; this prevents that.
            /// </summary>
            GIT_CHECKOUT_DONT_WRITE_INDEX = (int)(1u<<23),
            
            /// <summary>
            /// Recursively checkout submodules with same options (NOT IMPLEMENTED)
            /// </summary>
            GIT_CHECKOUT_UPDATE_SUBMODULES = (int)(1u<<16),
            
            /// <summary>
            /// Recursively checkout submodules if HEAD moved in super repo (NOT IMPLEMENTED)
            /// </summary>
            GIT_CHECKOUT_UPDATE_SUBMODULES_IF_CHANGED = (int)(1u<<17),
        }
        
        /// <summary>
        /// default is a dry run, no actual updates
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_NONE = git_checkout_strategy_t.GIT_CHECKOUT_NONE;
        
        /// <summary>
        /// Allow safe updates that cannot overwrite uncommitted data
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_SAFE = git_checkout_strategy_t.GIT_CHECKOUT_SAFE;
        
        /// <summary>
        /// Allow all updates to force working directory to look like index
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_FORCE = git_checkout_strategy_t.GIT_CHECKOUT_FORCE;
        
        /// <summary>
        /// Allow checkout to recreate missing files
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_RECREATE_MISSING = git_checkout_strategy_t.GIT_CHECKOUT_RECREATE_MISSING;
        
        /// <summary>
        /// Allow checkout to make safe updates even if conflicts are found
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_ALLOW_CONFLICTS = git_checkout_strategy_t.GIT_CHECKOUT_ALLOW_CONFLICTS;
        
        /// <summary>
        /// Remove untracked files not in index (that are not ignored)
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_REMOVE_UNTRACKED = git_checkout_strategy_t.GIT_CHECKOUT_REMOVE_UNTRACKED;
        
        /// <summary>
        /// Remove ignored files not in index
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_REMOVE_IGNORED = git_checkout_strategy_t.GIT_CHECKOUT_REMOVE_IGNORED;
        
        /// <summary>
        /// Only update existing files, don't create new ones
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_UPDATE_ONLY = git_checkout_strategy_t.GIT_CHECKOUT_UPDATE_ONLY;
        
        /// <summary>
        /// Normally checkout updates index entries as it goes; this stops that.
        /// Implies `GIT_CHECKOUT_DONT_WRITE_INDEX`.
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_DONT_UPDATE_INDEX = git_checkout_strategy_t.GIT_CHECKOUT_DONT_UPDATE_INDEX;
        
        /// <summary>
        /// Don't refresh index/config/etc before doing checkout
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_NO_REFRESH = git_checkout_strategy_t.GIT_CHECKOUT_NO_REFRESH;
        
        /// <summary>
        /// Allow checkout to skip unmerged files
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_SKIP_UNMERGED = git_checkout_strategy_t.GIT_CHECKOUT_SKIP_UNMERGED;
        
        /// <summary>
        /// For unmerged files, checkout stage 2 from index
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_USE_OURS = git_checkout_strategy_t.GIT_CHECKOUT_USE_OURS;
        
        /// <summary>
        /// For unmerged files, checkout stage 3 from index
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_USE_THEIRS = git_checkout_strategy_t.GIT_CHECKOUT_USE_THEIRS;
        
        /// <summary>
        /// Treat pathspec as simple list of exact match file paths
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_DISABLE_PATHSPEC_MATCH = git_checkout_strategy_t.GIT_CHECKOUT_DISABLE_PATHSPEC_MATCH;
        
        /// <summary>
        /// Ignore directories in use, they will be left empty
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_SKIP_LOCKED_DIRECTORIES = git_checkout_strategy_t.GIT_CHECKOUT_SKIP_LOCKED_DIRECTORIES;
        
        /// <summary>
        /// Don't overwrite ignored files that exist in the checkout target
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_DONT_OVERWRITE_IGNORED = git_checkout_strategy_t.GIT_CHECKOUT_DONT_OVERWRITE_IGNORED;
        
        /// <summary>
        /// Write normal merge files for conflicts
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_CONFLICT_STYLE_MERGE = git_checkout_strategy_t.GIT_CHECKOUT_CONFLICT_STYLE_MERGE;
        
        /// <summary>
        /// Include common ancestor data in diff3 format files for conflicts
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_CONFLICT_STYLE_DIFF3 = git_checkout_strategy_t.GIT_CHECKOUT_CONFLICT_STYLE_DIFF3;
        
        /// <summary>
        /// Don't overwrite existing files or folders
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_DONT_REMOVE_EXISTING = git_checkout_strategy_t.GIT_CHECKOUT_DONT_REMOVE_EXISTING;
        
        /// <summary>
        /// Normally checkout writes the index upon completion; this prevents that.
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_DONT_WRITE_INDEX = git_checkout_strategy_t.GIT_CHECKOUT_DONT_WRITE_INDEX;
        
        /// <summary>
        /// Recursively checkout submodules with same options (NOT IMPLEMENTED)
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_UPDATE_SUBMODULES = git_checkout_strategy_t.GIT_CHECKOUT_UPDATE_SUBMODULES;
        
        /// <summary>
        /// Recursively checkout submodules if HEAD moved in super repo (NOT IMPLEMENTED)
        /// </summary>
        public const git_checkout_strategy_t GIT_CHECKOUT_UPDATE_SUBMODULES_IF_CHANGED = git_checkout_strategy_t.GIT_CHECKOUT_UPDATE_SUBMODULES_IF_CHANGED;
        
        /// <summary>
        /// Checkout notification flags
        /// </summary>
        /// <remarks>
        /// Checkout will invoke an options notification callback (`notify_cb`) for
        /// certain cases - you pick which ones via `notify_flags`:- GIT_CHECKOUT_NOTIFY_CONFLICT invokes checkout on conflicting paths.- GIT_CHECKOUT_NOTIFY_DIRTY notifies about "dirty" files, i.e. those that
        /// do not need an update but no longer match the baseline.  Core git
        /// displays these files when checkout runs, but won't stop the checkout.- GIT_CHECKOUT_NOTIFY_UPDATED sends notification for any file changed.- GIT_CHECKOUT_NOTIFY_UNTRACKED notifies about untracked files.- GIT_CHECKOUT_NOTIFY_IGNORED notifies about ignored files.Returning a non-zero value from this callback will cancel the checkout.
        /// The non-zero return value will be propagated back and returned by the
        /// git_checkout_... call.Notification callbacks are made prior to modifying any files on disk,
        /// so canceling on any notification will still happen prior to any files
        /// being modified.
        /// </remarks>
        [Flags]
        public enum git_checkout_notify_t : int
        {
            GIT_CHECKOUT_NOTIFY_NONE = (int)0,
            
            GIT_CHECKOUT_NOTIFY_CONFLICT = (int)(1u<<0),
            
            GIT_CHECKOUT_NOTIFY_DIRTY = (int)(1u<<1),
            
            GIT_CHECKOUT_NOTIFY_UPDATED = (int)(1u<<2),
            
            GIT_CHECKOUT_NOTIFY_UNTRACKED = (int)(1u<<3),
            
            GIT_CHECKOUT_NOTIFY_IGNORED = (int)(1u<<4),
            
            GIT_CHECKOUT_NOTIFY_ALL = (int)0x0FFFFu,
        }
        
        public const git_checkout_notify_t GIT_CHECKOUT_NOTIFY_NONE = git_checkout_notify_t.GIT_CHECKOUT_NOTIFY_NONE;
        
        public const git_checkout_notify_t GIT_CHECKOUT_NOTIFY_CONFLICT = git_checkout_notify_t.GIT_CHECKOUT_NOTIFY_CONFLICT;
        
        public const git_checkout_notify_t GIT_CHECKOUT_NOTIFY_DIRTY = git_checkout_notify_t.GIT_CHECKOUT_NOTIFY_DIRTY;
        
        public const git_checkout_notify_t GIT_CHECKOUT_NOTIFY_UPDATED = git_checkout_notify_t.GIT_CHECKOUT_NOTIFY_UPDATED;
        
        public const git_checkout_notify_t GIT_CHECKOUT_NOTIFY_UNTRACKED = git_checkout_notify_t.GIT_CHECKOUT_NOTIFY_UNTRACKED;
        
        public const git_checkout_notify_t GIT_CHECKOUT_NOTIFY_IGNORED = git_checkout_notify_t.GIT_CHECKOUT_NOTIFY_IGNORED;
        
        public const git_checkout_notify_t GIT_CHECKOUT_NOTIFY_ALL = git_checkout_notify_t.GIT_CHECKOUT_NOTIFY_ALL;
        
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public partial struct git_checkout_perfdata
        {
            public size_t mkdir_calls;
            
            public size_t stat_calls;
            
            public size_t chmod_calls;
        }
        
        /// <summary>
        /// Checkout options structure
        /// </summary>
        /// <remarks>
        /// Initialize with `GIT_CHECKOUT_OPTIONS_INIT`. Alternatively, you can
        /// use `git_checkout_init_options`.
        /// </remarks>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public partial struct git_checkout_options
        {
            public uint version;
            
            /// <summary>
            /// default will be a safe checkout
            /// </summary>
            public uint checkout_strategy;
            
            /// <summary>
            /// don't apply filters like CRLF conversion
            /// </summary>
            public int disable_filters;
            
            /// <summary>
            /// default is 0755
            /// </summary>
            public uint dir_mode;
            
            /// <summary>
            /// default is 0644 or 0755 as dictated by blob
            /// </summary>
            public uint file_mode;
            
            /// <summary>
            /// default is O_CREAT | O_TRUNC | O_WRONLY
            /// </summary>
            public int file_open_flags;
            
            /// <summary>
            /// see `git_checkout_notify_t` above
            /// </summary>
            public uint notify_flags;
            
            public git_checkout_notify_cb notify_cb;
            
            public IntPtr notify_payload;
            
            /// <summary>
            /// Optional callback to notify the consumer of checkout progress.
            /// </summary>
            public git_checkout_progress_cb progress_cb;
            
            public IntPtr progress_payload;
            
            /// <summary>
            /// When not zeroed out, array of fnmatch patterns specifying which
            /// paths should be taken into account, otherwise all files.  Use
            /// GIT_CHECKOUT_DISABLE_PATHSPEC_MATCH to treat as simple list.
            /// </summary>
            public git_strarray paths;
            
            /// <summary>
            /// The expected content of the working directory; defaults to HEAD.
            /// If the working directory does not match this baseline information,
            /// that will produce a checkout conflict.
            /// </summary>
            public git_tree baseline;
            
            /// <summary>
            /// expected content of workdir, expressed as an index.
            /// </summary>
            public git_index baseline_index;
            
            /// <summary>
            /// alternative checkout path to workdir
            /// </summary>
            [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))]
            public string target_directory;
            
            /// <summary>
            /// the name of the common ancestor side of conflicts
            /// </summary>
            [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))]
            public string ancestor_label;
            
            /// <summary>
            /// the name of the "our" side of conflicts
            /// </summary>
            [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))]
            public string our_label;
            
            /// <summary>
            /// the name of the "their" side of conflicts
            /// </summary>
            [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))]
            public string their_label;
            
            /// <summary>
            /// Optional callback to notify the consumer of performance data.
            /// </summary>
            public git_checkout_perfdata_cb perfdata_cb;
            
            public IntPtr perfdata_payload;
        }
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int git_checkout_notify_cb(git_checkout_notify_t why, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string path, in git_diff_file baseline, in git_diff_file target, in git_diff_file workdir, IntPtr payload);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void git_checkout_progress_cb([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string path, size_t completed_steps, size_t total_steps, IntPtr payload);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void git_checkout_perfdata_cb(in git_checkout_perfdata perfdata, IntPtr payload);
        
        /// <summary>
        /// Initialize git_checkout_options structure
        /// </summary>
        /// <param name="opts">The `git_checkout_options` struct to initialize.</param>
        /// <param name="version">The struct version; pass `GIT_CHECKOUT_OPTIONS_VERSION`.</param>
        /// <returns>Zero on success; -1 on failure.</returns>
        /// <remarks>
        /// Initializes a `git_checkout_options` with default values. Equivalent to creating
        /// an instance with GIT_CHECKOUT_OPTIONS_INIT.
        /// </remarks>
        public static git_result git_checkout_init_options(ref git_checkout_options opts, uint version)
        {
            var __result__ = git_checkout_init_options__(ref opts, version).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_checkout_init_options", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_checkout_init_options__(ref git_checkout_options opts, uint version);
        
        /// <summary>
        /// Updates files in the index and the working tree to match the content of
        /// the commit pointed at by HEAD.
        /// </summary>
        /// <param name="repo">repository to check out (must be non-bare)</param>
        /// <param name="opts">specifies checkout options (may be NULL)</param>
        /// <returns>0 on success, GIT_EUNBORNBRANCH if HEAD points to a non
        /// existing branch, non-zero value returned by `notify_cb`, or
        /// other error code 
        /// &lt;
        /// 0 (use git_error_last for error details)</returns>
        /// <remarks>
        /// Note that this is _not_ the correct mechanism used to switch branches;
        /// do not change your `HEAD` and then call this method, that would leave
        /// you with checkout conflicts since your working directory would then
        /// appear to be dirty.  Instead, checkout the target of the branch and
        /// then update `HEAD` using `git_repository_set_head` to point to the
        /// branch you checked out.
        /// </remarks>
        public static git_result git_checkout_head(git_repository repo, in git_checkout_options opts)
        {
            var __result__ = git_checkout_head__(repo, opts).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_checkout_head", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_checkout_head__(git_repository repo, in git_checkout_options opts);
        
        /// <summary>
        /// Updates files in the working tree to match the content of the index.
        /// </summary>
        /// <param name="repo">repository into which to check out (must be non-bare)</param>
        /// <param name="index">index to be checked out (or NULL to use repository index)</param>
        /// <param name="opts">specifies checkout options (may be NULL)</param>
        /// <returns>0 on success, non-zero return value from `notify_cb`, or error
        /// code 
        /// &lt;
        /// 0 (use git_error_last for error details)</returns>
        public static git_result git_checkout_index(git_repository repo, git_index index, in git_checkout_options opts)
        {
            var __result__ = git_checkout_index__(repo, index, opts).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_checkout_index", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_checkout_index__(git_repository repo, git_index index, in git_checkout_options opts);
        
        /// <summary>
        /// Updates files in the index and working tree to match the content of the
        /// tree pointed at by the treeish.
        /// </summary>
        /// <param name="repo">repository to check out (must be non-bare)</param>
        /// <param name="treeish">a commit, tag or tree which content will be used to update
        /// the working directory (or NULL to use HEAD)</param>
        /// <param name="opts">specifies checkout options (may be NULL)</param>
        /// <returns>0 on success, non-zero return value from `notify_cb`, or error
        /// code 
        /// &lt;
        /// 0 (use git_error_last for error details)</returns>
        public static git_result git_checkout_tree(git_repository repo, git_object treeish, in git_checkout_options opts)
        {
            var __result__ = git_checkout_tree__(repo, treeish, opts).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_checkout_tree", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_checkout_tree__(git_repository repo, git_object treeish, in git_checkout_options opts);
    }
}
