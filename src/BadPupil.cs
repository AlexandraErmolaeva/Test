namespace ConsoleApp1;

class BadPupil : Pupil
{
    public string Name { get; set; }
    public int Point { get; set; }

    // Если убрать base, то имя этого ученика не выведется, т.к. я не переопределяла методы.
    // Не понимаю, как без base присвоить имя этому ученику. 
    // Для всех объектов теперь вызывается базовый конструктор, а мне он нужен не везде. Так вообще норм делать?
    public BadPupil(string name, int point) : base(name)
    {
        Name = name;
        Point = point;
    }

    public override void Study()
    {
        base.Study();
    }

    public override void Read()
    {
        base.Read();
    }

    public override void Write()
    {
        base.Write();
    }

    public override void Relax()
    {
        base.Relax();
    }

    public override void Info()
    {
        Console.WriteLine($"{Name} - двоешник.");
    }
}
