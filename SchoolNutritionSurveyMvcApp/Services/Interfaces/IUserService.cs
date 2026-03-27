namespace SchoolNutritionSurveyMvcApp.Services.Interfaces
{
    public interface IUserService
    {
        public void AddToDatabase(UserFormModel user);

        public List<UserFormModel> GetUsers();
    }
}
