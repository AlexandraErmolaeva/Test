namespace ConsoleApp1;

class ExcelentPupil : Pupil
{
    public string Name { get; set; }
    public int Point { get; set; }

    public ExcelentPupil(string name, int point) : base(name)
    {
        Name = name;
        Point = point;
    }

    public override void Study()
    {
        Console.WriteLine($"Все списывают у {Name}, молодец!");
    }

    public override void Read()
    {
        Console.WriteLine($"{Name} прочел 4 тома Войны и Мира.");
    }

    public override void Write()
    {
        Console.WriteLine($"У {Name} вся домашка на пятерки!");
    }

    public override void Relax()
    {
        Console.WriteLine($"У Самурая {Name} нет цели, только путь, отдых ему не нужен.");
    }

    public override void Info()
    {
        Console.WriteLine($"{Name} - отличник.");
    }
}
