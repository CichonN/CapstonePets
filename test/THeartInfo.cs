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
    
    public partial class THeartInfo
    {
        public int intHeartInfoID { get; set; }
        public bool isNormal { get; set; }
        public bool isMurMur { get; set; }
        public bool isFast { get; set; }
        public bool isSlow { get; set; }
        public bool isMuffled { get; set; }
        public int intHealthExamID { get; set; }
    
        public virtual THealthExam THealthExam { get; set; }
    }
}
