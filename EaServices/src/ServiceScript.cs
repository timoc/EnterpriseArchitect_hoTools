﻿using System;
using AddinFramework.Util.Script;
using EAAddinFramework.Utils;

namespace hoTools.EaServices
{
    public class ServiceScript : Service
    {
        public ScriptFunction Function;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="function"></param>
        public ServiceScript(ScriptFunction function) : base($"{function.Owner.Name}:{function.Name}", $"{function.Owner.Name}:{function.Name}", function.Description)
        {
            Function = function;
        }
        // public ServiceScript(ScriptFunction function) : base($"{function.Owner.Name}:{function.Name}", $"{function.Owner.Name}:{function.Name}", function.Owner.LanguageName)

    }
}
