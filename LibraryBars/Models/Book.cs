using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryBars.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace LibraryBars.Models
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Display(Name = "Год выпуска")]
        [MaxLength(4)]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public string Year { get; set; }
        [Display(Name = "Автор")]
        public string Creator { get; set; }
        [Display(Name="Жанр")]
        public Genres Genre { get; set; }
        [Display(Name="Количество")]
        public int Count { get; set; }
    }
}
