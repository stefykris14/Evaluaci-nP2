using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S8EvaluacionPractica2P.Models
{
    [Table("titles")]
    public class Title
    {
        [Key, Column(Order = 0)]
        public int emp_no { get; set; }

        [Key, Column(Order = 1)]
        [StringLength(50)]
        [Display(Name = "Título")]
        public string title { get; set; }

        [Key, Column(Order = 2)]
        [DataType(DataType.Date)]
        public DateTime from_date { get; set; }

        [DataType(DataType.Date)]
        public DateTime? to_date { get; set; }

        [ForeignKey("emp_no")]
        public virtual Employee Employee { get; set; }
    }
}
