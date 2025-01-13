namespace 函数
{
    internal class Program
    {
        #region 函数概念
        //函数也可以称为方法
        //作用为 封装代码
        //可以使用函数名称 来执行函数内的代码
        //提升代码复用率
        #endregion

        #region 函数写在哪里
        //函数写在class语句块 or struct语句块中
        #endregion

        #region 函数基本语法
        //static 返回类型 函数名(参数类型 参数名1,参数类型 参数名2,......)
        //{
        //      函数代码
        //
        //
        //      return 返回值;(有返回类型才写)
        //}

        //void 表示无返回值
        //帕斯卡命名法 MyName     驼峰命名法 myName    函数名使用第一种
        //参数可以有，也可以没有，按需。参数类型可以为任意类型,参数名使用驼峰命名法。
        
        
        //无参无返
        static void out1()
        {
            
        }
        //有参无返
        static void out2(int a) 
        {
            
        }
        //无参有返
        static int out3()
        {
            return 1;
        }
        //有参有返
        static int out4(int a)
        {
            return a;
        }
        //有参有多返回值
        static int[] Sum(int a, int b)
        {
            int sum = a+b;
            int avg = sum / 2;
            return new int[] { sum, avg };
        }
        #endregion

        #region ref 与 out
        //ref 与 c++中的 type& a 中的 & 一样。
        //可以使值类型，外部内部一起变。
        //ref外部必须初始化，函数内部不用初始化
        //out可以外部不初始化，但内部必须初始化
        static void Value(ref int a) 
        {
            a = 10;
        }
        static void Value1(out int a)
        {
            a = 1000;
        }
        //ref与out的作用：解决值类型和引用类型在函数内部改值或重新声明 能够影响外部传入的变量，让其也能被修改
        //使用上，在声明参数的时候前面加上ref与out关键字即可。
        #endregion

        #region 可变长参数关键词
        //params关键字后面必为数组
        //有了这个关键字，意味着可以传入n个参数，n可以为0，传入的参数会存入arr数组中
        //函数参数中最多出现一个params关键字，并且位置一定在最后。
        static int Sum1(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                sum += arr[i];
            }
            return sum;
        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("函数");
            #region ref与out代码示例
            //以下都是对ref与out写的代码

            int ax = 100;
            Value(ref ax);
            Console.WriteLine(ax);

            int ax1 = 100;
            Value1(out ax1);
            Console.WriteLine(ax1);

            //对应 ref必须初始化
            //out可以不初始化
            int ax2;
            //Value(ref ax2); //未初始化，所以报错
            //Console.WriteLine(ax2);

            Value1(out ax2);
            Console.WriteLine(ax2);
            #endregion

            #region 可变长参数关键字代码示例
            Console.Write("请输入您要输入的数字数量: ");
            int n = int.Parse(Console.ReadLine()); // 读取用户想要输入的数字数量
            int[] arr = new int[n]; // 创建一个大小为n的数组

            for (int i = 0; i < n; i++)
            {
                Console.Write($"请输入第 {i + 1} 个数字: ");
                arr[i] = int.Parse(Console.ReadLine()); // 读取用户输入的每个数字并存储到数组中
            }

            Console.WriteLine("总和是: " + Sum1(arr)); // 调用Sum1方法计算总和并输出
                                                    
            // 存在params关键字 调用方法时，可以这样做：
            int result = Sum1(1, 2, 3); // 不需要显式创建数组
            #endregion
        }
    }
}
