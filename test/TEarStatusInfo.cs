//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test
{
    using System;
    using System.Collections.Generic;
    
    public partial class TEarStatusInfo
    {
        public int intEarStatusInfoID { get; set; }
        public bool isNormal { get; set; }
        public bool isInflamed { get; set; }
        public bool isTumor { get; set; }
        public bool isDirty { get; set; }
        public bool isPainful { get; set; }
        public bool isExcessiveHair { get; set; }
        public int intHealthExamID { get; set; }
    
        public virtual THealthExam THealthExam { get; set; }
    }
}
