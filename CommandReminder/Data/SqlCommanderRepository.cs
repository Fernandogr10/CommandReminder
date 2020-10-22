using CommandReminder.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandReminder.Data
{
    public class SqlCommanderRepository : ICommanderRepository
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepository(CommanderContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command command)
        {
            if (command is null)
                throw new ArgumentNullException(nameof(command));

            _context.Add(command);
        }

        public void DeleteCommand(Command command)
        {
            if (command is null)
                throw new ArgumentNullException(nameof(command));

            _context.Commands.Remove(command);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(command => command.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateCommand(Command command)
        {
             
        }
    }
}
