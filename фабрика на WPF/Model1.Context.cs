﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace фабрика_на_WPF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class clothEntities : DbContext
    {
        public clothEntities()
            : base("name=clothEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Заказ> Заказ { get; set; }
        public virtual DbSet<Заказные_изделия> Заказные_изделия { get; set; }
        public virtual DbSet<Изделия> Изделия { get; set; }
        public virtual DbSet<Изделия_созданные_заказчиками> Изделия_созданные_заказчиками { get; set; }
        public virtual DbSet<Окантовка> Окантовка { get; set; }
        public virtual DbSet<Остатки_тканей> Остатки_тканей { get; set; }
        public virtual DbSet<Пользователь> Пользователь { get; set; }
        public virtual DbSet<Пользовательская_фурнитура> Пользовательская_фурнитура { get; set; }
        public virtual DbSet<Пользовательские_ткани> Пользовательские_ткани { get; set; }
        public virtual DbSet<Поставки> Поставки { get; set; }
        public virtual DbSet<Поставщик_ткани> Поставщик_ткани { get; set; }
        public virtual DbSet<Поставщик_Фурнитуры> Поставщик_Фурнитуры { get; set; }
        public virtual DbSet<Роль> Роль { get; set; }
        public virtual DbSet<Склад_ткани> Склад_ткани { get; set; }
        public virtual DbSet<Склад_фунитуры> Склад_фунитуры { get; set; }
        public virtual DbSet<Спецификация> Спецификация { get; set; }
        public virtual DbSet<Текущий_этап_выполнения> Текущий_этап_выполнения { get; set; }
        public virtual DbSet<Ткани> Ткани { get; set; }
        public virtual DbSet<Фурнитура> Фурнитура { get; set; }
        public virtual DbSet<Фурнитура_изделия> Фурнитура_изделия { get; set; }
    }
}
