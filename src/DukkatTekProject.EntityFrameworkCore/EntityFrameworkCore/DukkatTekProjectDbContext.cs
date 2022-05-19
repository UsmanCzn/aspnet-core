using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DukkatTekProject.Authorization.Roles;
using DukkatTekProject.Authorization.Users;
using DukkatTekProject.MultiTenancy;
using DukkatTekProject.ProductInventories;
using DukkatTekProject.Products;
using DukkatTekProject.Products.ProductCategories;

namespace DukkatTekProject.EntityFrameworkCore
{
    public class DukkatTekProjectDbContext : AbpZeroDbContext<Tenant, Role, User, DukkatTekProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<ProductInventory> ProductInventories { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DukkatTekProjectDbContext(DbContextOptions<DukkatTekProjectDbContext> options)
            : base(options)
        {
        }
    }
}
