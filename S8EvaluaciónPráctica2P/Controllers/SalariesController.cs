using S8EvaluacionPractica2P.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Obtener salario anterior
var salarioAnterior = db.Salaries
    .Where(s => s.emp_no == salary.emp_no && s.from_date == salary.from_date)
    .Select(s => s.salary)
    .FirstOrDefault();

// Registrar auditoría
db.LogAuditoria.Add(new LogAuditoriaSalarios
{
    emp_no = salary.emp_no,
    salary_anterior = salarioAnterior,
    salary_nuevo = salary.salary,
    modificado_por = Session["Username"]?.ToString() ?? "Sistema",
    fecha_modificacion = DateTime.Now
});
