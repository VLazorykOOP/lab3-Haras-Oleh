using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zavdannia1;
using zavdannia2;

//https://github.com/Haras-Oleh/csharp_lab3

namespace zavdannia1 
{
    public class Romb
    {
protected int a { get; set; }
protected int d1 { get; set; }
protected string c { get; }

public Romb(int a_, int d1_, string c_)
{
if (a_ > 0)
{
a = a_;
}
if (d1_ > 0)
{
d1 = d1_;
}
c = c_;
}

        public void Otrimatu_Storony_ta_Diagonal()
        {
        Console.WriteLine($"Сторона A = {a}");
        Console.WriteLine($"Дiагональ D1 = {d1}");
        }

        public void Otrimatu_Perimetr()
        {
        int perimetr = a + a + a + a;
        Console.WriteLine($"Периметр дорiвнює: {perimetr}");
        }

        public void Otrimatu_Ploschu()
        {
        int ploscha = (a * d1)/2;
        Console.WriteLine($"Площа дорiвнює: {ploscha}");
        }

        public void Chu_E_Kvadratom()
        {
        if (d1 == a * Math.Sqrt(2))
        {
        Console.WriteLine("Даний Ромб є квадратом!");
        }
        if (d1 != a * Math.Sqrt(2))
        {
        Console.WriteLine("Даний Ромб НЕ є квадратом!");
        }
        }
        }
        }

namespace zavdannia2
{
    public class Detal
        {
        protected string  virobnuk{ get; set; }

        public Detal(string virobnuk)
        {
        this.virobnuk = virobnuk;
        }

        public void Show()
        {
        Console.WriteLine("Список iнформацiї про дану деталь:");
        Console.WriteLine($"виробник: {virobnuk}");
        }
        }

    public class Mehanizm : Detal
        {
        protected string kraina { get; set; }

        public Mehanizm(string virobnuk, string kraina) : base(virobnuk)
        {
        this.virobnuk = virobnuk;
        this.kraina = kraina;
        }

        public void Show()
        {
        Console.WriteLine("Список iнформацiї про даний механiзм:");
        Console.WriteLine($"Виробник: {this.virobnuk}");
        Console.WriteLine($"Країна: {this.kraina}");
        }
        }

    public class Vurib : Mehanizm
        {
        public Vurib(string virobnuk, string kraina) : base(virobnuk, kraina)
        {
        this.virobnuk = virobnuk;
        this.kraina = kraina;
        }

        public void Show()
        {
        Console.WriteLine("Список iнформацiї про даний вирiб:");
        Console.WriteLine($"Виробник: {this.virobnuk}");
        Console.WriteLine($"Країна: {this.kraina}");
        }
        }

    public class Vuzol : Mehanizm
        {
        protected string posada { get; set; }

        public Vuzol(string virobnuk, string kraina) : base(virobnuk,kraina)
        {
        this.posada = posada;
        this.virobnuk = virobnuk;
        this.kraina = kraina;
        }

        public void Show()
        {
        Console.WriteLine("Список iнформацiї про даний вузол:");
        Console.WriteLine($"Виробник : {this.virobnuk}");
        Console.WriteLine($"Країна: {this.kraina}");
        }
        }
        }

namespace laboratorna_robota3
{
        internal class Program
        {
        static void Main(string[] args)
        {
        int vubir = 0;
        do
        {
        Console.Write("Оберiть,будь ласка,одне iз двох завдань даної лабораторної роботи,яке Ви хочете перевiрити?: ");
        vubir = int.Parse(Console.ReadLine());
        } while (vubir != 1 && vubir != 2);

        switch (vubir)
        {
        case 1:
        Console.WriteLine("Хiд роботи першого завдання:");
        {
        Console.Write("Введiть,будь ласка, розмiр сторони а: ");
        int a = int.Parse(Console.ReadLine());
		
        Console.Write("Введiть,будь ласка, розмiр дiагоналi d1: ");
        int d1 = int.Parse(Console.ReadLine());
		
        Console.Write("Введiть,будь ласка,колiр ромба : ");
        string color = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Розмiрностi Вашого ромба:");
        Romb A = new Romb(a, d1, color);
        A.Otrimatu_Storony_ta_Diagonal();
        Console.WriteLine();

        Console.WriteLine("Периметр Вашого ромба:");
        A.Otrimatu_Perimetr();
        Console.WriteLine();

        Console.WriteLine("Площа Вашого ромба:");
        A.Otrimatu_Ploschu();
        Console.WriteLine();

        Console.WriteLine("Перевiрка чи є Ваший ромб квадратом:");
        A.Chu_E_Kvadratom();
        Console.WriteLine();
        }
        break;
        case 2:
        Console.WriteLine("Хiд роботи другого завдання:");
        {
        Detal Detal = new Detal("Автомобiля");
        Detal.Show();
        Console.WriteLine();

        Mehanizm Mehanizm = new Mehanizm("Volkswagen", "Нiмеччина");
        Mehanizm.Show();
        Console.WriteLine();

        Vurib Vurib = new Vurib("Bosch", "Австрiя");
        Vurib.Show();
        Console.WriteLine();

        Vuzol vuzol = new Vuzol("Davide Campari-Milano", "Iталiя");
        vuzol.Show();
        Console.WriteLine();
        }
        break;
        default:
        Console.WriteLine("Помилка!");
        break;
        }
        }
        }
        }
