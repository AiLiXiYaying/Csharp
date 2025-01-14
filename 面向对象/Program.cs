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
        //构造函数可以重载   先调用构造函数，最后调用析构函数，这个过程为自动的
        //重点：在有构造函数后，默认构造函数将不存在，这时候需要手动创建默认构造函数
        public Person(int age, string name)
        {
            this.name = name;
            this.age = age;
        }
        public Person(string name)
        {
            this.name = name;
        }
        //手动创建默认构造函数  详情看我eff c++中的构造函数定义
        //如果不手动创建默认构造函数，并且存在其他的带参构造函数时，就会导致Person p2 = new Person();报错
        public Person()
        {
            this.name = "AA";
            this.age = 200;
            Console.WriteLine("先调用了默认构造函数");
        }
        //与c++不同点     建议搜搜，这里写的不完全
        // : this() 作用是复用一些代码 ， 在这里，首先调用了默认构造函数，然后再调用了Person(int age, string name, int id)
        public Person(int age, string name, int id) : this()
        {
            Console.WriteLine("调用了三个参数的构造函数1");
        }
        //在这里，首先调用了public Person( string name),然后再调用了public Person(string name, int id)
        public Person(string name, int id) : this(name)
        {
            Console.WriteLine("调用了三个参数的构造函数2");
        }

        //构造函数
        //实例化对象时调用的函数
        //主要用来初始化成员变量
        //可以使用this语法重用代码
        //可以在函数中用this区分同名参数和成员变量 与c++一致
        //有参构造会顶掉默认的无参构造
        #endregion

        #region 析构函数
        //当引用类型的堆内存被回收时，会调用析构函数
        //对需要手动管理内存的语言（如c++）,需要在析构函数中做一些内存回收处理
        //c#中存在自动垃圾回收机制 GC
        //所以不会怎么使用析构函数，除非你想在某一个对象被垃圾回收时，做一些特殊处理
        //unity开发中，析构函数几乎不会使用

        //基本语法
        //析构函数是当垃圾真正被回收的时候，才调用的函数
        ~Person()
        {

        }
        #endregion

        #region 垃圾回收机制
        //垃圾回收 英文简写为GC
        //GC只负责堆内存的垃圾回收
        //值类型在栈上分配内存，有他们自己的生命周期。

        //c#中内存回收机制的大概原理
        //0代内存 1代内存 2代内存
        //代的概念：
        //代是gc使用的一种算法（分代算法）
        //新分配的对象都会被放在0代内存中
        //每次分配都可能会进行gc以释放内存（0代内存满时）

        //详细上网搜。推荐链接（https://www.bilibili.com/video/BV1tV411q7Rq?spm_id_from=333.788.player.switch&vd_source=b80de2e394cd52c729e13308b7529d52&p=8）

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

        #region 成员属性
        public string Name
        {
            //get set 访问权限不能都低于属性(Name)的权限
            //private get 则代表在类外部无法获取到
            get //返回
            {
                //可添加逻辑处理
                return this.name;
            }
            //private set 则代表在类外部无法设置
            set //设置
            {
                //可添加逻辑处理
                //value关键字 用来表示 外部传入的值
                this.name = value;
            }
        }
        
        //自动属性
            public string zame { get; set; }
            public int Age { get; set; }

        #endregion

        #region 索引器
        //访问修饰符 返回值 this[参数类型 参数名，参数类型 参数名...]
        //{
        //      内部写法和规则和索引器相同
        //      get{}
        //      set{}
        //}

        //函数与属性综合体
        //推荐类中有数组时使用索引器
        //可以重载
        //这里的示例可以不看，因为随手乱写的，可以只看语法
        public int this[int a,int b]
        {
            get { return a + b; }
            set {  }
        }
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
            Person p2 = new Person(55,"你好",66824);
            //调用成员变量与成员方法 
            //与c++一致 
            //重点：只能调用具有public修饰符的成员变量或成员方法
            p1.name = "aa";//这里覆盖掉了上面的构造函数的string值
            p1.Speak();
            Console.WriteLine(p2.age);
            #endregion

            #region 成员属性的使用
            Person p3 = new Person();
            //这里执行的set 
            p3.Name = "gogo";
            //这里执行的是get 因为使用了Name
            Console.WriteLine(p3.Name);



            // 创建Person对象
            Person person = new Person();

            // 使用自动属性
            person.Name = "张三"; // 设置Name属性
            person.Age = 30;      // 设置Age属性

            // 输出属性值
            Console.WriteLine("姓名: " + person.Name);
            Console.WriteLine("年龄: " + person.Age);
            #endregion

            #region 索引器的使用
            Person person2 = new Person();
            Console.WriteLine(person2[5, 6]);
            #endregion

            #region 手动触发垃圾回收
            //手动触发垃圾回收的方法
            //一般情况下，都是在 加载场景 or loading条 （人话：游戏加载界面）时调用
            GC.Collect();
            #endregion

        }
    }
}
