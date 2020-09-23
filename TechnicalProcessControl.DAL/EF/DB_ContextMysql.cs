using MySql.Data.MySqlClient;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TechnicalProcessControl.DAL.Models;

namespace TechnicalProcessControl.DAL.EF
{
    public static class ConnectionMysql
    {
        public static string ConnectionString;
    }

    public class ConnectionMysqlContext : DbContext
    {
        #region DBSet`s
        //A
        // public DbSet<AccessScheduleEntity> AccessScheduleEntites { get; set; }
        //public DbSet<UsersTelegram> UsersTelegram { get; set; }
        //public DbSet<TelegramBot> TelegramBot { get; set; }
        //public DbSet<TextTelegram> TextTelegram { get; set; }
        //public DbSet<Production> Production { get; set; }
        //public DbSet<Messages> Messages { get; set; }
        //public DbSet<Routes> Routes { get; set; }
        //public DbSet<Contractors> Contractors { get; set; }
        //public DbSet<City> City { get; set; }

        //public DbSet<City> City { get; set; }
        public DbSet<Users> UsersTelegram { get; set; }
        public DbSet<TelegramBot> TelegramBot { get; set; }
        public DbSet<TextTelegram> TextTelegram { get; set; }
        public DbSet<Production> Production { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<Routes> Routes { get; set; }
        public DbSet<Contractors> Contractors { get; set; }
        public DbSet<City> City { get; set; }

        public DbSet<UserRole> Rules { get; set; }



        #endregion



        static ConnectionMysqlContext()
        {
            MySqlConnection csb;

            //csb = new MySqlConnection()
            //{ 
            //    ConnectionString =
            //    DataSource = "localhost",
            //    Database = "DB_BOT_TERMINAL",
            //    UserID = "SYSDBA",
            //    Password = "masterkey",
            //    Charset = "UTF8",
            //    Pooling = true,
            //    ConnectionLifeTime = 900
            //};



#if DEBUG
            csb = new MySqlConnection()
            {
                //ConnectionString = "server=localhost;port=3305;database=parking;uid=root"
                //ConnectionString = "server = localhost; UserId = root; Password = 12345678; database = user"
                ConnectionString = "Server=u0890548.plsk.regruhosting.ru;Database=u0890548_terminalmk;Uid=u0890_maxtel;Pwd=620930620Maks"


            };


            //server = localhost; UserId = root; Password = 12345678; database = test;
#endif
            csb = new MySqlConnection()
            {
                //ConnectionString = "server=localhost;port=3305;database=parking;uid=root"
                //ConnectionString = "server = localhost; UserId = root; Password = 12345678; database = user"
                //ConnectionString = "Server=u0890548.plsk.regruhosting.ru;Database=u0890548_terminalmk;Uid=u0890_root;Pwd=12345678"
                ConnectionString = "Server=u0890548.plsk.regruhosting.ru;Database=u0890548_terminalmk;Uid=u0890_maxtel;Pwd=620930maks"


            };
            ConnectionMysql.ConnectionString = csb.ConnectionString;
            Database.SetInitializer<ConnectionMysqlContext>(null);
        }

        public ConnectionMysqlContext() : base(new MySqlConnection(ConnectionMysql.ConnectionString), true)
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
