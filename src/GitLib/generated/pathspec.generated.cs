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
        /// Options controlling how pathspec match should be executed
        /// </summary>
        [Flags]
        public enum git_pathspec_flag_t : int
        {
            GIT_PATHSPEC_DEFAULT = (int)0,
            
            /// <summary>
            /// GIT_PATHSPEC_IGNORE_CASE forces match to ignore case; otherwise
            /// match will use native case sensitivity of platform filesystem
            /// </summary>
            GIT_PATHSPEC_IGNORE_CASE = (int)(1u<<0),
            
            /// <summary>
            /// GIT_PATHSPEC_USE_CASE forces case sensitive match; otherwise
            /// match will use native case sensitivity of platform filesystem
            /// </summary>
            GIT_PATHSPEC_USE_CASE = (int)(1u<<1),
            
            /// <summary>
            /// GIT_PATHSPEC_NO_GLOB disables glob patterns and just uses simple
            /// string comparison for matching
            /// </summary>
            GIT_PATHSPEC_NO_GLOB = (int)(1u<<2),
            
            /// <summary>
            /// GIT_PATHSPEC_NO_MATCH_ERROR means the match functions return error
            /// code GIT_ENOTFOUND if no matches are found; otherwise no matches is
            /// still success (return 0) but `git_pathspec_match_list_entrycount`
            /// will indicate 0 matches.
            /// </summary>
            GIT_PATHSPEC_NO_MATCH_ERROR = (int)(1u<<3),
            
            /// <summary>
            /// GIT_PATHSPEC_FIND_FAILURES means that the `git_pathspec_match_list`
            /// should track which patterns matched which files so that at the end of
            /// the match we can identify patterns that did not match any files.
            /// </summary>
            GIT_PATHSPEC_FIND_FAILURES = (int)(1u<<4),
            
            /// <summary>
            /// GIT_PATHSPEC_FAILURES_ONLY means that the `git_pathspec_match_list`
            /// does not need to keep the actual matching filenames.  Use this to
            /// just test if there were any matches at all or in combination with
            /// GIT_PATHSPEC_FIND_FAILURES to validate a pathspec.
            /// </summary>
            GIT_PATHSPEC_FAILURES_ONLY = (int)(1u<<5),
        }
        
        public const git_pathspec_flag_t GIT_PATHSPEC_DEFAULT = git_pathspec_flag_t.GIT_PATHSPEC_DEFAULT;
        
        /// <summary>
        /// GIT_PATHSPEC_IGNORE_CASE forces match to ignore case; otherwise
        /// match will use native case sensitivity of platform filesystem
        /// </summary>
        public const git_pathspec_flag_t GIT_PATHSPEC_IGNORE_CASE = git_pathspec_flag_t.GIT_PATHSPEC_IGNORE_CASE;
        
        /// <summary>
        /// GIT_PATHSPEC_USE_CASE forces case sensitive match; otherwise
        /// match will use native case sensitivity of platform filesystem
        /// </summary>
        public const git_pathspec_flag_t GIT_PATHSPEC_USE_CASE = git_pathspec_flag_t.GIT_PATHSPEC_USE_CASE;
        
        /// <summary>
        /// GIT_PATHSPEC_NO_GLOB disables glob patterns and just uses simple
        /// string comparison for matching
        /// </summary>
        public const git_pathspec_flag_t GIT_PATHSPEC_NO_GLOB = git_pathspec_flag_t.GIT_PATHSPEC_NO_GLOB;
        
        /// <summary>
        /// GIT_PATHSPEC_NO_MATCH_ERROR means the match functions return error
        /// code GIT_ENOTFOUND if no matches are found; otherwise no matches is
        /// still success (return 0) but `git_pathspec_match_list_entrycount`
        /// will indicate 0 matches.
        /// </summary>
        public const git_pathspec_flag_t GIT_PATHSPEC_NO_MATCH_ERROR = git_pathspec_flag_t.GIT_PATHSPEC_NO_MATCH_ERROR;
        
        /// <summary>
        /// GIT_PATHSPEC_FIND_FAILURES means that the `git_pathspec_match_list`
        /// should track which patterns matched which files so that at the end of
        /// the match we can identify patterns that did not match any files.
        /// </summary>
        public const git_pathspec_flag_t GIT_PATHSPEC_FIND_FAILURES = git_pathspec_flag_t.GIT_PATHSPEC_FIND_FAILURES;
        
        /// <summary>
        /// GIT_PATHSPEC_FAILURES_ONLY means that the `git_pathspec_match_list`
        /// does not need to keep the actual matching filenames.  Use this to
        /// just test if there were any matches at all or in combination with
        /// GIT_PATHSPEC_FIND_FAILURES to validate a pathspec.
        /// </summary>
        public const git_pathspec_flag_t GIT_PATHSPEC_FAILURES_ONLY = git_pathspec_flag_t.GIT_PATHSPEC_FAILURES_ONLY;
        
        /// <summary>
        /// Compiled pathspec
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public readonly partial struct git_pathspec : IEquatable<git_pathspec>
        {
            private readonly IntPtr _handle;
            
            public git_pathspec(IntPtr handle) => _handle = handle;
            
            public IntPtr Handle => _handle;
            
            public bool Equals(git_pathspec other) => _handle.Equals(other._handle);
            
            public override bool Equals(object obj) => obj is git_pathspec other && Equals(other);
            
            public override int GetHashCode() => _handle.GetHashCode();
            
            public override string ToString() => "0x" + (IntPtr.Size == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
            
            public static bool operator ==(git_pathspec left, git_pathspec right) => left.Equals(right);
            
            public static bool operator !=(git_pathspec left, git_pathspec right) => !left.Equals(right);
        }
        
        /// <summary>
        /// List of filenames matching a pathspec
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public readonly partial struct git_pathspec_match_list : IEquatable<git_pathspec_match_list>
        {
            private readonly IntPtr _handle;
            
            public git_pathspec_match_list(IntPtr handle) => _handle = handle;
            
            public IntPtr Handle => _handle;
            
            public bool Equals(git_pathspec_match_list other) => _handle.Equals(other._handle);
            
            public override bool Equals(object obj) => obj is git_pathspec_match_list other && Equals(other);
            
            public override int GetHashCode() => _handle.GetHashCode();
            
            public override string ToString() => "0x" + (IntPtr.Size == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
            
            public static bool operator ==(git_pathspec_match_list left, git_pathspec_match_list right) => left.Equals(right);
            
            public static bool operator !=(git_pathspec_match_list left, git_pathspec_match_list right) => !left.Equals(right);
        }
        
        /// <summary>
        /// Compile a pathspec
        /// </summary>
        /// <param name="out">Output of the compiled pathspec</param>
        /// <param name="pathspec">A git_strarray of the paths to match</param>
        /// <returns>0 on success, 
        /// &lt;
        /// 0 on failure</returns>
        public static git_result git_pathspec_new(out git_pathspec @out, string[] pathspec)
        {
            var pathspec__ = git_strarray.Allocate(pathspec);
            var __result__ = git_pathspec_new__(out @out, in pathspec__);
            pathspec__.Free();
            __result__.Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_pathspec_new", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_pathspec_new__(out git_pathspec @out, in git_strarray pathspec);
        
        /// <summary>
        /// Free a pathspec
        /// </summary>
        /// <param name="ps">The compiled pathspec</param>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void git_pathspec_free(git_pathspec ps);
        
        /// <summary>
        /// Try to match a path against a pathspec
        /// </summary>
        /// <param name="ps">The compiled pathspec</param>
        /// <param name="flags">Combination of git_pathspec_flag_t options to control match</param>
        /// <param name="path">The pathname to attempt to match</param>
        /// <returns>1 is path matches spec, 0 if it does not</returns>
        /// <remarks>
        /// Unlike most of the other pathspec matching functions, this will not
        /// fall back on the native case-sensitivity for your platform.  You must
        /// explicitly pass flags to control case sensitivity or else this will
        /// fall back on being case sensitive.
        /// </remarks>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int git_pathspec_matches_path(git_pathspec ps, uint flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshalerStrict))] string path);
        
        /// <summary>
        /// Match a pathspec against the working directory of a repository.
        /// </summary>
        /// <param name="out">Output list of matches; pass NULL to just get return value</param>
        /// <param name="repo">The repository in which to match; bare repo is an error</param>
        /// <param name="flags">Combination of git_pathspec_flag_t options to control match</param>
        /// <param name="ps">Pathspec to be matched</param>
        /// <returns>0 on success, -1 on error, GIT_ENOTFOUND if no matches and
        /// the GIT_PATHSPEC_NO_MATCH_ERROR flag was given</returns>
        /// <remarks>
        /// This matches the pathspec against the current files in the working
        /// directory of the repository.  It is an error to invoke this on a bare
        /// repo.  This handles git ignores (i.e. ignored files will not be
        /// considered to match the `pathspec` unless the file is tracked in the
        /// index).If `out` is not NULL, this returns a `git_patchspec_match_list`.  That
        /// contains the list of all matched filenames (unless you pass the
        /// `GIT_PATHSPEC_FAILURES_ONLY` flag) and may also contain the list of
        /// pathspecs with no match (if you used the `GIT_PATHSPEC_FIND_FAILURES`
        /// flag).  You must call `git_pathspec_match_list_free()` on this object.
        /// </remarks>
        public static git_result git_pathspec_match_workdir(out git_pathspec_match_list @out, git_repository repo, uint flags, git_pathspec ps)
        {
            var __result__ = git_pathspec_match_workdir__(out @out, repo, flags, ps).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_pathspec_match_workdir", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_pathspec_match_workdir__(out git_pathspec_match_list @out, git_repository repo, uint flags, git_pathspec ps);
        
        /// <summary>
        /// Match a pathspec against entries in an index.
        /// </summary>
        /// <param name="out">Output list of matches; pass NULL to just get return value</param>
        /// <param name="index">The index to match against</param>
        /// <param name="flags">Combination of git_pathspec_flag_t options to control match</param>
        /// <param name="ps">Pathspec to be matched</param>
        /// <returns>0 on success, -1 on error, GIT_ENOTFOUND if no matches and
        /// the GIT_PATHSPEC_NO_MATCH_ERROR flag is used</returns>
        /// <remarks>
        /// This matches the pathspec against the files in the repository index.NOTE: At the moment, the case sensitivity of this match is controlled
        /// by the current case-sensitivity of the index object itself and the
        /// USE_CASE and IGNORE_CASE flags will have no effect.  This behavior will
        /// be corrected in a future release.If `out` is not NULL, this returns a `git_patchspec_match_list`.  That
        /// contains the list of all matched filenames (unless you pass the
        /// `GIT_PATHSPEC_FAILURES_ONLY` flag) and may also contain the list of
        /// pathspecs with no match (if you used the `GIT_PATHSPEC_FIND_FAILURES`
        /// flag).  You must call `git_pathspec_match_list_free()` on this object.
        /// </remarks>
        public static git_result git_pathspec_match_index(out git_pathspec_match_list @out, git_index index, uint flags, git_pathspec ps)
        {
            var __result__ = git_pathspec_match_index__(out @out, index, flags, ps).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_pathspec_match_index", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_pathspec_match_index__(out git_pathspec_match_list @out, git_index index, uint flags, git_pathspec ps);
        
        /// <summary>
        /// Match a pathspec against files in a tree.
        /// </summary>
        /// <param name="out">Output list of matches; pass NULL to just get return value</param>
        /// <param name="tree">The root-level tree to match against</param>
        /// <param name="flags">Combination of git_pathspec_flag_t options to control match</param>
        /// <param name="ps">Pathspec to be matched</param>
        /// <returns>0 on success, -1 on error, GIT_ENOTFOUND if no matches and
        /// the GIT_PATHSPEC_NO_MATCH_ERROR flag is used</returns>
        /// <remarks>
        /// This matches the pathspec against the files in the given tree.If `out` is not NULL, this returns a `git_patchspec_match_list`.  That
        /// contains the list of all matched filenames (unless you pass the
        /// `GIT_PATHSPEC_FAILURES_ONLY` flag) and may also contain the list of
        /// pathspecs with no match (if you used the `GIT_PATHSPEC_FIND_FAILURES`
        /// flag).  You must call `git_pathspec_match_list_free()` on this object.
        /// </remarks>
        public static git_result git_pathspec_match_tree(out git_pathspec_match_list @out, git_tree tree, uint flags, git_pathspec ps)
        {
            var __result__ = git_pathspec_match_tree__(out @out, tree, flags, ps).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_pathspec_match_tree", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_pathspec_match_tree__(out git_pathspec_match_list @out, git_tree tree, uint flags, git_pathspec ps);
        
        /// <summary>
        /// Match a pathspec against files in a diff list.
        /// </summary>
        /// <param name="out">Output list of matches; pass NULL to just get return value</param>
        /// <param name="diff">A generated diff list</param>
        /// <param name="flags">Combination of git_pathspec_flag_t options to control match</param>
        /// <param name="ps">Pathspec to be matched</param>
        /// <returns>0 on success, -1 on error, GIT_ENOTFOUND if no matches and
        /// the GIT_PATHSPEC_NO_MATCH_ERROR flag is used</returns>
        /// <remarks>
        /// This matches the pathspec against the files in the given diff list.If `out` is not NULL, this returns a `git_patchspec_match_list`.  That
        /// contains the list of all matched filenames (unless you pass the
        /// `GIT_PATHSPEC_FAILURES_ONLY` flag) and may also contain the list of
        /// pathspecs with no match (if you used the `GIT_PATHSPEC_FIND_FAILURES`
        /// flag).  You must call `git_pathspec_match_list_free()` on this object.
        /// </remarks>
        public static git_result git_pathspec_match_diff(out git_pathspec_match_list @out, git_diff diff, uint flags, git_pathspec ps)
        {
            var __result__ = git_pathspec_match_diff__(out @out, diff, flags, ps).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_pathspec_match_diff", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_pathspec_match_diff__(out git_pathspec_match_list @out, git_diff diff, uint flags, git_pathspec ps);
        
        /// <summary>
        /// Free memory associates with a git_pathspec_match_list
        /// </summary>
        /// <param name="m">The git_pathspec_match_list to be freed</param>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void git_pathspec_match_list_free(git_pathspec_match_list m);
        
        /// <summary>
        /// Get the number of items in a match list.
        /// </summary>
        /// <param name="m">The git_pathspec_match_list object</param>
        /// <returns>Number of items in match list</returns>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern size_t git_pathspec_match_list_entrycount(git_pathspec_match_list m);
        
        /// <summary>
        /// Get a matching filename by position.
        /// </summary>
        /// <param name="m">The git_pathspec_match_list object</param>
        /// <param name="pos">The index into the list</param>
        /// <returns>The filename of the match</returns>
        /// <remarks>
        /// This routine cannot be used if the match list was generated by
        /// `git_pathspec_match_diff`.  If so, it will always return NULL.
        /// </remarks>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshalerRelaxedNoCleanup))]
        public static extern string git_pathspec_match_list_entry(git_pathspec_match_list m, size_t pos);
        
        /// <summary>
        /// Get a matching diff delta by position.
        /// </summary>
        /// <param name="m">The git_pathspec_match_list object</param>
        /// <param name="pos">The index into the list</param>
        /// <returns>The filename of the match</returns>
        /// <remarks>
        /// This routine can only be used if the match list was generated by
        /// `git_pathspec_match_diff`.  Otherwise it will always return NULL.
        /// </remarks>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ref readonly git_diff_delta git_pathspec_match_list_diff_entry(git_pathspec_match_list m, size_t pos);
        
        /// <summary>
        /// Get the number of pathspec items that did not match.
        /// </summary>
        /// <param name="m">The git_pathspec_match_list object</param>
        /// <returns>Number of items in original pathspec that had no matches</returns>
        /// <remarks>
        /// This will be zero unless you passed GIT_PATHSPEC_FIND_FAILURES when
        /// generating the git_pathspec_match_list.
        /// </remarks>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern size_t git_pathspec_match_list_failed_entrycount(git_pathspec_match_list m);
        
        /// <summary>
        /// Get an original pathspec string that had no matches.
        /// </summary>
        /// <param name="m">The git_pathspec_match_list object</param>
        /// <param name="pos">The index into the failed items</param>
        /// <returns>The pathspec pattern that didn't match anything</returns>
        /// <remarks>
        /// This will be return NULL for positions out of range.
        /// </remarks>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshalerRelaxedNoCleanup))]
        public static extern string git_pathspec_match_list_failed_entry(git_pathspec_match_list m, size_t pos);
    }
}
