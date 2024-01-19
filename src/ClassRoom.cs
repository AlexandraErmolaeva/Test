namespace ConsoleApp1;

class ClassRoom
{
    public Pupil Pupil { get; set; }

    public ClassRoom()
    {
        Pupil = AddPupil();
    }

    // Добавить ученика в лист ClassRoom.
    public Pupil AddPupil()
    {
        Console.WriteLine("Введите имя ученика: ");

        var name = Console.ReadLine();
        var point = new Random().Next(1, 10);

        // Плохая успеваемость.
        if (point <= 3)
        {
            return new BadPupil(name, point);
        }
        // Хорошая успеваемость.
        if (point > 3 && point <= 6)
        {
            return new GoodPupil(name, point);
        }
        // Отличная успеваемость.
        return new ExcelentPupil(name, point);
    }

    // Показать, как ученики умеют учиться.
    public void ShowInfo()
    {
        Pupil.Study();
        Pupil.Read();
        Pupil.Write();
        Pupil.Relax();
        Pupil.Info();

        Console.WriteLine(new string('-', 20));
    }
}

