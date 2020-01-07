using System;
using System.Linq;
using CSharpWars.Common.Helpers.Interfaces;
using CSharpWars.Enums;
using CSharpWars.Processor.Middleware;
using CSharpWars.Scripting;
using CSharpWars.Scripting.Model;

namespace CSharpWars.Processor.Moves
{
    public class Teleport : Move
    {
        private readonly IRandomHelper _randomHelper;

        public Teleport(BotProperties botProperties, IRandomHelper randomHelper) : base(botProperties)
        {
            _randomHelper = randomHelper;
        }

        public override BotResult Go()
        {
            throw new NotImplementedException();
        }
    }
}