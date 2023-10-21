using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Clientes
{
    [Key]
    public int clienteId { get; set; }
    [Required(ErrorMessage = "El Nombre es requerido")]
    public string nombres { get; set; }
    [Required(ErrorMessage = "El Rnc es requerido")]
    public string rnc { get; set; }
    public string direccion { get; set; }
    public int limiteCredito { get; set; }
}

