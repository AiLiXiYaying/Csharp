namespace 抽象类和抽象方法
{
    //可以理解为c++虚方法与纯虚函数
    #region 抽象类和抽象方法概念
    // 抽象类（Abstract Class）的示例

    // 抽象类不能被实例化，只能用作其他类的基类
    abstract class Animal
    {
        // 抽象类的构造函数可以有实现，可以用来初始化成员变量
        public Animal()
        {
            // 构造函数代码
        }

        // 抽象属性，没有具体的实现，必须在派生类中实现
        public abstract string Name { get; set; }

        // 抽象方法，没有具体的实现，必须在派生类中实现
        public abstract void Speak();

        // 非抽象方法，可以有具体的实现
        public void Eat()
        {
            Console.WriteLine("This animal is eating.");
        }
    }

    // 派生类必须实现基类中的所有抽象成员
    class Dog : Animal
    {
        // 实现抽象属性
        public override string Name { get; set; }

        // 实现抽象方法
        public override void Speak()
        {
            Console.WriteLine("The dog says: Woof!");
        }
    }
    
    class Cat : Animal
    {
        // 实现抽象属性
        public override string Name { get; set; }

        // 实现抽象方法
        public override void Speak()
        {
            Console.WriteLine("The cat says: Meow!");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, 抽象类和抽象方法");

            #region 代码示例
            // 抽象类不能被实例化
            // Animal myAnimal = new Animal(); // 错误，无法编译
            
            // 但是可以创建派生类的实例
            Dog myDog = new Dog { Name = "Buddy" };
            Cat myCat = new Cat { Name = "Kitty" };

            // 调用派生类中实现的抽象方法
            myDog.Speak(); // 输出: The dog says: Woof!
            myCat.Speak(); // 输出: The cat says: Meow!

            // 调用基类中的非抽象方法
            myDog.Eat(); // 输出: This animal is eating.
            myCat.Eat(); // 输出: This animal is eating.
            
            //设计框架时会使用抽象类 and 抽象方法
            #endregion
        }
    }
}
