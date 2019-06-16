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
        /// Filters are applied in one of two directions: smudging - which is
        /// exporting a file from the Git object database to the working directory,
        /// and cleaning - which is importing a file from the working directory to
        /// the Git object database.  These values control which direction of
        /// change is being applied.
        /// </summary>
        public enum git_filter_mode_t : int
        {
            GIT_FILTER_TO_WORKTREE = (int)0,
            
            GIT_FILTER_SMUDGE = (int)GIT_FILTER_TO_WORKTREE,
            
            GIT_FILTER_TO_ODB = (int)1,
            
            GIT_FILTER_CLEAN = (int)GIT_FILTER_TO_ODB,
        }
        
        public const git_filter_mode_t GIT_FILTER_TO_WORKTREE = git_filter_mode_t.GIT_FILTER_TO_WORKTREE;
        
        public const git_filter_mode_t GIT_FILTER_SMUDGE = git_filter_mode_t.GIT_FILTER_SMUDGE;
        
        public const git_filter_mode_t GIT_FILTER_TO_ODB = git_filter_mode_t.GIT_FILTER_TO_ODB;
        
        public const git_filter_mode_t GIT_FILTER_CLEAN = git_filter_mode_t.GIT_FILTER_CLEAN;
        
        /// <summary>
        /// Filter option flags.
        /// </summary>
        [Flags]
        public enum git_filter_flag_t : int
        {
            GIT_FILTER_DEFAULT = (int)0u,
            
            GIT_FILTER_ALLOW_UNSAFE = (int)(1u<<0),
        }
        
        public const git_filter_flag_t GIT_FILTER_DEFAULT = git_filter_flag_t.GIT_FILTER_DEFAULT;
        
        public const git_filter_flag_t GIT_FILTER_ALLOW_UNSAFE = git_filter_flag_t.GIT_FILTER_ALLOW_UNSAFE;
        
        /// <summary>
        /// A filter that can transform file data
        /// </summary>
        /// <remarks>
        /// This represents a filter that can be used to transform or even replace
        /// file data.  Libgit2 includes one built in filter and it is possible to
        /// write your own (see git2/sys/filter.h for information on that).The two builtin filters are:* "crlf" which uses the complex rules with the "text", "eol", and
        /// "crlf" file attributes to decide how to convert between LF and CRLF
        /// line endings
        /// * "ident" which replaces "$Id$" in a blob with "$Id: 
        /// &lt;blob
        /// OID&gt;$" upon
        /// checkout and replaced "$Id: 
        /// &lt;anything
        /// &gt;$" with "$Id$" on checkin.
        /// </remarks>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public readonly partial struct git_filter : IEquatable<git_filter>
        {
            private readonly IntPtr _handle;
            
            public git_filter(IntPtr handle) => _handle = handle;
            
            public IntPtr Handle => _handle;
            
            public bool Equals(git_filter other) => _handle.Equals(other._handle);
            
            public override bool Equals(object obj) => obj is git_filter other && Equals(other);
            
            public override int GetHashCode() => _handle.GetHashCode();
            
            public override string ToString() => "0x" + (IntPtr.Size == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
            
            public static bool operator ==(git_filter left, git_filter right) => left.Equals(right);
            
            public static bool operator !=(git_filter left, git_filter right) => !left.Equals(right);
        }
        
        /// <summary>
        /// List of filters to be applied
        /// </summary>
        /// <remarks>
        /// This represents a list of filters to be applied to a file / blob.  You
        /// can build the list with one call, apply it with another, and dispose it
        /// with a third.  In typical usage, there are not many occasions where a
        /// git_filter_list is needed directly since the library will generally
        /// handle conversions for you, but it can be convenient to be able to
        /// build and apply the list sometimes.
        /// </remarks>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public readonly partial struct git_filter_list : IEquatable<git_filter_list>
        {
            private readonly IntPtr _handle;
            
            public git_filter_list(IntPtr handle) => _handle = handle;
            
            public IntPtr Handle => _handle;
            
            public bool Equals(git_filter_list other) => _handle.Equals(other._handle);
            
            public override bool Equals(object obj) => obj is git_filter_list other && Equals(other);
            
            public override int GetHashCode() => _handle.GetHashCode();
            
            public override string ToString() => "0x" + (IntPtr.Size == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
            
            public static bool operator ==(git_filter_list left, git_filter_list right) => left.Equals(right);
            
            public static bool operator !=(git_filter_list left, git_filter_list right) => !left.Equals(right);
        }
        
        /// <summary>
        /// Load the filter list for a given path.
        /// </summary>
        /// <param name="filters">Output newly created git_filter_list (or NULL)</param>
        /// <param name="repo">Repository object that contains `path`</param>
        /// <param name="blob">The blob to which the filter will be applied (if known)</param>
        /// <param name="path">Relative path of the file to be filtered</param>
        /// <param name="mode">Filtering direction (WT-&gt;ODB or ODB-&gt;WT)</param>
        /// <param name="flags">Combination of `git_filter_flag_t` flags</param>
        /// <returns>0 on success (which could still return NULL if no filters are
        /// needed for the requested file), 
        /// &lt;
        /// 0 on error</returns>
        /// <remarks>
        /// This will return 0 (success) but set the output git_filter_list to NULL
        /// if no filters are requested for the given file.
        /// </remarks>
        public static git_result git_filter_list_load(out git_filter_list filters, git_repository repo, git_blob blob, [MarshalAs(UnmanagedType.LPUTF8Str)] string path, git_filter_mode_t mode, uint flags)
        {
            var __result__ = git_filter_list_load__(out filters, repo, blob, path, mode, flags).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_filter_list_load", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_filter_list_load__(out git_filter_list filters, git_repository repo, git_blob blob, [MarshalAs(UnmanagedType.LPUTF8Str)] string path, git_filter_mode_t mode, uint flags);
        
        /// <summary>
        /// Query the filter list to see if a given filter (by name) will run.
        /// The built-in filters "crlf" and "ident" can be queried, otherwise this
        /// is the name of the filter specified by the filter attribute.
        /// </summary>
        /// <param name="filters">A loaded git_filter_list (or NULL)</param>
        /// <param name="name">The name of the filter to query</param>
        /// <returns>1 if the filter is in the list, 0 otherwise</returns>
        /// <remarks>
        /// This will return 0 if the given filter is not in the list, or 1 if
        /// the filter will be applied.
        /// </remarks>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern int git_filter_list_contains(git_filter_list filters, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);
        
        /// <summary>
        /// Apply filter list to a data buffer.
        /// </summary>
        /// <param name="out">Buffer to store the result of the filtering</param>
        /// <param name="filters">A loaded git_filter_list (or NULL)</param>
        /// <param name="in">Buffer containing the data to filter</param>
        /// <returns>0 on success, an error code otherwise</returns>
        /// <remarks>
        /// See `git2/buffer.h` for background on `git_buf` objects.If the `in` buffer holds data allocated by libgit2 (i.e. `in-&gt;asize` is
        /// not zero), then it will be overwritten when applying the filters.  If
        /// not, then it will be left untouched.If there are no filters to apply (or `filters` is NULL), then the `out`
        /// buffer will reference the `in` buffer data (with `asize` set to zero)
        /// instead of allocating data.  This keeps allocations to a minimum, but
        /// it means you have to be careful about freeing the `in` data since `out`
        /// may be pointing to it!
        /// </remarks>
        public static git_result git_filter_list_apply_to_data(out git_buf @out, git_filter_list filters, ref git_buf @in)
        {
            var __result__ = git_filter_list_apply_to_data__(out @out, filters, ref @in).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_filter_list_apply_to_data", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_filter_list_apply_to_data__(out git_buf @out, git_filter_list filters, ref git_buf @in);
        
        /// <summary>
        /// Apply a filter list to the contents of a file on disk
        /// </summary>
        /// <param name="out">buffer into which to store the filtered file</param>
        /// <param name="filters">the list of filters to apply</param>
        /// <param name="repo">the repository in which to perform the filtering</param>
        /// <param name="path">the path of the file to filter, a relative path will be
        /// taken as relative to the workdir</param>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern int git_filter_list_apply_to_file(out git_buf @out, git_filter_list filters, git_repository repo, [MarshalAs(UnmanagedType.LPUTF8Str)] string path);
        
        /// <summary>
        /// Apply a filter list to the contents of a blob
        /// </summary>
        /// <param name="out">buffer into which to store the filtered file</param>
        /// <param name="filters">the list of filters to apply</param>
        /// <param name="blob">the blob to filter</param>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern int git_filter_list_apply_to_blob(out git_buf @out, git_filter_list filters, git_blob blob);
        
        /// <summary>
        /// Apply a filter list to an arbitrary buffer as a stream
        /// </summary>
        /// <param name="filters">the list of filters to apply</param>
        /// <param name="data">the buffer to filter</param>
        /// <param name="target">the stream into which the data will be written</param>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern int git_filter_list_stream_data(git_filter_list filters, ref git_buf data, ref git_writestream target);
        
        /// <summary>
        /// Apply a filter list to a file as a stream
        /// </summary>
        /// <param name="filters">the list of filters to apply</param>
        /// <param name="repo">the repository in which to perform the filtering</param>
        /// <param name="path">the path of the file to filter, a relative path will be
        /// taken as relative to the workdir</param>
        /// <param name="target">the stream into which the data will be written</param>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern int git_filter_list_stream_file(git_filter_list filters, git_repository repo, [MarshalAs(UnmanagedType.LPUTF8Str)] string path, ref git_writestream target);
        
        /// <summary>
        /// Apply a filter list to a blob as a stream
        /// </summary>
        /// <param name="filters">the list of filters to apply</param>
        /// <param name="blob">the blob to filter</param>
        /// <param name="target">the stream into which the data will be written</param>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern int git_filter_list_stream_blob(git_filter_list filters, git_blob blob, ref git_writestream target);
        
        /// <summary>
        /// Free a git_filter_list
        /// </summary>
        /// <param name="filters">A git_filter_list created by `git_filter_list_load`</param>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void git_filter_list_free(git_filter_list filters);
    }
}
