using CommandAPI.Models;
using System;
using System.Collections.Generic;

namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return new List<Command>
            {
                new Command
                {
                    Id = 0,
                    HowTo = "How to generate a migration",
                    CommandLine = "dotnet ef migrations add <Name of Migrations>",
                    Platform = ".Net Core EF"
                },
                new Command
                {
                    Id = 1,
                    HowTo = "Run Migrations",
                    CommandLine = "dotnet ef database update",
                    Platform = ".Net Core EF"
                },
                new Command
                {
                    Id = 2,
                    HowTo = "List active migrations",
                    CommandLine = "dotnet ef migrations list",
                    Platform = ".Net Core EF"
                }
            };
        }

        public Command GetCommmandById(int id)
        {
            return new Command
            {
                Id = 0,
                HowTo = "How to generate a migration",
                CommandLine = "dotnet ef migrations add <Name of Migrations>"
            };
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
