using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    //This is how you can insert mock data
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command {Id=0, HowTo="Boil an egg", Line="Boil Water", Platform="Kettle and Pan"},
                new Command {Id=1, HowTo="Cut Bread", Line="Get a Knife", Platform="Chopping Board"},
                new Command {Id=2, HowTo="Make Cup of Tea", Line="Place Teabag in cup", Platform="Kettle and Cup"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command {Id=0, HowTo="Boil an egg", Line="Boil Water", Platform="Kettle and Pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}