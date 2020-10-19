using CommandReminder.Models;
using System.Collections.Generic;

namespace CommandReminder.Data
{
    public interface ICommanderRepository
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}
