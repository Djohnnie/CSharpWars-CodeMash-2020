using System;
using System.Linq;
using CSharpWars.Enums;
using CSharpWars.Processor.Middleware;
using CSharpWars.Scripting;
using CSharpWars.Scripting.Model;

namespace CSharpWars.Processor.Moves
{
    public class MeleeAttack : Move
    {
        public MeleeAttack(BotProperties botProperties) : base(botProperties) { }

        public override BotResult Go()
        {
            throw new NotImplementedException();
        }
    }
}