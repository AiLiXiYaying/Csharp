using System.Runtime.CompilerServices;

namespace 面向对象_2_静态成员
{

    #region 知识点一 : 静态成员基本概念
    //静态成员关键字 static
    //静态成员特点 直接使用类名.出使用

    //重点：静态成员与程序同生共死，直到程序结束才会被释放
    //      静态成员存在于静态存储区
    //      静态成员有自己唯一的一个“内存小房间”
    //      静态成员具有唯一性 在任何地方使用，都是使用小房间里的内容，改变它，也是改变小房间里的内容
    



    //作用 ： 常用的唯一的方法 比如 相同规则的数学计算相关函数  --静态方法
    class Person()
    {
        //静态成员变量
        public static int age;
        //成员变量
        public string name;

        //静态成员方法
        public static void Speak()
        {
            //静态函数中不能使用非静态成员，
            //成员变量只能在对象实例化之后，才能点出来使用 不能无中生有
            Console.WriteLine("这是静态成员方法");
        }
        //成员方法
        public void Speak1()
        {
            Console.WriteLine("这是成员方法");
        }
    }

    //常量是特殊的static     static不需要立马初始化，而const则必须初始化
    //const只能修饰变量，而static可以修饰很多
    #endregion

    #region 知识点二 ： 静态类
    //静态类不能被实例化
    //静态类内 只能由静态成员

    //作用：将常用的静态成员写在静态类中 方便使用
    //不能被实例化 体现工具类的 唯一性

    static class Person2
    {
        static public int age;
        static public void Speak2()
        {

        }
        static public int Test
        {
            get;
            set;
        }

        #region 静态构造函数
        //静态类和普通类都可以有静态构造函数
        //不能使用访问修饰符
        //不能有参数
        //只会自动调用一次
        static Person2()
        {
            Console.WriteLine("静态构造函数");
            age = 18;
        }
        #endregion

        #endregion
    }

        internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("静态成员");
            #region 知识点一: 静态成员基本概念 示例代码
            Person.age = 18; //直接使用类名.出使用
            Person.Speak();//直接使用类名.出使用
            Console.WriteLine(Person.age);
            #endregion

            #region 知识点二: 静态类 示例代码
            //静态构造函数
            Console.WriteLine(Person2.age);
            Console.WriteLine(Person2.age);
            Console.WriteLine(Person2.age);
            #endregion
        }
    }
}
