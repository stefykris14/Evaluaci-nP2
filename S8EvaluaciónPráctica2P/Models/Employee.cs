using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaNomina.Models
{
    [Table("employees")]
    public class Employee
    {
        [Key]
        [Column("emp_no")]
        public int EmpNo { get; set; }

        [Required, StringLength(50)]
        public string CI { get; set; }

        [StringLength(50)]
        [Column("birth_date")]
        public string BirthDate { get; set; }

        [Required, StringLength(50)]
        [Column("first_name")]
        public string FirstName { get; set; }

        [Required, StringLength(50)]
        [Column("last_name")]
        public string LastName { get; set; }

        [Required, StringLength(1)]
        public string Gender { get; set; }

        [Required, StringLength(50)]
        [Column("hire_date")]
        public string HireDate { get; set; }

        [StringLength(100)]
        public string Correo { get; set; }
    }
}