using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /************************* Первый пример *************************/
            Base b = new Base();
            // Вызов реализации Dispose в типе b: "Dispose класса Base"
            b.Dispose();
            // Вызов реализации Dispose в типе объекта b: "Dispose класса Base"
            ((IDisposable)b).Dispose();
            /************************* Второй пример ************************/
            Derived d = new Derived();
            // Вызов реализации Dispose в типе d: "Dispose класса Derived"
            d.Dispose();
            // Вызов реализации Dispose в типе объекта d: "Dispose класса Derived"
            ((IDisposable)d).Dispose();
            /************************* Третий пример *************************/
            b = new Derived();
            // Вызов реализации Dispose в типе b: "Dispose класса Base"
            b.Dispose();
            // Вызов реализации Dispose в типе объекта b: "Dispose класса Derived"
            ((IDisposable)b).Dispose();


        }
    }
    // Этот класс является производным от Object и реализует IDisposable
    internal class Base : IDisposable
    {
        // Этот метод неявно запечатан и его нельзя переопределить
        public void Dispose()
        {
            Console.WriteLine("Base's Dispose");
        }
        
    }
    // Этот класс наследует от Base и повторно реализует IDisposable
    internal class Derived : Base, IDisposable
    {
        // Этот метод не может переопределить Dispose из Base.
        // Ключевое слово 'new' указывает на то, что этот метод
        // повторно реализует метод Dispose интерфейса IDisposable
        new public void Dispose()
        {
            Console.WriteLine("Derived's Dispose");
            // ПРИМЕЧАНИЕ: следующая строка кода показывает,
            // как вызвать реализацию базового класса (если нужно)
            // base.Dispose();
        }
    }
}
