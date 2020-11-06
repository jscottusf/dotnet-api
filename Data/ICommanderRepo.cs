using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    // interface == a list of methods which you are going to provide to consumer, it is a contract
    public interface ICommanderRepo
    {
        bool SaveChanges();
        //IEnumerable refers to an api list while Command is the type <T>
        IEnumerable<Command> GetAllCommands();
        //Command is the return type
        Command GetCommandById(int id);
        void CreateCommand(Command command);
    }
}