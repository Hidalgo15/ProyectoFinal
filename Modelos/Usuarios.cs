using System.ComponentModel.DataAnnotations;

public class Usuario
{
    [Key]
    public string? Cedula { get; set; }
    public string? NombreUsuario { get; set; }
    public string? Clave { get; set; }
    public TipoUsuario Tipo { get; set; }
    public List<Multa> Multas { get; set; } = new List<Multa>();
    public decimal Salario { get; set; }
    public decimal ComicionesAcumuladas { get; set; }
}

public enum TipoUsuario
{
    Agente,
    PersonalOficina,
    Administrador
}

public class LoginModel
{
    public string? Cedula { get; set; }
    public string? Clave { get; set; }
}