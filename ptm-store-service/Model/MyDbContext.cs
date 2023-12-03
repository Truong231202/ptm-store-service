using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using MyClass.Model;

namespace ptm_store_service.Model
{
    public class MyDbContext :DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }


        public DbSet<Categories> categories { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<Address> addresses { get; set; }
        public DbSet<CartLines> cartLines { get; set; }
        public DbSet<Carts> carts { get; set; }
        public DbSet<Customers> customers { get; set; }
        public DbSet<Orders> orders { get; set; }
        public DbSet<PaymentMethods> paymentMethods { get; set; }
        public DbSet<Phones> phones { get; set; }
        public DbSet<ShippingMethods> shippingMethods { get; set; }






        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(e =>
            {
                e.ToTable("Category");
                e.HasKey(cate => cate.CategoryId);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.ToTable("Products");
                entity.HasKey(p => p.ProductId);
                entity.HasOne(e => e.Categories).WithMany(e => e.Products) .HasForeignKey(e => e.CategoryId);
            });

            modelBuilder.Entity<Carts>(entity =>
            {
                entity.ToTable("Carts");
                entity.HasKey(cart => cart.CartId);
            });

            modelBuilder.Entity<CartLines>(entity =>
            {
                entity.ToTable("Cartline");
                entity.HasKey(e => e.CartLineId);
                entity.HasOne(e => e.Carts).WithMany(e => e.CartLines).HasForeignKey(e => e.CartId);
            });

            modelBuilder.Entity<>

        }
    }
}
