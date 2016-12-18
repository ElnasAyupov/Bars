using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace LibraryBars.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        [StringLength(40)]
        [Display(Name="ФИО")]
        public string Name { get; set; }
        [Display(Name="Адрес")]
        public string Address { get; set; }
        [MaxLength(12)]
        [Display(Name="Телефон")]
        public string Phone { get; set; }
        public string SecCode { get; set; }
    }
}
