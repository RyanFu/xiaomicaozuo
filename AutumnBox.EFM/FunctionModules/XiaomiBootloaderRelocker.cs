﻿using AutumnBox.Basic.Executer;

namespace AutumnBox.Basic.Functions
{
    public class XiaomiBootloaderRelocker : FunctionModule
    {
        protected override OutputData MainMethod()
        {
            var o = Ae(" oem lock");
            return o;
        }
    }
}