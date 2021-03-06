﻿using CommandReminder.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandReminder.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) 
            : base(opt)
        { }

        public DbSet<Command> Commands { get; set; }
    }
}
