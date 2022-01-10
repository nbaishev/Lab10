using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {

            Angle angle = new Angle(180, 0, 0);
            Console.WriteLine(angle.Gradus);
            Console.WriteLine(angle.Min);
            Console.WriteLine(angle.Sec);
            angle.ToRadians();
            angle.Gradus += 180;
            angle.ToRadians();
            Console.ReadKey();
        }
    }

    class Angle
    {
        short gradus;
        byte min;
        byte sec;

        public short Gradus
        {
            set
            {
                if ((value >= 0) && (value <= 360))
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Неверный ввод данных");
                }
            }
            get
            {
                return gradus;
            }
        }

        public byte Min
        {
            set
            {
                if ((value >= 0) && (value < 60))
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Неверный ввод данных");
                }
            }
            get
            {
                return min;
            }
        }

        public byte Sec
        {
            set
            {
                if ((value >= 0) && (value < 60))
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Неверный ввод данных");
                }
            }
            get
            {
                return sec;
            }
        }

        public Angle(short gradus = 0, byte min = 0, byte sec = 0)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }

        public void ToRadians()
        {
            Console.WriteLine("Значение в радианах {0:F2}", ((gradus * 3600 + min * 60 + sec) * Math.PI / 180 / 3600));
        }
    }
}
