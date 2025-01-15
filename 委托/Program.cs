namespace 委托
{
    #region 声明委托
    //委托不能重名
    //委托本质是一个类
    public delegate void PrintDelegate(string message);
    //作用与c++ 函数指针差不多
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, 委托");
            #region 第一种使用
            //存起来
            PrintDelegate a = new PrintDelegate(fun);

            //执行
            a.Invoke("KeLaita");
            #endregion

            #region 第二种使用
            //存起来
            PrintDelegate a1 = fun;
            //这里为多播委托（委托变量 存储多个函数）
            a1 += fun;
            //执行
            a1("Mo");
            #endregion

            #region 官方提供的委托
            //无参无返回值的委托 Action
            Action action = fun1;

            //指定返回类型的 泛型委托
            Func<string> fx = fun2;
            Console.WriteLine(fx.Invoke());

            //还有很多官方提供的委托 基本可以满足正常需求
            #endregion
        }

        static void fun(string name)
        {
            Console.WriteLine("你好{0}", name);
        }
        static void fun1()
        {
            Console.WriteLine("你好");
        }
        static string fun2()
        {
            return "你好xxx";
        }

    }
}
