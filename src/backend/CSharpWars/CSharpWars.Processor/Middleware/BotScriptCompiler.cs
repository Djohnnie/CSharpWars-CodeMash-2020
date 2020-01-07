using System;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpWars.Common.Extensions;
using CSharpWars.Enums;
using CSharpWars.Processor.Middleware.Interfaces;
using CSharpWars.Scripting;
using CSharpWars.Scripting.Model;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace CSharpWars.Processor.Middleware
{
    public class BotScriptCompiler : IBotScriptCompiler
    {
        public Script Compile(string script)
        {
            throw new NotImplementedException();
        }
    }
}