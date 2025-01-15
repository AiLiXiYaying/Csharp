using System.Reflection;

namespace 运算符重载
{
    #region 运算符概念
    //与c++一致
    //让自定义类和结构体 能够使用运算符
    //使用operator关键字
    
    //公共的静态方法
    //返回值写在operator前
    //逻辑处理自定义

    class Person
    {
        public int age;
        static public Person operator+(Person a,Person b)
        {
            //编写逻辑
            Person person = new Person();
            person.age = a.age + b.age;
            return person;
        }
    }
    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("运算符重载");
            Person c = new Person();
            c.age = 1;
            Person d = new Person();
            d.age = 2;
            //让类对象与类对象之间可以进行计算
            Person h = c + d;
            Console.WriteLine(h.age);
        }
    }
}
