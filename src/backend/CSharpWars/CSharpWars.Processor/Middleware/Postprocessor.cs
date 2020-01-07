using System;
using System.Linq;
using System.Threading.Tasks;
using CSharpWars.Common.Extensions;
using CSharpWars.Common.Helpers.Interfaces;
using CSharpWars.Enums;
using CSharpWars.Processor.Middleware.Interfaces;
using CSharpWars.Processor.Moves;

namespace CSharpWars.Processor.Middleware
{
    public class Postprocessor : IPostprocessor
    {
        private readonly IRandomHelper _randomHelper;

        public Postprocessor(IRandomHelper randomHelper)
        {
            _randomHelper = randomHelper;
        }

        public Task Go(ProcessingContext context)
        {
            throw new NotImplementedException();
        }
    }
}