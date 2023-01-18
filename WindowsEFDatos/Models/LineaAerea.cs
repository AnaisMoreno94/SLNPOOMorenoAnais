using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFDatos.Models
{
    public class LineaAerea
    {
        [Key]
        public int IdLinea { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime FechaInicioActividades { get; set; }


        public List<Avion> Aviones { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
