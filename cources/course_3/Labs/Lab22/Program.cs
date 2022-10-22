using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Lab22
{
    public abstract class Component
    {
        public abstract string Operation();
    }
    class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "Component";
        }
    }
    abstract class Decorator : Component
    {
        protected Component _component;
        public Decorator(Component component)
        {
            this._component = component;
        }
        public void SetComponent(Component component)
        {
            this._component = component;
        }
        public override string Operation()
        {
            if (this._component != null)
            {
                return this._component.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }
    class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component comp) : base(comp)
        {
        }
        public override string Operation()
        {
            return $"DecoratorA({base.Operation()})";
        }
    }
    class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"DecoratorB({base.Operation()})";
        }
    }
    
    public class Client
    {
        public void ClientCode(Component component)
        {
            Console.WriteLine("РЕЗУЛЬТАТ: " + component.Operation());
        }
    }
    
    public class Facade
    {
        protected Subsystem1 _subsystem1;
        
        protected Subsystem2 _subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            this._subsystem1 = subsystem1;
            this._subsystem2 = subsystem2;
        }
        
        //  Методы Фасада удобны для быстрого доступа к сложной функциональности
        // подсистем. Однако клиенты получают только часть возможностей
        // подсистемы.
        public string Operation()
        {
            string result = "Фасад инициализирует подсистемы:\n";
            result += this._subsystem1.operation1();
            result += this._subsystem2.operation1();
            result += "Фасад приказывает подсистемам выполнить действие:\n";
            result += this._subsystem1.operationN();
            result += this._subsystem2.operationZ();
            return result;
        }
    }
    
    // Подсистема может принимать запросы либо от фасада, либо от клиента
    // напрямую. В любом случае, для Подсистемы Фасад – это еще один клиент, и
    // он не является частью Подсистемы.
    public class Subsystem1
    {
        public string operation1()
        {
            return "Подсистема 1: Готова!\n";
        }

        public string operationN()
        {
            return "Подсистема 1: Перейти!\n";
        }
    }
    
    // Некоторые фасады могут работать с разными подсистемами одновременно.
    public class Subsystem2
    {
        public string operation1()
        {
            return "Подсистема 2: будьте готовы!\n";
        }

        public string operationZ()
        {
            return "Подсистема 2: Огонь!\n";
        }
    }


    class Client2
    {
        // Клиентский код работает со сложными подсистемами через простой
        // интерфейс, предоставляемый Фасадом. Когда фасад управляет жизненным
        // циклом подсистемы, клиент может даже не знать о существовании
        // подсистемы. Такой подход позволяет держать сложность под контролем.
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Operation());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            var simple = new ConcreteComponent();
            Console.WriteLine("Клиент: Я получаю простой компонент!: ");
            client.ClientCode(simple);
            Console.WriteLine();

            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("Клиент: Теперь у меня есть декорированный компонент!: ");
            client.ClientCode(decorator2);
            Console.WriteLine("___________________________");
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            Facade facade = new Facade(subsystem1, subsystem2);
            Client2.ClientCode(facade);
        }
    }
}