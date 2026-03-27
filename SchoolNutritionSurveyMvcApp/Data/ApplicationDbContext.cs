using Microsoft.EntityFrameworkCore;

namespace SchoolNutritionSurveyMvcApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserFormModel> UserResults { get; set; }

        public ApplicationDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

            var connectionString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserFormModel>().ToTable("user_results");
            modelBuilder.Entity<UserFormModel>(entity =>
            {
                entity.HasKey(u => u.Id);

                entity.Property(u => u.LearningClass).HasColumnName("learning_class").IsRequired();
                entity.Property(u => u.MunicipalDistrict).HasColumnName("municipal_district").IsRequired().HasMaxLength(100);
                entity.Property(u => u.AnswerForFood1).HasColumnName("answer_for_food1").IsRequired();
                entity.Property(u => u.AnswerForFood2).HasColumnName("answer_for_food2").IsRequired();
                entity.Property(u => u.AnswerForFood3).HasColumnName("answer_for_food3").IsRequired();
                entity.Property(u => u.AnswerForFood4).HasColumnName("answer_for_food4").IsRequired();
                entity.Property(u => u.AnswerForFood5).HasColumnName("answer_for_food5").IsRequired();
                entity.Property(u => u.AnswerForFood6).HasColumnName("answer_for_food6").IsRequired();
                entity.Property(u => u.AnswerForFood7).HasColumnName("answer_for_food7").IsRequired();
                entity.Property(u => u.AnswerForFood8).HasColumnName("answer_for_food8").IsRequired().HasMaxLength(500);
            });
        }
    }
}
