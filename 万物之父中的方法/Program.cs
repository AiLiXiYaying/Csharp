namespace 万物之父中的方法
{
    #region 继承万物之父中的方法
    public class MyClass : Object
    {
        public override string ToString()
        {
            return "这是 MyClass 的字符串表示。";
        }

        public override bool Equals(object obj)
        {
            //用于确定指定的对象是否等于当前对象。这个方法也可以在派生类中被重写，以提供自定义的比较逻辑。
            // 实现自定义的比较逻辑
            return base.Equals(obj);
        }

        //返回当前对象的哈希代码。当需要在哈希表中存储对象时，这个方法很有用。如果重写了 Equals 方法，通常也应该重写 GetHashCode 方法，以确保两个相等的对象返回相同的哈希代码。
        public override int GetHashCode()
        {
            // 实现自定义的哈希代码生成逻辑
            return base.GetHashCode();
        }

        public void DisplayTypeInfo()
        {
            //返回当前实例的 System.Type。Type 对象提供有关对象的类型信息。
            Type t = this.GetType();
            Console.WriteLine("这个对象的类型是: " + t.ToString());
        }

        public MyClass ShallowCopy()
        {
            //创建当前对象的浅表副本。这个方法是受保护的，通常用于实现浅复制。
            return (MyClass)this.MemberwiseClone();
        }


    }
    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, 万物之父中的方法");
            #region 
            //判断相等
            
            Console.WriteLine(object.Equals(1, 1));
            
            //引用类型判断，是判断地址是否一样
            #endregion
        }
    }
}
