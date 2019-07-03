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
        /// Flags for indicating option behavior for git_blame APIs.
        /// </summary>
        [Flags]
        public enum git_blame_flag_t : int
        {
            /// <summary>
            /// Normal blame, the default
            /// </summary>
            GIT_BLAME_NORMAL = (int)0,
            
            /// <summary>
            /// Track lines that have moved within a file (like `git blame -M`).
            /// NOT IMPLEMENTED.
            /// </summary>
            GIT_BLAME_TRACK_COPIES_SAME_FILE = (int)(1 << 0),
            
            /// <summary>
            /// Track lines that have moved across files in the same commit (like `git blame -C`).
            /// NOT IMPLEMENTED.
            /// </summary>
            GIT_BLAME_TRACK_COPIES_SAME_COMMIT_MOVES = (int)(1 << 1),
            
            /// <summary>
            /// Track lines that have been copied from another file that exists in the
            /// same commit (like `git blame -CC`). Implies SAME_FILE.
            /// NOT IMPLEMENTED.
            /// </summary>
            GIT_BLAME_TRACK_COPIES_SAME_COMMIT_COPIES = (int)(1 << 2),
            
            /// <summary>
            /// Track lines that have been copied from another file that exists in *any*
            /// commit (like `git blame -CCC`). Implies SAME_COMMIT_COPIES.
            /// NOT IMPLEMENTED.
            /// </summary>
            GIT_BLAME_TRACK_COPIES_ANY_COMMIT_COPIES = (int)(1 << 3),
            
            /// <summary>
            /// Restrict the search of commits to those reachable following only the
            /// first parents.
            /// </summary>
            GIT_BLAME_FIRST_PARENT = (int)(1 << 4),
            
            /// <summary>
            /// Use mailmap file to map author and committer names and email addresses
            /// to canonical real names and email addresses. The mailmap will be read
            /// from the working directory, or HEAD in a bare repository.
            /// </summary>
            GIT_BLAME_USE_MAILMAP = (int)(1 << 5),
        }
        
        /// <summary>
        /// Normal blame, the default
        /// </summary>
        public const git_blame_flag_t GIT_BLAME_NORMAL = git_blame_flag_t.GIT_BLAME_NORMAL;
        
        /// <summary>
        /// Track lines that have moved within a file (like `git blame -M`).
        /// NOT IMPLEMENTED.
        /// </summary>
        public const git_blame_flag_t GIT_BLAME_TRACK_COPIES_SAME_FILE = git_blame_flag_t.GIT_BLAME_TRACK_COPIES_SAME_FILE;
        
        /// <summary>
        /// Track lines that have moved across files in the same commit (like `git blame -C`).
        /// NOT IMPLEMENTED.
        /// </summary>
        public const git_blame_flag_t GIT_BLAME_TRACK_COPIES_SAME_COMMIT_MOVES = git_blame_flag_t.GIT_BLAME_TRACK_COPIES_SAME_COMMIT_MOVES;
        
        /// <summary>
        /// Track lines that have been copied from another file that exists in the
        /// same commit (like `git blame -CC`). Implies SAME_FILE.
        /// NOT IMPLEMENTED.
        /// </summary>
        public const git_blame_flag_t GIT_BLAME_TRACK_COPIES_SAME_COMMIT_COPIES = git_blame_flag_t.GIT_BLAME_TRACK_COPIES_SAME_COMMIT_COPIES;
        
        /// <summary>
        /// Track lines that have been copied from another file that exists in *any*
        /// commit (like `git blame -CCC`). Implies SAME_COMMIT_COPIES.
        /// NOT IMPLEMENTED.
        /// </summary>
        public const git_blame_flag_t GIT_BLAME_TRACK_COPIES_ANY_COMMIT_COPIES = git_blame_flag_t.GIT_BLAME_TRACK_COPIES_ANY_COMMIT_COPIES;
        
        /// <summary>
        /// Restrict the search of commits to those reachable following only the
        /// first parents.
        /// </summary>
        public const git_blame_flag_t GIT_BLAME_FIRST_PARENT = git_blame_flag_t.GIT_BLAME_FIRST_PARENT;
        
        /// <summary>
        /// Use mailmap file to map author and committer names and email addresses
        /// to canonical real names and email addresses. The mailmap will be read
        /// from the working directory, or HEAD in a bare repository.
        /// </summary>
        public const git_blame_flag_t GIT_BLAME_USE_MAILMAP = git_blame_flag_t.GIT_BLAME_USE_MAILMAP;
        
        /// <summary>
        /// Blame options structure
        /// </summary>
        /// <remarks>
        /// Initialize with `GIT_BLAME_OPTIONS_INIT`. Alternatively, you can
        /// use `git_blame_init_options`.
        /// </remarks>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public partial struct git_blame_options
        {
            public uint version;
            
            /// <summary>
            /// A combination of `git_blame_flag_t`
            /// </summary>
            public uint flags;
            
            /// <summary>
            /// The lower bound on the number of alphanumeric
            /// characters that must be detected as moving/copying within a file for it to
            /// associate those lines with the parent commit. The default value is 20.
            /// This value only takes effect if any of the `GIT_BLAME_TRACK_COPIES_*`
            /// flags are specified.
            /// </summary>
            public ushort min_match_characters;
            
            /// <summary>
            /// The id of the newest commit to consider. The default is HEAD.
            /// </summary>
            public git_oid newest_commit;
            
            /// <summary>
            /// The id of the oldest commit to consider.
            /// The default is the first commit encountered with a NULL parent.
            /// </summary>
            public git_oid oldest_commit;
            
            /// <summary>
            /// The first line in the file to blame.
            /// The default is 1 (line numbers start with 1).
            /// </summary>
            public size_t min_line;
            
            /// <summary>
            /// The last line in the file to blame.
            /// The default is the last line of the file.
            /// </summary>
            public size_t max_line;
        }
        
        /// <summary>
        /// Structure that represents a blame hunk.
        /// </summary>
        /// <remarks>
        /// - `lines_in_hunk` is the number of lines in this hunk
        /// - `final_commit_id` is the OID of the commit where this line was last
        /// changed.
        /// - `final_start_line_number` is the 1-based line number where this hunk
        /// begins, in the final version of the file
        /// - `final_signature` is the author of `final_commit_id`. If
        /// `GIT_BLAME_USE_MAILMAP` has been specified, it will contain the canonical
        /// real name and email address.
        /// - `orig_commit_id` is the OID of the commit where this hunk was found.  This
        /// will usually be the same as `final_commit_id`, except when
        /// `GIT_BLAME_TRACK_COPIES_ANY_COMMIT_COPIES` has been specified.
        /// - `orig_path` is the path to the file where this hunk originated, as of the
        /// commit specified by `orig_commit_id`.
        /// - `orig_start_line_number` is the 1-based line number where this hunk begins
        /// in the file named by `orig_path` in the commit specified by
        /// `orig_commit_id`.
        /// - `orig_signature` is the author of `orig_commit_id`. If
        /// `GIT_BLAME_USE_MAILMAP` has been specified, it will contain the canonical
        /// real name and email address.
        /// - `boundary` is 1 iff the hunk has been tracked to a boundary commit (the
        /// root, or the commit specified in git_blame_options.oldest_commit)
        /// </remarks>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public partial struct git_blame_hunk
        {
            public size_t lines_in_hunk;
            
            public git_oid final_commit_id;
            
            public size_t final_start_line_number;
            
            public IntPtr final_signature;
            
            public git_oid orig_commit_id;
            
            [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))]
            public string orig_path;
            
            public size_t orig_start_line_number;
            
            public IntPtr orig_signature;
            
            public sbyte boundary;
        }
        
        /// <summary>
        /// Opaque structure to hold blame results
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public readonly partial struct git_blame : IEquatable<git_blame>
        {
            private readonly IntPtr _handle;
            
            public git_blame(IntPtr handle) => _handle = handle;
            
            public IntPtr Handle => _handle;
            
            public bool Equals(git_blame other) => _handle.Equals(other._handle);
            
            public override bool Equals(object obj) => obj is git_blame other && Equals(other);
            
            public override int GetHashCode() => _handle.GetHashCode();
            
            public override string ToString() => "0x" + (IntPtr.Size == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
            
            public static bool operator ==(git_blame left, git_blame right) => left.Equals(right);
            
            public static bool operator !=(git_blame left, git_blame right) => !left.Equals(right);
        }
        
        /// <summary>
        /// Initialize git_blame_options structure
        /// </summary>
        /// <param name="opts">The `git_blame_options` struct to initialize.</param>
        /// <param name="version">The struct version; pass `GIT_BLAME_OPTIONS_VERSION`.</param>
        /// <returns>Zero on success; -1 on failure.</returns>
        /// <remarks>
        /// Initializes a `git_blame_options` with default values. Equivalent to creating
        /// an instance with GIT_BLAME_OPTIONS_INIT.
        /// </remarks>
        public static git_result git_blame_init_options(ref git_blame_options opts, uint version)
        {
            var __result__ = git_blame_init_options__(ref opts, version).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_blame_init_options", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_blame_init_options__(ref git_blame_options opts, uint version);
        
        /// <summary>
        /// Gets the number of hunks that exist in the blame structure.
        /// </summary>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint git_blame_get_hunk_count(git_blame blame);
        
        /// <summary>
        /// Gets the blame hunk at the given index.
        /// </summary>
        /// <param name="blame">the blame structure to query</param>
        /// <param name="index">index of the hunk to retrieve</param>
        /// <returns>the hunk at the given index, or NULL on error</returns>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ref readonly git_blame_hunk git_blame_get_hunk_byindex(git_blame blame, uint index);
        
        /// <summary>
        /// Gets the hunk that relates to the given line number in the newest commit.
        /// </summary>
        /// <param name="blame">the blame structure to query</param>
        /// <param name="lineno">the (1-based) line number to find a hunk for</param>
        /// <returns>the hunk that contains the given line, or NULL on error</returns>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ref readonly git_blame_hunk git_blame_get_hunk_byline(git_blame blame, size_t lineno);
        
        /// <summary>
        /// Get the blame for a single file.
        /// </summary>
        /// <param name="out">pointer that will receive the blame object</param>
        /// <param name="repo">repository whose history is to be walked</param>
        /// <param name="path">path to file to consider</param>
        /// <param name="options">options for the blame operation.  If NULL, this is treated as
        /// though GIT_BLAME_OPTIONS_INIT were passed.</param>
        /// <returns>0 on success, or an error code. (use git_error_last for information
        /// about the error.)</returns>
        public static git_result git_blame_file(out git_blame @out, git_repository repo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string path, ref git_blame_options options)
        {
            var __result__ = git_blame_file__(out @out, repo, path, ref options).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_blame_file", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_blame_file__(out git_blame @out, git_repository repo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string path, ref git_blame_options options);
        
        /// <summary>
        /// Get blame data for a file that has been modified in memory. The `reference`
        /// parameter is a pre-calculated blame for the in-odb history of the file. This
        /// means that once a file blame is completed (which can be expensive), updating
        /// the buffer blame is very fast.
        /// </summary>
        /// <param name="out">pointer that will receive the resulting blame data</param>
        /// <param name="reference">cached blame from the history of the file (usually the output
        /// from git_blame_file)</param>
        /// <param name="buffer">the (possibly) modified contents of the file</param>
        /// <param name="buffer_len">number of valid bytes in the buffer</param>
        /// <returns>0 on success, or an error code. (use git_error_last for information
        /// about the error)</returns>
        /// <remarks>
        /// Lines that differ between the buffer and the committed version are marked as
        /// having a zero OID for their final_commit_id.
        /// </remarks>
        public static git_result git_blame_buffer(out git_blame @out, git_blame reference, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string buffer, size_t buffer_len)
        {
            var __result__ = git_blame_buffer__(out @out, reference, buffer, buffer_len).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_blame_buffer", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_blame_buffer__(out git_blame @out, git_blame reference, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string buffer, size_t buffer_len);
        
        /// <summary>
        /// Free memory allocated by git_blame_file or git_blame_buffer.
        /// </summary>
        /// <param name="blame">the blame structure to free</param>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void git_blame_free(git_blame blame);
    }
}
