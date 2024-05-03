using System;


public class ResponseLogin
{
    public int StatusCode { get; set; }
    public bool Success { get; set; }
    public bool Error { get; set; }
    public string Message { get; set; }
    public ResponseBody Response { get; set; }


}

public class ResponseBody
{
    public DataResponseLogin data { get; set; }
}

public class DataResponseLogin
{
  
    public bool Status { get; set; }
    public string Mensaje { get; set; }
    public string Token { get; set; }
    public UsuarioModel Usuario { get; set; }

}

public class UserModel
{
    public int Id {get; set; }
    public string Nombre { get; set;}
    public string User { get; set;}
    public string Perfil { get; set; }
    public string IdPerfil {get; set;}
    public string Pwd { get; set; }
}

public class UsuarioModel
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string NombrePersona { get; set; }
        public int IdSucursal { get; set; }        
        public string NombreSucursal { get; set; }
        public int IdPerfil { get; set; }
    }