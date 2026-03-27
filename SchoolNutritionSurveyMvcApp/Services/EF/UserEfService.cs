using Microsoft.EntityFrameworkCore;
using SchoolNutritionSurveyMvcApp.Data;
using SchoolNutritionSurveyMvcApp.Services.Interfaces;

namespace SchoolNutritionSurveyMvcApp.Services.EF
{
    public class UserEfService : IUserService
    {
        public void AddToDatabase(UserFormModel user)
        {
            using var dbContext = new ApplicationDbContext();
            dbContext.UserResults.Add(user);
            dbContext.SaveChanges();
        }

        public List<UserFormModel> GetUsers()
        {
            using var dbContext = new ApplicationDbContext();
            return dbContext.UserResults.AsNoTracking().ToList();
        }
    }
}
