using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.    Модель  компьютера  характеризуется  кодом  и  названием  марки компьютера,  типом  процессора,  частотой  работы  процессора,  
 * объемом оперативной памяти, объемом жесткого диска, объемом памяти видеокарты, стоимостью компьютера в условных единицах и количеством экземпляров, 
 * имеющихся в наличии. Создать список, содержащий 6-10 записей с различным набором значений характеристик.

Определить:

- все компьютеры с указанным процессором. Название процессора запросить у пользователя;

- все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;

- вывести весь список, отсортированный по увеличению стоимости;

- вывести весь список, сгруппированный по типу процессора;

- найти самый дорогой и самый бюджетный компьютер;

- есть ли хотя бы один компьютер в количестве не менее 30 штук?*/

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем несколько экземпляров класса Computer в List<>
            List<Computer> computers = new List<Computer>()
            {
                new Computer(){computerID = 1, brandName = "Dell", processorType = "AMD", processorFrequency = 3.5, computerRAM = 8, storageCapacity = 1, videocardMemory = 2, cost = 80000, stock = 15},
                new Computer(){computerID = 2, brandName = "Lenovo", processorType = "Intel", processorFrequency = 2.7, computerRAM = 16, storageCapacity = 2, videocardMemory = 4, cost = 180000, stock = 1},
                new Computer(){computerID = 3, brandName = "Dell", processorType = "AMD", processorFrequency = 1.7, computerRAM = 4, storageCapacity = 2, videocardMemory = 4, cost = 45000, stock = 13},
                new Computer(){computerID = 4, brandName = "Lenovo", processorType = "Intel", processorFrequency = 2.7, computerRAM = 8, storageCapacity = 0.5, videocardMemory = 1, cost = 60000, stock = 4},
                new Computer(){computerID = 5, brandName = "Dell", processorType = "Intel", processorFrequency = 3.3, computerRAM = 8, storageCapacity = 0.5, videocardMemory = 1, cost = 80000, stock = 1},
                new Computer(){computerID = 6, brandName = "Acer", processorType = "Intel", processorFrequency = 3.9, computerRAM = 16, storageCapacity = 1, videocardMemory = 2, cost = 100000, stock = 8},
                new Computer(){computerID = 7, brandName = "ASUS", processorType = "AMD", processorFrequency = 4.2, computerRAM = 16, storageCapacity = 2, videocardMemory = 1, cost = 200000, stock = 3}
            };

            #region first task
            //1 - все компьютеры с указанным процессором. Название процессора запросить у пользователя;

            //Console.WriteLine("Введите название процессора");
            //string processorType = Console.ReadLine();
            //List<Computer> computersByProcessor = computers.Where(x => x.processorType == processorType).ToList();
            //foreach (Computer computer in computersByProcessor)
            //{
            //    computer.Print();
            //}
            #endregion

            #region second task
            //2 - все компьютеры с объемом ОЗУ не ниже, чем указано.Объем ОЗУ запросить у пользователя;

            //Console.WriteLine("Введите минимальный объем ОЗУ");
            //double computerRAM = Convert.ToDouble(Console.ReadLine());
            //List<Computer> computersByRAM = computers.Where(x => x.computerRAM >= computerRAM).ToList();
            //foreach (Computer computer in computersByRAM)
            //{
            //    computer.Print();
            //}
            #endregion

            #region third task
            //3 - вывести весь список, отсортированный по увеличению стоимости;

            //List<Computer> computersByCost = computers.OrderBy(x => x.cost).ToList();
            //foreach (Computer computer in computersByCost)
            //{
            //    computer.Print();
            //}
            #endregion

            #region fourth task
            //4 - вывести весь список, сгруппированный по типу процессора;

            //IEnumerable<IGrouping<string, Computer>> iGroups = computers.GroupBy(x=>x.processorType).ToList();
            //foreach (IGrouping<string, Computer> iGroup in iGroups)
            //{
            //    Console.WriteLine(iGroup.Key);

            //    foreach (Computer computer in iGroup)
            //    {
            //        computer.Print();
            //    }
            //}
            #endregion

            #region fifth task
            //5 - найти самый дорогой и самый бюджетный компьютер;

            //List<Computer> computersMinMax = computers.OrderBy(x => x.cost).ToList();
            //Console.Write("Самый бюджетный компьютер: ");
            //computersMinMax.FirstOrDefault().Print();
            //Console.Write("Самый дорогой компьютер: ");
            //computersMinMax.LastOrDefault().Print();
            #endregion

            #region sixth task
            //6 - есть ли хотя бы один компьютер в количестве не менее 30 штук?

            bool stock30more = computers.Any(x => x.stock >= 30);
            if (stock30more)
            {
                Console.WriteLine("На складе есть позиции с количеством экземпляров свыше 30");
            }
            else
            {
                Console.WriteLine("На складе нет позиций с количеством экземпляров свыше 30");
            }
            #endregion


            Console.ReadKey();
        }
    }
}
