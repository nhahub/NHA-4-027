using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TerralexApp.Data
{
    public partial class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>  // DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }

        public virtual DbSet<City> Cities { get; set; }

        public virtual DbSet<Client> Clients { get; set; }

        public virtual DbSet<ClientDocument> ClientDocuments { get; set; }

        public virtual DbSet<OfficeProfile> OfficeProfiles { get; set; }

        public virtual DbSet<OfficeStuff> OfficeStuffs { get; set; }

        public virtual DbSet<Payment> Payments { get; set; }

        public virtual DbSet<Property> Properties { get; set; }

        public virtual DbSet<PropertyDocumnet> PropertyDocumnets { get; set; }

        public virtual DbSet<PropertyImage> PropertyImages { get; set; }

        public virtual DbSet<PropertyType> PropertyTypes { get; set; }

        public virtual DbSet<ProppertyCategory> ProppertyCategories { get; set; }

        public virtual DbSet<ServerType> ServerTypes { get; set; }

        public virtual DbSet<Template> Templates { get; set; }

        public virtual DbSet<Transaction> Transactions { get; set; }

        public virtual DbSet<TransactionDocument> TransactionDocuments { get; set; }

        public virtual DbSet<TransactionFee> TransactionFees { get; set; }

        public virtual DbSet<TransactionStatus> TransactionStatuses { get; set; }

        public virtual DbSet<TransactionsStage> TransactionsStages { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Appointment>(entity =>
        //    {
        //        entity.HasKey(e => e.AppointmentId).HasName("PK__Appointm__A50828FCEC7DD2A5");

        //        entity.Property(e => e.IsDeleted).HasAnnotation("Relational:DefaultConstraintName", "DF_Appointments_IsDeleted");

        //        entity.HasOne(d => d.Client).WithMany(p => p.Appointments)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_Appointments_Clients");
        //    });

        //    modelBuilder.Entity<City>(entity =>
        //    {
        //        entity.Property(e => e.IsDeleted).HasAnnotation("Relational:DefaultConstraintName", "DF_Cities_IsDelete");
        //    });

        //    modelBuilder.Entity<Client>(entity =>
        //    {
        //        entity.HasKey(e => e.ClientId).HasName("pk_client");

        //        entity.Property(e => e.IsDeleted).HasAnnotation("Relational:DefaultConstraintName", "DF_Clients_IsDeleted");
        //    });

        //    modelBuilder.Entity<ClientDocument>(entity =>
        //    {
        //        entity.Property(e => e.IsDeleted).HasAnnotation("Relational:DefaultConstraintName", "DF_ClientDocuments_IsDeleted");

        //        entity.HasOne(d => d.Client).WithMany(p => p.ClientDocuments)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_ClientDocuments_Clients");
        //    });

        //    modelBuilder.Entity<OfficeProfile>(entity =>
        //    {
        //        entity.Property(e => e.OfficeId).HasAnnotation("Relational:DefaultConstraintName", "DF_OfficeProfiles_OfficeId");
        //        entity.Property(e => e.IsDeleted).HasAnnotation("Relational:DefaultConstraintName", "DF_OfficeProfiles_IsDeleted");
        //    });

        //    modelBuilder.Entity<OfficeStuff>(entity =>
        //    {
        //        entity.Property(e => e.IsDeleted).HasAnnotation("Relational:DefaultConstraintName", "DF_OfficeStuffs_IsDeleted");
        //        entity.Property(e => e.OfficeId).HasAnnotation("Relational:DefaultConstraintName", "DF_OfficeStuffs_OfficeId");

        //        entity.HasOne(d => d.Office).WithMany(p => p.OfficeStuffs)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_OfficeStuffs_OfficeProfiles");
        //    });

        //    modelBuilder.Entity<Payment>(entity =>
        //    {
        //        entity.HasKey(e => e.PaymentId).HasName("PK__Payments__ED1FC9EAFD1CFCB6");

        //        entity.Property(e => e.IsDeleted).HasAnnotation("Relational:DefaultConstraintName", "DF__Payments__create__412EB0B6");
        //        entity.Property(e => e.PaymentDate)
        //            .HasDefaultValueSql("(getdate())")
        //            .HasAnnotation("Relational:DefaultConstraintName", "DF__Payments__paymen__403A8C7D");

        //        entity.HasOne(d => d.Transaction).WithOne(p => p.Payment)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_Payments_Transactions");
        //    });

        //    modelBuilder.Entity<Property>(entity =>
        //    {
        //        entity.HasKey(e => e.PropertyId).HasName("PK__Properti__735BA46311C48B44");

        //        entity.Property(e => e.Documents).IsFixedLength();
        //        entity.Property(e => e.IsDeleted).HasAnnotation("Relational:DefaultConstraintName", "DF_Properties_IsDeleted");

        //        entity.HasOne(d => d.City).WithMany(p => p.Properties)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_Properties_Cities");

        //        entity.HasOne(d => d.PropertyType).WithMany(p => p.Properties)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_Properties_PropertyTypes");
        //    });

        //    modelBuilder.Entity<PropertyDocumnet>(entity =>
        //    {
        //        entity.Property(e => e.IsDeleted).HasAnnotation("Relational:DefaultConstraintName", "DF_PropertyDocumnets_IsDeleted");

        //        entity.HasOne(d => d.Property).WithMany(p => p.PropertyDocumnets)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_PropertyDocumnets_Properties");
        //    });

        //    modelBuilder.Entity<PropertyImage>(entity =>
        //    {
        //        entity.Property(e => e.IsDeleted).HasAnnotation("Relational:DefaultConstraintName", "DF_PropertyImages_IsDeleted");

        //        entity.HasOne(d => d.Property).WithMany(p => p.PropertyImages)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_PropertyImages_Properties");
        //    });

        //    modelBuilder.Entity<PropertyType>(entity =>
        //    {
        //        entity.Property(e => e.IsDeleted).HasAnnotation("Relational:DefaultConstraintName", "DF_PropertyTypes_IsDeleted");

        //        entity.HasOne(d => d.PropertyCategory).WithMany(p => p.PropertyTypes)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_PropertyTypes_ProppertyCategories");
        //    });

        //    modelBuilder.Entity<ProppertyCategory>(entity =>
        //    {
        //        entity.Property(e => e.PropertyCategoryId).ValueGeneratedNever();
        //        entity.Property(e => e.IsDeleted).HasAnnotation("Relational:DefaultConstraintName", "DF_ProppertyCategories_IsDeleted");
        //    });

        //    modelBuilder.Entity<ServerType>(entity =>
        //    {
        //        entity.Property(e => e.IsDeleted).HasAnnotation("Relational:DefaultConstraintName", "DF_ServerTypes_IsDeleted");
        //    });

        //    modelBuilder.Entity<Template>(entity =>
        //    {
        //        entity.HasKey(e => e.TemplateId).HasName("pk_template");

        //        entity.Property(e => e.IsDeleted).HasAnnotation("Relational:DefaultConstraintName", "DF_Templates_IsDeleted");
        //    });

        //    modelBuilder.Entity<Transaction>(entity =>
        //    {
        //        entity.HasKey(e => e.TransactionId).HasName("PK__Transact__85C600AFD77FAD8A");

        //        entity.Property(e => e.IsDeleted).HasAnnotation("Relational:DefaultConstraintName", "DF_Transactions_IsDeleted");

        //        entity.HasOne(d => d.Client).WithMany(p => p.Transactions)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_Transactions_Clients");

        //        entity.HasOne(d => d.Property).WithMany(p => p.Transactions)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_Transactions_Properties");

        //        entity.HasOne(d => d.ServiceType).WithMany(p => p.Transactions)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_Transactions_ServerTypes");

        //        entity.HasOne(d => d.Stuff).WithMany(p => p.Transactions)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_Transactions_OfficeStuffs");

        //        entity.HasOne(d => d.TransactionStatus).WithMany(p => p.Transactions)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_Transactions_TransactionStatus");
        //    });

        //    modelBuilder.Entity<TransactionDocument>(entity =>
        //    {
        //        entity.HasKey(e => e.TransactionDocument_Id).HasName("PK_Documents");

        //        entity.Property(e => e.TransactionDocument_Id).ValueGeneratedNever();
        //        entity.Property(e => e.IsDeleted).HasAnnotation("Relational:DefaultConstraintName", "DF_TransactionDocuments_IsDeleted");

        //        entity.HasOne(d => d.Template).WithMany(p => p.TransactionDocuments)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_TransactionDocuments_Templates");

        //        entity.HasOne(d => d.Transaction).WithMany(p => p.TransactionDocuments)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_TransactionDocuments_Transactions");
        //    });

        //    modelBuilder.Entity<TransactionFee>(entity =>
        //    {
        //        entity.Property(e => e.IsDeleted).HasAnnotation("Relational:DefaultConstraintName", "DF_TransactionFees_Isdeleted");

        //        entity.HasOne(d => d.Transaction).WithMany(p => p.TransactionFees)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_TransactionFees_Transactions");
        //    });

        //    modelBuilder.Entity<TransactionStatus>(entity =>
        //    {
        //        entity.Property(e => e.IsDeleted).HasAnnotation("Relational:DefaultConstraintName", "DF_TransactionStatus_IsDeleted");
        //    });

        //    modelBuilder.Entity<TransactionsStage>(entity =>
        //    {
        //        entity.HasKey(e => e.TransactionsStageId).HasName("PK__transact__781A97F81A356878");

        //        entity.Property(e => e.IsDeleted).HasAnnotation("Relational:DefaultConstraintName", "DF_TransactionsStages_IsDeleted");

        //        entity.HasOne(d => d.Transaction).WithMany(p => p.TransactionsStages)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_TransactionsStages_Transactions");
        //    });

        //    OnModelCreatingPartial(modelBuilder);
        //}

        // partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}