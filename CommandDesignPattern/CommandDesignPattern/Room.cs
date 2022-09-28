namespace CommandDesignPattern
{
    internal class Room 
    {
        private ICommand command;

        public Room(ICommand command)
        {
            this.command = command;
        }

       public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
