namespace 结构体
{
    #region 1.结构体概念
    //结构体 是一种自定义变量类型 类似枚举
    //他是数据和函数的集合
    //在结构体中，可以声明各种变量和方法

    //作用：用来表现存在关系的数据集合 比如用结构体表现学生 动物 人类等等
    #endregion

    #region 2.结构体基本语法
    //采用帕斯卡命名法
    struct 自定义结构体名字
    {
        //变量

        //构造函数（可选）

        //函数
    }
    #endregion

    #region 3.结构体实例
    struct Student
    {
        //变量 
        //结构体中声明的变量，不能直接初始化
        //变量类型可以是任意类型，包括结构体，但不能是自己的结构体
        //Student s;//报错，因为是自己的结构体
        int age;
        bool sex;
        int number;
        string name;

        //构造函数
        //如果声明了构造函数，那么就必须把所有变量数据初始化
        //没有返回值
        //方便快速初始化结构体对象
        public Student(int age,bool sex,int number,string name) 
        {  
            //this关键字 与c++一致
            this.age = age;
            this.sex = sex;
            this.number = number;
            this.name = name;
        }

        //函数 
        public void Speak()
        {
            Console.WriteLine("我的名字是{0},今年{1}岁", this.name, this.age);
        }
    }
    //默认为私有，想要变公有，则需要在前方加上public关键字
    //私有在外边用不了，与c++一致
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("结构体");

            #region 4.结构体的使用
            Student student1 = new Student(18,true, 5201314,"小明");//学生1
            student1.Speak();
            #endregion
        }
    }
}
