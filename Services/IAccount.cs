using System.Threading.Tasks;
using CW_PD8.DTO;

namespace CW_PD8.Services
{
    public interface IAccount
    {
        public Task<DbAnswer> RegisterAsync(UserDto dto);
        public Task<LoginHelper> LoginAsync(UserDto dto);
        public Task<LoginHelper> UpdateAccessTokenAsync(RefreshTokenDto dto);
    }
}