using SoaProductApp.Controller;


namespace SoaProductApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Controller.Controller controller = new();
            controller.BusinessLogicHandler();
        }

    }
}