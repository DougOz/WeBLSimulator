﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WeebulEntities : DbContext
    {
        public WeebulEntities()
            : base("name=WeebulEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Fighter> Fighters { get; set; }
        public virtual DbSet<FightPlan> FightPlans { get; set; }
        public virtual DbSet<Cut> Cuts { get; set; }
        public virtual DbSet<Fight> Fights { get; set; }
        public virtual DbSet<FighterRound> FighterRounds { get; set; }
        public virtual DbSet<FighterRoundCut> FighterRoundCuts { get; set; }
        public virtual DbSet<FightOption> FightOptions { get; set; }
        public virtual DbSet<Round> Rounds { get; set; }
        public virtual DbSet<Tactic> Tactics { get; set; }
        public virtual DbSet<JudgeRound> JudgeRounds { get; set; }
    }
}
