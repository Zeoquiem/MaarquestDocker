using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class MaarquestContext : DbContext
    {
        public MaarquestContext()
        {
        }

        public MaarquestContext(DbContextOptions<MaarquestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ADDRESS> ADDRESS { get; set; }
        public virtual DbSet<CREDIT_CARD> CREDIT_CARD { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMER { get; set; }
        public virtual DbSet<CUSTOMER_KITCHEN> CUSTOMER_KITCHEN { get; set; }
        public virtual DbSet<DELIVERY> DELIVERY { get; set; }
        public virtual DbSet<DELIVERY_PRODUCT> DELIVERY_PRODUCT { get; set; }
        public virtual DbSet<NOTIFICATION> NOTIFICATION { get; set; }
        public virtual DbSet<ORDER> ORDER { get; set; }
        public virtual DbSet<ORDER_PRODUCT_TYPE> ORDER_PRODUCT_TYPE { get; set; }
        public virtual DbSet<PAYMENT_MEAN> PAYMENT_MEAN { get; set; }
        public virtual DbSet<PAYPAL> PAYPAL { get; set; }
        public virtual DbSet<POSITION_TYPE> POSITION_TYPE { get; set; }
        public virtual DbSet<PRODUCT> PRODUCT { get; set; }
        public virtual DbSet<PRODUCT_CATEGORY> PRODUCT_CATEGORY { get; set; }
        public virtual DbSet<PRODUCT_TYPE> PRODUCT_TYPE { get; set; }
        public virtual DbSet<PROMOTION> PROMOTION { get; set; }
        public virtual DbSet<PROMOTION_CUSTOMER> PROMOTION_CUSTOMER { get; set; }
        public virtual DbSet<PROMOTION_PACK> PROMOTION_PACK { get; set; }
        public virtual DbSet<PROMOTION_TYPE> PROMOTION_TYPE { get; set; }
        public virtual DbSet<RECEIPT> RECEIPT { get; set; }
        public virtual DbSet<RECEIPT_PRODUCT_TYPE> RECEIPT_PRODUCT_TYPE { get; set; }
        public virtual DbSet<RECOMMENDATION> RECOMMENDATION { get; set; }
        public virtual DbSet<SUPERMARKET> SUPERMARKET { get; set; }
        public virtual DbSet<SUPERMARKET_OPERATOR> SUPERMARKET_OPERATOR { get; set; }
        public virtual DbSet<SUPERMARKET_OPERATOR_FUNCTION> SUPERMARKET_OPERATOR_FUNCTION { get; set; }
        public virtual DbSet<SUPERMARKET_SHELF> SUPERMARKET_SHELF { get; set; }
        public virtual DbSet<SUPERMARKET_STOCK> SUPERMARKET_STOCK { get; set; }
        public virtual DbSet<SUPPLIER> SUPPLIER { get; set; }
        public virtual DbSet<SUPPLIER_CONTACT_REQUEST> SUPPLIER_CONTACT_REQUEST { get; set; }
        public virtual DbSet<SUPPLIER_OPERATOR> SUPPLIER_OPERATOR { get; set; }
        public virtual DbSet<SUPPLIER_OPERATOR_FUNCTION> SUPPLIER_OPERATOR_FUNCTION { get; set; }
        public virtual DbSet<SUPPLIER_PRODUCT_REQUEST> SUPPLIER_PRODUCT_REQUEST { get; set; }
        public virtual DbSet<SUPPLIER_STORAGE> SUPPLIER_STORAGE { get; set; }
        public virtual DbSet<TRANSPORT_MEAN> TRANSPORT_MEAN { get; set; }
        public virtual DbSet<USER_TYPE> USER_TYPE { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=127.0.0.1,1433;initial catalog=MaarquestContext;persist security info=True;user id=sa;password=p7M4rSzg5?");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ADDRESS>(entity =>
            {
                entity.HasKey(e => e.ADDRESS_ID)
                    .HasName("PK__ADDRESS__66EDEA2FE7B09E53");

                entity.ToTable("ADDRESS");

                entity.Property(e => e.CITY)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.COUNTRY)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LIGN_ONE)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LIGN_TWO)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.POSTCODE)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.RECEIVER)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.REGION)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CREDIT_CARD>(entity =>
            {
                entity.HasKey(e => e.CREDIT_CARD_ID)
                    .HasName("PK__CREDIT_C__99F1C4F6F0334035");

                entity.ToTable("CREDIT_CARD");

                entity.Property(e => e.CARD_NAME)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CARD_NUMBER)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.EXPIRY_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<CUSTOMER>(entity =>
            {
                entity.HasKey(e => e.CUSTOMER_ID)
                    .HasName("PK__CUSTOMER__1CE12D37F2E467E7");

                entity.ToTable("CUSTOMER");

                entity.Property(e => e.BIRTHDATE).HasColumnType("date");

                entity.Property(e => e.FIRSTNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GENDER)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LASTNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MAIL)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PASSWORD)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TEL)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.USERNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ADDRESS)
                    .WithMany(p => p.CUSTOMERs)
                    .HasForeignKey(d => d.ADDRESS_ID)
                    .HasConstraintName("FK__CUSTOMER__ADDRES__0F624AF8");
            });

            modelBuilder.Entity<CUSTOMER_KITCHEN>(entity =>
            {
                entity.HasKey(e => new { e.CUSTOMER_ID, e.PRODUCT_ID })
                    .HasName("CUSTOMER_KITCHEN_ID");

                entity.ToTable("CUSTOMER_KITCHEN");

                entity.HasOne(d => d.CUSTOMER)
                    .WithMany(p => p.CUSTOMER_KITCHENs)
                    .HasForeignKey(d => d.CUSTOMER_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CUSTOMER___CUSTO__10566F31");

                entity.HasOne(d => d.PRODUCT)
                    .WithMany(p => p.CUSTOMER_KITCHENs)
                    .HasForeignKey(d => d.PRODUCT_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CUSTOMER___PRODU__114A936A");
            });

            modelBuilder.Entity<DELIVERY>(entity =>
            {
                entity.HasKey(e => e.DELIVERY_ID)
                    .HasName("PK__DELIVERY__7D75E88B2833A72D");

                entity.ToTable("DELIVERY");

                entity.Property(e => e.DATE).HasColumnType("datetime");

                entity.HasOne(d => d.ORDER)
                    .WithMany(p => p.DELIVERies)
                    .HasForeignKey(d => d.ORDER_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DELIVERY__ORDER___14270015");

                entity.HasOne(d => d.SUPERMARKET)
                    .WithMany(p => p.DELIVERies)
                    .HasForeignKey(d => d.SUPERMARKET_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DELIVERY__SUPERM__1332DBDC");

                entity.HasOne(d => d.SUPPLIER)
                    .WithMany(p => p.DELIVERies)
                    .HasForeignKey(d => d.SUPPLIER_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DELIVERY__SUPPLI__123EB7A3");

                entity.HasOne(d => d.TRANSPORT_MEAN)
                    .WithMany(p => p.DELIVERies)
                    .HasForeignKey(d => d.TRANSPORT_MEAN_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DELIVERY__TRANSP__151B244E");
            });

            modelBuilder.Entity<DELIVERY_PRODUCT>(entity =>
            {
                entity.HasKey(e => new { e.DELIVERY_ID, e.PRODUCT_ID })
                    .HasName("DELIVERY_PRODUCT_ID");

                entity.ToTable("DELIVERY_PRODUCT");

                entity.HasOne(d => d.DELIVERY)
                    .WithMany(p => p.DELIVERY_PRODUCTs)
                    .HasForeignKey(d => d.DELIVERY_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DELIVERY___DELIV__160F4887");

                entity.HasOne(d => d.PRODUCT)
                    .WithMany(p => p.DELIVERY_PRODUCTs)
                    .HasForeignKey(d => d.PRODUCT_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DELIVERY___PRODU__17036CC0");
            });

            modelBuilder.Entity<NOTIFICATION>(entity =>
            {
                entity.HasKey(e => e.NOTIFICATION_ID)
                    .HasName("PK__NOTIFICA__83A4A446556CE054");

                entity.ToTable("NOTIFICATION");

                entity.Property(e => e.LABEL)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.USER_TYPE)
                    .WithMany(p => p.NOTIFICATIONs)
                    .HasForeignKey(d => d.USER_TYPE_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NOTIFICAT__USER___17F790F9");
            });

            modelBuilder.Entity<ORDER>(entity =>
            {
                entity.HasKey(e => e.ORDER_ID)
                    .HasName("PK__ORDER__460A9464C7B15C8C");

                entity.ToTable("ORDER");

                entity.Property(e => e.DATE).HasColumnType("datetime");

                entity.HasOne(d => d.SUPERMARKET)
                    .WithMany(p => p.ORDERs)
                    .HasForeignKey(d => d.SUPERMARKET_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ORDER__SUPERMARK__19DFD96B");

                entity.HasOne(d => d.SUPPLIER)
                    .WithMany(p => p.ORDERs)
                    .HasForeignKey(d => d.SUPPLIER_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ORDER__SUPPLIER___18EBB532");
            });

            modelBuilder.Entity<ORDER_PRODUCT_TYPE>(entity =>
            {
                entity.HasKey(e => new { e.ORDER_ID, e.PRODUCT_TYPE_ID })
                    .HasName("ORDER_PRODUCT_TYPE_ID");

                entity.ToTable("ORDER_PRODUCT_TYPE");

                entity.HasOne(d => d.ORDER)
                    .WithMany(p => p.ORDER_PRODUCT_TYPEs)
                    .HasForeignKey(d => d.ORDER_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ORDER_PRO__ORDER__1AD3FDA4");

                entity.HasOne(d => d.PRODUCT_TYPE)
                    .WithMany(p => p.ORDER_PRODUCT_TYPEs)
                    .HasForeignKey(d => d.PRODUCT_TYPE_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ORDER_PRO__PRODU__1BC821DD");
            });

            modelBuilder.Entity<PAYMENT_MEAN>(entity =>
            {
                entity.HasKey(e => e.PAYMENT_MEAN_ID)
                    .HasName("PK__PAYMENT___AAAE34D448D8D2C0");

                entity.ToTable("PAYMENT_MEAN");

                entity.HasOne(d => d.ADDRESS)
                    .WithMany(p => p.PAYMENT_MEANs)
                    .HasForeignKey(d => d.ADDRESS_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAYMENT_M__ADDRE__1DB06A4F");

                entity.HasOne(d => d.USER_TYPE)
                    .WithMany(p => p.PAYMENT_MEANs)
                    .HasForeignKey(d => d.USER_TYPE_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAYMENT_M__USER___1CBC4616");
            });

            modelBuilder.Entity<PAYPAL>(entity =>
            {
                entity.HasKey(e => e.PAYPAL_ID)
                    .HasName("PK__PAYPAL__0F6090AF8C8E15E6");

                entity.ToTable("PAYPAL");

                entity.Property(e => e.IDENTIFIANT_PAYPAL)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<POSITION_TYPE>(entity =>
            {
                entity.HasKey(e => e.POSITION_TYPE_ID)
                    .HasName("PK__POSITION__D78930B3E3111C94");

                entity.ToTable("POSITION_TYPE");

                entity.Property(e => e.LABEL)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PRODUCT>(entity =>
            {
                entity.HasKey(e => e.PRODUCT_ID)
                    .HasName("PK__PRODUCT__52B41763A1B189AE");

                entity.ToTable("PRODUCT");

                entity.Property(e => e.EXPIRY_DATE).HasColumnType("date");

                entity.HasOne(d => d.POSITION_TYPE)
                    .WithMany(p => p.PRODUCTs)
                    .HasForeignKey(d => d.POSITION_TYPE_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PRODUCT__POSITIO__208CD6FA");

                entity.HasOne(d => d.PRODUCT_TYPE)
                    .WithMany(p => p.PRODUCTs)
                    .HasForeignKey(d => d.PRODUCT_TYPE_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PRODUCT__PRODUCT__1F98B2C1");
            });

            modelBuilder.Entity<PRODUCT_CATEGORY>(entity =>
            {
                entity.HasKey(e => e.PRODUCT_CATEGORY_ID)
                    .HasName("PK__PRODUCT___DE243968526A574E");

                entity.ToTable("PRODUCT_CATEGORY");

                entity.Property(e => e.LABEL)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PRODUCT_TYPE>(entity =>
            {
                entity.HasKey(e => e.PRODUCT_TYPE_ID)
                    .HasName("PK__PRODUCT___A60F8E8192DCDEA3");

                entity.ToTable("PRODUCT_TYPE");

                entity.Property(e => e.DETAILS)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NAME)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.PRODUCT_CATEGORY)
                    .WithMany(p => p.PRODUCT_TYPEs)
                    .HasForeignKey(d => d.PRODUCT_CATEGORY_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PRODUCT_T__PRODU__22751F6C");

                entity.HasOne(d => d.SUPPLIER)
                    .WithMany(p => p.PRODUCT_TYPEs)
                    .HasForeignKey(d => d.SUPPLIER_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PRODUCT_T__SUPPL__2180FB33");
            });

            modelBuilder.Entity<PROMOTION>(entity =>
            {
                entity.HasKey(e => e.PROMOTION_ID)
                    .HasName("PK__PROMOTIO__F956993A5D51E32B");

                entity.ToTable("PROMOTION");

                entity.HasOne(d => d.PRODUCT_TYPE)
                    .WithMany(p => p.PROMOTIONs)
                    .HasForeignKey(d => d.PRODUCT_TYPE_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROMOTION__PRODU__25518C17");

                entity.HasOne(d => d.PROMOTION_PACK)
                    .WithMany(p => p.PROMOTIONs)
                    .HasForeignKey(d => d.PROMOTION_PACK_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROMOTION__PROMO__236943A5");

                entity.HasOne(d => d.PROMOTION_TYPE)
                    .WithMany(p => p.PROMOTIONs)
                    .HasForeignKey(d => d.PROMOTION_TYPE_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROMOTION__PROMO__245D67DE");
            });

            modelBuilder.Entity<PROMOTION_CUSTOMER>(entity =>
            {
                entity.HasKey(e => new { e.PROMOTION_ID, e.CUSTOMER_ID })
                    .HasName("PROMOTION_CUSTOMER_ID");

                entity.ToTable("PROMOTION_CUSTOMER");

                entity.HasOne(d => d.CUSTOMER)
                    .WithMany(p => p.PROMOTION_CUSTOMERs)
                    .HasForeignKey(d => d.CUSTOMER_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROMOTION__CUSTO__2739D489");

                entity.HasOne(d => d.PROMOTION)
                    .WithMany(p => p.PROMOTION_CUSTOMERs)
                    .HasForeignKey(d => d.PROMOTION_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROMOTION__PROMO__2645B050");
            });

            modelBuilder.Entity<PROMOTION_PACK>(entity =>
            {
                entity.HasKey(e => e.PROMOTION_PACK_ID)
                    .HasName("PK__PROMOTIO__1A4B1A14F4ACF5B0");

                entity.ToTable("PROMOTION_PACK");

                entity.Property(e => e.LABEL)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.PRODUCT_CATEGORY)
                    .WithMany(p => p.PROMOTION_PACKs)
                    .HasForeignKey(d => d.PRODUCT_CATEGORY_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROMOTION__PRODU__282DF8C2");
            });

            modelBuilder.Entity<PROMOTION_TYPE>(entity =>
            {
                entity.HasKey(e => e.PROMOTION_TYPE_ID)
                    .HasName("PK__PROMOTIO__5866D4F30CA14E5A");

                entity.ToTable("PROMOTION_TYPE");

                entity.Property(e => e.OPERATION)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RECEIPT>(entity =>
            {
                entity.HasKey(e => e.RECEIPT_ID)
                    .HasName("PK__RECEIPT__D1F6B97E53423428");

                entity.ToTable("RECEIPT");

                entity.Property(e => e.DATE).HasColumnType("datetime");

                entity.HasOne(d => d.CUSTOMER)
                    .WithMany(p => p.RECEIPTs)
                    .HasForeignKey(d => d.CUSTOMER_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RECEIPT__CUSTOME__29221CFB");
            });

            modelBuilder.Entity<RECEIPT_PRODUCT_TYPE>(entity =>
            {
                entity.HasKey(e => new { e.RECEIPT_ID, e.PRODUCT_TYPE_ID })
                    .HasName("RECEIPT_PRODUCT_TYPE_ID");

                entity.ToTable("RECEIPT_PRODUCT_TYPE");

                entity.HasOne(d => d.PRODUCT_TYPE)
                    .WithMany(p => p.RECEIPT_PRODUCT_TYPEs)
                    .HasForeignKey(d => d.PRODUCT_TYPE_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RECEIPT_P__PRODU__2B0A656D");

                entity.HasOne(d => d.RECEIPT)
                    .WithMany(p => p.RECEIPT_PRODUCT_TYPEs)
                    .HasForeignKey(d => d.RECEIPT_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RECEIPT_P__RECEI__2A164134");
            });

            modelBuilder.Entity<RECOMMENDATION>(entity =>
            {
                entity.HasKey(e => e.RECOMMENDATION_ID)
                    .HasName("PK__RECOMMEN__81CD506B0301B113");

                entity.ToTable("RECOMMENDATION");

                entity.Property(e => e.LABEL)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CUSTOMER)
                    .WithMany(p => p.RECOMMENDATIONs)
                    .HasForeignKey(d => d.CUSTOMER_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RECOMMEND__CUSTO__2BFE89A6");

                entity.HasOne(d => d.PRODUCT_TYPE)
                    .WithMany(p => p.RECOMMENDATIONs)
                    .HasForeignKey(d => d.PRODUCT_TYPE_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RECOMMEND__PRODU__2CF2ADDF");
            });

            modelBuilder.Entity<SUPERMARKET>(entity =>
            {
                entity.HasKey(e => e.SUPERMARKET_ID)
                    .HasName("PK__SUPERMAR__D0EA428556AE6273");

                entity.ToTable("SUPERMARKET");

                entity.Property(e => e.FAX)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TEL)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.ADDRESS)
                    .WithMany(p => p.SUPERMARKETs)
                    .HasForeignKey(d => d.ADDRESS_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SUPERMARK__ADDRE__2DE6D218");
            });

            modelBuilder.Entity<SUPERMARKET_OPERATOR>(entity =>
            {
                entity.HasKey(e => e.SUPERMARKET_OPERATOR_ID)
                    .HasName("PK__SUPERMAR__FB6BB50875383B8C");

                entity.ToTable("SUPERMARKET_OPERATOR");

                entity.Property(e => e.BIRTHDATE).HasColumnType("date");

                entity.Property(e => e.FIRSTNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GENDER)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LASTNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MAIL)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PASSWORD)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TEL)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.USERNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SUPERMARKET)
                    .WithMany(p => p.SUPERMARKET_OPERATORs)
                    .HasForeignKey(d => d.SUPERMARKET_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SUPERMARK__SUPER__2EDAF651");

                entity.HasOne(d => d.SUPERMARKET_OPERATOR_FUNCTION)
                    .WithMany(p => p.SUPERMARKET_OPERATORs)
                    .HasForeignKey(d => d.SUPERMARKET_OPERATOR_FUNCTION_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SUPERMARK__SUPER__2FCF1A8A");
            });

            modelBuilder.Entity<SUPERMARKET_OPERATOR_FUNCTION>(entity =>
            {
                entity.HasKey(e => e.SUPERMARKET_OPERATOR_FUNCTION_ID)
                    .HasName("PK__SUPERMAR__74A611E38F681002");

                entity.ToTable("SUPERMARKET_OPERATOR_FUNCTION");

                entity.Property(e => e.AUTHORIZATION)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LABEL)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SUPERMARKET_SHELF>(entity =>
            {
                entity.HasKey(e => e.SUPERMARKET_SHELF_ID)
                    .HasName("PK__SUPERMAR__33EB531E0F295813");

                entity.ToTable("SUPERMARKET_SHELF");

                entity.HasOne(d => d.PRODUCT_CATEGORY)
                    .WithMany(p => p.SUPERMARKET_SHELves)
                    .HasForeignKey(d => d.PRODUCT_CATEGORY_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SUPERMARK__PRODU__31B762FC");

                entity.HasOne(d => d.SUPERMARKET)
                    .WithMany(p => p.SUPERMARKET_SHELves)
                    .HasForeignKey(d => d.SUPERMARKET_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SUPERMARK__SUPER__30C33EC3");
            });

            modelBuilder.Entity<SUPERMARKET_STOCK>(entity =>
            {
                entity.HasKey(e => e.SUPERMARKET_STOCK_ID)
                    .HasName("PK__SUPERMAR__F5EE823DB0C5A2F6");

                entity.ToTable("SUPERMARKET_STOCK");

                entity.HasOne(d => d.SUPERMARKET)
                    .WithMany(p => p.SUPERMARKET_STOCKs)
                    .HasForeignKey(d => d.SUPERMARKET_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SUPERMARK__SUPER__32AB8735");
            });

            modelBuilder.Entity<SUPPLIER>(entity =>
            {
                entity.HasKey(e => e.SUPPLIER_ID)
                    .HasName("PK__SUPPLIER__88565CC18122D33D");

                entity.ToTable("SUPPLIER");

                entity.Property(e => e.COMPANY_NAME)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.COMPANY_SIGN)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FAX)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SIRET)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TEL)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.ADDRESS)
                    .WithMany(p => p.SUPPLIERs)
                    .HasForeignKey(d => d.ADDRESS_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SUPPLIER__ADDRES__339FAB6E");
            });

            modelBuilder.Entity<SUPPLIER_CONTACT_REQUEST>(entity =>
            {
                entity.HasKey(e => e.SUPPLIER_CONTACT_REQUEST_ID)
                    .HasName("PK__SUPPLIER__E21EF4383A3AF3A0");

                entity.ToTable("SUPPLIER_CONTACT_REQUEST");

                entity.HasOne(d => d.SUPPLIER)
                    .WithMany(p => p.SUPPLIER_CONTACT_REQUESTs)
                    .HasForeignKey(d => d.SUPPLIER_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SUPPLIER___SUPPL__3493CFA7");
            });

            modelBuilder.Entity<SUPPLIER_OPERATOR>(entity =>
            {
                entity.HasKey(e => e.SUPPLIER_OPERATOR_ID)
                    .HasName("PK__SUPPLIER__FB2E47A84693DEAA");

                entity.ToTable("SUPPLIER_OPERATOR");

                entity.Property(e => e.BIRTHDATE).HasColumnType("date");

                entity.Property(e => e.FIRSTNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GENDER)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LASTNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MAIL)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PASSWORD)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TEL)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.USERNAME)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SUPPLIER)
                    .WithMany(p => p.SUPPLIER_OPERATORs)
                    .HasForeignKey(d => d.SUPPLIER_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SUPPLIER___SUPPL__3587F3E0");

                entity.HasOne(d => d.SUPPLIER_OPERATOR_FUNCTION)
                    .WithMany(p => p.SUPPLIER_OPERATORs)
                    .HasForeignKey(d => d.SUPPLIER_OPERATOR_FUNCTION_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SUPPLIER___SUPPL__37703C52");

                entity.HasOne(d => d.SUPPLIER_STORAGE)
                    .WithMany(p => p.SUPPLIER_OPERATORs)
                    .HasForeignKey(d => d.SUPPLIER_STORAGE_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SUPPLIER___SUPPL__367C1819");
            });

            modelBuilder.Entity<SUPPLIER_OPERATOR_FUNCTION>(entity =>
            {
                entity.HasKey(e => e.SUPPLIER_OPERATOR_FUNCTION_ID)
                    .HasName("PK__SUPPLIER__7C29BAB331CBCDF0");

                entity.ToTable("SUPPLIER_OPERATOR_FUNCTION");

                entity.Property(e => e.AUTHORIZATION)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LABEL)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SUPPLIER_PRODUCT_REQUEST>(entity =>
            {
                entity.HasKey(e => e.SUPPLIER_PRODUCT_REQUEST_ID)
                    .HasName("PK__SUPPLIER__E2F18072DAD792D6");

                entity.ToTable("SUPPLIER_PRODUCT_REQUEST");

                entity.HasOne(d => d.PRODUCT_TYPE)
                    .WithMany(p => p.SUPPLIER_PRODUCT_REQUESTs)
                    .HasForeignKey(d => d.PRODUCT_TYPE_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SUPPLIER___PRODU__395884C4");

                entity.HasOne(d => d.SUPPLIER)
                    .WithMany(p => p.SUPPLIER_PRODUCT_REQUESTs)
                    .HasForeignKey(d => d.SUPPLIER_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SUPPLIER___SUPPL__3864608B");
            });

            modelBuilder.Entity<SUPPLIER_STORAGE>(entity =>
            {
                entity.HasKey(e => e.SUPPLIER_STORAGE_ID)
                    .HasName("PK__SUPPLIER__81A326CA6E7156F8");

                entity.ToTable("SUPPLIER_STORAGE");

                entity.HasOne(d => d.ADDRESS)
                    .WithMany(p => p.SUPPLIER_STORAGEs)
                    .HasForeignKey(d => d.ADDRESS_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SUPPLIER___ADDRE__3B40CD36");

                entity.HasOne(d => d.SUPPLIER)
                    .WithMany(p => p.SUPPLIER_STORAGEs)
                    .HasForeignKey(d => d.SUPPLIER_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SUPPLIER___SUPPL__3A4CA8FD");
            });

            modelBuilder.Entity<TRANSPORT_MEAN>(entity =>
            {
                entity.HasKey(e => e.TRANSPORT_MEAN_ID)
                    .HasName("PK__TRANSPOR__AF57C24890BCFD9D");

                entity.ToTable("TRANSPORT_MEAN");

                entity.Property(e => e.LABEL)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<USER_TYPE>(entity =>
            {
                entity.HasKey(e => e.USER_TYPE_ID)
                    .HasName("PK__USER_TYP__79658EF56333A6A3");

                entity.ToTable("USER_TYPE");

                entity.Property(e => e.LABEL)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
