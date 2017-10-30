using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ShiYing.Utility
{
    public class CommandManager
    {
        private Dictionary<string, CommandBase> _commandMap = new Dictionary<string, CommandBase>();

        private CommandManager() { }

        private static CommandManager _managerInstance;
        public static CommandManager Instance => _managerInstance ?? (_managerInstance = new CommandManager());

        public void AddCommand(string name, CommandBase command) => _commandMap.Add(name, command);

        public CommandBase this[string name] => _commandMap[name];
    }
}
