//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Webnangcao
{
    using System;
    using System.Collections.Generic;
    
    public partial class answer
    {
        public string answerID { get; set; }
        public string questionID { get; set; }
        public string content { get; set; }
        public string thoigian { get; set; }
        public Nullable<int> view { get; set; }
        public Nullable<double> vote { get; set; }
        public string UserID { get; set; }
    
        public virtual question question { get; set; }
        public virtual User User { get; set; }
    }
}