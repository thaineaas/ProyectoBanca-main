
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoBanca.Models
{
    [Table("t_cuentas")]
    public class Cuentas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [NotNull]
        public String? Nombre { get; set; }
        [NotNull]
        public Decimal? SaldoInicial { get; set; }
        [NotNull]
        public String? Email { get; set; }
        [NotNull]
        public String? Tipo { get; set; }
    }
}
