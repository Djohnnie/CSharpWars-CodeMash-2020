using System;
using System.Collections.Generic;
using System.Linq;
using CSharpWars.Enums;
using CSharpWars.Processor.Middleware;
using CSharpWars.Scripting;
using CSharpWars.Scripting.Model;

namespace CSharpWars.Processor.Moves
{
    public class SelfDestruct : Move
    {
        public SelfDestruct(BotProperties botProperties) : base(botProperties)
        {
        }

        public override BotResult Go()
        {
            throw new NotImplementedException();
        }
    }
}