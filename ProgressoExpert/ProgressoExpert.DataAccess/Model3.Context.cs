﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProgressoExpert.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class base3Entities : DbContext
    {
        public base3Entities()
            : base("name=base3Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C_Acc17> C_Acc17 { get; set; }
        public virtual DbSet<C_Acc18> C_Acc18 { get; set; }
        public virtual DbSet<C_AccRg393> C_AccRg393 { get; set; }
        public virtual DbSet<C_AccRg420> C_AccRg420 { get; set; }
        public virtual DbSet<C_YearOffset> C_YearOffset { get; set; }
        public virtual DbSet<C_Reference56> C_Reference56 { get; set; }
        public virtual DbSet<C_Reference63> C_Reference63 { get; set; }
        public virtual DbSet<C_AccRgAT2415> C_AccRgAT2415 { get; set; }
        public virtual DbSet<RgTn1> RgTn1 { get; set; }
        public virtual DbSet<RgTn2> RgTn2 { get; set; }
    }
}
