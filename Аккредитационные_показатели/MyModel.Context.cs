﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Аккредитационные_показатели
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Аккредитационные_показателиEntities : DbContext
    {
        public Аккредитационные_показателиEntities()
            : base("name=Аккредитационные_показателиEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AcademicLoad> AcademicLoad { get; set; }
        public virtual DbSet<Admission_student> Admission_student { get; set; }
        public virtual DbSet<As_teacher_pract> As_teacher_pract { get; set; }
        public virtual DbSet<DirectionTraining> DirectionTraining { get; set; }
        public virtual DbSet<Disciplines> Disciplines { get; set; }
        public virtual DbSet<EducationLevels> EducationLevels { get; set; }
        public virtual DbSet<Management_Master_degree_program> Management_Master_degree_program { get; set; }
        public virtual DbSet<Practitioners> Practitioners { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
    }
}
