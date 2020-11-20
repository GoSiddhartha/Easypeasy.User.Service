namespace Easypeasy.User.Service.Service.Interface
{
    public interface IUserService
    {
        Domain.User GetUserByEmail(string email);
    }
}
