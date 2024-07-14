namespace AdminLTE.ViewModels
{
    public class AuthModel
    {
        public string Message { get; set; }
        public bool IsAuthenticated { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public List<string> Roles { get; set; }
        public List<string> Permissons { get; set; }
        public DateTime ExpiresOn { get; set; }
    }
}
