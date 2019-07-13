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
        /// Represents a single git message trailer.
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public partial struct git_message_trailer
        {
            [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshalerRelaxedNoCleanup))]
            public string key;
            
            [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshalerRelaxedNoCleanup))]
            public string value;
        }
        
        /// <summary>
        /// Represents an array of git message trailers.
        /// </summary>
        /// <remarks>
        /// Struct members under the private comment are private, subject to change
        /// and should not be used by callers.
        /// </remarks>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public partial struct git_message_trailer_array
        {
            public IntPtr trailers;
            
            public size_t count;
            
            /// <summary>
            /// private
            /// </summary>
            public IntPtr _trailer_block;
        }
        
        /// <summary>
        /// Clean up excess whitespace and make sure there is a trailing newline in the message.
        /// </summary>
        /// <param name="out">The user-allocated git_buf which will be filled with the
        /// cleaned up message.</param>
        /// <param name="message">The message to be prettified.</param>
        /// <param name="strip_comments">Non-zero to remove comment lines, 0 to leave them in.</param>
        /// <param name="comment_char">Comment character. Lines starting with this character
        /// are considered to be comments and removed if `strip_comments` is non-zero.</param>
        /// <returns>0 or an error code.</returns>
        /// <remarks>
        /// Optionally, it can remove lines which start with the comment character.
        /// </remarks>
        public static git_result git_message_prettify(out git_buf @out, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshalerStrict))] string message, int strip_comments, sbyte comment_char)
        {
            var __result__ = git_message_prettify__(out @out, message, strip_comments, comment_char).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_message_prettify", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_message_prettify__(out git_buf @out, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshalerStrict))] string message, int strip_comments, sbyte comment_char);
        
        /// <summary>
        /// Parse trailers out of a message, filling the array pointed to by +arr+.
        /// </summary>
        /// <param name="arr">A pre-allocated git_message_trailer_array struct to be filled in
        /// with any trailers found during parsing.</param>
        /// <param name="message">The message to be parsed</param>
        /// <returns>0 on success, or non-zero on error.</returns>
        /// <remarks>
        /// Trailers are key/value pairs in the last paragraph of a message, not
        /// including any patches or conflicts that may be present.
        /// </remarks>
        public static git_result git_message_trailers(ref git_message_trailer_array arr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshalerStrict))] string message)
        {
            var __result__ = git_message_trailers__(ref arr, message).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_message_trailers", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_message_trailers__(ref git_message_trailer_array arr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshalerStrict))] string message);
        
        /// <summary>
        /// Clean's up any allocated memory in the git_message_trailer_array filled by
        /// a call to git_message_trailers.
        /// </summary>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void git_message_trailer_array_free(ref git_message_trailer_array arr);
    }
}
