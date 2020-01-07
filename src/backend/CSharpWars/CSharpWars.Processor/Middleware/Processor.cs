using System;
using System.Linq;
using System.Threading.Tasks;
using CSharpWars.Processor.Middleware.Interfaces;

namespace CSharpWars.Processor.Middleware
{
    public class Processor : IProcessor
    {
        private readonly IBotProcessingFactory _botProcessingFactory;

        public Processor(IBotProcessingFactory botProcessingFactory)
        {
            _botProcessingFactory = botProcessingFactory;
        }

        public async Task Go(ProcessingContext context)
        {
            throw new NotImplementedException();
        }
    }
}