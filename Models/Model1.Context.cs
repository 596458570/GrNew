﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gr.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HRMSDBEntities : DbContext
    {
        public HRMSDBEntities()
            : base("name=HRMSDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<AuthEmp> AuthEmp { get; set; }
        public virtual DbSet<Authority> Authority { get; set; }
        public virtual DbSet<Dept> Dept { get; set; }
        public virtual DbSet<Emp> Emp { get; set; }
        public virtual DbSet<EmpAtten> EmpAtten { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<AdminCoed> AdminCoed { get; set; }
        public virtual DbSet<Djt> Djt { get; set; }
        public virtual DbSet<Lyb> Lyb { get; set; }
        public virtual DbSet<phb> phb { get; set; }
        public virtual DbSet<Sqwz> Sqwz { get; set; }
    }
}