namespace 断子绝孙
{
    //sealed关键字    密封类
    //简称断子绝孙
    //作用
    //让类无法被继承
    sealed class A
    {

    }

    /*class B : A 
    {

    }*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sealed");
        }
    }
}
