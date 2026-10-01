namespace Api_CedeSys_v2.Application.Dtos.Auth
{
    public class LoginErrorDto
    {
        public string Message { get; set; } = "";
        public int IntentosRestantes { get; set; }
        public bool Bloqueado { get; set; }
    }
}
