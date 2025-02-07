﻿namespace 隐式转换与显式转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("隐式转换与显式转换");

            #region 隐式转换
            //隐式转换 顾名思义，在你无法看到的地方，悄悄地转换。
            int a1 = 10;
            //这里就发生了隐式转换，由int隐式转换为long，由于能小转大，所以不报错。
            long a2 = a1;
            //这里就发生了隐式转换，由long隐式转换为int，由于不能大转小，所以报错。
            //a1 = a2;
            //所以综上所述，数据类型之间会进行隐式转换。只需注意的是（不严谨），大的数据类型不能隐式转换为小的数据类型，但小的数据类型可以隐式转换为大的数据类型。

            //不过多阐述，用的多了自然就清楚了，不需要死记硬背。
            #endregion

            #region 显式转换
            //只需要记住一点 可以看到他们之间发生了转换，程序员手动转换，就叫显式转换
            int b1 = 10;
            long b2 = b1;
            b1 = (int)b2; // 与上面的隐式转换的不同点，我将long显式转换为int，那么就可以将这个值赋值给b1.但有个隐患则是，大数据类型强行变为小数据类型，那么就可能导致数据精度丢失，例如超过了int的21亿，那么就会导致异常。

            //parse法 将字符串转换为对应的数据类型
            string str1 = "123";
            int c1 = int.Parse(str1);//将字符串123转化为int 123.
            Console.WriteLine(c1 + 5);//123+5=128
            str1 = "true";
            bool c2 = bool.Parse(str1);
            Console.WriteLine(c2);//输出true
            #endregion
        }
    }
}
