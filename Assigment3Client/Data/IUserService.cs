using System.Threading.Tasks;

namespace Assigment3Client.Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string password);
    }
}