using ASP_SignalR.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace ASP_SignalR
{
    public class CompanyContext : DbContext
    {
        // Your context has been configured to use a 'ConmpanyContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ASP_SignalR.ConmpanyContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ConmpanyContext' 
        // connection string in the application configuration file.
        public CompanyContext()
            : base("name=ConmpanyContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Chats> Chats { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}