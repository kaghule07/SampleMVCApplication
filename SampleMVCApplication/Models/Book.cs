using System.ComponentModel.DataAnnotations;
namespace SampleMVCApplication.Models
{
    public class Book
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ID { get; set; }
        [Display(Name = "Book Name")]
        [Required(ErrorMessage = "Book Name  is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Author Name  is required")]
        [MaxLength(20)]
        public string AuthorName { get; set; }
        [Required(ErrorMessage = "Publisher Name  is required")]
        [MaxLength(20)]
        public string PublisherName { get; set; }
        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date, ErrorMessage = "PublisherDate is not in proper format")]
        public DataType PublisherDate { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(minimum: 100, maximum: 1000, ErrorMessage = "Price should be between 100-1000")]
        public double Price { get; set; }   

    }
}
