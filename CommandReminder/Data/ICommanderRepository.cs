using CommandReminder.Models;
using System.Collections.Generic;

namespace CommandReminder.Data
{
    public interface ICommanderRepository
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}
