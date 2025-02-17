// Written By: Patrick Leonard
// 2/17/25

namespace Page_135_Simula_s_Test;

public class Program
{
    static void Main()
    {
        Chest chest = new();

        while (true)
        {
            Console.Write($"The chest is {chest.State.ToString().ToLower()}. What do you want to do?");
            string resp = Console.ReadLine() ?? "";

            switch (resp.ToLower())
            {
                case ("unlock"):
                    chest.Unlock();
                    break;
                case ("open"):
                    chest.Open();
                    break;
                case ("close"):
                    chest.Close();
                    break;
                case ("lock"):
                    chest.Lock();
                    break;
            }
        }
    }
}

public class Chest
{
    // Backing Fields
    private ChestState state = ChestState.LOCKED;

    // Gets and Sets
    public ChestState State
    {
        get => state;
        private set => state = value;
    }

    // Enums
    public enum ChestState
    {
        OPEN,
        CLOSED,
        LOCKED
    }

    // Methods
    public void Open()
    {
        if (State == ChestState.CLOSED) State = ChestState.OPEN;
    }

    public void Close()
    {
        if (State == ChestState.OPEN) State = ChestState.CLOSED;
    }

    public void Unlock()
    {
        if (State == ChestState.LOCKED) State = ChestState.CLOSED;
    }

    public void Lock()
    {
        if (State == ChestState.CLOSED) State = ChestState.LOCKED;
    }

}