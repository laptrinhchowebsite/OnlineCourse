using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class ProductCategoryMap : EntityTypeConfiguration<ProductCategory>
    {
        public ProductCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.MetaTitle)
                .HasMaxLength(250);

            this.Property(t => t.CreateBy)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductCategory");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MetaTitle).HasColumnName("MetaTitle");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.CreateBy).HasColumnName("CreateBy");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ShowOnHome).HasColumnName("ShowOnHome");
        }
    }
}
