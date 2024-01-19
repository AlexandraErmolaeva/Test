namespace ConsoleApp1;

class Pupil
{
    // Базовый класс Pupil.
    public string Name { get; set; }

    public Pupil(string name)
    {
        Name = name;
    }

    public virtual void Study()
    {
        Console.WriteLine($"{Name} нихрена не хочет учиться!");
    }

    public virtual void Read()
    {
        Console.WriteLine($"{Name} не прочел ни одной книги за лето.");
    }

    public virtual void Write()
    {
        Console.WriteLine($"{Name} не сделал домашку, атата.");
    }

    public virtual void Relax()
    {
        Console.WriteLine($"Балдеж - второе имя {Name}");
    }

    public virtual void Info()
    {
        Console.WriteLine($"Уровень знаний {Name} неизвестен.");
    }

}
