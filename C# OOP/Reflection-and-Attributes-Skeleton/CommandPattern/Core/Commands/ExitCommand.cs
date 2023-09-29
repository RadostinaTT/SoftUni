namespace CommandPattern.Core.Commands
{
    using CommandPattern.Core.Contracts;
    using System;
    class ExitCommand : ICommand
    {
        public string Execute(string[] args)
        {
            Environment.Exit(0);
            
            return null;
        }
    }
}