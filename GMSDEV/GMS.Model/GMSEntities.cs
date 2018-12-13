using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GMS.Model
{
    public partial class GMSEntities :DbContext
    {
        public GMSEntities()
            : base("name=GMSEntities")
        {
        }
        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<AdminUser> AdminUsers { get; set; }
        public virtual DbSet<AdminUserType> AdminUserTypes { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CheckOut> CheckOuts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<CustomerType> CustomerTypes { get; set; }
        public virtual DbSet<DelivaryMethod> DelivaryMethods { get; set; }
        public virtual DbSet<Membership> Memberships { get; set; }

        public virtual DbSet<MembershipType> MembershipTypes { get; set; }

        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<OfferType> OfferTypes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
    }
}