using System.ComponentModel.DataAnnotations;

public class UserFormModel
{
    [Required(ErrorMessage = "Пожалуйста, укажите класс обучения")]
    [Range(1, 11, ErrorMessage = "Класс должен быть от 1 до 11")]
    [Display(Name = "Класс обучения")]
    public int LearningClass { get; set; }
    
    [Required(ErrorMessage = "Пожалуйста, укажите муниципальный округ")]
    [StringLength(100, ErrorMessage = "Название округа не должно превышать 100 символов")]
    [Display(Name = "Муниципальный/городской округ")]
    public string MunicipalDistrict { get; set; }
    
    [Required(ErrorMessage = "Пожалуйста, ответьте на вопрос")]
    [Display(Name = "Нравится ли питание в школьной столовой?")]
    public string AnswerForFood1 { get; set; }
    
    [Display(Name = "Если не нравится, объясните почему?")]
    public string AnswerForFood2 { get; set; }
    
    [Display(Name = "В школе я чаще всего...")]
    public string AnswerForFood3 { get; set; }
    
    [Display(Name = "Частота покупки перекуса в буфете")]
    public string AnswerForFood4 { get; set; }
    
    [Display(Name = "Какая еда нравится больше всего?")]
    public string AnswerForFood5 { get; set; }
    
    [Display(Name = "Какая еда не нравится?")]
    public string AnswerForFood6 { get; set; }
    
    [Display(Name = "Как часто проводятся беседы о здоровом питании?")]
    public string AnswerForFood7 { get; set; }
    
    [Display(Name = "Предложения по улучшению питания")]
    [StringLength(500, ErrorMessage = "Предложение не должно превышать 500 символов")]
    public string AnswerForFood8 { get; set; }
}