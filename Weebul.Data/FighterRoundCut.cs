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
    
    public partial class FighterRoundCut
    {
        public int FRID { get; set; }
        public int CutID { get; set; }
        public double RoundDamage { get; set; }
    
        public virtual Cut Cut { get; set; }
        public virtual FighterRound FighterRound { get; set; }
    }
}
