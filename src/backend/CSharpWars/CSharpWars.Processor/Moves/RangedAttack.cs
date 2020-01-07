using System;
using System.Linq;
using CSharpWars.Enums;
using CSharpWars.Processor.Middleware;
using CSharpWars.Scripting;
using CSharpWars.Scripting.Model;

namespace CSharpWars.Processor.Moves
{
    public class RangedAttack : Move
    {
        public RangedAttack(BotProperties botProperties) : base(botProperties) { }

        public override BotResult Go()
        {
            throw new NotImplementedException();
        }
    }
}