namespace 密封方法
{
    #region 密封方法
    // 基类
    public class BaseClass
    {
        // 虚方法，可以被重写
        public virtual void VirtualMethod()
        {
            Console.WriteLine("BaseClass VirtualMethod");
        }
    }

    // 派生类
    public class DerivedClass : BaseClass
    {
        //使用sealed时，必须有override关键字
        // 重写基类的虚方法，并密封它
        public sealed override void VirtualMethod()
        {
            Console.WriteLine("DerivedClass VirtualMethod");
        }
    }

    // 另一个派生类，尝试重写密封方法将导致编译错误
    public class AnotherDerivedClass : DerivedClass
    {
        // 下面的代码会导致编译错误，因为VirtualMethod已经在DerivedClass中被密封
        // public override void VirtualMethod()
        // {
        //     Console.WriteLine("AnotherDerivedClass VirtualMethod");
        // }
    }

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, 密封方法");
        }
    }
}
