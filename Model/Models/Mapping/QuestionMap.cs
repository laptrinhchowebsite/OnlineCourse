using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class QuestionMap : EntityTypeConfiguration<Question>
    {
        public QuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(3000);

            this.Property(t => t.Answer)
                .HasMaxLength(4000);

            this.Property(t => t.Type)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Question");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Answer).HasColumnName("Answer");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
