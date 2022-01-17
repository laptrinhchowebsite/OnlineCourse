using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Model.Models.Mapping;

namespace Model.Models
{
    public partial class OnlineCourseDbContext : DbContext
    {
        static OnlineCourseDbContext()
        {
            Database.SetInitializer<OnlineCourseDbContext>(null);
        }

        public OnlineCourseDbContext()
            : base("Name=OnlineLearnContext")
        {
        }

        public DbSet<Exam> Exams { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ExamMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ProductCategoryMap());
            modelBuilder.Configurations.Add(new QuestionMap());
            modelBuilder.Configurations.Add(new ResultMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
