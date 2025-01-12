namespace 基础数据类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("变量");
            #region 知识点1 如何申明变量
            /*变量 可以变化的量 与数学函数模块中的变量与常量一样，在编程中，可将变量当作容器，用来存放变化的量*/
            /*在编程中，变量有类型，称为数据类型；不同的数据类型可以容纳不同的变量*/

            //变量申明写法
            /*数据类型 变量名 = 表达式（值）*/    //重点： 这里的 = 是赋值，而非等号，编程中的等号是==
            int i = 1;   //int 为数据类型 ， i为变量名 ， =是赋值符号 ， 1则是表达式（值）//其中 变量名可以随意起名。
            #endregion

            #region 知识点2 变量类型有哪些
            //不同的变量类型有不同的存储范围
            //1.有符号整形变量
            //有符号指的是什么？   有符号指的是 -，+这种符号，即包括负数，0，正数
            //sbyte  -128~127
            sbyte a1 = 10;
            //int    -21亿~21亿
            int a2 = 20;
            //short  -3万~3万
            short a3 = 30;
            //long   -9百万兆~9百万兆
            long a4 = 40;

            //2.无符号整型变量 无符号指的是 +这种符号，即包括0，正数
            //byte 0~255
            byte b1 = 10;
            //ushort 0~65535
            ushort b2 = 20;
            //uint 0~42亿
            uint b3 = 30;
            //ulong 0~18百万兆
            ulong b4 = 40;

            //3.浮点数（小数）
            //float 存储7/8位数字
            float c1 = 10.123456789f;  //重点 ： float数据类型，值的结尾要加f。
            Console.WriteLine(c1); //结果为10.123457 超出有限范围会四舍五入
            //double 存储15/17位数字
            double c2 = 10.5;

            //4.特殊类型
            //bool 表示真 假 ，真为true ， 假为false.
            bool d1 = true; //  1 
            bool d2 = false; // 0
            //char 存储字符，但只能存储1个
            char e1 = 'a';
            //string 字符串 ，可以存储多个字符拼接成的字符串
            string f1 = "hello";
            #endregion

            #region 初始化，定义，声明，赋值
            //初始化 包含定义，声明，赋值 ；初始化就是满足上述步骤，并第一次赋值时，称为初始化
            int g1 = 1;
            //定义 包含定义，声明  ；  定义就是满足上述步骤，第一次声明并定义，称为定义
            int g3; 
            //声明 就是在其他地方定义过，但在这里想要使用，就需要先进行声明，就可以调用其他地方的该变量，详情请见c++ extern
            //赋值 
            int g4 = 44; // 第一次赋值    
            g4 = 5; //重赋值 第n此赋值 ， 后面的会覆盖掉前面的，现在的g4的值就是5而非44.
            #endregion
            
            #region 常量
            //变量是会变化的量 ， 那么常量就是不会变化的量  重点：常量无法重赋值，而且定义时，必须初始化常量。
            //关键字 基础数据类型 常量名 = 表达式；          这里，常量名与变量名无异，表达的都是一个名字，const为关键字。
            const int a11 = 1;
            #endregion

            #region 隐式转换

            #endregion

            //以下为杂项，意思为 与当前主题无关，但又不想多开一个新主题，因此写在该主题最下方。
            #region 转义字符
            //这里只涉及常用转义字符
            // \n 换行
            Console.WriteLine("1.hello\nworld"); //试着运行，会发现，hello后面的world换行了
            // \' 单引号
            Console.WriteLine("\'hello world\'");//试着运行，会发现，hello左侧出现了',world右侧出现了'
            // \" 双引号
            Console.WriteLine("\"hello world\""); ////试着运行，会发现， heelo左侧出现了"，world右侧出现了"
            // \\ 斜杠
            Console.WriteLine("hello\\world"); ////试着运行，会发现，hello与world之间出现了一个斜杠
            
            //接下来是一些好玩的转义字符
            // \a 警告音
            Console.WriteLine("\nhello \a world");
            // \t 相当于打了一个tab键
            Console.WriteLine("\n\thello world");
            #endregion


        }
    }
}
