public interface IWorker
{
    void Work();
}

public interface IManager
{
    void Manage();
}

public class Developer : IWorker
{
    public void Work()
    {
        Console.WriteLine("The developer is coding.");
    }
}

public class TeamLead : IWorker, IManager
{
    public void Work()
    {
        Console.WriteLine("The team lead is working on a task.");
    }

    public void Manage()
    {
        Console.WriteLine("The team lead is managing the team.");
    }
}
