using System;

namespace Test_2
{
    class Program
    {

        static void Main(string[] args)
        {
            //变量

            //数据类型：整形（有符号）
            //sbyte:字节 8位 范围-2^7-2^7-1
            //short:短整形 16位 范围-2^15-2^15-1
            //long:长整形 64位 范围-2^63-2^63-1
            //int:整形 32位 范围-2^31-2^31-1

            //数据类型：整形（无符号）
            //byte:字节 8位 范围0-2^8-1
            //ushort:短整形 16位 范围0-2^161
            //ulong:长整形 64位 范围0-2^64-1
            //uint:整形 32位 范围0-2^32-1

            //int类型的变量，变量名字为age，age初始值为18
            int age = 18;
            //string类型的变量，变量名字为name，name初始值为张三
            string name = "张三";

            //数据类型：浮点（小数）
            //float:单精度 32位 7位有效数字
            //double:双精度 64位 15位有效数字
            //decimal:高精度 128位 28-29位有效数字
            float money = 5.2f;
            double money2 = 5.2;

            //整数默认使用int类型，小数默认使用double类型
            //整数常用int类型，小数常用float类型

            //数据类型：字符
            //char:单引号只包裹一个字符 16位 2字节
            //string:双引号包裹任意长度字符
            //bool:仅存true（真）和flase（假） 8位 1字节
            char c = 'a';
            string str = "麦迪";
            bool b = true;

            //变量命名规则_强制要求
            //变量名只能是字母 数字 下划线的组合
            //变量名必须为字母或下划线“_”开头
            //变量名不能使用C#语言关键词
            //不能和其他变量名或方法相同

            //变量命名规则_习惯要求
            //驼峰命名法：首单词首字母小写，后面单词首字母大写
            //变量名尽量能见名知意

            //变量的本质
            //值是可擦出的


            //常量

            //静态常量:const
            //必须定义初始值，并且后续不可变
            const int age1 = 18;

            //动态常量:readonly
            //只能声明为类字段 (static),支持实例类型或静态类型
            //只能在声明时初始化或在构造函数时初始化，初始化后无法更改
            /*static readonly int name;*/
    }
}