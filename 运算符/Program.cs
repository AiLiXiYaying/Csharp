namespace 运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("运算符");
            #region 算术运算符

            #region 赋值运算符
            //将右侧的值，赋值给左侧的变量  
            int a1 = 1;
            #endregion

            #region 加法运算符
            // + 先计算右侧的500+20+0，然后将结果通过赋值运算符给到a2
            int a2 = 500 + 20 + 0;
            #endregion

            #region 减法运算符
            //- 与加法运算符同理
            int a3 = 540 - 20 - 0;
            #endregion

            #region 乘法运算符
            //* 与加法减法运算符同理
            int a4 = 100*5;
            #endregion

            #region 取余运算符
            //% 与加法减法乘法运算符同理      先算除法，然后取那个余数
            int a5 = 100 % 6;
            Console.WriteLine(a5);
            #endregion

            #region 运算符优先级
            //优先级 默认为现实数学的运算规律 先算乘除法，再算加减法
            int a6 = 100 / 5 + 5 * 5;
            //编程中，优先级更改，需要小括号，先算最里面的小括号，再算相对的外层的小括号
            int a7 = 4 * (9 / (55 * (55 + 66)));
            #endregion

            #region 复合运算符
            //+= -= *= /= %=
            int a8 = 100;
            a8 += 444; // a8 = 100+444
            #endregion

            #region 自增运算符
            //++i 与 i++
            int i = 1;
            i++; // 先用再增
            ++i; // 先增再用
            #endregion

            #endregion

            #region 条件运算符

            #region > 与 >=
            //判断，然后返回一个bool值
            bool a11 = 5 > 3;
            #endregion

            #region < 与 <=
            //同理
            #endregion

            #region ==
            //同理 ==为数学中的=号，相等时返回true，不相等时返回false。
            #endregion

            #region !=
            //同理 意思为 不等于
            #endregion

            #endregion

            #region 逻辑运算符
            //与(&&)或(||)非(!)

            #region 与 &&
            //双方返回值都为真才为真(true),一方为假，则为假
            bool a44 = 5>3 && 3>1;
            #endregion

            #region 或 ||
            //一方为真则为真
            bool a55 = 5 > 3 && 3 > 1;
            #endregion

            #region 非 ！
            //对最后结果取反，如果最后的结果为真，取反为假。如果最后的结果为假，则取反为真
            bool a33 = !(53 > 1); // ！（true）    // false
            #endregion

            #endregion

            #region 三目运算符
            string b11 = 5>3 ? "true时返回" : "false时返回";
            //先通过5>3计算出bool值，通过计算出的bool值，选择性执行?号右侧的语句。为true时返回:左侧的东西，为false时返回:右侧的东西。
            #endregion
        }
    }
}
