
       using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Salary
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Employee")]
        public int EmpNo { get; set; }

        public decimal SalaryAmount { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime? ToDate { get; set; }
    }