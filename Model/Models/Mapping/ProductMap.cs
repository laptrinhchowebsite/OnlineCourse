using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(250);

            this.Property(t => t.Code)
                .HasMaxLength(10);

            this.Property(t => t.MetaTitle)
                .HasMaxLength(250);

            this.Property(t => t.Description)
                .HasMaxLength(500);

            this.Property(t => t.Image)
                .HasMaxLength(250);

            this.Property(t => t.CreateBy)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(50);

            this.Property(t => t.MetaKeywords)
                .HasMaxLength(250);

            this.Property(t => t.MetaDescriptions)
                .HasMaxLength(250);

            this.Property(t => t.LinkVideo)
                .HasMaxLength(50);

            this.Property(t => t.ListType)
                .HasMaxLength(250);

            this.Property(t => t.ListFile)
                .HasMaxLength(3000);

            // Table & Column Mappings
            this.ToTable("Product");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.MetaTitle).HasColumnName("MetaTitle");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Image).HasColumnName("Image");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.PromotionPrice).HasColumnName("PromotionPrice");
            this.Property(t => t.IncludeVAT).HasColumnName("IncludeVAT");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.CategoryID).HasColumnName("CategoryID");
            this.Property(t => t.Detail).HasColumnName("Detail");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.CreateBy).HasColumnName("CreateBy");
            this.Property(t => t.ModifiDate).HasColumnName("ModifiDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.MetaKeywords).HasColumnName("MetaKeywords");
            this.Property(t => t.MetaDescriptions).HasColumnName("MetaDescriptions");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ViewCount).HasColumnName("ViewCount");
            this.Property(t => t.LinkVideo).HasColumnName("LinkVideo");
            this.Property(t => t.ListType).HasColumnName("ListType");
            this.Property(t => t.ListFile).HasColumnName("ListFile");
        }
    }
}
