namespace 多态
{
    #region 多态概念
    // 多态性（Polymorphism）的示例
    //多种状态
    //同一父类的对象，执行相同的方法有不同的表现
    //让对象有唯一行为的特征

    // 定义一个基类
    public class Animal
    {
        //virtual关键字 
        // 基类中的虚方法，可以被派生类重写
        public virtual void Speak()
        {
            
            Console.WriteLine("This animal makes a sound.");
        }
    }

    // 定义一个派生类
    public class Dog : Animal
    {
        //override关键字
        // 重写基类中的Speak方法
        public override void Speak()
        {
            Console.WriteLine("The dog says: Woof!");
        }
    }

    // 定义另一个派生类
    public class Cat : Animal
    {
        // 重写基类中的Speak方法
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
            Console.WriteLine("Hello, 多态");

            #region 多态示例代码
            // 创建基类和派生类的对象
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            // 多态性体现在这里：
            // 我们可以声明一个基类类型的引用，但指向派生类的对象
            // 然后调用Speak方法，该方法会根据对象的实际类型来调用相应的方法

            // 调用基类对象的Speak方法
            myAnimal.Speak(); // 输出: This animal makes a sound.

            // 调用派生类Dog对象的Speak方法，尽管引用类型是Animal
            myDog.Speak(); // 输出: The dog says: Woof!

            // 调用派生类Cat对象的Speak方法，尽管引用类型是Animal
            myCat.Speak(); // 输出: The cat says: Meow!

            // 这就是多态性的体现：同一个方法调用，根据对象的实际类型产生不同的行为
            #endregion
        }
    }
}
