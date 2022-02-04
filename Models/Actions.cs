using System;
using Module2HW5.Exceptions;
using Module2HW5.Interfaces;

namespace Module2HW5.Models
{
    public class Actions : IActions
    {
        public Actions(ILogger logger)
        {
            Logger = logger;
        }

        private ILogger Logger { get; set; }

        public bool CallInfo()
        {
            Logger.LogInfo($"Start method: {nameof(CallInfo)}");
            return true;
        }

        public bool CallWarning()
        {
            throw new BusinessException("Skipped logic in method");
        }

        public bool CallError()
        {
            throw new Exception("I broke logic");
        }
    }
}
