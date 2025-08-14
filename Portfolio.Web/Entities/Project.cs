using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Entities
{
    public class Project
    {
        public int ProjectId { get; set; }

        [MinLength(5,ErrorMessage ="Proje adı en az 5 karakter olmalı")]
        [MaxLength(50,ErrorMessage ="Proje adı en fazla 50 karakter olmalıdır")]
        [Required(ErrorMessage ="Proje adı boş geçilemez")]
        public string ProjectName { get; set; }

        [Required(ErrorMessage = "Proje Açıklaması boş geçilemez")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Proje resmi boş geçilemez")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Proje github linki boş geçilemez")]
        public string GithubUrl { get; set; }

        [Required(ErrorMessage = "Proje kategori boş geçilemez")]
        public int CategoryId { get; set; }
        //navigation property
        public Category? Category { get; set; }
    }
}
