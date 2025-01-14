namespace 面向对象
{
    //三P
    //封装 继承 多态
    #region 类
    class Person
    {

        #region 成员方法
        //成员方法与c++一致
        //成员方法提供该类的行为
        public void Speak()
        {
            //this关键字，可以理解为c++的this指针
            //作用为 表示 使用当前的成员变量，而非函数中参数的名字
            Console.WriteLine(" 你好 {0}", this.name);
        }
        #endregion

        #region 构造函数
        //重点：在有构造函数后，默认构造函数将不存在，这时候需要手动创建默认构造函数
        public Person(int age,string name)
        {
            this.name = name;
            this.age = age;
        }
        //手动创建默认构造函数  详情看我eff c++中的构造函数定义
        //如果不手动创建默认构造函数，并且存在其他的带参构造函数时，就会导致Person p2 = new Person();报错
        public Person()
        {
            this.name = "AA";
            this.age = 200;
        }
        #endregion

        #region 成员变量
        //与c++不同的是 访问修饰符需要在成员变量定义时写
        //访问修饰符与c++一致 都有public private protected
        //public 公有 可以在 类外类内 与 子类 中使用
        //private 私有 只可以 类内 使用
        //protected 保护 只可以在 类内 与 子类 中使用
        //成员变量提供该类特征
        //类内，如果不加任何修饰符，则默认为private
        public int age;
        public string name;
        int id;
        #endregion
    
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("面向对象");

            #region 类的对象实例化
            //与c++一致
            //p1是对象
            //可以将类名看作数据类型  类创建对象的过程叫 对象实例化

            Person p1 = new Person(18,"KeLaita");
            Person p2 = new Person();
            //调用成员变量与成员方法 
            //与c++一致 
            //重点：只能调用具有public修饰符的成员变量或成员方法
            p1.name = "aa";//这里覆盖掉了上面的构造函数的string值
            p1.Speak();
            Console.WriteLine(p2.age);
            #endregion

        }
    }
}
