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
    public partial class DiffTests : GitLibTestsBase
    {
        public DiffTests() : base("diff") {}
        
        private void Check()
        {
            Test_git_diff_init_options();
            Test_git_diff_find_init_options();
            Test_git_diff_free();
            Test_git_diff_tree_to_tree();
            Test_git_diff_tree_to_index();
            Test_git_diff_index_to_workdir();
            Test_git_diff_tree_to_workdir();
            Test_git_diff_tree_to_workdir_with_index();
            Test_git_diff_index_to_index();
            Test_git_diff_merge();
            Test_git_diff_find_similar();
            Test_git_diff_num_deltas();
            Test_git_diff_num_deltas_of_type();
            Test_git_diff_get_delta();
            Test_git_diff_is_sorted_icase();
            Test_git_diff_foreach();
            Test_git_diff_status_char();
            Test_git_diff_print();
            Test_git_diff_to_buf();
            Test_git_diff_blobs();
            Test_git_diff_blob_to_buffer();
            Test_git_diff_buffers();
            Test_git_diff_from_buffer();
            Test_git_diff_get_stats();
            Test_git_diff_stats_files_changed();
            Test_git_diff_stats_insertions();
            Test_git_diff_stats_deletions();
            Test_git_diff_stats_to_buf();
            Test_git_diff_stats_free();
            Test_git_diff_format_email();
            Test_git_diff_commit_as_email();
            Test_git_diff_format_email_init_options();
            Test_git_diff_patchid_init_options();
            Test_git_diff_patchid();
        }
    }
}
