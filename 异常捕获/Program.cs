namespace 异常捕获
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("异常捕获");

            #region 异常捕获
            //必备部分 try与catch必须一起出现
            try
            {
                //要检测的代码放在try块里面
                string str1 = Console.ReadLine();
                int c1 = int.Parse(str1);
                Console.WriteLine(c1);
            }
            catch
            {
                //如果检测到异常，则会输出catch里的代码
                Console.WriteLine("请输入合法数字");
            }
            //可选部分
            finally 
            {
                //不论结果怎样，都会执行的代码
                Console.WriteLine("完毕");
            }

            #endregion
        }
    }
}
