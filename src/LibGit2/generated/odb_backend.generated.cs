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
        /// Streaming mode
        /// </summary>
        [Flags]
        public enum git_odb_stream_t : int
        {
            GIT_STREAM_RDONLY = (int)(1 << 1),
            
            GIT_STREAM_WRONLY = (int)(1 << 2),
            
            GIT_STREAM_RW = (int)(GIT_STREAM_RDONLY | GIT_STREAM_WRONLY),
        }
        
        public const git_odb_stream_t GIT_STREAM_RDONLY = git_odb_stream_t.GIT_STREAM_RDONLY;
        
        public const git_odb_stream_t GIT_STREAM_WRONLY = git_odb_stream_t.GIT_STREAM_WRONLY;
        
        public const git_odb_stream_t GIT_STREAM_RW = git_odb_stream_t.GIT_STREAM_RW;
        
        /// <summary>
        /// A stream to read/write from a backend.
        /// </summary>
        /// <remarks>
        /// This represents a stream of data being written to or read from a
        /// backend. When writing, the frontend functions take care of
        /// calculating the object's id and all `finalize_write` needs to do is
        /// store the object with the id it is passed.
        /// </remarks>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public partial struct git_odb_stream
        {
            public git_odb_backend backend;
            
            public uint mode;
            
            public IntPtr hash_ctx;
            
            public git_off_t declared_size;
            
            public git_off_t received_bytes;
            
            public read_delegate read;
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int read_delegate(ref git_odb_stream stream, IntPtr buffer, size_t len);
            
            public write_delegate write;
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int write_delegate(ref git_odb_stream stream, IntPtr buffer, size_t len);
            
            public finalize_write_delegate finalize_write;
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int finalize_write_delegate(ref git_odb_stream stream, IntPtr buffer, size_t len);
            
            public free_delegate free;
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void free_delegate(ref git_odb_stream stream, IntPtr buffer, size_t len);
        }
        
        /// <summary>
        /// A stream to write a pack file to the ODB
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public partial struct git_odb_writepack
        {
            public git_odb_backend backend;
            
            public append_delegate append;
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int append_delegate(ref git_odb_writepack writepack, IntPtr data, size_t size, ref git_transfer_progress stats);
            
            public commit_delegate commit;
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate int commit_delegate(ref git_odb_writepack writepack, IntPtr data, size_t size, ref git_transfer_progress stats);
            
            public free_delegate free;
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void free_delegate(ref git_odb_writepack writepack, IntPtr data, size_t size, ref git_transfer_progress stats);
        }
        
        /// <summary>
        /// Create a backend for the packfiles.
        /// </summary>
        /// <param name="out">location to store the odb backend pointer</param>
        /// <param name="objects_dir">the Git repository's objects directory</param>
        /// <returns>0 or an error code</returns>
        public static git_result git_odb_backend_pack(out git_odb_backend @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string objects_dir)
        {
            var __result__ = git_odb_backend_pack__(out @out, objects_dir).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_odb_backend_pack", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_odb_backend_pack__(out git_odb_backend @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string objects_dir);
        
        /// <summary>
        /// Create a backend for loose objects
        /// </summary>
        /// <param name="out">location to store the odb backend pointer</param>
        /// <param name="objects_dir">the Git repository's objects directory</param>
        /// <param name="compression_level">zlib compression level to use</param>
        /// <param name="do_fsync">whether to do an fsync() after writing</param>
        /// <param name="dir_mode">permissions to use creating a directory or 0 for defaults</param>
        /// <param name="file_mode">permissions to use creating a file or 0 for defaults</param>
        /// <returns>0 or an error code</returns>
        public static git_result git_odb_backend_loose(out git_odb_backend @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string objects_dir, int compression_level, int do_fsync, uint dir_mode, uint file_mode)
        {
            var __result__ = git_odb_backend_loose__(out @out, objects_dir, compression_level, do_fsync, dir_mode, file_mode).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_odb_backend_loose", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_odb_backend_loose__(out git_odb_backend @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string objects_dir, int compression_level, int do_fsync, uint dir_mode, uint file_mode);
        
        /// <summary>
        /// Create a backend out of a single packfile
        /// </summary>
        /// <param name="out">location to store the odb backend pointer</param>
        /// <param name="index_file">path to the packfile's .idx file</param>
        /// <returns>0 or an error code</returns>
        /// <remarks>
        /// This can be useful for inspecting the contents of a single
        /// packfile.
        /// </remarks>
        public static git_result git_odb_backend_one_pack(out git_odb_backend @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string index_file)
        {
            var __result__ = git_odb_backend_one_pack__(out @out, index_file).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_odb_backend_one_pack", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_odb_backend_one_pack__(out git_odb_backend @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string index_file);
    }
}
