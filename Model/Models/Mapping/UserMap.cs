using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.UserName)
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .HasMaxLength(32);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Address)
                .HasMaxLength(350);

            this.Property(t => t.Email)
                .HasMaxLength(150);

            this.Property(t => t.Phone)
                .HasMaxLength(20);

            this.Property(t => t.CreateBy)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(50);

            this.Property(t => t.ProductList)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("User");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.CreateBy).HasColumnName("CreateBy");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ProductList).HasColumnName("ProductList");
        }
    }
}
