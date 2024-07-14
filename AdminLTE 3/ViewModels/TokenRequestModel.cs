using System.ComponentModel.DataAnnotations;

namespace AdminLTE.ViewModels
{
    public class TokenRequestModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        public int? TemplateId { get; set; }
        public int? TemplateVersion { get; set; }
    }
}
