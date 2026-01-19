using Chess.Core.Shield;
using Chess.UI.Text;

namespace Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter a message: ");
                    var message = Console.ReadLine();

                    if (message != null)
                    {
                        Message.Info(message);
                        Message.Info($"Length: {message.Trim().Length}");
                    }
                }
                catch (DomainException e)
                {
                    Message.Error(e.Message);
                }
                finally
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
