using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;
                Console.Write("Ввведите адрес здания ");
                string address = Convert.ToString(Console.ReadLine());
                Console.Write("Ввведите длину здания ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ввведите ширину здания ");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ввведите высоту здания ");
                double z = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ввведите этажность здания ");
                int n = Convert.ToInt32(Console.ReadLine());
                MultiBuilding building = new MultiBuilding(address, x, y, z, n);
                building.Print();
            }
            catch
            {
                Console.WriteLine("Ошибка! Входная строка имела неверный формат");
            }
            Console.ReadKey();
        }
    }
    class Building
    {
        public string Address { get; set; }
        public double length;
        public double Length
        {
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    Console.WriteLine("Длина должна быть > 0");
                }
            }
            get
            {
                return length;
            }
        }
        public double width;
        public double Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Ширина должна быть > 0");
                }
            }
            get
            {
                return width;
            }
        }
        public double height;
        public double Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Высота должна быть > 0");
                }
            }
            get
            {
                return height;
            }
        }
        public Building(string address,  double x, double y, double z)
        {
            Address = address;
            Length = x;
            Width = y;
            Height = z;
        }
        public void Print()
        {
            Console.WriteLine("Адрес здания {0}. Длина здания {1}. Ширина здания {2}. Высота  {3}", Address, Length, Width, Height);
        }
    }
    class MultiBuilding : Building
    {
        public int floors;
        public int Floors
        {
            set
            {
                if (value > 0)
                {
                    floors = (int)height;
                }
                else
                {
                    Console.WriteLine("Этаж должен быть > 0");
                }
            }
            get
            {
                return floors;
            }
        }
        public MultiBuilding(string address, double x, double y, double z, int n)
            : base(address, x, y, z)
        {
            Floors = n;
        }
        public void Print()
        {
            Console.WriteLine("Адрес здания {0}\nДлина здания {1}\nШирина здания {2}\nВысота здания {3}\nЭтажность здания {4}", Address, Length, Width, Height, Floors);
        }
    }
}
