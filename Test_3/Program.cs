using System;
using System.Threading.Channels;

namespace Test_3 
{
    class Program
    {
        static void Main(string[] args)
        {
            //双目运算符
            //双目运算符是指有两个操作数的运算符
            //若操作数是数字类型，则进行数学运算
            //若操作数是字符串类型，则进行字符串拼接
            // + ：加法运算符
            // - ：减法运算符
            // * ：乘法运算符
            // / ：除法运算符
            // % ：取余运算符
            // + ：字符串拼接运算符
            /*int age = 18;
            Console.WriteLine("年龄："  + age);//字符串拼接
            int a = 10;
            int b = 20;
            Console.WriteLine(a + b);//数学运算*/

            //赋值运算符: "="
            //"="是赋值号不是等于号
            //赋值类型要匹配
            //赋值左操作不可以是表达式
            /*int a = 0;
            int b = 0;
            int a + b = c; //错误
            int c = a + b; //正确 */
            //重新赋值后将覆盖原来的值

            //自增减运算符："++" "--"
            //自增减运算符可加在变量前后
            //前置自增：++a 先自增后使用
            //后置自增：a++ 先使用后自增
            /*int a = 10;
             Console.WriteLine(++a);//前置自增
             Console.WriteLine(a++);//后置自增*/

            //关系运算符
            //关系运算符用于比较两个值的大小
            //关系运算符的结果是布尔值，即true或false
            //> ：大于
            //>= ：大于等于
            //< ：小于
            //<= ：小于等于
            //== ：等于
            //!= ：不等于
            /*int myAge = 39;
            int yourAge = 20;
            Console.WriteLine(myAge > yourAge);//true
            double rabbit = 3;
            double turtle = 0.3;
            Console.WriteLine(rabbit < turtle);//false
            int dog = 50;
            int rabbit1 = 5;
            Console.WriteLine(dog < rabbit1);//false
            int myHuveMoney = 10;
            int yourHaveMoney = 10;
            Console.WriteLine(myHuveMoney == yourHaveMoney);//true*/

            //三元运算符
            //三元运算符有三个操作数
            //三元运算符的语法是：条件？表达式1：表达式2
            /*int age = 10;
            string result = age >= 18 ? "成年人" : "未成年人";
            Console.WriteLine(result);//未成年人
            int age1 = 30;
            string result1 = age1 >= 18 ? "成年人" : "未成年人";
            Console.WriteLine(result1);//成年人*/

            //逻辑运算符
            //逻辑运算符运算的结果为布尔值，即true或false
            //& ：逻辑“与”运算符
            //& 布尔表达式1 & 布尔表达式2
            //表达式1和表达式2都为true时，结果为true，否则为false
            //| ：逻辑“或”运算符
            //| 布尔表达式1 | 布尔表达式2
            //表达式1和表达式2有一个为true时，结果为true，否则为false
            //! ：逻辑“非”运算符
            //! 布尔表达式
            //如果布尔表达式为true，则结果为false；如果布尔表达式为false，则结果为true
            //逻辑运算符-双与、双或（常用）
            //&& ：逻辑“与”运算符（短路）
            //双与运算符是短路运算符，如果第一个布尔表达式为false，则不再计算第二个布尔表达式，直接返回false
            //|| ：逻辑“或”运算符（短路）
            //双或运算符是短路运算符，如果第一个布尔表达式为true，则不再计算第二个布尔表达式，直接返回true
            //其中“&&”运算符运算优先级高于“||”运算符
            /*char s = '女';
            int age = 20;
            string result = s == '女' & age >= 18 ? "能招募" : "不能招募";
            Console.WriteLine(result);*/
            /*int a = 10;
            Console.WriteLine(a > 0 | ++a < 20);
            int b = 10;
            Console.WriteLine(b > 0 || ++b < 20);
            Console.WriteLine("a:" + a + ",b:" + b);*/
        }
    } 
}