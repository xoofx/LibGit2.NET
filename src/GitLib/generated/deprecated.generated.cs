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
        /// Free the memory referred to by the git_buf.  This is an alias of
        /// `git_buf_dispose` and is preserved for backward compatibility.
        /// </summary>
        /// <seealso cref="git_buf_dispose"/>
        /// 
        /// <remarks>
        /// This function is deprecated, but there is no plan to remove this
        /// function at this time.@deprecated Use git_buf_dispose
        /// </remarks>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void git_buf_free(ref git_buf buffer);
        
        /// <summary>
        /// Return the last `git_error` object that was generated for the
        /// current thread.  This is an alias of `git_error_last` and is
        /// preserved for backward compatibility.
        /// </summary>
        /// <seealso cref="git_error_last"/>
        /// 
        /// <remarks>
        /// This function is deprecated, but there is no plan to remove this
        /// function at this time.@deprecated Use git_error_last
        /// </remarks>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ref readonly git_error giterr_last();
        
        /// <summary>
        /// Clear the last error.  This is an alias of `git_error_last` and is
        /// preserved for backward compatibility.
        /// </summary>
        /// <seealso cref="git_error_clear"/>
        /// 
        /// <remarks>
        /// This function is deprecated, but there is no plan to remove this
        /// function at this time.@deprecated Use git_error_clear
        /// </remarks>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void giterr_clear();
        
        /// <summary>
        /// Sets the error message to the given string.  This is an alias of
        /// `git_error_set_str` and is preserved for backward compatibility.
        /// </summary>
        /// <seealso cref="git_error_set_str"/>
        /// 
        /// <remarks>
        /// This function is deprecated, but there is no plan to remove this
        /// function at this time.@deprecated Use git_error_set_str
        /// </remarks>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void giterr_set_str(int error_class, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string @string);
        
        /// <summary>
        /// Indicates that an out-of-memory situation occured.  This is an alias
        /// of `git_error_set_oom` and is preserved for backward compatibility.
        /// </summary>
        /// <seealso cref="git_error_set_oom"/>
        /// 
        /// <remarks>
        /// This function is deprecated, but there is no plan to remove this
        /// function at this time.@deprecated Use git_error_set_oom
        /// </remarks>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void giterr_set_oom();
    }
}
