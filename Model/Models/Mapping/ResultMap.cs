using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class ResultMap : EntityTypeConfiguration<Result>
    {
        public ResultMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UserID, t.ExamID });

            // Properties
            this.Property(t => t.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ExamID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ResultQuiz)
                .HasMaxLength(300);

            this.Property(t => t.StartDateQuiz)
                .HasMaxLength(300);

            this.Property(t => t.StartTimeQuiz)
                .HasMaxLength(20);

            this.Property(t => t.FinishTimeQuiz)
                .HasMaxLength(20);

            this.Property(t => t.StartTimeEssay)
                .HasMaxLength(20);

            this.Property(t => t.FinishTimeEssay)
                .HasMaxLength(20);

            this.Property(t => t.Score)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Result");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.ExamID).HasColumnName("ExamID");
            this.Property(t => t.ResultQuiz).HasColumnName("ResultQuiz");
            this.Property(t => t.ResultEssay).HasColumnName("ResultEssay");
            this.Property(t => t.StartDateQuiz).HasColumnName("StartDateQuiz");
            this.Property(t => t.StartTimeQuiz).HasColumnName("StartTimeQuiz");
            this.Property(t => t.FinishTimeQuiz).HasColumnName("FinishTimeQuiz");
            this.Property(t => t.StartDateEssay).HasColumnName("StartDateEssay");
            this.Property(t => t.StartTimeEssay).HasColumnName("StartTimeEssay");
            this.Property(t => t.FinishTimeEssay).HasColumnName("FinishTimeEssay");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Score).HasColumnName("Score");
        }
    }
}
