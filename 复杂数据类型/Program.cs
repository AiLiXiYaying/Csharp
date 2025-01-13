using System.Security.Cryptography.X509Certificates;

namespace 复杂数据类型
{
    #region 1.1枚举申明
    //枚举是一个整型常量集合 声明一般在namespace空间中，当然也可以在class，struct语句块中声明
    enum E_direction
    {
        up,//0
        down,//1
        right,//2
        left, //3   数值大小会累加
    }
    //重点：枚举不能在函数块中声明
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("复杂数据类型");
            #region 1.2使用枚举
            //自定义的枚举类型 变量名 = 默认值（自定义的枚举类型.枚举项）
            E_direction dir = E_direction.up;
            //实际使用 枚举相当于给数值起了个名字 ， 方便程序员了解具体是什么用处。
            if (dir == E_direction.up)
            {
                Console.WriteLine("向上走");
            }
            else if (dir == E_direction.down)
            {
                Console.WriteLine("向下走");
            }

            //在游戏开发中，对象很多时候，有很多状态
            //比如玩家有一个动作状态，我们需要用一个变量或者标识来表示当前玩家处于的是哪种状态
            //可能会使用int
            //1行走 2待机 3跑步 4跳跃 
            //那么枚举的作用就出来了，假如用数字，我们会很难分清楚这段代码的含义，但枚举可以帮助我们清晰的分清楚代码的含义。

            //提升代码维护性与可读性
            //枚举与switch天生一对
            #endregion

            #region 2.1数组声明
            //数组在内存中是连续性的
            //栈上 数据类型[] 变量名 = {元素1，元素2，元素n};
            int[] arr1 = { 1, 2, 1,7,8,9,3 };
            //堆上 数据类型[] 变量名 = new 数据类型[数组长度];
            int[] arr11 = new int[5];
            //堆上 数据类型[] 变量名 = new 数据类型[数组长度]{元素1，元素2，元素n};
            int[] arr12 = new int[] { 5, 6, 7, 8, 9,10 };
            //堆上 数据类型[] 变量名 = new 数据类型[数组长度]{元素1，元素2，元素n};
            int[] arr13 = new int[5] { 5, 6, 7, 8, 9 };


            //二维数组申明
            //栈上 数据类型[,] 变量名 = {{0行元素1，0行元素2}，{1行元素1,1行元素2 }};
            int[,] arr21 = { 
                            { 5, 6 },
                            { 4, 8 } 
            };
            //堆上 数据类型[,] 变量名 = new 数据类型[行,列];
            int[,] arr22 = new int[2, 3];
            //省略
            int[,] arr23 = new int[3, 3]
            {
                { 1,2,3},
                { 4,5,6},
                { 7,8,9}
            };
            //
            int[,] arr24 = new int[,]
            {
                { 1,2,3},
                { 4,5,6},
                { 7,8,9}
            };
            #endregion

            #region 2.2使用数组
            //1.数组长度
            //数组变量名.Length
            Console.WriteLine(arr1.Length);
            //2.获取数组中的某个元素
            //数组变量名[数字]          数字范围为0~ Length-1
            Console.WriteLine(arr11[0]);
            //3.修改数组中的元素
            arr1[0] = 55;
            //4.遍历数组
            foreach (int i in arr1) 
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\n");
            //5.增加数组的元素
            int[] arr14 = new int[10];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr14[i] = arr1[i];
            }
            foreach (int i in arr14)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\n");
            //6.删除数组中的元素
            int[] arr15 = new int[4];
            for (int i = 0; i < arr15.Length; i++)
            {
                arr15[i] = arr1[i];
            }
            foreach (int i in arr15)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
            //查找数组中的元素
            int i1 = 3;
            for (int i = 0;i < arr1.Length; i++)
            {
                if (i1 == arr1[i])
                {
                    Console.WriteLine("查找到了：{0},在索引{1}的位置", arr1[i] ,i);
                }
            }


            //数组用来批量存储游戏中的同一类型对象，比如：所有的玩家，怪物。
            #endregion

            //值类型与引用类型 忽略
        }
    }
}

