//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestFul_1.Models.entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_chapter_comment
    {
        public long C_id { get; set; }
        public string C_content { get; set; }
        public Nullable<int> C_active { get; set; }
        public Nullable<int> C_chapter_id { get; set; }
        public Nullable<int> C_user_id { get; set; }
    
        public virtual tbl_chapter tbl_chapter { get; set; }
    }
}
