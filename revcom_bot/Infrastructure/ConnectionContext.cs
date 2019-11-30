﻿using FirebirdSql.Data.FirebirdClient;
using TerminalMKTelegramBot.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminalMKTerminalBot.Models;

namespace TerminalMKTelegramBot.Infrastructure
{
    public static class Connection
    {
        public static string ConnectionString;
    }

    public class ConnectionContext :DbContext
    {
        #region DBSet`s
        //A
        // public DbSet<AccessScheduleEntity> AccessScheduleEntites { get; set; }
        public DbSet<UsersTelegram> UsersTelegram { get; set; }
        public DbSet<TelegramBot> TelegramBot { get; set; }
        public DbSet<TextTelegram> TextTelegram { get; set; }
        public DbSet<Production> Production { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<Routes> Routes { get; set; }
        public DbSet<Contractors> Contractors { get; set; }
        public DbSet<City> City { get; set; }

        

        #endregion



        static ConnectionContext()
        {
            FbConnectionStringBuilder csb;

            csb = new FbConnectionStringBuilder()
            {
                DataSource = "localhost",
                Database = "DB_BOT_TERMINAL",
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
                Database = "DB_BOT_TERMINAL",
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
