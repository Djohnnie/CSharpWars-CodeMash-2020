using System;
using CSharpWars.Processor.Middleware;
using CSharpWars.Scripting.Model;

namespace CSharpWars.Processor.Moves
{
    public class EmptyMove : Move
    {
        public EmptyMove(BotProperties botProperties) : base(botProperties) { }

        public override BotResult Go()
        {
            throw new NotImplementedException();
        }
    }
}