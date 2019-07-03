//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;

namespace GitLib.Tests
{
    public partial class ReflogTests : GitLibTestsBase
    {
        public ReflogTests() : base("reflog") {}
        
        private void Check()
        {
            Test_git_reflog_read();
            Test_git_reflog_write();
            Test_git_reflog_append();
            Test_git_reflog_rename();
            Test_git_reflog_delete();
            Test_git_reflog_entrycount();
            Test_git_reflog_entry_byindex();
            Test_git_reflog_drop();
            Test_git_reflog_entry_id_old();
            Test_git_reflog_entry_id_new();
            Test_git_reflog_entry_committer();
            Test_git_reflog_entry_message();
            Test_git_reflog_free();
        }
    }
}
