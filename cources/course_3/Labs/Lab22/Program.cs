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
        }
    }
}