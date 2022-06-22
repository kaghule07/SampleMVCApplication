using System.ComponentModel.DataAnnotations;

namespace SampleMVCApplication.Models
{
    public class Student
    {
        [Key]
        [ScaffoldColumn(false)]
        public int RollNo { get; set; }
        [Display(Name ="Student Name")]
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Age is required")]
        [Range(minimum:18,maximum:60,ErrorMessage ="Age should be between 18-60")]
        public int Age { get; set; }
        [Required(ErrorMessage ="Email ID is required")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Email ID is not in proper format")]
        public string EmailID { get; set; }
        [Required(ErrorMessage = "City is required")]
        [MaxLength(20)]
        public string City { get; set; }
        [Required(ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
