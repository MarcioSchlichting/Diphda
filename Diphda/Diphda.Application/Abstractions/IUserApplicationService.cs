namespace Diphda.Application
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IUserApplicationService
    {
        Task AddAsync(UserDTO userDTO);

        Task UpdateAsync(UserDTO userDTO);

        Task DeleteAsync(int userId);

        Task<IEnumerable<UserDTO>> GetAllAsync();

        Task<UserDTO> GetByIdAsync(int id);
    }
}