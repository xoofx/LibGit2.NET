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
        /// Unique identity of any object (commit, tree, blob, tag).
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public unsafe partial struct git_oid
        {
            /// <summary>
            /// raw binary formatted id
            /// </summary>
            public fixed byte id[20];
        }
        
        /// <summary>
        /// OID Shortener object
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public readonly partial struct git_oid_shorten : IEquatable<git_oid_shorten>
        {
            private readonly IntPtr _handle;
            
            public git_oid_shorten(IntPtr handle) => _handle = handle;
            
            public IntPtr Handle => _handle;
            
            public bool Equals(git_oid_shorten other) => _handle.Equals(other._handle);
            
            public override bool Equals(object obj) => obj is git_oid_shorten other && Equals(other);
            
            public override int GetHashCode() => _handle.GetHashCode();
            
            public override string ToString() => "0x" + (IntPtr.Size == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
            
            public static bool operator ==(git_oid_shorten left, git_oid_shorten right) => left.Equals(right);
            
            public static bool operator !=(git_oid_shorten left, git_oid_shorten right) => !left.Equals(right);
        }
        
        /// <summary>
        /// Parse a hex formatted object id into a git_oid.
        /// </summary>
        /// <param name="out">oid structure the result is written into.</param>
        /// <param name="str">input hex string; must be pointing at the start of
        /// the hex sequence and have at least the number of bytes
        /// needed for an oid encoded in hex (40 bytes).</param>
        /// <returns>0 or an error code</returns>
        public static git_result git_oid_fromstr(out git_oid @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string str)
        {
            var __result__ = git_oid_fromstr__(out @out, str).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_oid_fromstr", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_oid_fromstr__(out git_oid @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string str);
        
        /// <summary>
        /// Parse a hex formatted null-terminated string into a git_oid.
        /// </summary>
        /// <param name="out">oid structure the result is written into.</param>
        /// <param name="str">input hex string; must be null-terminated.</param>
        /// <returns>0 or an error code</returns>
        public static git_result git_oid_fromstrp(out git_oid @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string str)
        {
            var __result__ = git_oid_fromstrp__(out @out, str).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_oid_fromstrp", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_oid_fromstrp__(out git_oid @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string str);
        
        /// <summary>
        /// Parse N characters of a hex formatted object id into a git_oid.
        /// </summary>
        /// <param name="out">oid structure the result is written into.</param>
        /// <param name="str">input hex string of at least size `length`</param>
        /// <param name="length">length of the input string</param>
        /// <returns>0 or an error code</returns>
        /// <remarks>
        /// If N is odd, the last byte's high nibble will be read in and the
        /// low nibble set to zero.
        /// </remarks>
        public static git_result git_oid_fromstrn(out git_oid @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, size_t length)
        {
            var __result__ = git_oid_fromstrn__(out @out, str, length).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_oid_fromstrn", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_oid_fromstrn__(out git_oid @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, size_t length);
        
        /// <summary>
        /// Copy an already raw oid into a git_oid structure.
        /// </summary>
        /// <param name="out">oid structure the result is written into.</param>
        /// <param name="raw">the raw input bytes to be copied.</param>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void git_oid_fromraw(out git_oid @out, IntPtr raw);
        
        /// <summary>
        /// Format a git_oid into a hex string.
        /// </summary>
        /// <param name="out">output hex string; must be pointing at the start of
        /// the hex sequence and have at least the number of bytes
        /// needed for an oid encoded in hex (40 bytes). Only the
        /// oid digits are written; a '
        /// \
        /// 0' terminator must be added
        /// by the caller if it is required.</param>
        /// <param name="id">oid structure to format.</param>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void git_oid_fmt(IntPtr @out, in git_oid id);
        
        /// <summary>
        /// Format a git_oid into a partial hex string.
        /// </summary>
        /// <param name="out">output hex string; you say how many bytes to write.
        /// If the number of bytes is &gt; GIT_OID_HEXSZ, extra bytes
        /// will be zeroed; if not, a '
        /// \
        /// 0' terminator is NOT added.</param>
        /// <param name="n">number of characters to write into out string</param>
        /// <param name="id">oid structure to format.</param>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void git_oid_nfmt(IntPtr @out, size_t n, in git_oid id);
        
        /// <summary>
        /// Format a git_oid into a loose-object path string.
        /// </summary>
        /// <param name="out">output hex string; must be pointing at the start of
        /// the hex sequence and have at least the number of bytes
        /// needed for an oid encoded in hex (41 bytes). Only the
        /// oid digits are written; a '
        /// \
        /// 0' terminator must be added
        /// by the caller if it is required.</param>
        /// <param name="id">oid structure to format.</param>
        /// <remarks>
        /// The resulting string is "aa/...", where "aa" is the first two
        /// hex digits of the oid and "..." is the remaining 38 digits.
        /// </remarks>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void git_oid_pathfmt(IntPtr @out, in git_oid id);
        
        /// <summary>
        /// Format a git_oid into a statically allocated c-string.
        /// </summary>
        /// <param name="oid">The oid structure to format</param>
        /// <returns>the c-string</returns>
        /// <remarks>
        /// The c-string is owned by the library and should not be freed
        /// by the user. If libgit2 is built with thread support, the string
        /// will be stored in TLS (i.e. one buffer per thread) to allow for
        /// concurrent calls of the function.
        /// </remarks>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr git_oid_tostr_s(in git_oid oid);
        
        /// <summary>
        /// Format a git_oid into a buffer as a hex format c-string.
        /// </summary>
        /// <param name="out">the buffer into which the oid string is output.</param>
        /// <param name="n">the size of the out buffer.</param>
        /// <param name="id">the oid structure to format.</param>
        /// <returns>the out buffer pointer, assuming no input parameter
        /// errors, otherwise a pointer to an empty string.</returns>
        /// <remarks>
        /// If the buffer is smaller than GIT_OID_HEXSZ+1, then the resulting
        /// oid c-string will be truncated to n-1 characters (but will still be
        /// NUL-byte terminated).If there are any input parameter errors (out == NULL, n == 0, oid ==
        /// NULL), then a pointer to an empty string is returned, so that the
        /// return value can always be printed.
        /// </remarks>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr git_oid_tostr(IntPtr @out, size_t n, in git_oid id);
        
        /// <summary>
        /// Copy an oid from one structure to another.
        /// </summary>
        /// <param name="out">oid structure the result is written into.</param>
        /// <param name="src">oid structure to copy from.</param>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void git_oid_cpy(out git_oid @out, in git_oid src);
        
        /// <summary>
        /// Compare two oid structures.
        /// </summary>
        /// <param name="a">first oid structure.</param>
        /// <param name="b">second oid structure.</param>
        /// <returns>&lt;
        /// 0, 0, &gt;0 if a 
        /// &lt;
        /// b, a == b, a &gt; b.</returns>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern int git_oid_cmp(in git_oid a, in git_oid b);
        
        /// <summary>
        /// Compare two oid structures for equality
        /// </summary>
        /// <param name="a">first oid structure.</param>
        /// <param name="b">second oid structure.</param>
        /// <returns>true if equal, false otherwise</returns>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern int git_oid_equal(in git_oid a, in git_oid b);
        
        /// <summary>
        /// Compare the first 'len' hexadecimal characters (packets of 4 bits)
        /// of two oid structures.
        /// </summary>
        /// <param name="a">first oid structure.</param>
        /// <param name="b">second oid structure.</param>
        /// <param name="len">the number of hex chars to compare</param>
        /// <returns>0 in case of a match</returns>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern int git_oid_ncmp(in git_oid a, in git_oid b, size_t len);
        
        /// <summary>
        /// Check if an oid equals an hex formatted object id.
        /// </summary>
        /// <param name="id">oid structure.</param>
        /// <param name="str">input hex string of an object id.</param>
        /// <returns>0 in case of a match, -1 otherwise.</returns>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern int git_oid_streq(in git_oid id, [MarshalAs(UnmanagedType.LPUTF8Str)] string str);
        
        /// <summary>
        /// Compare an oid to an hex formatted object id.
        /// </summary>
        /// <param name="id">oid structure.</param>
        /// <param name="str">input hex string of an object id.</param>
        /// <returns>-1 if str is not valid, 
        /// &lt;
        /// 0 if id sorts before str,
        /// 0 if id matches str, &gt;0 if id sorts after str.</returns>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern int git_oid_strcmp(in git_oid id, [MarshalAs(UnmanagedType.LPUTF8Str)] string str);
        
        /// <summary>
        /// Check is an oid is all zeros.
        /// </summary>
        /// <returns>1 if all zeros, 0 otherwise.</returns>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern int git_oid_iszero(in git_oid id);
        
        /// <summary>
        /// Create a new OID shortener.
        /// </summary>
        /// <param name="min_length">The minimal length for all identifiers,
        /// which will be used even if shorter OIDs would still
        /// be unique.</param>
        /// <returns>a `git_oid_shorten` instance, NULL if OOM</returns>
        /// <remarks>
        /// The OID shortener is used to process a list of OIDs
        /// in text form and return the shortest length that would
        /// uniquely identify all of them.E.g. look at the result of `git log --abbrev`.
        /// </remarks>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern git_oid_shorten git_oid_shorten_new(size_t min_length);
        
        /// <summary>
        /// Add a new OID to set of shortened OIDs and calculate
        /// the minimal length to uniquely identify all the OIDs in
        /// the set.
        /// </summary>
        /// <param name="os">a `git_oid_shorten` instance</param>
        /// <param name="text_id">an OID in text form</param>
        /// <returns>the minimal length to uniquely identify all OIDs
        /// added so far to the set; or an error code (
        /// &lt;
        /// 0) if an
        /// error occurs.</returns>
        /// <remarks>
        /// The OID is expected to be a 40-char hexadecimal string.
        /// The OID is owned by the user and will not be modified
        /// or freed.For performance reasons, there is a hard-limit of how many
        /// OIDs can be added to a single set (around ~32000, assuming
        /// a mostly randomized distribution), which should be enough
        /// for any kind of program, and keeps the algorithm fast and
        /// memory-efficient.Attempting to add more than those OIDs will result in a
        /// GIT_ERROR_INVALID error
        /// </remarks>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern int git_oid_shorten_add(git_oid_shorten os, [MarshalAs(UnmanagedType.LPUTF8Str)] string text_id);
        
        /// <summary>
        /// Free an OID shortener instance
        /// </summary>
        /// <param name="os">a `git_oid_shorten` instance</param>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void git_oid_shorten_free(git_oid_shorten os);
    }
}
