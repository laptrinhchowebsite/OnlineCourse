using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class ExamMap : EntityTypeConfiguration<Exam>
    {
        public ExamMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(250);

            this.Property(t => t.MetaTitle)
                .HasMaxLength(250);

            this.Property(t => t.Code)
                .HasMaxLength(10);

            this.Property(t => t.QuestionList)
                .HasMaxLength(200);

            this.Property(t => t.AnswerList)
                .HasMaxLength(200);

            this.Property(t => t.Type)
                .HasMaxLength(1);

            this.Property(t => t.UserList)
                .HasMaxLength(3000);

            this.Property(t => t.ScoreList)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Exam");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.MetaTitle).HasColumnName("MetaTitle");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.QuestionList).HasColumnName("QuestionList");
            this.Property(t => t.AnswerList).HasColumnName("AnswerList");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.TotalScore).HasColumnName("TotalScore");
            this.Property(t => t.Time).HasColumnName("Time");
            this.Property(t => t.TotalQuestion).HasColumnName("TotalQuestion");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.QuestionEssay).HasColumnName("QuestionEssay");
            this.Property(t => t.UserList).HasColumnName("UserList");
            this.Property(t => t.ScoreList).HasColumnName("ScoreList");
        }
    }
}
