using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OnlineTutor.Web.Areas.Admin.Models.Dtos
{
    public class CategoryAddDto
    {
        [DisplayName("Kategori Ad")]
        [Required(ErrorMessage = "{0} adlı alan boş bırakılmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0},{1} karakterden kısa olmamalıdır.")]
        [MaxLength(50, ErrorMessage = "{0}, {1} karakterden uzun olmamalıdır.")]
        public string Name { get; set; }
        [DisplayName("Kategori Açıklaması")]
        [Required(ErrorMessage = "{0} adlı alan boş bırakılmamalıdır.")]
        [MinLength(10, ErrorMessage = "{0},{1} karakterden kısa olmamalıdır.")]
        [MaxLength(500, ErrorMessage = "{0}, {1} karakterden uzun olmamalıdır.")]
        public string Description { get; set; }
    }
}
