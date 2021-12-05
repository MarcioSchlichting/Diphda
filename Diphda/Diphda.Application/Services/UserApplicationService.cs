namespace Diphda.Application
{
    using Diphda.Domain.Abstractions;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using AutoMapper;
    using Diphda.Domain.Account;

    public sealed class UserApplicationService : IUserApplicationService
    {
        private readonly IMapper mapper;

        private readonly IUserService service;

        public UserApplicationService(IMapper mapper, IUserService service)
        {
            this.mapper = mapper;
            this.service = service;
        }

        public async Task AddAsync(UserDTO userDTO)
        {
            var user = mapper.Map<User>(userDTO);

            await service.AddAsync(user);
        }

        public async Task<IEnumerable<UserDTO>> GetAllAsync()
        {
            var users = await service.GetAllAsync();
            var usersDTO = mapper.Map<IEnumerable<UserDTO>>(users);

            return usersDTO;
        }

        public async Task<UserDTO> GetByIdAsync(int id)
        {
            var user = await service.GetByIdAsync(id);
            var userDTO = mapper.Map<UserDTO>(user);

            return userDTO;
        }

        public async Task DeleteAsync(int userId)
        {
            await service.DeleteAsync(userId);
        }

        public async Task UpdateAsync(UserDTO userDTO)
        {
            var user = mapper.Map<User>(userDTO);

            await service.UpdateAsync(user);
        }
    }
}