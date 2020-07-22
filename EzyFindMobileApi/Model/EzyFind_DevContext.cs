using System;
using System.IO;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace EzyFindMobileApi.Model
{
    public partial class EzyFind_DevContext : DbContext
    {
        public EzyFind_DevContext()
        {
        }

        public EzyFind_DevContext(DbContextOptions<EzyFind_DevContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DevForms> DevForms { get; set; }
        public virtual DbSet<ElmahError> ElmahError { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<MapCategoryAttributes> MapCategoryAttributes { get; set; }
        public virtual DbSet<MapCompanyArea> MapCompanyArea { get; set; }
        public virtual DbSet<MapCompanyAuditLog> MapCompanyAuditLog { get; set; }
        public virtual DbSet<MapCompanyCategory> MapCompanyCategory { get; set; }
        public virtual DbSet<MapCompanyDocument> MapCompanyDocument { get; set; }
        public virtual DbSet<MapCompanyEmail> MapCompanyEmail { get; set; }
        public virtual DbSet<MapCompanyMagazineAd> MapCompanyMagazineAd { get; set; }
        public virtual DbSet<MapCompanyPackage> MapCompanyPackage { get; set; }
        public virtual DbSet<MapCompanyPayment> MapCompanyPayment { get; set; }
        public virtual DbSet<MapCompanyProvide> MapCompanyProvide { get; set; }
        public virtual DbSet<MapCompanySeek> MapCompanySeek { get; set; }
        public virtual DbSet<MapCompanyTask> MapCompanyTask { get; set; }
        public virtual DbSet<MapCompanyUsers> MapCompanyUsers { get; set; }
        public virtual DbSet<MapCustomerEnquiryUpload> MapCustomerEnquiryUpload { get; set; }
        public virtual DbSet<MapEflyersUpload> MapEflyersUpload { get; set; }
        public virtual DbSet<MapItemRequestArea> MapItemRequestArea { get; set; }
        public virtual DbSet<MapItemRequestCategory> MapItemRequestCategory { get; set; }
        public virtual DbSet<MapItemRequestCategoryAttribute> MapItemRequestCategoryAttribute { get; set; }
        public virtual DbSet<MapItemRequestUpload> MapItemRequestUpload { get; set; }
        public virtual DbSet<MapItemResponseUpload> MapItemResponseUpload { get; set; }
        public virtual DbSet<MapPackageAttributes> MapPackageAttributes { get; set; }
        public virtual DbSet<MapProductDocument> MapProductDocument { get; set; }
        public virtual DbSet<MapProductImages> MapProductImages { get; set; }
        public virtual DbSet<MapSettingsRole> MapSettingsRole { get; set; }
        public virtual DbSet<MapSpecialUpload> MapSpecialUpload { get; set; }
        public virtual DbSet<MapUserRoleRights> MapUserRoleRights { get; set; }
        public virtual DbSet<MapUsersSettings> MapUsersSettings { get; set; }
        public virtual DbSet<MstBeestatus> MstBeestatus { get; set; }
        public virtual DbSet<MstCategory> MstCategory { get; set; }
        public virtual DbSet<MstCategoryAttribute> MstCategoryAttribute { get; set; }
        public virtual DbSet<MstCategoryAttributeDataType> MstCategoryAttributeDataType { get; set; }
        public virtual DbSet<MstCity> MstCity { get; set; }
        public virtual DbSet<MstCms> MstCms { get; set; }
        public virtual DbSet<MstCompany> MstCompany { get; set; }
        public virtual DbSet<MstCompanyDocumentType> MstCompanyDocumentType { get; set; }
        public virtual DbSet<MstCompanyStatus> MstCompanyStatus { get; set; }
        public virtual DbSet<MstCompanyTaskList> MstCompanyTaskList { get; set; }
        public virtual DbSet<MstConfiguration> MstConfiguration { get; set; }
        public virtual DbSet<MstContactForm> MstContactForm { get; set; }
        public virtual DbSet<MstCountry> MstCountry { get; set; }
        public virtual DbSet<MstCrmCustomer> MstCrmCustomer { get; set; }
        public virtual DbSet<MstCrmCustomerComment> MstCrmCustomerComment { get; set; }
        public virtual DbSet<MstCrmInventory> MstCrmInventory { get; set; }
        public virtual DbSet<MstCrmInventoryType> MstCrmInventoryType { get; set; }
        public virtual DbSet<MstCrmInvoice> MstCrmInvoice { get; set; }
        public virtual DbSet<MstCrmInvoiceDetails> MstCrmInvoiceDetails { get; set; }
        public virtual DbSet<MstCrmQuote> MstCrmQuote { get; set; }
        public virtual DbSet<MstCrmQuoteDetails> MstCrmQuoteDetails { get; set; }
        public virtual DbSet<MstCustomerEnquiry> MstCustomerEnquiry { get; set; }
        public virtual DbSet<MstCustomerEnquiryResponse> MstCustomerEnquiryResponse { get; set; }
        public virtual DbSet<MstDocumentStatus> MstDocumentStatus { get; set; }
        public virtual DbSet<MstDomain> MstDomain { get; set; }
        public virtual DbSet<MstEFlyers> MstEFlyers { get; set; }
        public virtual DbSet<MstEmailStack> MstEmailStack { get; set; }
        public virtual DbSet<MstFavourites> MstFavourites { get; set; }
        public virtual DbSet<MstFranchisee> MstFranchisee { get; set; }
        public virtual DbSet<MstItemRequest> MstItemRequest { get; set; }
        public virtual DbSet<MstItemResponse> MstItemResponse { get; set; }
        public virtual DbSet<MstKeywords> MstKeywords { get; set; }
        public virtual DbSet<MstMagazineAd> MstMagazineAd { get; set; }
        public virtual DbSet<MstMagazineAdType> MstMagazineAdType { get; set; }
        public virtual DbSet<MstMagazineSection> MstMagazineSection { get; set; }
        public virtual DbSet<MstMailType> MstMailType { get; set; }
        public virtual DbSet<MstNotificationStack> MstNotificationStack { get; set; }
        public virtual DbSet<MstPackage> MstPackage { get; set; }
        public virtual DbSet<MstPackageAttribute> MstPackageAttribute { get; set; }
        public virtual DbSet<MstPaymentMode> MstPaymentMode { get; set; }
        public virtual DbSet<MstPaymentStatus> MstPaymentStatus { get; set; }
        public virtual DbSet<MstPaymentType> MstPaymentType { get; set; }
        public virtual DbSet<MstPeriodType> MstPeriodType { get; set; }
        public virtual DbSet<MstProvince> MstProvince { get; set; }
        public virtual DbSet<MstQuantityType> MstQuantityType { get; set; }
        public virtual DbSet<MstRating> MstRating { get; set; }
        public virtual DbSet<MstSettings> MstSettings { get; set; }
        public virtual DbSet<MstSettingType> MstSettingType { get; set; }
        public virtual DbSet<MstSpecials> MstSpecials { get; set; }
        public virtual DbSet<MstStatus> MstStatus { get; set; }
        public virtual DbSet<MstSuburb> MstSuburb { get; set; }
        public virtual DbSet<MstUserRole> MstUserRole { get; set; }
        public virtual DbSet<MstUsers> MstUsers { get; set; }
        public virtual DbSet<MstUserStatus> MstUserStatus { get; set; }
        public virtual DbSet<MstVersion> MstVersion { get; set; }
        public virtual DbSet<MstVolumeType> MstVolumeType { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<PostAttachment> PostAttachment { get; set; }
        public virtual DbSet<PrdBid> PrdBid { get; set; }
        public virtual DbSet<PrdCategory> PrdCategory { get; set; }
        public virtual DbSet<PrdOrderDetails> PrdOrderDetails { get; set; }
        public virtual DbSet<PrdOrderPayment> PrdOrderPayment { get; set; }
        public virtual DbSet<PrdOrders> PrdOrders { get; set; }
        public virtual DbSet<PrdOrderStatus> PrdOrderStatus { get; set; }
        public virtual DbSet<PrdOrderStatusType> PrdOrderStatusType { get; set; }
        public virtual DbSet<PrdProducts> PrdProducts { get; set; }
        public virtual DbSet<PrdShoppingCart> PrdShoppingCart { get; set; }
        public virtual DbSet<PrdSubCategory> PrdSubCategory { get; set; }
        public virtual DbSet<SystemRole> SystemRole { get; set; }
        public virtual DbSet<SystemUser> SystemUser { get; set; }

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string projectpath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location).ToString();
                string currentdir = Directory.GetCurrentDirectory();
                IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

                //var builder = new dbcontextoptionsbuilder<ezyfind_devcontext>();
                var connectionString = configuration.GetSection("ConnectionString").GetSection("EzyFindDBConnection").Value;
                optionsBuilder.UseSqlServer(connectionString);
                base.OnConfiguring(optionsBuilder);
            }

            //if (!optionsBuilder.IsConfigured)
            //{
            //    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings. 
            //    optionsBuilder.UseSqlServer("Server=ezyfindsqldev.czdto6qpwk2z.us-east-2.rds.amazonaws.com,1433;Database=EzyFind_Dev;User ID=Dev;Password=EzyFind2233!;");
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Query<out_usp_GetUsersList>();

            modelBuilder.Entity<DevForms>(entity =>
            {
                entity.HasKey(e => e.FormId);

                entity.ToTable("DEV_Forms");

                entity.Property(e => e.FormName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FormUrl)
                    .HasColumnName("FormURL")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsForm).HasDefaultValueSql("((1))");

                entity.Property(e => e.SortOrder).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.ParentFormNavigation)
                    .WithMany(p => p.InverseParentFormNavigation)
                    .HasForeignKey(d => d.ParentForm)
                    .HasConstraintName("FK_DEV_Forms_DEV_Forms");
            });

            modelBuilder.Entity<ElmahError>(entity =>
            {
                entity.HasKey(e => e.ErrorId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("ELMAH_Error");

                entity.Property(e => e.ErrorId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AllXml)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.Application)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TimeUtc).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.DomainId).HasColumnName("DomainID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.TitleCategoryId).HasColumnName("TitleCategoryID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<MapCategoryAttributes>(entity =>
            {
                entity.HasKey(e => e.CategoryAttributeId);

                entity.ToTable("MAP_Category_Attributes");

                entity.Property(e => e.CategoryAttributeId).HasColumnName("Category_Attribute_ID");

                entity.Property(e => e.CatAttributeId).HasColumnName("CatAttributeID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CatAttribute)
                    .WithMany(p => p.MapCategoryAttributes)
                    .HasForeignKey(d => d.CatAttributeId)
                    .HasConstraintName("FK_MAP_Category_Attributes_MST_CategoryAttribute");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MapCategoryAttributes)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_MAP_Category_Attributes_MST_Category");
            });

            modelBuilder.Entity<MapCompanyArea>(entity =>
            {
                entity.HasKey(e => e.CompanyAreaId);

                entity.ToTable("MAP_Company_Area");

                entity.Property(e => e.CompanyAreaId).HasColumnName("Company_Area_ID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CompPackageId).HasColumnName("CompPackageID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.SuburbId).HasColumnName("SuburbID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.MapCompanyArea)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_MAP_Company_Area_MST_City");

                entity.HasOne(d => d.CompPackage)
                    .WithMany(p => p.MapCompanyArea)
                    .HasForeignKey(d => d.CompPackageId)
                    .HasConstraintName("FK_MAP_Company_Area_MAP_Company_Package");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.MapCompanyArea)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_MAP_Company_Area_MST_Country");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.MapCompanyArea)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_MAP_Company_Area_MST_Province");

                entity.HasOne(d => d.Suburb)
                    .WithMany(p => p.MapCompanyArea)
                    .HasForeignKey(d => d.SuburbId)
                    .HasConstraintName("FK_MAP_Company_Area_MST_Suburb");
            });

            modelBuilder.Entity<MapCompanyAuditLog>(entity =>
            {
                entity.HasKey(e => e.AuditLogId);

                entity.ToTable("MAP_Company_AuditLog");

                entity.Property(e => e.AuditLogId).HasColumnName("AuditLogID");

                entity.Property(e => e.AuditDate).HasColumnType("datetime");

                entity.Property(e => e.AuditLog)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MapCompanyAuditLog)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MAP_Company_AuditLog_MST_Company");
            });

            modelBuilder.Entity<MapCompanyCategory>(entity =>
            {
                entity.HasKey(e => e.CompanyCategoryId);

                entity.ToTable("MAP_Company_Category");

                entity.HasIndex(e => new { e.CategoryId, e.CompPackageId })
                    .HasName("M_COMP_CAT");

                entity.Property(e => e.CompanyCategoryId).HasColumnName("Company_Category_ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CompPackageId).HasColumnName("CompPackageID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CompPackage)
                    .WithMany(p => p.MapCompanyCategory)
                    .HasForeignKey(d => d.CompPackageId)
                    .HasConstraintName("FK_MAP_Company_Category_MST_Company");
            });

            modelBuilder.Entity<MapCompanyDocument>(entity =>
            {
                entity.HasKey(e => e.CompDocId);

                entity.ToTable("MAP_Company_Document");

                entity.Property(e => e.CompDocId).HasColumnName("CompDocID");

                entity.Property(e => e.AboutDocument)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentPath)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentStatusId).HasColumnName("DocumentStatusID");

                entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RejectReason)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MapCompanyDocument)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MAP_Company_Document_MST_Company");

                entity.HasOne(d => d.DocumentStatus)
                    .WithMany(p => p.MapCompanyDocument)
                    .HasForeignKey(d => d.DocumentStatusId)
                    .HasConstraintName("FK_MAP_Company_Document_MST_DocumentStatus");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.MapCompanyDocument)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .HasConstraintName("FK_MAP_Company_Document_MST_CompanyDocumentType");
            });

            modelBuilder.Entity<MapCompanyEmail>(entity =>
            {
                entity.HasKey(e => e.CompMailId);

                entity.ToTable("MAP_Company_Email");

                entity.Property(e => e.CompMailId).HasColumnName("CompMailID");

                entity.Property(e => e.CompPackageId).HasColumnName("CompPackageID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CompPackage)
                    .WithMany(p => p.MapCompanyEmail)
                    .HasForeignKey(d => d.CompPackageId)
                    .HasConstraintName("FK_MAP_Company_Email_MAP_Company_Package1");
            });

            modelBuilder.Entity<MapCompanyMagazineAd>(entity =>
            {
                entity.HasKey(e => e.CompMagId);

                entity.ToTable("MAP_Company_MagazineAd");

                entity.Property(e => e.CompMagId).HasColumnName("CompMagID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.HasOne(d => d.MagazineAd)
                    .WithMany(p => p.MapCompanyMagazineAd)
                    .HasForeignKey(d => d.MagazineAdId)
                    .HasConstraintName("FK_MAP_Company_MagazineAd_MST_MagazineAd");
            });

            modelBuilder.Entity<MapCompanyPackage>(entity =>
            {
                entity.HasKey(e => e.CompPackageId);

                entity.ToTable("MAP_Company_Package");

                entity.HasIndex(e => new { e.CompPackageId, e.CompanyId, e.IsActive, e.FromDate, e.ToDate })
                    .HasName("IDX_CP_CPID_CID");

                entity.Property(e => e.CompPackageId).HasColumnName("CompPackageID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.MapCompanyPackage)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK_MAP_Company_Package_MST_Package");
            });

            modelBuilder.Entity<MapCompanyPayment>(entity =>
            {
                entity.HasKey(e => e.CompPaymentId);

                entity.ToTable("MAP_Company_Payment");

                entity.Property(e => e.CompPaymentId).HasColumnName("CompPaymentID");

                entity.Property(e => e.CompPackageId).HasColumnName("CompPackageID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNumber)
                    .IsUnicode(false)
                    .HasComputedColumnSql("('INV - 000'+CONVERT([varchar](max),[CompPaymentID]))");

                entity.Property(e => e.InvoicePath).IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentModeId).HasColumnName("PaymentModeID");

                entity.Property(e => e.PaymentStatusId).HasColumnName("PaymentStatusID");

                entity.Property(e => e.TotalAmountUsd).HasColumnName("TotalAmountUSD");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .IsUnicode(false);

                entity.HasOne(d => d.CompPackage)
                    .WithMany(p => p.MapCompanyPayment)
                    .HasForeignKey(d => d.CompPackageId)
                    .HasConstraintName("FK_MAP_Company_Payment_MAP_Company_Package");

                entity.HasOne(d => d.PaymentMode)
                    .WithMany(p => p.MapCompanyPayment)
                    .HasForeignKey(d => d.PaymentModeId)
                    .HasConstraintName("FK_MAP_Company_Payment_MST_PaymentMode");

                entity.HasOne(d => d.PaymentStatus)
                    .WithMany(p => p.MapCompanyPayment)
                    .HasForeignKey(d => d.PaymentStatusId)
                    .HasConstraintName("FK_MAP_Company_Payment_MST_PaymentStatus");
            });

            modelBuilder.Entity<MapCompanyProvide>(entity =>
            {
                entity.HasKey(e => e.ProvideKeywordId);

                entity.ToTable("MAP_Company_Provide");

                entity.Property(e => e.ProvideKeywordId).HasColumnName("ProvideKeywordID");

                entity.Property(e => e.CompPackageId).HasColumnName("CompPackageID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.KeywordId).HasColumnName("KeywordID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PeriodTypeId).HasColumnName("PeriodTypeID");

                entity.Property(e => e.QuantityTypeId).HasColumnName("QuantityTypeID");

                entity.Property(e => e.VolumeTypeId).HasColumnName("VolumeTypeID");

                entity.HasOne(d => d.CompPackage)
                    .WithMany(p => p.MapCompanyProvide)
                    .HasForeignKey(d => d.CompPackageId)
                    .HasConstraintName("FK_MAP_Company_Provide_MAP_Company_Package");

                entity.HasOne(d => d.Keyword)
                    .WithMany(p => p.MapCompanyProvide)
                    .HasForeignKey(d => d.KeywordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MAP_Company_Provide_MST_Keywords");

                entity.HasOne(d => d.PeriodType)
                    .WithMany(p => p.MapCompanyProvide)
                    .HasForeignKey(d => d.PeriodTypeId)
                    .HasConstraintName("FK_MAP_Company_Provide_MST_PeriodType");

                entity.HasOne(d => d.QuantityType)
                    .WithMany(p => p.MapCompanyProvide)
                    .HasForeignKey(d => d.QuantityTypeId)
                    .HasConstraintName("FK_MAP_Company_Provide_MST_QuantityType");

                entity.HasOne(d => d.VolumeType)
                    .WithMany(p => p.MapCompanyProvide)
                    .HasForeignKey(d => d.VolumeTypeId)
                    .HasConstraintName("FK_MAP_Company_Provide_MST_VolumeType");
            });

            modelBuilder.Entity<MapCompanySeek>(entity =>
            {
                entity.HasKey(e => e.SeekKeywordId);

                entity.ToTable("MAP_Company_Seek");

                entity.Property(e => e.SeekKeywordId).HasColumnName("SeekKeywordID");

                entity.Property(e => e.CompPackageId).HasColumnName("CompPackageID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.KeywordId).HasColumnName("KeywordID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PeriodTypeId).HasColumnName("PeriodTypeID");

                entity.Property(e => e.QuantityTypeId).HasColumnName("QuantityTypeID");

                entity.Property(e => e.VolumeTypeId).HasColumnName("VolumeTypeID");

                entity.HasOne(d => d.CompPackage)
                    .WithMany(p => p.MapCompanySeek)
                    .HasForeignKey(d => d.CompPackageId)
                    .HasConstraintName("FK_MAP_Company_Seek_MAP_Company_Package");

                entity.HasOne(d => d.Keyword)
                    .WithMany(p => p.MapCompanySeek)
                    .HasForeignKey(d => d.KeywordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MAP_Company_Seek_MST_Keywords");

                entity.HasOne(d => d.PeriodType)
                    .WithMany(p => p.MapCompanySeek)
                    .HasForeignKey(d => d.PeriodTypeId)
                    .HasConstraintName("FK_MAP_Company_Seek_MST_PeriodType");

                entity.HasOne(d => d.QuantityType)
                    .WithMany(p => p.MapCompanySeek)
                    .HasForeignKey(d => d.QuantityTypeId)
                    .HasConstraintName("FK_MAP_Company_Seek_MST_QuantityType");

                entity.HasOne(d => d.VolumeType)
                    .WithMany(p => p.MapCompanySeek)
                    .HasForeignKey(d => d.VolumeTypeId)
                    .HasConstraintName("FK_MAP_Company_Seek_MST_VolumeType");
            });

            modelBuilder.Entity<MapCompanyTask>(entity =>
            {
                entity.HasKey(e => e.CompTaskId);

                entity.ToTable("MAP_Company_Task");

                entity.Property(e => e.CompTaskId).HasColumnName("CompTaskID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MapCompanyTask)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MAP_Company_Task_MST_Company");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.MapCompanyTask)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_MAP_Company_Task_MST_CompanyTaskList");
            });

            modelBuilder.Entity<MapCompanyUsers>(entity =>
            {
                entity.HasKey(e => e.CompanyUserId);

                entity.ToTable("MAP_Company_Users");

                entity.Property(e => e.CompanyUserId).HasColumnName("CompanyUserID");

                entity.Property(e => e.CompPackageId).HasColumnName("CompPackageID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsMainBusinessUser).HasColumnName("isMainBusinessUser");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.CompPackage)
                    .WithMany(p => p.MapCompanyUsers)
                    .HasForeignKey(d => d.CompPackageId)
                    .HasConstraintName("FK_MAP_Company_Users_MAP_Company_Package");
            });

            modelBuilder.Entity<MapCustomerEnquiryUpload>(entity =>
            {
                entity.HasKey(e => e.CeUploadId);

                entity.ToTable("MAP_CustomerEnquiry_Upload");

                entity.Property(e => e.CeUploadId).HasColumnName("CE_UploadID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerEnquiryId).HasColumnName("CustomerEnquiryID");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ThumbNailPath)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.UploadPath)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.CustomerEnquiry)
                    .WithMany(p => p.MapCustomerEnquiryUpload)
                    .HasForeignKey(d => d.CustomerEnquiryId)
                    .HasConstraintName("FK_MAP_CustomerEnquiry_Upload_MST_CustomerEnquiry");
            });

            modelBuilder.Entity<MapEflyersUpload>(entity =>
            {
                entity.HasKey(e => e.EflyerUploadId);

                entity.ToTable("MAP_EFlyers_Upload");

                entity.Property(e => e.EflyerUploadId).HasColumnName("EflyerUploadID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Efmid).HasColumnName("EFMID");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ThumbNailImagePath)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Efm)
                    .WithMany(p => p.MapEflyersUpload)
                    .HasForeignKey(d => d.Efmid)
                    .HasConstraintName("FK_MAP_EFlyers_Upload_MST_E_Flyers");
            });

            modelBuilder.Entity<MapItemRequestArea>(entity =>
            {
                entity.HasKey(e => e.IrAreaId);

                entity.ToTable("MAP_ItemRequest_Area");

                entity.Property(e => e.IrAreaId).HasColumnName("IR_Area_ID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ItemRequestId).HasColumnName("ItemRequestID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.SuburbId).HasColumnName("SuburbID");
            });

            modelBuilder.Entity<MapItemRequestCategory>(entity =>
            {
                entity.HasKey(e => e.IrCategoryId);

                entity.ToTable("MAP_ItemRequest_Category");

                entity.Property(e => e.IrCategoryId).HasColumnName("IR_Category_ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ItemRequestId).HasColumnName("ItemRequestID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MapItemRequestCategoryAttribute>(entity =>
            {
                entity.HasKey(e => e.IrCategoryAttributeId);

                entity.ToTable("MAP_ItemRequest_Category_Attribute");

                entity.Property(e => e.IrCategoryAttributeId).HasColumnName("IR_Category_Attribute_ID");

                entity.Property(e => e.CategoryAttributeId).HasColumnName("Category_Attribute_ID");

                entity.Property(e => e.CategoryValue).IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ItemRequestId).HasColumnName("ItemRequestID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CategoryAttribute)
                    .WithMany(p => p.MapItemRequestCategoryAttribute)
                    .HasForeignKey(d => d.CategoryAttributeId)
                    .HasConstraintName("FK_MAP_ItemRequest_Category_Attribute_MAP_Category_Attributes");

                entity.HasOne(d => d.ItemRequest)
                    .WithMany(p => p.MapItemRequestCategoryAttribute)
                    .HasForeignKey(d => d.ItemRequestId)
                    .HasConstraintName("FK_MAP_ItemRequest_Category_Attribute_MST_ItemRequest");
            });

            modelBuilder.Entity<MapItemRequestUpload>(entity =>
            {
                entity.HasKey(e => e.IrUploadId);

                entity.ToTable("MAP_ItemRequest_Upload");

                entity.Property(e => e.IrUploadId).HasColumnName("IR_UploadID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ItemRequestId).HasColumnName("ItemRequestID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ThumbNailPath)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.UploadPath)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MapItemResponseUpload>(entity =>
            {
                entity.HasKey(e => e.IrUploadId);

                entity.ToTable("MAP_ItemResponse_Upload");

                entity.Property(e => e.IrUploadId).HasColumnName("IR_UploadID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ItemResponseId).HasColumnName("ItemResponseID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UploadPath)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.HasOne(d => d.ItemResponse)
                    .WithMany(p => p.MapItemResponseUpload)
                    .HasForeignKey(d => d.ItemResponseId)
                    .HasConstraintName("FK_MAP_ItemResponse_Upload_MST_ItemResponse");
            });

            modelBuilder.Entity<MapPackageAttributes>(entity =>
            {
                entity.HasKey(e => e.PackageDetailId);

                entity.ToTable("MAP_Package_Attributes");

                entity.Property(e => e.PackageDetailId).HasColumnName("PackageDetailID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.PattributeId).HasColumnName("PAttributeID");

                entity.Property(e => e.Value)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.MapPackageAttributes)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK_MAP_Package_Attributes_MST_Package");

                entity.HasOne(d => d.Pattribute)
                    .WithMany(p => p.MapPackageAttributes)
                    .HasForeignKey(d => d.PattributeId)
                    .HasConstraintName("FK_MAP_Package_Attributes_MST_PackageAttribute");
            });

            modelBuilder.Entity<MapProductDocument>(entity =>
            {
                entity.HasKey(e => e.DocumentId);

                entity.ToTable("MAP_Product_Document");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentPath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.MapProductDocument)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_MAP_Product_Document_PRD_Products");
            });

            modelBuilder.Entity<MapProductImages>(entity =>
            {
                entity.HasKey(e => e.ImageId);

                entity.ToTable("MAP_Product_Images");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.MapProductImages)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_MAP_Product_Images_PRD_Products");
            });

            modelBuilder.Entity<MapSettingsRole>(entity =>
            {
                entity.HasKey(e => e.Srid);

                entity.ToTable("MAP_Settings_Role");

                entity.Property(e => e.Srid).HasColumnName("SRID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.MapSettingsRole)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_MAP_Settings_Role_MST_User_Role");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.MapSettingsRole)
                    .HasForeignKey(d => d.SettingId)
                    .HasConstraintName("FK_MAP_Settings_Role_MST_Settings");
            });

            modelBuilder.Entity<MapSpecialUpload>(entity =>
            {
                entity.HasKey(e => e.SpecialUploadId);

                entity.ToTable("MAP_Special_Upload");

                entity.Property(e => e.SpecialUploadId).HasColumnName("SpecialUploadID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Label)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SpecialId).HasColumnName("SpecialID");

                entity.Property(e => e.ThumbNailPath)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.UploadPath)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Special)
                    .WithMany(p => p.MapSpecialUpload)
                    .HasForeignKey(d => d.SpecialId)
                    .HasConstraintName("FK_MAP_Special_Upload_MST_Specials");
            });

            modelBuilder.Entity<MapUserRoleRights>(entity =>
            {
                entity.HasKey(e => e.RightsId);

                entity.ToTable("MAP_User_Role_Rights");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.MapUserRoleRights)
                    .HasForeignKey(d => d.FormId)
                    .HasConstraintName("FK_MAP_User_Role_Rights_DEV_Forms");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.MapUserRoleRights)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_MAP_User_Role_Rights_MST_User_Role");
            });

            modelBuilder.Entity<MapUsersSettings>(entity =>
            {
                entity.HasKey(e => e.UserSettingId);

                entity.ToTable("MAP_Users_Settings");

                entity.Property(e => e.AccessToken)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SPost).HasColumnName("sPost");

                entity.Property(e => e.SUserId)
                    .HasColumnName("sUserID")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Sms).HasColumnName("SMS");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.MapUsersSettings)
                    .HasForeignKey(d => d.SettingId)
                    .HasConstraintName("FK_MAP_Users_Settings_MST_Settings");
            });

            modelBuilder.Entity<MstBeestatus>(entity =>
            {
                entity.HasKey(e => e.BeestatusId);

                entity.ToTable("MST_BEEStatus");

                entity.Property(e => e.BeestatusId)
                    .HasColumnName("BEEStatusID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BeestatusName)
                    .HasColumnName("BEEStatusName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProcurementRecognition).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ScorePoint)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Beestatus)
                    .WithOne(p => p.InverseBeestatus)
                    .HasForeignKey<MstBeestatus>(d => d.BeestatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MST_BEEStatus_MST_BEEStatus");
            });

            modelBuilder.Entity<MstCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("MST_Category");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryIcon)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryThumbNailIcon)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsCategory).HasColumnName("isCategory");

                entity.Property(e => e.IsMainCategory).HasColumnName("isMainCategory");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParentCategoryId).HasColumnName("ParentCategoryID");

                entity.HasOne(d => d.ParentCategory)
                    .WithMany(p => p.InverseParentCategory)
                    .HasForeignKey(d => d.ParentCategoryId)
                    .HasConstraintName("FK_Mst_Category_Mst_Category");
            });

            modelBuilder.Entity<MstCategoryAttribute>(entity =>
            {
                entity.HasKey(e => e.CatAttributeId);

                entity.ToTable("MST_CategoryAttribute");

                entity.Property(e => e.CatAttributeId).HasColumnName("CatAttributeID");

                entity.Property(e => e.CatAttribute).IsUnicode(false);

                entity.Property(e => e.CatAttributeDataTypeId).HasColumnName("CatAttributeDataTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CatAttributeDataType)
                    .WithMany(p => p.MstCategoryAttribute)
                    .HasForeignKey(d => d.CatAttributeDataTypeId)
                    .HasConstraintName("FK_MST_CategoryAttribute_MST_CategoryAttributeDataType");
            });

            modelBuilder.Entity<MstCategoryAttributeDataType>(entity =>
            {
                entity.HasKey(e => e.CatAttributeDataTypeId);

                entity.ToTable("MST_CategoryAttributeDataType");

                entity.Property(e => e.CatAttributeDataTypeId).HasColumnName("CatAttributeDataTypeID");

                entity.Property(e => e.CatAttributeDataType)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstCity>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("MST_City");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityName).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.MstCity)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_City_Province");
            });

            modelBuilder.Entity<MstCms>(entity =>
            {
                entity.HasKey(e => e.Cmsid);

                entity.ToTable("MST_CMS");

                entity.Property(e => e.Cmsid).HasColumnName("CMSID");

                entity.Property(e => e.Cmstext)
                    .HasColumnName("CMSText")
                    .IsUnicode(false);

                entity.Property(e => e.Cmstitle)
                    .HasColumnName("CMSTitle")
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstCompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.ToTable("MST_Company");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.BeestatusId).HasColumnName("BEEStatusID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyStatusId).HasColumnName("CompanyStatusID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CrmInvoiceFooter)
                    .HasColumnName("CRM_InvoiceFooter")
                    .IsUnicode(false);

                entity.Property(e => e.CrmInvoiceHeader)
                    .HasColumnName("CRM_InvoiceHeader")
                    .IsUnicode(false);

                entity.Property(e => e.CrmQuoteFooter)
                    .HasColumnName("CRM_QuoteFooter")
                    .IsUnicode(false);

                entity.Property(e => e.CrmQuoteHeader)
                    .HasColumnName("CRM_QuoteHeader")
                    .IsUnicode(false);

                entity.Property(e => e.CrmcolorCode)
                    .HasColumnName("CRMColorCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.DomainUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Featured).HasDefaultValueSql("((0))");

                entity.Property(e => e.FranchiseeId).HasColumnName("FranchiseeID");

                entity.Property(e => e.HelpDeskNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LogoPath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MainBusinessUserId).HasColumnName("MainBusinessUserID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PayFastMerchantId)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.PayFastMerchantKey)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.PayGateMerchantId)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.PayGateMerchantKey)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.PayPalMerchantId)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.PayPalMerchantKey)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vatnumber)
                    .HasColumnName("VATNumber")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WebSite)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Beestatus)
                    .WithMany(p => p.MstCompany)
                    .HasForeignKey(d => d.BeestatusId)
                    .HasConstraintName("FK_MST_Company_MST_BEEStatus1");

                entity.HasOne(d => d.CompanyStatus)
                    .WithMany(p => p.MstCompany)
                    .HasForeignKey(d => d.CompanyStatusId)
                    .HasConstraintName("FK_MST_Company_MST_CompanyStatus");
            });

            modelBuilder.Entity<MstCompanyDocumentType>(entity =>
            {
                entity.HasKey(e => e.DocumentTypeId);

                entity.ToTable("MST_CompanyDocumentType");

                entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstCompanyStatus>(entity =>
            {
                entity.HasKey(e => e.CompanyStatusId);

                entity.ToTable("MST_CompanyStatus");

                entity.Property(e => e.CompanyStatusId).HasColumnName("CompanyStatusID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstCompanyTaskList>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.ToTable("MST_CompanyTaskList");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Percentage).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TaskDescription)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.TaskName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstConfiguration>(entity =>
            {
                entity.HasKey(e => e.ConfigurationId);

                entity.ToTable("MST_Configuration");

                entity.Property(e => e.FbApiclientId)
                    .HasColumnName("FB_APIClientID")
                    .IsUnicode(false);

                entity.Property(e => e.FbApisecretKey)
                    .HasColumnName("FB_APISecretKey")
                    .IsUnicode(false);

                entity.Property(e => e.FbFanPageLink)
                    .HasColumnName("FB_FanPageLink")
                    .IsUnicode(false);

                entity.Property(e => e.GpApiclientId)
                    .HasColumnName("GP_APIClientID")
                    .IsUnicode(false);

                entity.Property(e => e.GpApisecretKey)
                    .HasColumnName("GP_APISecretKey")
                    .IsUnicode(false);

                entity.Property(e => e.GpFanPageLink)
                    .HasColumnName("GP_FanPageLink")
                    .IsUnicode(false);

                entity.Property(e => e.IgApiclientId)
                    .HasColumnName("IG_APIClientID")
                    .IsUnicode(false);

                entity.Property(e => e.IgApisecretKey)
                    .HasColumnName("IG_APISecretKey")
                    .IsUnicode(false);

                entity.Property(e => e.IgFanPageLink)
                    .HasColumnName("IG_FanPageLink")
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SmsIsEnabled).HasColumnName("SMS_IsEnabled");

                entity.Property(e => e.SmsPassword)
                    .HasColumnName("SMS_Password")
                    .IsUnicode(false);

                entity.Property(e => e.SmsUserName)
                    .HasColumnName("SMS_UserName")
                    .IsUnicode(false);

                entity.Property(e => e.SmtpEnableSsl).HasColumnName("SMTP_EnableSSL");

                entity.Property(e => e.SmtpFromEmail)
                    .HasColumnName("SMTP_FromEmail")
                    .IsUnicode(false);

                entity.Property(e => e.SmtpFromName)
                    .HasColumnName("SMTP_FromName")
                    .IsUnicode(false);

                entity.Property(e => e.SmtpHostServer)
                    .HasColumnName("SMTP_HostServer")
                    .IsUnicode(false);

                entity.Property(e => e.SmtpPassword)
                    .HasColumnName("SMTP_Password")
                    .IsUnicode(false);

                entity.Property(e => e.SmtpPort)
                    .HasColumnName("SMTP_Port")
                    .IsUnicode(false);

                entity.Property(e => e.SmtpUserName)
                    .HasColumnName("SMTP_UserName")
                    .IsUnicode(false);

                entity.Property(e => e.TwApiclientId)
                    .HasColumnName("TW_APIClientID")
                    .IsUnicode(false);

                entity.Property(e => e.TwApisecretKey)
                    .HasColumnName("TW_APISecretKey")
                    .IsUnicode(false);

                entity.Property(e => e.TwFanPageLink)
                    .HasColumnName("TW_FanPageLink")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstContactForm>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("MST_ContactForm");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("MST_Country");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryName).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstCrmCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("MST_CRM_Customer");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo).HasMaxLength(50);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.StreetAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.SuburbId).HasColumnName("SuburbID");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstCrmCustomerComment>(entity =>
            {
                entity.HasKey(e => e.CustomerCommentId);

                entity.ToTable("MST_CRM_CustomerComment");

                entity.Property(e => e.Comment)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.CommentDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.MstCrmCustomerComment)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_MST_CustomerComment_MST_Customer");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MstCrmCustomerComment)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_MST_CustomerComment_MST_Users");
            });

            modelBuilder.Entity<MstCrmInventory>(entity =>
            {
                entity.HasKey(e => e.InventoryId);

                entity.ToTable("MST_CRM_Inventory");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InventoryDescription).IsUnicode(false);

                entity.Property(e => e.InventoryName)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OfficeDescription).IsUnicode(false);

                entity.Property(e => e.QunatityTypeName).IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MstCrmInventory)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MST_Inventory_MST_Company");

                entity.HasOne(d => d.InventoryType)
                    .WithMany(p => p.MstCrmInventory)
                    .HasForeignKey(d => d.InventoryTypeId)
                    .HasConstraintName("FK_MST_Inventory_MST_InventoryType");
            });

            modelBuilder.Entity<MstCrmInventoryType>(entity =>
            {
                entity.HasKey(e => e.InventoryTypeId);

                entity.ToTable("MST_CRM_InventoryType");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InventoryTypeName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstCrmInvoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);

                entity.ToTable("MST_CRM_Invoice");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDescription).IsUnicode(false);

                entity.Property(e => e.InvoiceFooter).IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(('INVOICE - 000'+CONVERT([varchar](max),[CompanyId]))+CONVERT([varchar](max),[InvoiceId]))");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentModeId).HasColumnName("PaymentModeID");

                entity.Property(e => e.PaymentStatusId).HasColumnName("PaymentStatusID");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .IsUnicode(false);

                entity.Property(e => e.Vatamount).HasColumnName("VATAmount");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MstCrmInvoice)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MST_Invoice_MST_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.MstCrmInvoice)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_MST_Invoice_MST_Users");
            });

            modelBuilder.Entity<MstCrmInvoiceDetails>(entity =>
            {
                entity.HasKey(e => e.InvoiceLineItemId);

                entity.ToTable("MST_CRM_InvoiceDetails");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Inventory)
                    .WithMany(p => p.MstCrmInvoiceDetails)
                    .HasForeignKey(d => d.InventoryId)
                    .HasConstraintName("FK_MST_InvoiceDetails_MST_Inventory");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.MstCrmInvoiceDetails)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_MST_InvoiceDetails_MST_Invoice");
            });

            modelBuilder.Entity<MstCrmQuote>(entity =>
            {
                entity.HasKey(e => e.QuoteId);

                entity.ToTable("MST_CRM_Quote");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.QuoteDate).HasColumnType("datetime");

                entity.Property(e => e.QuoteDescription).IsUnicode(false);

                entity.Property(e => e.QuoteFooter).IsUnicode(false);

                entity.Property(e => e.QuoteNo)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(('QUOTE - 000'+CONVERT([varchar](max),[CompanyId]))+CONVERT([varchar](max),[QuoteId]))");

                entity.Property(e => e.Vatamount).HasColumnName("VATAmount");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MstCrmQuote)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MST_Quote_MST_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.MstCrmQuote)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_MST_Quote_MST_Users");
            });

            modelBuilder.Entity<MstCrmQuoteDetails>(entity =>
            {
                entity.HasKey(e => e.QuoteLineItemId);

                entity.ToTable("MST_CRM_QuoteDetails");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Inventory)
                    .WithMany(p => p.MstCrmQuoteDetails)
                    .HasForeignKey(d => d.InventoryId)
                    .HasConstraintName("FK_MST_QuoteDetails_MST_Inventory");

                entity.HasOne(d => d.Quote)
                    .WithMany(p => p.MstCrmQuoteDetails)
                    .HasForeignKey(d => d.QuoteId)
                    .HasConstraintName("FK_MST_QuoteDetails_MST_Quote");
            });

            modelBuilder.Entity<MstCustomerEnquiry>(entity =>
            {
                entity.HasKey(e => e.CustomerEnquiryId);

                entity.ToTable("MST_CustomerEnquiry");

                entity.Property(e => e.CustomerEnquiryId).HasColumnName("CustomerEnquiryID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EnquiryDate).HasColumnType("datetime");

                entity.Property(e => e.EnquiryDescription)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.EnquiryStatusId).HasColumnName("EnquiryStatusID");

                entity.Property(e => e.EnquiryTitle)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MstCustomerEnquiry)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MST_CustomerEnquiry_MST_Company");

                entity.HasOne(d => d.EnquiryStatus)
                    .WithMany(p => p.MstCustomerEnquiry)
                    .HasForeignKey(d => d.EnquiryStatusId)
                    .HasConstraintName("FK_MST_CustomerEnquiry_MST_Status");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MstCustomerEnquiry)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_MST_CustomerEnquiry_MST_Users");
            });

            modelBuilder.Entity<MstCustomerEnquiryResponse>(entity =>
            {
                entity.HasKey(e => e.CeresponseId);

                entity.ToTable("MST_CustomerEnquiryResponse");

                entity.Property(e => e.CeresponseId).HasColumnName("CEResponseID");

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerEnquiryId).HasColumnName("CustomerEnquiryID");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ResponseDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MstCustomerEnquiryResponse)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MST_CustomerEnquiryResponse_MST_Company");

                entity.HasOne(d => d.CustomerEnquiry)
                    .WithMany(p => p.MstCustomerEnquiryResponse)
                    .HasForeignKey(d => d.CustomerEnquiryId)
                    .HasConstraintName("FK_MST_CustomerEnquiryResponse_MST_CustomerEnquiry");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MstCustomerEnquiryResponse)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_MST_CustomerEnquiryResponse_MST_Users");
            });

            modelBuilder.Entity<MstDocumentStatus>(entity =>
            {
                entity.HasKey(e => e.DocumentStatusId);

                entity.ToTable("MST_DocumentStatus");

                entity.Property(e => e.DocumentStatusId).HasColumnName("DocumentStatusID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentStatus)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstDomain>(entity =>
            {
                entity.HasKey(e => e.DomainId);

                entity.ToTable("MST_Domain");

                entity.Property(e => e.DomainId).HasColumnName("DomainID");

                entity.Property(e => e.DomainName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstEFlyers>(entity =>
            {
                entity.HasKey(e => e.Efmid);

                entity.ToTable("MST_E_Flyers");

                entity.Property(e => e.Efmid).HasColumnName("EFMID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsMenu).HasColumnName("isMenu");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Title)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MstEFlyers)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_MST_E_Flyers_MST_Category");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MstEFlyers)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MST_E_Flyers_MST_Company");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MstEFlyers)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_MST_E_Flyers_MST_Status");
            });

            modelBuilder.Entity<MstEmailStack>(entity =>
            {
                entity.HasKey(e => e.EmailStackId);

                entity.ToTable("MST_EmailStack");

                entity.Property(e => e.AttachmentName).IsUnicode(false);

                entity.Property(e => e.AttachmentPath).IsUnicode(false);

                entity.Property(e => e.EmailCreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailSentOn).HasColumnType("datetime");

                entity.Property(e => e.FromAddress)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ToBcc).HasColumnName("ToBCC");

                entity.Property(e => e.ToBccname).HasColumnName("ToBCCName");

                entity.Property(e => e.ToCc).HasColumnName("ToCC");

                entity.Property(e => e.ToCcname).HasColumnName("ToCCName");
            });

            modelBuilder.Entity<MstFavourites>(entity =>
            {
                entity.HasKey(e => e.MstFavouriteId);

                entity.ToTable("MST_Favourites");

                entity.Property(e => e.MstFavouriteId).HasColumnName("MST_FavouriteID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EflyerId).HasColumnName("EFlyerID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SpecialId).HasColumnName("SpecialID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MstFavourites)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MST_Favourites_MST_Company");

                entity.HasOne(d => d.Eflyer)
                    .WithMany(p => p.MstFavourites)
                    .HasForeignKey(d => d.EflyerId)
                    .HasConstraintName("FK_MST_Favourites_MST_E_Flyers");

                entity.HasOne(d => d.Special)
                    .WithMany(p => p.MstFavourites)
                    .HasForeignKey(d => d.SpecialId)
                    .HasConstraintName("FK_MST_Favourites_MST_Specials");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MstFavourites)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_MST_Favourites_MST_Users");
            });

            modelBuilder.Entity<MstFranchisee>(entity =>
            {
                entity.HasKey(e => e.FranchiseId);

                entity.ToTable("MST_Franchisee");

                entity.Property(e => e.FranchiseId).HasColumnName("FranchiseID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FranchiseName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FranchiseUserId).HasColumnName("FranchiseUserID");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.StreetAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.SuburbId).HasColumnName("SuburbID");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.MstFranchisee)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_MST_Franchisee_MST_Country");

                entity.HasOne(d => d.FranchiseUser)
                    .WithMany(p => p.MstFranchisee)
                    .HasForeignKey(d => d.FranchiseUserId)
                    .HasConstraintName("FK_MST_Franchisee_MST_Users");
            });

            modelBuilder.Entity<MstItemRequest>(entity =>
            {
                entity.HasKey(e => e.ItemRequestId);

                entity.ToTable("MST_ItemRequest");

                entity.Property(e => e.ItemRequestId).HasColumnName("ItemRequestID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ItemRequestDate).HasColumnType("datetime");

                entity.Property(e => e.ItemRequestDescription)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ItemRequestStatusId).HasColumnName("ItemRequestStatusID");

                entity.Property(e => e.ItemRequestTitle)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.RequestApprovedMail).HasDefaultValueSql("((0))");

                entity.Property(e => e.SuburbId).HasColumnName("SuburbID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MstItemRequest)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_MST_ItemRequest_MST_Category");

                entity.HasOne(d => d.ItemRequestStatus)
                    .WithMany(p => p.MstItemRequest)
                    .HasForeignKey(d => d.ItemRequestStatusId)
                    .HasConstraintName("FK_MST_ItemRequest_MST_Status");
            });

            modelBuilder.Entity<MstItemResponse>(entity =>
            {
                entity.HasKey(e => e.ItemResponseId);

                entity.ToTable("MST_ItemResponse");

                entity.Property(e => e.ItemResponseId).HasColumnName("ItemResponseID");

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsAccepted).HasColumnName("isAccepted");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsRejected).HasColumnName("isRejected");

                entity.Property(e => e.ItemRequestId).HasColumnName("ItemRequestID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReplyToId).HasColumnName("ReplyToID");

                entity.Property(e => e.ResponseDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MstItemResponse)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MST_ItemResponse_MST_Company");

                entity.HasOne(d => d.ReplyTo)
                    .WithMany(p => p.InverseReplyTo)
                    .HasForeignKey(d => d.ReplyToId)
                    .HasConstraintName("FK_MST_ItemResponse_MST_ItemResponse1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MstItemResponse)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_MST_ItemResponse_MST_Users");
            });

            modelBuilder.Entity<MstKeywords>(entity =>
            {
                entity.HasKey(e => e.KeywordId);

                entity.ToTable("MST_Keywords");

                entity.Property(e => e.KeywordId).HasColumnName("KeywordID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MstKeywords)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_MST_Keywords_MST_Category");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MstKeywords)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_MST_Keywords_MST_Status");
            });

            modelBuilder.Entity<MstMagazineAd>(entity =>
            {
                entity.HasKey(e => e.MagazineAdId);

                entity.ToTable("MST_MagazineAd");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.MagazineAdType)
                    .WithMany(p => p.MstMagazineAd)
                    .HasForeignKey(d => d.MagazineAdTypeId)
                    .HasConstraintName("FK_MST_MagazineAd_MST_MagazineAdType");

                entity.HasOne(d => d.MagazineSection)
                    .WithMany(p => p.MstMagazineAd)
                    .HasForeignKey(d => d.MagazineSectionId)
                    .HasConstraintName("FK_MST_MagazineAd_MST_MagazineSection");
            });

            modelBuilder.Entity<MstMagazineAdType>(entity =>
            {
                entity.HasKey(e => e.MagazineAdTypeId);

                entity.ToTable("MST_MagazineAdType");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.MagazineAdTypeName)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstMagazineSection>(entity =>
            {
                entity.HasKey(e => e.MagazineSectionId);

                entity.ToTable("MST_MagazineSection");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.MagazineSectionName)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstMailType>(entity =>
            {
                entity.HasKey(e => e.MailTypeId);

                entity.ToTable("MST_MailType");

                entity.Property(e => e.MailTypeId)
                    .HasColumnName("MailTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.MailBody).IsUnicode(false);

                entity.Property(e => e.MailSubject)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.MailType)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstNotificationStack>(entity =>
            {
                entity.HasKey(e => e.NotificationId);

                entity.ToTable("MST_NotificationStack");

                entity.Property(e => e.NotificationId).HasColumnName("NotificationID");

                entity.Property(e => e.DeviceId)
                    .HasColumnName("DeviceID")
                    .IsUnicode(false);

                entity.Property(e => e.NotificationDate).HasColumnType("datetime");

                entity.Property(e => e.PostData).IsUnicode(false);
            });

            modelBuilder.Entity<MstPackage>(entity =>
            {
                entity.HasKey(e => e.PackageId);

                entity.ToTable("MST_Package");

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsRecommended).HasColumnName("isRecommended");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PackageName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstPackageAttribute>(entity =>
            {
                entity.HasKey(e => e.PattributeId);

                entity.ToTable("MST_PackageAttribute");

                entity.Property(e => e.PattributeId).HasColumnName("PAttributeID");

                entity.Property(e => e.AttributeName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstPaymentMode>(entity =>
            {
                entity.HasKey(e => e.PaymentModeId);

                entity.ToTable("MST_PaymentMode");

                entity.Property(e => e.PaymentModeId).HasColumnName("PaymentModeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMode).HasMaxLength(50);
            });

            modelBuilder.Entity<MstPaymentStatus>(entity =>
            {
                entity.HasKey(e => e.PaymentStatusId);

                entity.ToTable("MST_PaymentStatus");

                entity.Property(e => e.PaymentStatusId).HasColumnName("PaymentStatusID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentStatus)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstPaymentType>(entity =>
            {
                entity.HasKey(e => e.PaymentTypeId);

                entity.ToTable("MST_PaymentType");

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.Description).HasMaxLength(20);
            });

            modelBuilder.Entity<MstPeriodType>(entity =>
            {
                entity.HasKey(e => e.PeriodTypeId);

                entity.ToTable("MST_PeriodType");

                entity.Property(e => e.PeriodTypeId).HasColumnName("PeriodTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PeriodType)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstProvince>(entity =>
            {
                entity.HasKey(e => e.ProvinceId);

                entity.ToTable("MST_Province");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProvinceName).HasMaxLength(50);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.MstProvince)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Province_Country");
            });

            modelBuilder.Entity<MstQuantityType>(entity =>
            {
                entity.HasKey(e => e.QuantityTypeId);

                entity.ToTable("MST_QuantityType");

                entity.Property(e => e.QuantityTypeId).HasColumnName("QuantityTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.QuantityType)
                    .HasMaxLength(5000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstRating>(entity =>
            {
                entity.ToTable("MST_Rating");

                entity.Property(e => e.MstRatingId).HasColumnName("MST_RatingID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EflyerId).HasColumnName("EFlyerID");

                entity.Property(e => e.EmaiId)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Review)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialId).HasColumnName("SpecialID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MstRating)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MST_Rating_MST_Company");

                entity.HasOne(d => d.Special)
                    .WithMany(p => p.MstRating)
                    .HasForeignKey(d => d.SpecialId)
                    .HasConstraintName("FK_MST_Rating_MST_Specials");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MstRating)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_MST_Rating_MST_Status");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MstRating)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_MST_Rating_MST_Users");
            });

            modelBuilder.Entity<MstSettings>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("MST_Settings");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SettingName)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.HasOne(d => d.SettingType)
                    .WithMany(p => p.MstSettings)
                    .HasForeignKey(d => d.SettingTypeId)
                    .HasConstraintName("FK_MST_Settings_MST_SettingType");
            });

            modelBuilder.Entity<MstSettingType>(entity =>
            {
                entity.HasKey(e => e.SettingTypeId);

                entity.ToTable("MST_SettingType");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SettingTypeName)
                    .HasMaxLength(5000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstSpecials>(entity =>
            {
                entity.HasKey(e => e.SpecialId);

                entity.ToTable("MST_Specials");

                entity.Property(e => e.SpecialId).HasColumnName("SpecialID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Featured).HasDefaultValueSql("((0))");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.SpecialName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StreetAddress).IsUnicode(false);

                entity.Property(e => e.SuburbId).HasColumnName("SuburbID");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MstSpecials)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_MST_Specials_MST_Category");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.MstSpecials)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_MST_Specials_MST_City");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MstSpecials)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MST_Specials_MST_Company");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.MstSpecials)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_MST_Specials_MST_Country");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.MstSpecials)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_MST_Specials_MST_Province");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MstSpecials)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_MST_Specials_MST_Status");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.MstSpecials)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_MST_Specials_MST_Suburb");
            });

            modelBuilder.Entity<MstStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("MST_Status");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstSuburb>(entity =>
            {
                entity.HasKey(e => e.SuburbId);

                entity.ToTable("MST_Suburb");

                entity.Property(e => e.SuburbId).HasColumnName("SuburbID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SuburbName).HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.MstSuburb)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_SubUrb_City");
            });

            modelBuilder.Entity<MstUserRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("MST_User_Role");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstUsers>(entity =>
            {
                entity.HasKey(e => e.UserId);               

                entity.ToTable("MST_Users");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactNo).HasMaxLength(50);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateofBirth).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasColumnName("DeviceID")
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                   .HasColumnName("Token")
                   .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmailActivationCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ForgetPasswordCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FranchiseId).HasColumnName("FranchiseID");

                entity.Property(e => e.IsLoggedIn).HasColumnName("isLoggedIn");

                entity.Property(e => e.IsMobileLoggedIn).HasColumnName("isMobileLoggedIn");

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogInCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileActivationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StreetAddress)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.SuburbId).HasColumnName("SuburbID");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserProfileImage)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.UserProfileThumbNailImage)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.MstUsers)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_MST_Users_MST_City");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MstUsers)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_MST_Users_MST_Company");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.MstUsers)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_MST_Users_MST_Country");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.MstUsers)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_MST_Users_MST_Province");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.MstUsers)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_MST_Users_MST_User_Role");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MstUsers)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_User_Mst_UserStatus");

                entity.HasOne(d => d.Suburb)
                    .WithMany(p => p.MstUsers)
                    .HasForeignKey(d => d.SuburbId)
                    .HasConstraintName("FK_MST_Users_MST_Suburb");
            });

            modelBuilder.Entity<MstUserStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("MST_UserStatus");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstVersion>(entity =>
            {
                entity.HasKey(e => e.VersionId);

                entity.ToTable("MST_Version");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.VersionType)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstVolumeType>(entity =>
            {
                entity.HasKey(e => e.VolumeTypeId);

                entity.ToTable("MST_VolumeType");

                entity.Property(e => e.VolumeTypeId).HasColumnName("VolumeTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.VolumeType)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.DomainId).HasColumnName("DomainID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.TitleCategoryId).HasColumnName("TitleCategoryID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<PostAttachment>(entity =>
            {
                entity.Property(e => e.PostAttachmentId).HasColumnName("PostAttachmentID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.ThumbNailImagePath)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostAttachment)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK_PostAttachment_Post");
            });

            modelBuilder.Entity<PrdBid>(entity =>
            {
                entity.HasKey(e => e.BidId);

                entity.ToTable("PRD_Bid");

                entity.Property(e => e.BidId).HasColumnName("BidID");

                entity.Property(e => e.BidAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BidApprovedMail).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsAccepted)
                    .HasColumnName("isAccepted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PrdBid)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_PRD_Bid_PRD_Products");
            });

            modelBuilder.Entity<PrdCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("PRD_Category");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CategoryName).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DomainId).HasColumnName("DomainID");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithOne(p => p.InverseCategory)
                    .HasForeignKey<PrdCategory>(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRD_Category_PRD_Category");

                entity.HasOne(d => d.Domain)
                    .WithMany(p => p.PrdCategory)
                    .HasForeignKey(d => d.DomainId)
                    .HasConstraintName("FK_PRD_Category_MST_Domain");
            });

            modelBuilder.Entity<PrdOrderDetails>(entity =>
            {
                entity.HasKey(e => e.OrderDetailsId);

                entity.ToTable("PRD_OrderDetails");

                entity.Property(e => e.OrderDetailsId).HasColumnName("OrderDetailsID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.PrdOrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_PRD_OrderDetails_PRD_Orders");
            });

            modelBuilder.Entity<PrdOrderPayment>(entity =>
            {
                entity.HasKey(e => e.OrderPaymentId);

                entity.ToTable("PRD_OrderPayment");

                entity.Property(e => e.OrderPaymentId).HasColumnName("OrderPaymentID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentModeId).HasColumnName("PaymentModeID");

                entity.Property(e => e.PaymentRefNo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.PaymentMode)
                    .WithMany(p => p.PrdOrderPayment)
                    .HasForeignKey(d => d.PaymentModeId)
                    .HasConstraintName("FK_PRD_OrderPayment_MST_PaymentMode");
            });

            modelBuilder.Entity<PrdOrders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("PRD_Orders");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiredDate).HasColumnType("date");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderIdstring)
                    .HasColumnName("OrderIDString")
                    .HasMaxLength(38)
                    .IsUnicode(false)
                    .HasComputedColumnSql("('EZYLP000'+CONVERT([varchar],[OrderID]))");

                entity.Property(e => e.OrderIpaddress)
                    .HasColumnName("OrderIPaddress")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSessionId)
                    .HasColumnName("OrderSessionID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatusID");

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PrdOrders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_PRD_Orders_MST_Users");
            });

            modelBuilder.Entity<PrdOrderStatus>(entity =>
            {
                entity.HasKey(e => e.OrderStatusId);

                entity.ToTable("PRD_OrderStatus");

                entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatusID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderStatusDate).HasColumnType("datetime");

                entity.Property(e => e.OrderStatusTypeId).HasColumnName("OrderStatusTypeID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.PrdOrderStatus)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_PRD_OrderStatus_PRD_Orders");
            });

            modelBuilder.Entity<PrdOrderStatusType>(entity =>
            {
                entity.HasKey(e => e.OrderStatusTypeId);

                entity.ToTable("PRD_OrderStatusType");

                entity.Property(e => e.OrderStatusTypeId).HasColumnName("OrderStatusTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrdProducts>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("PRD_Products");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Auction).HasDefaultValueSql("((0))");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentName).HasMaxLength(500);

                entity.Property(e => e.DocumentPath).HasMaxLength(500);

                entity.Property(e => e.DomainId).HasColumnName("DomainID");

                entity.Property(e => e.Featured).HasDefaultValueSql("((0))");

                entity.Property(e => e.Hire).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductImage).HasMaxLength(500);

                entity.Property(e => e.ProductName).HasMaxLength(500);

                entity.Property(e => e.ProductNumber).HasMaxLength(50);

                entity.Property(e => e.Special).HasDefaultValueSql("((0))");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PrdProducts)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_PRD_Products_PRD_CategoryID");

                entity.HasOne(d => d.Domain)
                    .WithMany(p => p.PrdProducts)
                    .HasForeignKey(d => d.DomainId)
                    .HasConstraintName("FK_PRD_Products_MST_Domain");
            });

            modelBuilder.Entity<PrdShoppingCart>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("PRD_ShoppingCart");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SessionId)
                    .HasColumnName("SessionID")
                    .HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PrdShoppingCart)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_PRD_ShoppingCart_PRD_Products");
            });

            modelBuilder.Entity<PrdSubCategory>(entity =>
            {
                entity.HasKey(e => e.SubCategoryId);

                entity.ToTable("PRD_SubCategory");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DomainId).HasColumnName("DomainID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubCategoryName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PrdSubCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_PRD_SubCategory_PRD_Category");
            });

            modelBuilder.Entity<SystemRole>(entity =>
            {
                entity.Property(e => e.SystemRoleId).HasColumnName("SystemRoleID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SystemRoleName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SystemUser>(entity =>
            {
                entity.Property(e => e.SystemUserId).HasColumnName("SystemUserID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SystemUserName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SystemUser)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_SystemUser_SystemRole");
            });
        }
    }
}
