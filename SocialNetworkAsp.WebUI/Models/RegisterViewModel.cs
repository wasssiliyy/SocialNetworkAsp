using Microsoft.AspNetCore.Http;

namespace SocialNetworkAsp.WebUI.Models
{
    public class RegisterViewModel
    {
        public string? Name { get; set; }

        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? ConfirmedPassword{ get; set; }
        public bool IsConfirmedPrivacy { get; set; } = false;
    }
}
