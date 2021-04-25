using System.ComponentModel;

namespace VeraDemoNet.Models
{
    public class RegisterViewModel
    {
        public string Error { get; set; }
        [DisplayName("User Name")]
        public string UserName { get; set; }
        public string BlabName { get; set; }
        public string RealName { get; set; }
        public string Password { get; set; }
        public string CPassword { get; set; }
    }
}