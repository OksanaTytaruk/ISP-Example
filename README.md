# ISP Example (Interface Segregation Principle)

Цей репозиторій містить приклад принципу розділення інтерфейсу з SOLID.

## Принцип розділення інтерфейсу (ISP)

Краще створювати багато вузьких інтерфейсів, що відповідають за одну конкретну задачу, ніж один великий інтерфейс, який містить багато методів. Це допомагає уникнути ситуацій, коли клас реалізує методи, які йому не потрібні.

### Приклад коду:

```csharp
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
