﻿using FirebirdSql.Data.FirebirdClient;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TechnicalProcessControl.DAL.Models;

namespace TechnicalProcessControl.DAL.EF
{
    public static class Connection
    {
        public static string ConnectionString;
    }

    public class ConnectionContext : DbContext
    {
        #region DBSet`s
        //A
        // public DbSet<AccessScheduleEntity> AccessScheduleEntites { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<TelegramBot> TelegramBot { get; set; }
        public DbSet<TextTelegram> TextTelegram { get; set; }
        public DbSet<Production> Production { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<Routes> Routes { get; set; }
        public DbSet<Contractors> Contractors { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<UserRole> Rules { get; set; }

        public DbSet<Drawings> Drawings { get; set; }
        public DbSet<Details> Details { get; set; }
        public DbSet<Type> Type { get; set; }
        public DbSet<TechProcess001> TechProcess001 { get; set; }
        public DbSet<TechProcess002> TechProcess002 { get; set; }
        public DbSet<TechProcess003> TechProcess003 { get; set; }
        public DbSet<TechProcess004> TechProcess004 { get; set; }
        public DbSet<TechProcess005> TechProcess005 { get; set; }
        public DbSet<DrawingScan> DrawingScan { get; set; }
        public DbSet<Materials> Materials { get; set; }
        public DbSet<Drawing> Drawing { get; set; }
        public DbSet<Revisions> Revisions { get; set; }
        public DbSet<OperationName> OperationName { get; set; }
        public DbSet<OperationNumber> OperationNumber { get; set; }
        public DbSet<OperationPaintMaterial> OperationPaintMaterial { get; set; }
        #endregion

        #region DBSet`s proc
        //A
        // public DbSet<AccessScheduleEntity> AccessScheduleEntites { get; set; }
        public DbSet<DrawingsInfo> DrawingsInfo { get; set; }
        public DbSet<Test> Test { get; set; }

        #endregion





        static ConnectionContext()
        {
            FbConnectionStringBuilder csb;

            csb = new FbConnectionStringBuilder()
            {
                DataSource = "localhost",
                Database = "TECHDATABASEDB",
                UserID = "SYSDBA",
                Password = "masterkey",
                Charset = "UTF8",
                Pooling = true,
                ConnectionLifeTime = 900
            };



#if DEBUG
            csb = new FbConnectionStringBuilder()
            {
                DataSource = "localhost",
                Database = "TechDatabaseDb",
                UserID = "SYSDBA",
                Password = "masterkey",
                Charset = "UTF8",
                Pooling = true,
                ConnectionLifeTime = 900
            };
#endif

            Connection.ConnectionString = csb.ConnectionString;
            Database.SetInitializer<ConnectionContext>(null);
        }

        public ConnectionContext() : base(new FbConnection(Connection.ConnectionString), true)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<DecimalPropertyConvention>();
            modelBuilder.Conventions.Add(new DecimalPropertyConvention(15, 6));
        }
    }
}
