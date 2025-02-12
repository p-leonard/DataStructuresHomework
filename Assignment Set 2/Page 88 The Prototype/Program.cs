// Written By: Patrick Leonard
// 2/6/25

namespace The_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prototype proto = new();
            proto.QueryUserForPilotNumber();
            proto.StartHunterGame();
        }
    }
}
