﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI_tgve
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mySampleDatabaseEntities : DbContext
    {
        public mySampleDatabaseEntities()
            : base("name=mySampleDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<COLOURTYPE> COLOURTYPEs { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<MOVIE> MOVIEs { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<RATING> RATINGs { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Segment> Segments { get; set; }
        public virtual DbSet<Shipping> Shippings { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }
        public virtual DbSet<TourEvent> TourEvents { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
    }
}
