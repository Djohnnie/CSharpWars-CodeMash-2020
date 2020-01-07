using System;
using System.Threading.Tasks;
using CSharpWars.Logic.Interfaces;
using CSharpWars.Processor.Middleware.Interfaces;
using IProcessor = CSharpWars.Processor.Middleware.Interfaces.IProcessor;

namespace CSharpWars.Processor.Middleware
{
    public class Middleware : IMiddleware
    {
        private readonly IArenaLogic _arenaLogic;
        private readonly IBotLogic _botLogic;
        private readonly IPreprocessor _preprocessor;
        private readonly IProcessor _processor;
        private readonly IPostprocessor _postprocessor;

        public Middleware(
            IArenaLogic arenaLogic,
            IBotLogic botLogic,
            IPreprocessor preprocessor,
            IProcessor processor,
            IPostprocessor postprocessor)
        {
            _arenaLogic = arenaLogic;
            _botLogic = botLogic;
            _preprocessor = preprocessor;
            _processor = processor;
            _postprocessor = postprocessor;
        }

        public async Task Process()
        {
            throw new NotImplementedException();
        }
    }
}