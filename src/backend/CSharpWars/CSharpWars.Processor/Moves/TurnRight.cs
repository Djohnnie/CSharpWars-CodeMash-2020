using System;
using CSharpWars.Enums;
using CSharpWars.Processor.Middleware;
using CSharpWars.Scripting.Model;

namespace CSharpWars.Processor.Moves
{
    /// <summary>
    /// Class containing logic for turning right.
    /// </summary>
    /// <remarks>
    /// Performing this move makes the robot turn clockwise by 90°.
    /// This move does not consume stamina because the robot will not move away from its current location in the arena grid.
    /// </remarks>
    public class TurnRight : Move
    {
        public TurnRight(BotProperties botProperties) : base(botProperties) { }

        public override BotResult Go()
        {
            throw new NotImplementedException();
        }
    }
}