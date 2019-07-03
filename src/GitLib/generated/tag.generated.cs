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
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int git_tag_foreach_cb([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string name, ref git_oid oid, IntPtr payload);
        
        /// <summary>
        /// Lookup a tag object from the repository.
        /// </summary>
        /// <param name="out">pointer to the looked up tag</param>
        /// <param name="repo">the repo to use when locating the tag.</param>
        /// <param name="id">identity of the tag to locate.</param>
        /// <returns>0 or an error code</returns>
        public static git_result git_tag_lookup(out git_tag @out, git_repository repo, in git_oid id)
        {
            var __result__ = git_tag_lookup__(out @out, repo, id).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_tag_lookup", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_tag_lookup__(out git_tag @out, git_repository repo, in git_oid id);
        
        /// <summary>
        /// Lookup a tag object from the repository,
        /// given a prefix of its identifier (short id).
        /// </summary>
        /// <seealso cref="git_object_lookup_prefix"/>
        /// 
        /// <param name="out">pointer to the looked up tag</param>
        /// <param name="repo">the repo to use when locating the tag.</param>
        /// <param name="id">identity of the tag to locate.</param>
        /// <param name="len">the length of the short identifier</param>
        /// <returns>0 or an error code</returns>
        public static git_result git_tag_lookup_prefix(out git_tag @out, git_repository repo, in git_oid id, size_t len)
        {
            var __result__ = git_tag_lookup_prefix__(out @out, repo, id, len).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_tag_lookup_prefix", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_tag_lookup_prefix__(out git_tag @out, git_repository repo, in git_oid id, size_t len);
        
        /// <summary>
        /// Close an open tag
        /// </summary>
        /// <param name="tag">the tag to close</param>
        /// <remarks>
        /// You can no longer use the git_tag pointer after this call.IMPORTANT: You MUST call this method when you are through with a tag to
        /// release memory. Failure to do so will cause a memory leak.
        /// </remarks>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void git_tag_free(git_tag tag);
        
        /// <summary>
        /// Get the id of a tag.
        /// </summary>
        /// <param name="tag">a previously loaded tag.</param>
        /// <returns>object identity for the tag.</returns>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ref readonly git_oid git_tag_id(git_tag tag);
        
        /// <summary>
        /// Get the repository that contains the tag.
        /// </summary>
        /// <param name="tag">A previously loaded tag.</param>
        /// <returns>Repository that contains this tag.</returns>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern git_repository git_tag_owner(git_tag tag);
        
        /// <summary>
        /// Get the tagged object of a tag
        /// </summary>
        /// <param name="target_out">pointer where to store the target</param>
        /// <param name="tag">a previously loaded tag.</param>
        /// <returns>0 or an error code</returns>
        /// <remarks>
        /// This method performs a repository lookup for the
        /// given object and returns it
        /// </remarks>
        public static git_result git_tag_target(out git_object target_out, git_tag tag)
        {
            var __result__ = git_tag_target__(out target_out, tag).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_tag_target", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_tag_target__(out git_object target_out, git_tag tag);
        
        /// <summary>
        /// Get the OID of the tagged object of a tag
        /// </summary>
        /// <param name="tag">a previously loaded tag.</param>
        /// <returns>pointer to the OID</returns>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ref readonly git_oid git_tag_target_id(git_tag tag);
        
        /// <summary>
        /// Get the type of a tag's tagged object
        /// </summary>
        /// <param name="tag">a previously loaded tag.</param>
        /// <returns>type of the tagged object</returns>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern git_object_t git_tag_target_type(git_tag tag);
        
        /// <summary>
        /// Get the name of a tag
        /// </summary>
        /// <param name="tag">a previously loaded tag.</param>
        /// <returns>name of the tag</returns>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerRelaxedNoCleanup))]
        public static extern string git_tag_name(git_tag tag);
        
        /// <summary>
        /// Get the tagger (author) of a tag
        /// </summary>
        /// <param name="tag">a previously loaded tag.</param>
        /// <returns>reference to the tag's author or NULL when unspecified</returns>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ref readonly git_signature git_tag_tagger(git_tag tag);
        
        /// <summary>
        /// Get the message of a tag
        /// </summary>
        /// <param name="tag">a previously loaded tag.</param>
        /// <returns>message of the tag or NULL when unspecified</returns>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerRelaxedNoCleanup))]
        public static extern string git_tag_message(git_tag tag);
        
        /// <summary>
        /// Create a new tag in the repository from an object
        /// </summary>
        /// <param name="oid">Pointer where to store the OID of the
        /// newly created tag. If the tag already exists, this parameter
        /// will be the oid of the existing tag, and the function will
        /// return a GIT_EEXISTS error code.</param>
        /// <param name="repo">Repository where to store the tag</param>
        /// <param name="tag_name">Name for the tag; this name is validated
        /// for consistency. It should also not conflict with an
        /// already existing tag name</param>
        /// <param name="target">Object to which this tag points. This object
        /// must belong to the given `repo`.</param>
        /// <param name="tagger">Signature of the tagger for this tag, and
        /// of the tagging time</param>
        /// <param name="message">Full message for this tag</param>
        /// <param name="force">Overwrite existing references</param>
        /// <returns>0 on success, GIT_EINVALIDSPEC or an error code
        /// A tag object is written to the ODB, and a proper reference
        /// is written in the /refs/tags folder, pointing to it</returns>
        /// <remarks>
        /// A new reference will also be created pointing to
        /// this tag object. If `force` is true and a reference
        /// already exists with the given name, it'll be replaced.The message will not be cleaned up. This can be achieved
        /// through `git_message_prettify()`.The tag name will be checked for validity. You must avoid
        /// the characters '~', '^', ':', '
        /// \
        /// ', '?', '[', and '*', and the
        /// sequences ".." and "
        /// @
        /// {" which have special meaning to revparse.
        /// </remarks>
        public static git_result git_tag_create(ref git_oid oid, git_repository repo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string tag_name, git_object target, in git_signature tagger, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string message, int force)
        {
            var __result__ = git_tag_create__(ref oid, repo, tag_name, target, tagger, message, force).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_tag_create", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_tag_create__(ref git_oid oid, git_repository repo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string tag_name, git_object target, in git_signature tagger, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string message, int force);
        
        /// <summary>
        /// Create a new tag in the object database pointing to a git_object
        /// </summary>
        /// <param name="oid">Pointer where to store the OID of the
        /// newly created tag</param>
        /// <param name="repo">Repository where to store the tag</param>
        /// <param name="tag_name">Name for the tag</param>
        /// <param name="target">Object to which this tag points. This object
        /// must belong to the given `repo`.</param>
        /// <param name="tagger">Signature of the tagger for this tag, and
        /// of the tagging time</param>
        /// <param name="message">Full message for this tag</param>
        /// <returns>0 on success or an error code</returns>
        /// <remarks>
        /// The message will not be cleaned up. This can be achieved
        /// through `git_message_prettify()`.
        /// </remarks>
        public static git_result git_tag_annotation_create(ref git_oid oid, git_repository repo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string tag_name, git_object target, in git_signature tagger, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string message)
        {
            var __result__ = git_tag_annotation_create__(ref oid, repo, tag_name, target, tagger, message).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_tag_annotation_create", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_tag_annotation_create__(ref git_oid oid, git_repository repo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string tag_name, git_object target, in git_signature tagger, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string message);
        
        /// <summary>
        /// Create a new tag in the repository from a buffer
        /// </summary>
        /// <param name="oid">Pointer where to store the OID of the newly created tag</param>
        /// <param name="repo">Repository where to store the tag</param>
        /// <param name="buffer">Raw tag data</param>
        /// <param name="force">Overwrite existing tags</param>
        /// <returns>0 on success; error code otherwise</returns>
        public static git_result git_tag_create_frombuffer(ref git_oid oid, git_repository repo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string buffer, int force)
        {
            var __result__ = git_tag_create_frombuffer__(ref oid, repo, buffer, force).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_tag_create_frombuffer", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_tag_create_frombuffer__(ref git_oid oid, git_repository repo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string buffer, int force);
        
        /// <summary>
        /// Create a new lightweight tag pointing at a target object
        /// </summary>
        /// <param name="oid">Pointer where to store the OID of the provided
        /// target object. If the tag already exists, this parameter
        /// will be filled with the oid of the existing pointed object
        /// and the function will return a GIT_EEXISTS error code.</param>
        /// <param name="repo">Repository where to store the lightweight tag</param>
        /// <param name="tag_name">Name for the tag; this name is validated
        /// for consistency. It should also not conflict with an
        /// already existing tag name</param>
        /// <param name="target">Object to which this tag points. This object
        /// must belong to the given `repo`.</param>
        /// <param name="force">Overwrite existing references</param>
        /// <returns>0 on success, GIT_EINVALIDSPEC or an error code
        /// A proper reference is written in the /refs/tags folder,
        /// pointing to the provided target object</returns>
        /// <remarks>
        /// A new direct reference will be created pointing to
        /// this target object. If `force` is true and a reference
        /// already exists with the given name, it'll be replaced.The tag name will be checked for validity.
        /// See `git_tag_create()` for rules about valid names.
        /// </remarks>
        public static git_result git_tag_create_lightweight(ref git_oid oid, git_repository repo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string tag_name, git_object target, int force)
        {
            var __result__ = git_tag_create_lightweight__(ref oid, repo, tag_name, target, force).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_tag_create_lightweight", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_tag_create_lightweight__(ref git_oid oid, git_repository repo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string tag_name, git_object target, int force);
        
        /// <summary>
        /// Delete an existing tag reference.
        /// </summary>
        /// <param name="repo">Repository where lives the tag</param>
        /// <param name="tag_name">Name of the tag to be deleted;
        /// this name is validated for consistency.</param>
        /// <returns>0 on success, GIT_EINVALIDSPEC or an error code</returns>
        /// <remarks>
        /// The tag name will be checked for validity.
        /// See `git_tag_create()` for rules about valid names.
        /// </remarks>
        public static git_result git_tag_delete(git_repository repo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string tag_name)
        {
            var __result__ = git_tag_delete__(repo, tag_name).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_tag_delete", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_tag_delete__(git_repository repo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string tag_name);
        
        /// <summary>
        /// Fill a list with all the tags in the Repository
        /// </summary>
        /// <param name="tag_names">Pointer to a git_strarray structure where
        /// the tag names will be stored</param>
        /// <param name="repo">Repository where to find the tags</param>
        /// <returns>0 or an error code</returns>
        /// <remarks>
        /// The string array will be filled with the names of the
        /// matching tags; these values are owned by the user and
        /// should be free'd manually when no longer needed, using
        /// `git_strarray_free`.
        /// </remarks>
        public static git_result git_tag_list(out string[] tag_names, git_repository repo)
        {
            git_strarray tag_names__;
            var __result__ = git_tag_list__(out tag_names__, repo).Check();
            tag_names = tag_names__.ToArray();
            git_strarray_free(ref tag_names__);
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_tag_list", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_tag_list__(out git_strarray tag_names, git_repository repo);
        
        /// <summary>
        /// Fill a list with all the tags in the Repository
        /// which name match a defined pattern
        /// </summary>
        /// <param name="tag_names">Pointer to a git_strarray structure where
        /// the tag names will be stored</param>
        /// <param name="pattern">Standard fnmatch pattern</param>
        /// <param name="repo">Repository where to find the tags</param>
        /// <returns>0 or an error code</returns>
        /// <remarks>
        /// If an empty pattern is provided, all the tags
        /// will be returned.The string array will be filled with the names of the
        /// matching tags; these values are owned by the user and
        /// should be free'd manually when no longer needed, using
        /// `git_strarray_free`.
        /// </remarks>
        public static git_result git_tag_list_match(out string[] tag_names, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string pattern, git_repository repo)
        {
            git_strarray tag_names__;
            var __result__ = git_tag_list_match__(out tag_names__, pattern, repo).Check();
            tag_names = tag_names__.ToArray();
            git_strarray_free(ref tag_names__);
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_tag_list_match", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_tag_list_match__(out git_strarray tag_names, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8MarshallerStrict))] string pattern, git_repository repo);
        
        /// <summary>
        /// Call callback `cb' for each tag in the repository
        /// </summary>
        /// <param name="repo">Repository</param>
        /// <param name="callback">Callback function</param>
        /// <param name="payload">Pointer to callback data (optional)</param>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int git_tag_foreach(git_repository repo, git_tag_foreach_cb callback, IntPtr payload);
        
        /// <summary>
        /// Recursively peel a tag until a non tag git_object is found
        /// </summary>
        /// <param name="tag_target_out">Pointer to the peeled git_object</param>
        /// <param name="tag">The tag to be processed</param>
        /// <returns>0 or an error code</returns>
        /// <remarks>
        /// The retrieved `tag_target` object is owned by the repository
        /// and should be closed with the `git_object_free` method.
        /// </remarks>
        public static git_result git_tag_peel(out git_object tag_target_out, git_tag tag)
        {
            var __result__ = git_tag_peel__(out tag_target_out, tag).Check();
            return __result__;
        }
        
        [DllImport(GitLibName, EntryPoint = "git_tag_peel", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_tag_peel__(out git_object tag_target_out, git_tag tag);
        
        /// <summary>
        /// Create an in-memory copy of a tag. The copy must be explicitly
        /// free'd or it will leak.
        /// </summary>
        /// <param name="out">Pointer to store the copy of the tag</param>
        /// <param name="source">Original tag to copy</param>
        [DllImport(GitLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int git_tag_dup(out git_tag @out, git_tag source);
    }
}
