//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Weebul.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class JudgeRound
    {
        public int JrsId { get; set; }
        public int Fighter1Score { get; set; }
        public int Fighter2Score { get; set; }
        public int RoundId { get; set; }
        public int JudgeNumber { get; set; }
    
        public virtual Round Round { get; set; }
    }
}
