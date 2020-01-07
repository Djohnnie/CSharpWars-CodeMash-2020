﻿using System;
using Microsoft.CodeAnalysis.Scripting;

namespace CSharpWars.Processor.Middleware.Interfaces
{
    public interface IBotScriptCache
    {
        bool ScriptStored(Guid botId);

        void StoreScript(Guid botId, Script script);

        Script LoadScript(Guid botId);

        void ClearScript(Guid botId);
    }
}