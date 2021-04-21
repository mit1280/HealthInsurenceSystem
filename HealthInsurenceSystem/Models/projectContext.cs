using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HealthInsurenceSystem.Models
{
    public partial class projectContext : DbContext
    {
        public projectContext()
        {
        }

        public projectContext(DbContextOptions<projectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Interested> Interesteds { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Paymentlog> Paymentlogs { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Policy> Policies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:projectser.database.windows.net,1433;Initial Catalog=project;Persist Security Info=False;User ID=adminlogin;Password=Mitpatel1248;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Admin");

                entity.Property(e => e.AdminEmail)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Ptype)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Contact");

                entity.Property(e => e.Mnumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Subject).IsRequired();
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Pnumber)
                    .HasName("PK__Customer__BBE761DD09F4F645");

                entity.ToTable("Customer");

                entity.Property(e => e.Aemail)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cemail)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Lastpayment).HasColumnType("date");

                entity.Property(e => e.Ptype)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Purchaseddate).HasColumnType("date");
            });

            modelBuilder.Entity<Interested>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Interested");

                entity.Property(e => e.Cemail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ptype)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payment");

                entity.Property(e => e.Cardnumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiredDate)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Paymentlog>(entity =>
            {
                entity.HasKey(e => e.Paymentnumber)
                    .HasName("PK__Paymentl__954840B17BE78B1B");

                entity.ToTable("Paymentlog");

                entity.Property(e => e.Cemail)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Paymentdate).HasColumnType("date");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.Cnumber)
                    .HasName("PK__Person__1E5A0B8E14D13EED");

                entity.ToTable("Person");

                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Policy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Policy");

                entity.Property(e => e.MaxAge).HasColumnName("maxAge");

                entity.Property(e => e.MinAge).HasColumnName("minAge");

                entity.Property(e => e.MonthPremium).HasColumnName("monthPremium");

                entity.Property(e => e.Ptype)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
