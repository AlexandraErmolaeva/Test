using ConsoleApp1;

Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");

List<ClassRoom> pupils = new List<ClassRoom>();

// Добавление в листы наших учеников. У нас трое учеников.
for (int pupilsCount = 0; pupilsCount < 3; pupilsCount++)
{
    pupils.Add(new ClassRoom());
}

ClassRoom pupil;

// Вывод информации об успеваемости.
for (int i = 0; i < pupils.Count; i++)
{
    pupil = pupils[i];
    pupil.ShowInfo();
}