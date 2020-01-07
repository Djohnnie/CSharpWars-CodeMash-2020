using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpWars.DataAccess.Repositories.Interfaces;
using CSharpWars.DtoModel;
using CSharpWars.Logic.Interfaces;
using CSharpWars.Mapping.Interfaces;
using CSharpWars.Model;

namespace CSharpWars.Logic
{
    public class PlayerLogic : IPlayerLogic
    {
        private readonly IRepository<Player> _playerRepository;
        private readonly IMapper<Player, PlayerDto> _playerMapper;

        public PlayerLogic(IRepository<Player> playerRepository, IMapper<Player, PlayerDto> playerMapper)
        {
            _playerRepository = playerRepository;
            _playerMapper = playerMapper;
        }

        public async Task<IList<PlayerDto>> GetAllPlayers()
        {
            throw new NotImplementedException();
        }

        public async Task<PlayerDto> CreatePlayer(string playerName)
        {
            throw new NotImplementedException();
        }
    }
}