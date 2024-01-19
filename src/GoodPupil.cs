namespace ConsoleApp1;

class GoodPupil : Pupil
{
    public string Name { get; set; }
    public int Point { get; set; }

    public GoodPupil(string name, int point) : base(name)
    {
        Name = name;
        Point = point;
    }

    public override void Study()
    {
        Console.WriteLine($"Учеба {Name} дается нелегко.");
    }

    public override void Read()
    {
        base.Read();
    }

    public override void Write()
    {
        Console.WriteLine($"Если у {Name} домашка на пятерки, значит он ее списал.");
    }

    public override void Relax()
    {
        Console.WriteLine($"{Name} иногда спит на уроках.");
    }

    public override void Info()
    {
        Console.WriteLine($"{Name} - хорошист.");
    }
}
