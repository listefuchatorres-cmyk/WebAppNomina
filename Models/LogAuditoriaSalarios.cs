using System.ComponentModel.DataAnnotations;

public class LogAuditoriaSalarios
{
    [Key]
    public int Id { get; set; }

    public string Usuario { get; set; }

    public DateTime FechaActualizacion { get; set; }

    public string DetalleCambio { get; set; }

    public decimal Salario { get; set; }

    public int EmpNo { get; set; }
}