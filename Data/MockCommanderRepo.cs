using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{ Id = 0, HowTo = "Prepare an arrow", Line = "Ranged attack", Platform = "Bow & Arrow"},
                new Command{ Id = 0, HowTo = "Prepare balistae", Line = "Artilley attack", Platform = "Artillery construct"},
                new Command{ Id = 0, HowTo = "Deploy platoon", Line = "Foot unit", Platform = "Soldiers"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{
                Id = 0,
                HowTo = "Prepare an arrow",
                Line = "Ranged attack",
                Platform = "Bow & Arrow"
            };
        }
    }
}