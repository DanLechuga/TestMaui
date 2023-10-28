using Comun;
namespace MiddlewareMaui.Dtos.Collectios
{
    public class User : Agregado
    {        
        public string Username { get; set; }
        public string Password { get; set; }
        public ConfigAuditFields AuditFields { get; set; }

    }
}
