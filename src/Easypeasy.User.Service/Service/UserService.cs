using Easypeasy.User.Service.Infrastructure;
using Easypeasy.User.Service.Service.Interface;
using UserDto = Easypeasy.User.Service.Domain.User;

namespace Easypeasy.User.Service.Service
{
    public class UserService : IUserService
    {
        private SqlDB _sqldatabase { get; set; }
        public UserService(SqlDB sqldatabase)
        {
            _sqldatabase = sqldatabase;
        }
        public UserDto GetUserByEmail(string email)
        {
            var cmd = _sqldatabase.Connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM user WHERE user_email = @EmailId;";
            cmd.Parameters.AddWithValue("@EmailId", email);
            var result = cmd.ExecuteScalar() as UserDto;
            return result;
        }

    }
}
