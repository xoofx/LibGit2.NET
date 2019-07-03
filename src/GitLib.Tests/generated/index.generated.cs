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
    public partial class IndexTests : GitLibTestsBase
    {
        public IndexTests() : base("index") {}
        
        private void Check()
        {
            Test_git_index_open();
            Test_git_index_new();
            Test_git_index_free();
            Test_git_index_owner();
            Test_git_index_caps();
            Test_git_index_set_caps();
            Test_git_index_version();
            Test_git_index_set_version();
            Test_git_index_read();
            Test_git_index_write();
            Test_git_index_path();
            Test_git_index_checksum();
            Test_git_index_read_tree();
            Test_git_index_write_tree();
            Test_git_index_write_tree_to();
            Test_git_index_entrycount();
            Test_git_index_clear();
            Test_git_index_get_byindex();
            Test_git_index_get_bypath();
            Test_git_index_remove();
            Test_git_index_remove_directory();
            Test_git_index_add();
            Test_git_index_entry_stage();
            Test_git_index_entry_is_conflict();
            Test_git_index_iterator_new();
            Test_git_index_iterator_next();
            Test_git_index_iterator_free();
            Test_git_index_add_bypath();
            Test_git_index_add_frombuffer();
            Test_git_index_remove_bypath();
            Test_git_index_add_all();
            Test_git_index_remove_all();
            Test_git_index_update_all();
            Test_git_index_find();
            Test_git_index_find_prefix();
            Test_git_index_conflict_add();
            Test_git_index_conflict_get();
            Test_git_index_conflict_remove();
            Test_git_index_conflict_cleanup();
            Test_git_index_has_conflicts();
            Test_git_index_conflict_iterator_new();
            Test_git_index_conflict_next();
            Test_git_index_conflict_iterator_free();
        }
    }
}
