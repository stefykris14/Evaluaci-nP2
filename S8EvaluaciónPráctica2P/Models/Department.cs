using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S8EvaluaciónPráctica2P.Models
{
    [Table("departments")]
    public class Department
    {
        [Key]
        [StringLength(4)]
        [Display(Name = "Código Depto.")]
        public string dept_no { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Nombre Departamento")]
        public string dept_name { get; set; }
    }
}
