﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiTraining.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FabricsEntities : DbContext
    {
        public FabricsEntities()
            : base("name=FabricsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Occupation> Occupation { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderLine> OrderLine { get; set; }
        public virtual DbSet<Product> Product { get; set; }
    
        public virtual ObjectResult<usp_Fabrics_Result> usp_Fabrics(Nullable<int> createClients, Nullable<int> createOrders)
        {
            var createClientsParameter = createClients.HasValue ?
                new ObjectParameter("CreateClients", createClients) :
                new ObjectParameter("CreateClients", typeof(int));
    
            var createOrdersParameter = createOrders.HasValue ?
                new ObjectParameter("CreateOrders", createOrders) :
                new ObjectParameter("CreateOrders", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Fabrics_Result>("usp_Fabrics", createClientsParameter, createOrdersParameter);
        }
    }
}