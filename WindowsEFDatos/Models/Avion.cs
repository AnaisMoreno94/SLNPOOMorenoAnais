using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFDatos.Models
{
    [Table("Avion")]
    public class Avion
    {
        [Key]
        public int IdAvion { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Capacidad { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Denominacion { get; set;}

        public int LineaAereaID { get; set; }

        [ForeignKey("LineaAereaID")]
        public LineaAerea LineaAerea { get; set; }


        public override string ToString()
        {
            return $"Avion ID:{IdAvion}, Denominacion: {Denominacion}, Linea Aerea ID = {LineaAereaID}";
        }
    }
}
