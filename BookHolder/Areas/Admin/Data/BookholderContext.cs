using Microsoft.EntityFrameworkCore;
using System.Security.Principal;
using BookHolder.Areas.Admin.Models;

namespace BookHolder.Areas.Admin.Data
{
    public class BookholderContext: DbContext
    {
        public BookholderContext(DbContextOptions<BookholderContext> options)
                : base(options)
        {
        }       
        public DbSet<Customers> Customers { get; set; }
        public DbSet<FileImage> FileImages { get; set; }
        public DbSet<Invoice_details> Invoice_Details { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SaleOff> SaleOffs { get; set; }
        public DbSet<TransactStatus> TransactStatuses { get; set; }
        public DbSet<UserEvaluates> UserEvaluates { get; set; }
        public DbSet<StoreHouse> StoreHouses { get; set; }
        public DbSet<ImportHose> ImportHoses { get; set; }
        public DbSet<ExportStore> ExportStores { get; set; }
    }
}
