public class UsuarioSession
{
    private static UsuarioSession _instance;
    public Usuario UsuarioActual { get; private set; }

    private UsuarioSession() { }

    public static UsuarioSession GetInstance()
    {
        if (_instance == null)
        {
            _instance = new UsuarioSession();
        }
        return _instance;
    }

    public void SetUsuario(Usuario usuario)
    {
        UsuarioActual = usuario;
    }

    public string ObtenerUsuarioCedula()
    {
        return UsuarioActual?.Cedula ?? "Sin usuario en sesión";
    }

    public void LimpiarSesion()
    {
        UsuarioActual = null;
    }
    public bool EsTipoUsuario(TipoUsuario tipo)
    {
        return UsuarioActual?.Tipo == tipo;
    }
}

