namespace 继承
{
    //与c++ 继承 思想一致

    class Person
    {
        public int age;
    }

    //class Person2 : public Person { }  不同点 

    class Person2 : Person 
    {
        public new int age;         //将基类的age覆盖掉，之后使用person2实例化的对象的时候，使用的是自身的age
        //不推荐


        public int id;
    }

    //单根性 只能继承一个父类
    //传递性 子类可以继承父类的父类 ... 的所有内容


    #region 继承构造函数
    class A
    {
        public A(int i)
        {
            Console.WriteLine(i);
        } 
    }

    class B : A
    {
        //与c++思想一致
        //默认情况下，子类会默认调用父类的默认构造函数
        //通过base关键字 指定调用父类的某个构造函数
        public B(int i,int b) : base(i)
        {

        }
    }
    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("继承");


            //里氏替换原则
            //用父类容器 装载子类对象
            Person person = new Person2();
            #region is
            //is 关键字用于检查对象是否是特定类型的实例。它会返回一个布尔值，表示对象是否可以转换为指定的类型。
            if (person is Person2)
            {
                Console.WriteLine("是");
            }
            object obj = "Hello World!";
            if (obj is string)
            {
                Console.WriteLine("obj 是字符串类型");
            }
            else
            {
                Console.WriteLine("obj 不是字符串类型");
            }
            #endregion

            #region as
            //as 关键字用于将对象转换为特定类型。如果转换成功，as 返回转换后的对象；如果转换失败，则返回null（对于引用类型）或者 0（对于值类型）。因此，在使用as进行转换时，通常需要检查结果是否为null。
            Person2 person2 = person as Person2;

            object obj1 = "Hello World!";
            string str = obj1 as string;
            if (str != null)
            {
                Console.WriteLine("转换成功: " + str);
            }
            else
            {
                Console.WriteLine("转换失败");
            }


            object obj3 = 123; // obj 是一个整数

            // 尝试将 obj 转换为 string 类型
            string str1 = obj3 as string;

            // 检查转换是否成功
            if (str1 != null)
            {
                Console.WriteLine("转换成功，str 的值是: " + str1);
            }
            else
            {
                Console.WriteLine("转换失败，obj 不能转换为 string 类型");
            }


            #endregion

            //is 关键字仅检查对象是否可以转换为指定类型，但不执行实际的转换。
            //as 关键字尝试执行转换，如果转换失败，对于引用类型返回null，对于值类型则在运行时抛出异常（因为值类型不能为null）。
            //
            //




        }
    }
}
