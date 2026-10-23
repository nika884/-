using System;

namespace Yakushina_Veronika
{
    class Computer
    {
        public int InventoryNumber;
        public double CpuFrequency;
        public double HddSize;

        public void Show()
        {
            Console.WriteLine($"Инвентарный номер: {InventoryNumber}");
            Console.WriteLine($"Частота процессора: {CpuFrequency} ГГц");
            Console.WriteLine($"Объём жёсткого диска: {HddSize} ГБ");
        }

        public double MemoryCost(double pricePerGb)
        {
            return HddSize * pricePerGb;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();

            computer.InventoryNumber = 123345;
            computer.CpuFrequency = 1.5;
            computer.HddSize = 400;

            Console.WriteLine(" Данные о компьютере ");
            computer.Show();

            double cost = computer.MemoryCost(100);
            Console.WriteLine($"\nСтоимость внешней памяти: {cost} руб.");

            Console.ReadKey();
        }
    }
}