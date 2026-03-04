using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S8EvaluaciónPráctica2P.Models
{
    [Table("log_auditoria_salarios")]
    public class LogAuditoriaSalarios
    {
        [Key]
        public int Id { get; set; }

        public int emp_no { get; set; }
        public int salary_anterior { get; set; }
        public int salary_nuevo { get; set; }

        [StringLength(50)]
        public string modificado_por { get; set; }

        public DateTime fecha_modificacion { get; set; }
    }
}
