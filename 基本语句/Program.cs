using System.Diagnostics;

namespace 基本语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("基本语句");
            //重点：他们基本都可以进行嵌套。 即for循环内再写一个for循环，if内再写一个if语句等等。
            #region 条件判断语句

            #region if语句
            //if(条件判断)
            //{
            //满足条件时（为true）执行
            //}
            if (args.Length > 0)
            {

            }
            #endregion

            #region if_else语句
            //if(条件判断)
            //{
            //满足条件时（为true）执行
            //}
            //else
            //{
            // 不满足条件时执行
            //}
            if (args.Length > 1)
            {

            }
            else
            {

            }
            #endregion

            #region if_else if_else语句
            //if(条件判断)
            //{
            //满足条件时（为true）执行
            //}
            //else if(条件判断)
            //{
            // 满足条件时(为true)执行
            //}
            //else
            //{
            // 不满足条件时执行
            //}

            //按从上到下判断，优先判断if，其次为else if。 假设if满足true，则else if不执行
            if (args.Length > 2)
            {
                
            }
            else if (args.Length < 3)
            {
 
            }
            else if (args.Length > 4) 
            {

            }
            else
            {

            }
            #endregion

            #region switch语句
            //switch(值)
            //case为选择性执行，根据条件判断给定的数值，选择对应的case执行.
            //default为if中的else，全都不满足时执行。
            switch (0)
            {
                case 0:
                    Console.WriteLine("0");
                    break;
                case 1:
                    Console.WriteLine("1");
                    break;
                default:
                    Console.WriteLine("全都不满足");
                    break;
            }
            #endregion

            #endregion

            #region 循环语句

            #region for循环
            //第一个；号内的只初始化一次，也就是for(初始化;条件判断;自增)
            //{
            // 满足时(条件判断为true时)进行执行
            //}
            for (int i = 0; i < args.Length; i++) //这里，int i = 0 只执行一次，而 i < args.Length; i++ 则会每次循环都执行。
            {

            }
            #endregion

            #region while循环
            //while(条件判断)
            //{
            // 满足时(条件判断为true时)进行执行
            //}
            //为false时，退出循环。
            while (true)
            {

            }
            #endregion

            #region do while循环
            //do while循环，先执行一次，再进行判断。
            //其余与while循环一致
            do
            {

            } while (true);
            #endregion

            #endregion
            
            /*while (true)
            {
                continue;
                break;
            }*/
            //小知识： break关键字 表示退出当前循环，continue关键字表示跳过当前一次循环。
        }
    }
}
