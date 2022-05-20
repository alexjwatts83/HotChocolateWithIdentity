using System.Threading.Tasks;

namespace HotChocolateWithIdentity.Application.Services
{
    public interface IIdentityService
    {
        Task<string> GetUserNameAsync(string userId);

        Task<(Result Result, string UserId)> CreateUserAsync(
            string userName,
            string password);

        Task<Result> DeleteUserAsync(string userId);
    }
}
