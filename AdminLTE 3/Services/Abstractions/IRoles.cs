namespace AdminLTE.Services.Abstractions
{
    public interface IRoles
    {
        Task GenerateRolesFromPagesAsync();
        Task AddToRoles(string applicationUserId);
    }
}
