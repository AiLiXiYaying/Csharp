namespace 万物之父
{
    internal class Program
    {
        #region 万物之父
        //关键字 object 是所有类型的基类
        class Person()
        {

        }

        class Person2:Person 
        {
            public void Speak()
            {
                Console.WriteLine("哈哈哈");
            }
        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("万物之父");

            #region 万物之父使用
            //object是箱子

            
            Person f = new Person2();

            object obj = new Person2();
            
            if (obj is Person2)
            {
                (obj as Person2).Speak();
                
            }

            //装箱 
            //把值类型用引用类型存储
            //栈内存会迁移到堆内存中
            object o1 = 1;

            //拆箱
            //把引用类型存储的值类型取出来
            //堆内存会迁移到栈内存中
            int k = (int)o1;

            //优点 类似auto功效
            //缺点 存在内存迁移 增加了性能消耗

            #endregion

        }
    }
}
