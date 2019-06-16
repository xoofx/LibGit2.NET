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
        /// Supported credential types
        /// </summary>
        /// <remarks>
        /// This represents the various types of authentication methods supported by
        /// the library.
        /// </remarks>
        [Flags]
        public enum git_credtype_t : int
        {
            /// <summary>
            /// A vanilla user/password request
            /// </summary>
            /// <seealso cref="git_cred_userpass_plaintext_new"/>
            /// 
            GIT_CREDTYPE_USERPASS_PLAINTEXT = (int)(1u<<0),
            
            /// <summary>
            /// An SSH key-based authentication request
            /// </summary>
            /// <seealso cref="git_cred_ssh_key_new"/>
            /// 
            GIT_CREDTYPE_SSH_KEY = (int)(1u<<1),
            
            /// <summary>
            /// An SSH key-based authentication request, with a custom signature
            /// </summary>
            /// <seealso cref="git_cred_ssh_custom_new"/>
            /// 
            GIT_CREDTYPE_SSH_CUSTOM = (int)(1u<<2),
            
            /// <summary>
            /// An NTLM/Negotiate-based authentication request.
            /// </summary>
            /// <seealso cref="git_cred_default"/>
            /// 
            GIT_CREDTYPE_DEFAULT = (int)(1u<<3),
            
            /// <summary>
            /// An SSH interactive authentication request
            /// </summary>
            /// <seealso cref="git_cred_ssh_interactive_new"/>
            /// 
            GIT_CREDTYPE_SSH_INTERACTIVE = (int)(1u<<4),
            
            /// <summary>
            /// Username-only authentication request
            /// </summary>
            /// <seealso cref="git_cred_username_new"/>
            /// 
            /// <remarks>
            /// Used as a pre-authentication step if the underlying transport
            /// (eg. SSH, with no username in its URL) does not know which username
            /// to use.
            /// </remarks>
            GIT_CREDTYPE_USERNAME = (int)(1u<<5),
            
            /// <summary>
            /// An SSH key-based authentication request
            /// </summary>
            /// <seealso cref="git_cred_ssh_key_memory_new"/>
            /// 
            /// <remarks>
            /// Allows credentials to be read from memory instead of files.
            /// Note that because of differences in crypto backend support, it might
            /// not be functional.
            /// </remarks>
            GIT_CREDTYPE_SSH_MEMORY = (int)(1u<<6),
        }
        
        /// <summary>
        /// A vanilla user/password request
        /// </summary>
        /// <seealso cref="git_cred_userpass_plaintext_new"/>
        /// 
        public const git_credtype_t GIT_CREDTYPE_USERPASS_PLAINTEXT = git_credtype_t.GIT_CREDTYPE_USERPASS_PLAINTEXT;
        
        /// <summary>
        /// An SSH key-based authentication request
        /// </summary>
        /// <seealso cref="git_cred_ssh_key_new"/>
        /// 
        public const git_credtype_t GIT_CREDTYPE_SSH_KEY = git_credtype_t.GIT_CREDTYPE_SSH_KEY;
        
        /// <summary>
        /// An SSH key-based authentication request, with a custom signature
        /// </summary>
        /// <seealso cref="git_cred_ssh_custom_new"/>
        /// 
        public const git_credtype_t GIT_CREDTYPE_SSH_CUSTOM = git_credtype_t.GIT_CREDTYPE_SSH_CUSTOM;
        
        /// <summary>
        /// An NTLM/Negotiate-based authentication request.
        /// </summary>
        /// <seealso cref="git_cred_default"/>
        /// 
        public const git_credtype_t GIT_CREDTYPE_DEFAULT = git_credtype_t.GIT_CREDTYPE_DEFAULT;
        
        /// <summary>
        /// An SSH interactive authentication request
        /// </summary>
        /// <seealso cref="git_cred_ssh_interactive_new"/>
        /// 
        public const git_credtype_t GIT_CREDTYPE_SSH_INTERACTIVE = git_credtype_t.GIT_CREDTYPE_SSH_INTERACTIVE;
        
        /// <summary>
        /// Username-only authentication request
        /// </summary>
        /// <seealso cref="git_cred_username_new"/>
        /// 
        /// <remarks>
        /// Used as a pre-authentication step if the underlying transport
        /// (eg. SSH, with no username in its URL) does not know which username
        /// to use.
        /// </remarks>
        public const git_credtype_t GIT_CREDTYPE_USERNAME = git_credtype_t.GIT_CREDTYPE_USERNAME;
        
        /// <summary>
        /// An SSH key-based authentication request
        /// </summary>
        /// <seealso cref="git_cred_ssh_key_memory_new"/>
        /// 
        /// <remarks>
        /// Allows credentials to be read from memory instead of files.
        /// Note that because of differences in crypto backend support, it might
        /// not be functional.
        /// </remarks>
        public const git_credtype_t GIT_CREDTYPE_SSH_MEMORY = git_credtype_t.GIT_CREDTYPE_SSH_MEMORY;
        
        /// <summary>
        /// Type of SSH host fingerprint
        /// </summary>
        [Flags]
        public enum git_cert_ssh_t : int
        {
            /// <summary>
            /// MD5 is available
            /// </summary>
            GIT_CERT_SSH_MD5 = (int)(1 << 0),
            
            /// <summary>
            /// SHA-1 is available
            /// </summary>
            GIT_CERT_SSH_SHA1 = (int)(1 << 1),
        }
        
        /// <summary>
        /// MD5 is available
        /// </summary>
        public const git_cert_ssh_t GIT_CERT_SSH_MD5 = git_cert_ssh_t.GIT_CERT_SSH_MD5;
        
        /// <summary>
        /// SHA-1 is available
        /// </summary>
        public const git_cert_ssh_t GIT_CERT_SSH_SHA1 = git_cert_ssh_t.GIT_CERT_SSH_SHA1;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int git_cred_acquire_cb(out IntPtr cred, [MarshalAs(UnmanagedType.LPUTF8Str)] string url, [MarshalAs(UnmanagedType.LPUTF8Str)] string username_from_url, uint allowed_types, IntPtr payload);
        
        /// <summary>
        /// The base structure for all credential types
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public partial struct git_cred
        {
            /// <summary>
            /// A type of credential
            /// </summary>
            public git_credtype_t credtype;
            
            public free_delegate free;
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void free_delegate(ref git_cred cred);
        }
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int git_transport_cb(out git_transport @out, git_remote owner, IntPtr param);
        
        /// <summary>
        /// Hostkey information taken from libssh2
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public unsafe partial struct git_cert_hostkey
        {
            public git_cert parent;
            
            /// <summary>
            /// A hostkey type from libssh2, either
            /// `GIT_CERT_SSH_MD5` or `GIT_CERT_SSH_SHA1`
            /// </summary>
            public git_cert_ssh_t type;
            
            /// <summary>
            /// Hostkey hash. If type has `GIT_CERT_SSH_MD5` set, this will
            /// have the MD5 hash of the hostkey.
            /// </summary>
            public fixed byte hash_md5[16];
            
            /// <summary>
            /// Hostkey hash. If type has `GIT_CERT_SSH_SHA1` set, this will
            /// have the SHA-1 hash of the hostkey.
            /// </summary>
            public fixed byte hash_sha1[20];
        }
        
        /// <summary>
        /// X.509 certificate information
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public partial struct git_cert_x509
        {
            public git_cert parent;
            
            /// <summary>
            /// Pointer to the X.509 certificate data
            /// </summary>
            public IntPtr data;
            
            /// <summary>
            /// Length of the memory block pointed to by `data`.
            /// </summary>
            public size_t len;
        }
        
        /// <summary>
        /// A plaintext username and password
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public partial struct git_cred_userpass_plaintext
        {
            public git_cred parent;
            
            public IntPtr username;
            
            public IntPtr password;
        }
        
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public readonly partial struct _LIBSSH2_SESSION : IEquatable<_LIBSSH2_SESSION>
        {
            private readonly IntPtr _handle;
            
            public _LIBSSH2_SESSION(IntPtr handle) => _handle = handle;
            
            public IntPtr Handle => _handle;
            
            public bool Equals(_LIBSSH2_SESSION other) => _handle.Equals(other._handle);
            
            public override bool Equals(object obj) => obj is _LIBSSH2_SESSION other && Equals(other);
            
            public override int GetHashCode() => _handle.GetHashCode();
            
            public override string ToString() => "0x" + (IntPtr.Size == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
            
            public static bool operator ==(_LIBSSH2_SESSION left, _LIBSSH2_SESSION right) => left.Equals(right);
            
            public static bool operator !=(_LIBSSH2_SESSION left, _LIBSSH2_SESSION right) => !left.Equals(right);
        }
        
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public readonly partial struct _LIBSSH2_USERAUTH_KBDINT_PROMPT : IEquatable<_LIBSSH2_USERAUTH_KBDINT_PROMPT>
        {
            private readonly IntPtr _handle;
            
            public _LIBSSH2_USERAUTH_KBDINT_PROMPT(IntPtr handle) => _handle = handle;
            
            public IntPtr Handle => _handle;
            
            public bool Equals(_LIBSSH2_USERAUTH_KBDINT_PROMPT other) => _handle.Equals(other._handle);
            
            public override bool Equals(object obj) => obj is _LIBSSH2_USERAUTH_KBDINT_PROMPT other && Equals(other);
            
            public override int GetHashCode() => _handle.GetHashCode();
            
            public override string ToString() => "0x" + (IntPtr.Size == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
            
            public static bool operator ==(_LIBSSH2_USERAUTH_KBDINT_PROMPT left, _LIBSSH2_USERAUTH_KBDINT_PROMPT right) => left.Equals(right);
            
            public static bool operator !=(_LIBSSH2_USERAUTH_KBDINT_PROMPT left, _LIBSSH2_USERAUTH_KBDINT_PROMPT right) => !left.Equals(right);
        }
        
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public readonly partial struct _LIBSSH2_USERAUTH_KBDINT_RESPONSE : IEquatable<_LIBSSH2_USERAUTH_KBDINT_RESPONSE>
        {
            private readonly IntPtr _handle;
            
            public _LIBSSH2_USERAUTH_KBDINT_RESPONSE(IntPtr handle) => _handle = handle;
            
            public IntPtr Handle => _handle;
            
            public bool Equals(_LIBSSH2_USERAUTH_KBDINT_RESPONSE other) => _handle.Equals(other._handle);
            
            public override bool Equals(object obj) => obj is _LIBSSH2_USERAUTH_KBDINT_RESPONSE other && Equals(other);
            
            public override int GetHashCode() => _handle.GetHashCode();
            
            public override string ToString() => "0x" + (IntPtr.Size == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
            
            public static bool operator ==(_LIBSSH2_USERAUTH_KBDINT_RESPONSE left, _LIBSSH2_USERAUTH_KBDINT_RESPONSE right) => left.Equals(right);
            
            public static bool operator !=(_LIBSSH2_USERAUTH_KBDINT_RESPONSE left, _LIBSSH2_USERAUTH_KBDINT_RESPONSE right) => !left.Equals(right);
        }
        
        /// <summary>
        /// A ssh key from disk
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public partial struct git_cred_ssh_key
        {
            public git_cred parent;
            
            public IntPtr username;
            
            public IntPtr publickey;
            
            public IntPtr privatekey;
            
            public IntPtr passphrase;
        }
        
        /// <summary>
        /// Keyboard-interactive based ssh authentication
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public partial struct git_cred_ssh_interactive
        {
            public git_cred parent;
            
            public IntPtr username;
            
            public git_cred_ssh_interactive_callback prompt_callback;
            
            public IntPtr payload;
        }
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void git_cred_ssh_interactive_callback([MarshalAs(UnmanagedType.LPUTF8Str)] string name, int name_len, [MarshalAs(UnmanagedType.LPUTF8Str)] string instruction, int instruction_len, int num_prompts, ref LIBSSH2_USERAUTH_KBDINT_PROMPT prompts, ref LIBSSH2_USERAUTH_KBDINT_RESPONSE responses, out IntPtr @abstract);
        
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public readonly partial struct LIBSSH2_USERAUTH_KBDINT_PROMPT : IEquatable<LIBSSH2_USERAUTH_KBDINT_PROMPT>
        {
            public LIBSSH2_USERAUTH_KBDINT_PROMPT(_LIBSSH2_USERAUTH_KBDINT_PROMPT value) => this.Value = value;
            
            public readonly _LIBSSH2_USERAUTH_KBDINT_PROMPT Value;
            
            public bool Equals(LIBSSH2_USERAUTH_KBDINT_PROMPT other) =>  Value.Equals(other.Value);
            
            public override bool Equals(object obj) => obj is LIBSSH2_USERAUTH_KBDINT_PROMPT other && Equals(other);
            
            public override int GetHashCode() => Value.GetHashCode();
            
            public override string ToString() => Value.ToString();
            
            public static implicit operator _LIBSSH2_USERAUTH_KBDINT_PROMPT(LIBSSH2_USERAUTH_KBDINT_PROMPT from) => from.Value;
            
            public static implicit operator LIBSSH2_USERAUTH_KBDINT_PROMPT(_LIBSSH2_USERAUTH_KBDINT_PROMPT from) => new LIBSSH2_USERAUTH_KBDINT_PROMPT(from);
            
            public static bool operator ==(LIBSSH2_USERAUTH_KBDINT_PROMPT left, LIBSSH2_USERAUTH_KBDINT_PROMPT right) => left.Equals(right);
            
            public static bool operator !=(LIBSSH2_USERAUTH_KBDINT_PROMPT left, LIBSSH2_USERAUTH_KBDINT_PROMPT right) => !left.Equals(right);
        }
        
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public readonly partial struct LIBSSH2_USERAUTH_KBDINT_RESPONSE : IEquatable<LIBSSH2_USERAUTH_KBDINT_RESPONSE>
        {
            public LIBSSH2_USERAUTH_KBDINT_RESPONSE(_LIBSSH2_USERAUTH_KBDINT_RESPONSE value) => this.Value = value;
            
            public readonly _LIBSSH2_USERAUTH_KBDINT_RESPONSE Value;
            
            public bool Equals(LIBSSH2_USERAUTH_KBDINT_RESPONSE other) =>  Value.Equals(other.Value);
            
            public override bool Equals(object obj) => obj is LIBSSH2_USERAUTH_KBDINT_RESPONSE other && Equals(other);
            
            public override int GetHashCode() => Value.GetHashCode();
            
            public override string ToString() => Value.ToString();
            
            public static implicit operator _LIBSSH2_USERAUTH_KBDINT_RESPONSE(LIBSSH2_USERAUTH_KBDINT_RESPONSE from) => from.Value;
            
            public static implicit operator LIBSSH2_USERAUTH_KBDINT_RESPONSE(_LIBSSH2_USERAUTH_KBDINT_RESPONSE from) => new LIBSSH2_USERAUTH_KBDINT_RESPONSE(from);
            
            public static bool operator ==(LIBSSH2_USERAUTH_KBDINT_RESPONSE left, LIBSSH2_USERAUTH_KBDINT_RESPONSE right) => left.Equals(right);
            
            public static bool operator !=(LIBSSH2_USERAUTH_KBDINT_RESPONSE left, LIBSSH2_USERAUTH_KBDINT_RESPONSE right) => !left.Equals(right);
        }
        
        /// <summary>
        /// A key with a custom signature function
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public partial struct git_cred_ssh_custom
        {
            public git_cred parent;
            
            public IntPtr username;
            
            public IntPtr publickey;
            
            public size_t publickey_len;
            
            public git_cred_sign_callback sign_callback;
            
            public IntPtr payload;
        }
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int git_cred_sign_callback(ref LIBSSH2_SESSION session, out IntPtr sig, ref size_t sig_len, IntPtr data, size_t data_len, out IntPtr @abstract);
        
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public readonly partial struct LIBSSH2_SESSION : IEquatable<LIBSSH2_SESSION>
        {
            public LIBSSH2_SESSION(_LIBSSH2_SESSION value) => this.Value = value;
            
            public readonly _LIBSSH2_SESSION Value;
            
            public bool Equals(LIBSSH2_SESSION other) =>  Value.Equals(other.Value);
            
            public override bool Equals(object obj) => obj is LIBSSH2_SESSION other && Equals(other);
            
            public override int GetHashCode() => Value.GetHashCode();
            
            public override string ToString() => Value.ToString();
            
            public static implicit operator _LIBSSH2_SESSION(LIBSSH2_SESSION from) => from.Value;
            
            public static implicit operator LIBSSH2_SESSION(_LIBSSH2_SESSION from) => new LIBSSH2_SESSION(from);
            
            public static bool operator ==(LIBSSH2_SESSION left, LIBSSH2_SESSION right) => left.Equals(right);
            
            public static bool operator !=(LIBSSH2_SESSION left, LIBSSH2_SESSION right) => !left.Equals(right);
        }
        
        /// <summary>
        /// Username-only credential information
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public partial struct git_cred_username
        {
            public git_cred parent;
            
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
            public string username;
        }
        
        /// <summary>
        /// A key for NTLM/Kerberos "default" credentials
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public readonly partial struct git_cred_default : IEquatable<git_cred_default>
        {
            public git_cred_default(git_cred value) => this.Value = value;
            
            public readonly git_cred Value;
            
            public bool Equals(git_cred_default other) =>  Value.Equals(other.Value);
            
            public override bool Equals(object obj) => obj is git_cred_default other && Equals(other);
            
            public override int GetHashCode() => Value.GetHashCode();
            
            public override string ToString() => Value.ToString();
            
            public static implicit operator git_cred(git_cred_default from) => from.Value;
            
            public static implicit operator git_cred_default(git_cred from) => new git_cred_default(from);
            
            public static bool operator ==(git_cred_default left, git_cred_default right) => left.Equals(right);
            
            public static bool operator !=(git_cred_default left, git_cred_default right) => !left.Equals(right);
        }
        
        /// <summary>
        /// Check whether a credential object contains username information.
        /// </summary>
        /// <param name="cred">object to check</param>
        /// <returns>1 if the credential object has non-NULL username, 0 otherwise</returns>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern int git_cred_has_username(ref git_cred cred);
        
        /// <summary>
        /// Create a new plain-text username and password credential object.
        /// The supplied credential parameter will be internally duplicated.
        /// </summary>
        /// <param name="@out">The newly created credential object.</param>
        /// <param name="username">The username of the credential.</param>
        /// <param name="password">The password of the credential.</param>
        /// <returns>0 for success or an error code for failure</returns>
        public static git_result git_cred_userpass_plaintext_new(out IntPtr @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string username, [MarshalAs(UnmanagedType.LPUTF8Str)] string password)
        {
            var __result__ = git_cred_userpass_plaintext_new__(out @out, username, password).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_cred_userpass_plaintext_new", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_cred_userpass_plaintext_new__(out IntPtr @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string username, [MarshalAs(UnmanagedType.LPUTF8Str)] string password);
        
        /// <summary>
        /// Create a new passphrase-protected ssh key credential object.
        /// The supplied credential parameter will be internally duplicated.
        /// </summary>
        /// <param name="@out">The newly created credential object.</param>
        /// <param name="username">username to use to authenticate</param>
        /// <param name="publickey">The path to the public key of the credential.</param>
        /// <param name="privatekey">The path to the private key of the credential.</param>
        /// <param name="passphrase">The passphrase of the credential.</param>
        /// <returns>0 for success or an error code for failure</returns>
        public static git_result git_cred_ssh_key_new(out IntPtr @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string username, [MarshalAs(UnmanagedType.LPUTF8Str)] string publickey, [MarshalAs(UnmanagedType.LPUTF8Str)] string privatekey, [MarshalAs(UnmanagedType.LPUTF8Str)] string passphrase)
        {
            var __result__ = git_cred_ssh_key_new__(out @out, username, publickey, privatekey, passphrase).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_cred_ssh_key_new", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_cred_ssh_key_new__(out IntPtr @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string username, [MarshalAs(UnmanagedType.LPUTF8Str)] string publickey, [MarshalAs(UnmanagedType.LPUTF8Str)] string privatekey, [MarshalAs(UnmanagedType.LPUTF8Str)] string passphrase);
        
        /// <summary>
        /// Create a new ssh keyboard-interactive based credential object.
        /// The supplied credential parameter will be internally duplicated.
        /// </summary>
        /// <param name="username">Username to use to authenticate.</param>
        /// <param name="prompt_callback">The callback method used for prompts.</param>
        /// <param name="payload">Additional data to pass to the callback.</param>
        /// <returns>0 for success or an error code for failure.</returns>
        public static git_result git_cred_ssh_interactive_new(out IntPtr @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string username, git_cred_ssh_interactive_callback prompt_callback, IntPtr payload)
        {
            var __result__ = git_cred_ssh_interactive_new__(out @out, username, prompt_callback, payload).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_cred_ssh_interactive_new", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_cred_ssh_interactive_new__(out IntPtr @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string username, git_cred_ssh_interactive_callback prompt_callback, IntPtr payload);
        
        /// <summary>
        /// Create a new ssh key credential object used for querying an ssh-agent.
        /// The supplied credential parameter will be internally duplicated.
        /// </summary>
        /// <param name="@out">The newly created credential object.</param>
        /// <param name="username">username to use to authenticate</param>
        /// <returns>0 for success or an error code for failure</returns>
        public static git_result git_cred_ssh_key_from_agent(out IntPtr @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string username)
        {
            var __result__ = git_cred_ssh_key_from_agent__(out @out, username).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_cred_ssh_key_from_agent", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_cred_ssh_key_from_agent__(out IntPtr @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string username);
        
        /// <summary>
        /// Create an ssh key credential with a custom signing function.
        /// </summary>
        /// <param name="@out">The newly created credential object.</param>
        /// <param name="username">username to use to authenticate</param>
        /// <param name="publickey">The bytes of the public key.</param>
        /// <param name="publickey_len">The length of the public key in bytes.</param>
        /// <param name="sign_callback">The callback method to sign the data during the challenge.</param>
        /// <param name="payload">Additional data to pass to the callback.</param>
        /// <returns>0 for success or an error code for failure</returns>
        /// <remarks>
        /// This lets you use your own function to sign the challenge.This function and its credential type is provided for completeness
        /// and wraps `libssh2_userauth_publickey()`, which is undocumented.The supplied credential parameter will be internally duplicated.
        /// </remarks>
        public static git_result git_cred_ssh_custom_new(out IntPtr @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string username, [MarshalAs(UnmanagedType.LPUTF8Str)] string publickey, size_t publickey_len, git_cred_sign_callback sign_callback, IntPtr payload)
        {
            var __result__ = git_cred_ssh_custom_new__(out @out, username, publickey, publickey_len, sign_callback, payload).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_cred_ssh_custom_new", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_cred_ssh_custom_new__(out IntPtr @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string username, [MarshalAs(UnmanagedType.LPUTF8Str)] string publickey, size_t publickey_len, git_cred_sign_callback sign_callback, IntPtr payload);
        
        /// <summary>
        /// Create a "default" credential usable for Negotiate mechanisms like NTLM
        /// or Kerberos authentication.
        /// </summary>
        /// <returns>0 for success or an error code for failure</returns>
        public static git_result git_cred_default_new(out IntPtr @out)
        {
            var __result__ = git_cred_default_new__(out @out).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_cred_default_new", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_cred_default_new__(out IntPtr @out);
        
        /// <summary>
        /// Create a credential to specify a username.
        /// </summary>
        /// <remarks>
        /// This is used with ssh authentication to query for the username if
        /// none is specified in the url.
        /// </remarks>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern int git_cred_username_new(out IntPtr cred, [MarshalAs(UnmanagedType.LPUTF8Str)] string username);
        
        /// <summary>
        /// Create a new ssh key credential object reading the keys from memory.
        /// </summary>
        /// <param name="@out">The newly created credential object.</param>
        /// <param name="username">username to use to authenticate.</param>
        /// <param name="publickey">The public key of the credential.</param>
        /// <param name="privatekey">The private key of the credential.</param>
        /// <param name="passphrase">The passphrase of the credential.</param>
        /// <returns>0 for success or an error code for failure</returns>
        public static git_result git_cred_ssh_key_memory_new(out IntPtr @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string username, [MarshalAs(UnmanagedType.LPUTF8Str)] string publickey, [MarshalAs(UnmanagedType.LPUTF8Str)] string privatekey, [MarshalAs(UnmanagedType.LPUTF8Str)] string passphrase)
        {
            var __result__ = git_cred_ssh_key_memory_new__(out @out, username, publickey, privatekey, passphrase).Check();
            return __result__;
        }
        
        [DllImport(LibGit2Name, EntryPoint = "git_cred_ssh_key_memory_new", CallingConvention = CallingConvention.Cdecl)]
        private static extern git_result git_cred_ssh_key_memory_new__(out IntPtr @out, [MarshalAs(UnmanagedType.LPUTF8Str)] string username, [MarshalAs(UnmanagedType.LPUTF8Str)] string publickey, [MarshalAs(UnmanagedType.LPUTF8Str)] string privatekey, [MarshalAs(UnmanagedType.LPUTF8Str)] string passphrase);
        
        /// <summary>
        /// Free a credential.
        /// </summary>
        /// <param name="cred">the object to free</param>
        /// <remarks>
        /// This is only necessary if you own the object; that is, if you are a
        /// transport.
        /// </remarks>
        [DllImport(LibGit2Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void git_cred_free(ref git_cred cred);
    }
}
