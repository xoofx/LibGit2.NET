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
        /// Available tracing levels.  When tracing is set to a particular level,
        /// callers will be provided tracing at the given level and all lower levels.
        /// </summary>
        public enum git_trace_level_t : int
        {
            /// <summary>
            /// No tracing will be performed.
            /// </summary>
            GIT_TRACE_NONE = (int)0,
            
            /// <summary>
            /// Severe errors that may impact the program's execution
            /// </summary>
            GIT_TRACE_FATAL = (int)1,
            
            /// <summary>
            /// Errors that do not impact the program's execution
            /// </summary>
            GIT_TRACE_ERROR = (int)2,
            
            /// <summary>
            /// Warnings that suggest abnormal data
            /// </summary>
            GIT_TRACE_WARN = (int)3,
            
            /// <summary>
            /// Informational messages about program execution
            /// </summary>
            GIT_TRACE_INFO = (int)4,
            
            /// <summary>
            /// Detailed data that allows for debugging
            /// </summary>
            GIT_TRACE_DEBUG = (int)5,
            
            /// <summary>
            /// Exceptionally detailed debugging data
            /// </summary>
            GIT_TRACE_TRACE = (int)6,
        }
        
        /// <summary>
        /// No tracing will be performed.
        /// </summary>
        public const git_trace_level_t GIT_TRACE_NONE = git_trace_level_t.GIT_TRACE_NONE;
        
        /// <summary>
        /// Severe errors that may impact the program's execution
        /// </summary>
        public const git_trace_level_t GIT_TRACE_FATAL = git_trace_level_t.GIT_TRACE_FATAL;
        
        /// <summary>
        /// Errors that do not impact the program's execution
        /// </summary>
        public const git_trace_level_t GIT_TRACE_ERROR = git_trace_level_t.GIT_TRACE_ERROR;
        
        /// <summary>
        /// Warnings that suggest abnormal data
        /// </summary>
        public const git_trace_level_t GIT_TRACE_WARN = git_trace_level_t.GIT_TRACE_WARN;
        
        /// <summary>
        /// Informational messages about program execution
        /// </summary>
        public const git_trace_level_t GIT_TRACE_INFO = git_trace_level_t.GIT_TRACE_INFO;
        
        /// <summary>
        /// Detailed data that allows for debugging
        /// </summary>
        public const git_trace_level_t GIT_TRACE_DEBUG = git_trace_level_t.GIT_TRACE_DEBUG;
        
        /// <summary>
        /// Exceptionally detailed debugging data
        /// </summary>
        public const git_trace_level_t GIT_TRACE_TRACE = git_trace_level_t.GIT_TRACE_TRACE;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void git_trace_callback(git_trace_level_t level, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string msg);
        
        /// <summary>
        /// Sets the system tracing configuration to the specified level with the
        /// specified callback.  When system events occur at a level equal to, or
        /// lower than, the given level they will be reported to the given callback.
        /// </summary>
        /// <param name="level">Level to set tracing to</param>
        /// <param name="cb">Function to call with trace data</param>
        /// <returns>0 or an error code</returns>
        public static git_result git_trace_set(git_trace_level_t level, git_trace_callback cb)
        {
            var __result__ = git_trace_set__(level, cb).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_trace_set", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_trace_set__(git_trace_level_t level, git_trace_callback cb);
    }
}
