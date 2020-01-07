using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using CSharpWars.Common.Configuration.Interfaces;
using CSharpWars.Common.Extensions;
using CSharpWars.Common.Helpers.Interfaces;
using CSharpWars.DataAccess.Repositories.Interfaces;
using CSharpWars.DtoModel;
using CSharpWars.Enums;
using CSharpWars.Logic.Interfaces;
using CSharpWars.Mapping.Interfaces;
using CSharpWars.Model;

namespace CSharpWars.Logic
{
    public class BotLogic : IBotLogic
    {
        private readonly IRandomHelper _randomHelper;
        private readonly IRepository<Bot> _botRepository;
        private readonly IRepository<BotScript> _scriptRepository;
        private readonly IRepository<Bot, BotScript> _botScriptRepository;
        private readonly IRepository<Player> _playerRepository;
        private readonly IMapper<Bot, BotDto> _botMapper;
        private readonly IMapper<Bot, BotToCreateDto> _botToCreateMapper;
        private readonly IArenaLogic _arenaLogic;

        public BotLogic(
            IRandomHelper randomHelper,
            IRepository<Bot> botRepository,
            IRepository<BotScript> scriptRepository,
            IRepository<Bot, BotScript> botScriptRepository,
            IRepository<Player> playerRepository,
            IMapper<Bot, BotDto> botMapper,
            IMapper<Bot, BotToCreateDto> botToCreateMapper,
            IArenaLogic arenaLogic)
        {
            _randomHelper = randomHelper;
            _botRepository = botRepository;
            _scriptRepository = scriptRepository;
            _botScriptRepository = botScriptRepository;
            _playerRepository = playerRepository;
            _botMapper = botMapper;
            _botToCreateMapper = botToCreateMapper;
            _arenaLogic = arenaLogic;
        }

        public async Task<IList<BotDto>> GetAllActiveBots()
        {
            throw new NotImplementedException();
        }

        public async Task<IList<BotDto>> GetAllLiveBots()
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetBotScript(Guid botId)
        {
            throw new NotImplementedException();
        }

        public async Task<BotDto> CreateBot(BotToCreateDto botToCreate)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateBots(IList<BotDto> bots)
        {
            throw new NotImplementedException();
        }
    }
}