using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Computer
    {
        public int computerID;
        public string brandName;
        public string processorType;
        public double processorFrequency;
        public double computerRAM;
        public double storageCapacity;
        public double videocardMemory;
        public int cost;
        public int stock;

        public void Print()
        {
            Console.WriteLine($"{computerID}. {brandName} - Процессор - {processorType}({processorFrequency} ГГц), RAM - {computerRAM} ГБ, Объём памяти ЖД - {storageCapacity} ТБ, Объём памяти видеокарты - {videocardMemory} ГБ. Стоимость - {cost}. В наличии - {stock}");
        }
    }
}
