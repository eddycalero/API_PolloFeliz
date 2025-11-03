

namespace UNI.Models
{
    public class UNIDbContext: DbContext
    {
        public DbSet<UnitMeasure> UnitMeasure { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public UNIDbContext(DbContextOptions<UNIDbContext> dbContext):base(dbContext)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UnitMeasure>(model =>
            {
                model.ToTable("unit_measure", "product");
                model.HasKey(x => x.unit_measure_id);
                model.Property(x => x.unit_measure_id).ValueGeneratedOnAdd();
                model.HasIndex(x => x.name).IsUnique();
            });

            modelBuilder.Entity<Category>(model =>
            {
                model.ToTable("category", "product");
                model.HasKey(x => x.category_id);
                model.Property(x => x.category_id).ValueGeneratedOnAdd();
                model.HasIndex(x => x.name).IsUnique();
            });

            modelBuilder.Entity<Product>(model =>
            {
                model.ToTable("product", "product");
                model.HasKey(x => x.product_id);
                model.Property(x => x.product_id).ValueGeneratedOnAdd();
                model.HasIndex(x => x.name).IsUnique();
            });

            modelBuilder.Entity<SubCategory>(model =>
            {
                model.ToTable("subcategory", "product");
                model.HasKey(x => x.subcategory_id);
                model.Property(x => x.subcategory_id).ValueGeneratedOnAdd();
                model.HasIndex(x => x.name).IsUnique();
            });
        }


    }
}
