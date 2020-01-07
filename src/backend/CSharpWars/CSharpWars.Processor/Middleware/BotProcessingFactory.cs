using System;
using System.Threading.Tasks;
using CSharpWars.DtoModel;
using CSharpWars.Enums;
using CSharpWars.Logic.Interfaces;
using CSharpWars.Processor.Middleware.Interfaces;
using CSharpWars.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.Extensions.Logging;

namespace CSharpWars.Processor.Middleware
{
    public class BotProcessingFactory : IBotProcessingFactory
    {
        private readonly IBotLogic _botLogic;
        private readonly IBotScriptCompiler _botScriptCompiler;
        private readonly IBotScriptCache _botScriptCache;
        private readonly ILogger<BotProcessingFactory> _logger;

        public BotProcessingFactory(
            IBotLogic botLogic,
            IBotScriptCompiler botScriptCompiler,
            IBotScriptCache botScriptCache, ILogger<BotProcessingFactory> logger)
        {
            _botLogic = botLogic;
            _botScriptCompiler = botScriptCompiler;
            _botScriptCache = botScriptCache;
            _logger = logger;
        }

        public async Task Process(BotDto bot, ProcessingContext context)
        {
            throw new NotImplementedException();
        }
    }
}