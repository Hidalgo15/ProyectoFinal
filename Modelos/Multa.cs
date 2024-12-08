using System.ComponentModel.DataAnnotations;

public enum Estado{
    Perdonado,
    Cobrado
}
public class Multa{
    [Key]
    public int Id {get; set; }
    public string? Nombre { get; set; }
    public string? Descripción { get; set; }
    public double? Longitud  { get; set; }
    public double? Latitud { get; set; }
    public string? Foto { get; set; }
    public DateTime Fecha { get; set; }
    public Estado Estado { get; set; } 
    public Conceptos Concepto { get; set; }
    public int ConceptoId { get; set; }
    public string? CedulaUsuario { get; set; }
}

public class Conceptos{
    [Key]
    public int Id { get; set; }
    public string? Nombre {get; set; }
    public decimal Monto {get; set;}
}