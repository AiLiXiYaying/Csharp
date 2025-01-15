namespace 接口
{

    #region 定义接口
    public interface IAnimal
    {
        // 属性
        string Name { get; set; }

        // 方法
        void Eat();
        void Sound();

        // 事件
        event EventHandler OnMove;

        // 索引器
        string this[int index] { get; set; }
    }

    #endregion

    #region 接口使用 （类）
    //public class Dog : IAnimal, IDisposable 有接口有继承类时，用,隔开
    //接口可以继承其他接口，从而创建层次结构。一个接口可以继承多个接口。
    public class Dog : IAnimal
    {
        // 实现接口的属性
        public string Name { get; set; }

        // 实现接口的方法
        public void Eat()
        {
            Console.WriteLine("The dog is eating.");
        }

        ////显示
        //void IAnimal.Eat()
        //{
        //    Console.WriteLine("你好");
        //}

        public void Sound()
        {
            Console.WriteLine("The dog says: Woof!");
        }

        // 实现接口的事件
        public event EventHandler OnMove;

        // 实现接口的索引器
        public string this[int index]
        {
            get { return "1"; }
            set { /* 实现代码 */ }
        }
    }

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, 接口");

            #region 接口使用 （主）
            IAnimal animal = new Dog();
            animal.Name = "Buddy";
            animal.Eat();
            animal.Sound();
            #endregion

            //继承类    对象间的继承
            //继承接口  行为间的继承
        }
    }
}
