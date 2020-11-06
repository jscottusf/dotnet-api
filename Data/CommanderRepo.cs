using System;
using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data
{
    public class CommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _commanderContext;

        public CommanderRepo(CommanderContext commanderContext)
        {
            _commanderContext = commanderContext;
        }

        public void CreateCommand(Command command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            _commanderContext.Commands.Add(command);
            SaveChanges();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _commanderContext.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _commanderContext.Commands.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_commanderContext.SaveChanges() >= 0);
        }
    }
}