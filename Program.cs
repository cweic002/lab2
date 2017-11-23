using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


interface IPrint
{
   void Print();
}

abstract class GeometricFigure
{

     public virtual int Ploshad()
    {
        return 1;
    }

}

class Pramougolnik : GeometricFigure, IPrint
{
    private
    int _Shirina = 0;  //ширина 
    int _Visota = 0;   //высота

    public int Shirina { get; set; }  //свойство
    public int Visota { get; set; } //свойство
    public Pramougolnik(int a, int b) //Конструктор
    {
        _Shirina = a;
        _Visota = b;
    }
    public override int Ploshad()  //переопределение виртуального метода Площади
    {
        return (_Shirina * _Visota) / 2;
    }
    public override string ToString()
    {
        return "Треугольник: " + "Ширина " + _Shirina.ToString() + " Высота " + _Visota.ToString() + " Площадь " + Ploshad().ToString();
    }
    public void Print()
    {
        Console.WriteLine(this.ToString());
    }


}

class Kvfdrat : Pramougolnik, IPrint
{
    public Kvfdrat(int a):base(a,a)
    {
        this.Shirina= a;
        this.Visota = a;
    }
    public override int Ploshad()  //переопределение виртуального метода Площади
    {
        return (Shirina * Visota);
    }
    public override string ToString()
    {
        return "Квадрат: "+"Строны " + Visota.ToString() + " Площадь " + Ploshad().ToString();
    }
    public void Print()
    {
        Console.WriteLine(this.ToString());
    }

}

class Krug : GeometricFigure, IPrint
{
    private int _Radius=0;
    public int Radius {get; set;}
    public Krug(int a)
    {
        _Radius = a;
    }
    public override int Ploshad()  //переопределение виртуального метода Площади
    {
        return 3*_Radius* _Radius;
    }
    public override string ToString()
    {
        return "Круг: " + "Радиус " + _Radius.ToString() + " Площадь " + Ploshad().ToString();
    }
    public void Print()
    {
        Console.WriteLine(this.ToString());
    }
}




namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pramougolnik P_One= new Pramougolnik(5,8);
            Console.WriteLine(P_One.ToString());
            Kvfdrat K_One = new Kvfdrat(6);
            Console.WriteLine(K_One.ToString());
            Krug Kr_One = new Krug(9);
            Console.WriteLine(Kr_One.ToString());
            // вызов спомощу интерфейса
            P_One.Print();
            K_One.Print();
            Kr_One.Print();

            Console.ReadLine();
        }
    }
}
