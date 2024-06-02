using System.Numerics;

namespace HW4_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ДЗ модуль 6
            //Задание 1. Money
            Money money = new Money() { Whole = 5, Fraction = 15 };
            money.Print();
            Product koka = new Product("Запрещенка", "Nesquik");
            koka.Whole = 150;
            koka.Fraction = 99;
            Console.WriteLine($"Товар {koka.Type}, {koka.Name} стоит {koka.Total()}.\n" +
                $"Уменьшив цену на 23.50 получим стоимость {koka.Discount(23.50)}\n\n");

            //Задание 2. Устройства
            Kettle kettle = new Kettle("Чайник", "Индукционный чайник", "типа свистит");
            kettle.Show();
            kettle.Desc();
            kettle.Sound();
            Console.WriteLine();
            Microwave microwave = new Microwave("Микроволновка", "Микроволновая печь", "типа дзинькает");
            microwave.Show();
            microwave.Desc();
            microwave.Sound();
            Console.WriteLine();
            Car car = new Car("Автомобиль", "спортивный автомобиль", "типа врум-врум");
            car.Show();
            car.Desc();
            car.Sound();
            Console.WriteLine();
            Steamship steamship = new Steamship("Пароход","Булькающая шняга", "типа буль-буль");
            steamship.Show();
            steamship.Desc();
            steamship.Sound();
            Console.WriteLine();

            //Задание 2. Музыкальные инструменты
            Violin violin = new Violin("Скрипка", "Струнно-смычковый музыкальный инструмент с четырьмя струнами",
                "Самая высокая регистровая разновидность скрипичного семейства, ниже которой располагаются альт, виолончель и контрабас","как то звучит....");
            violin.Show();
            violin.Desc(); 
            violin.History();
            violin.Sound();
            Console.WriteLine();
            Trombone trombone = new Trombone("Тромбон", "Медный духовой музыкальный инструмент", "Появление тромбона относится к XV веку. " +
                "Принято считать, что непосредственными предшественниками этого инструмента были кулисные трубы, при игре на которых у музыканта была возможность передвигать трубку инструмента,\n" +
                "таким образом получая хроматический звукоряд", "как то звучит....");
            trombone.Show();
            trombone.Desc();
            trombone.History();
            trombone.Sound();
            Console.WriteLine();
            Ukulele ukulele = new Ukulele("Укулеле", "четырёхструнная разновидность гитары", "Укулеле появилась на Гавайских островах во второй половине XIX века, куда её," +
                " под названием машети да браса (порт. machete da braça), завезли португальцы с острова Мадейра", "как тот звучит....");
            ukulele.Show();
            ukulele.Desc();
            ukulele.History();
            ukulele.Sound();
            Console.WriteLine();
            Violoncello violoncello = new Violoncello("Виолончель", " смычковый музыкальный инструмент с 4-мя струнами", "Появление виолончели относится к началу XVI века." +
                " Первоначально она применялась как басовый инструмент для сопровождения пения", "как то звучит....");
            violoncello.Show();
            violoncello.Desc();
            violoncello.History();
            violoncello.Sound();
            Console.WriteLine();

            //Заданеи 4. Работники
            President president = new President();
            Security security = new Security();
            Manager manager = new Manager();
            Engineer engineer = new Engineer();
            president.Print();
            manager.Print();
            security.Print();
            engineer.Print();






        }
    }
}
