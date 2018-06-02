namespace Actio.Common.Commands
{
    public interface ICommandHander<int> where T : ICommand
    {
         Task HandleAsync(T Command);
    }
}