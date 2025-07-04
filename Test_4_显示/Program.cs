using System;
using System.Threading.Channels;

namespace Test_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //显式转换Convert.ToXXX()
            //将一个基本数据类型转换为另一个基本数据类型
            //将基本数据类型转换为 int 类型
            /*string age = Console.ReadLine();
            int a = Convert.ToInt32(age);*/
            //将基本数据类型转换为 double 类型
            /*double b = Convert.ToDouble(13.2);*/
            //将基本数据类型转换为 float 类型
            /*string s = "23.2";
            float f = Convert.ToSingle(s);*/

            //显式转换Parse()
            //在基本数据类型中问们可以直接使用 Parse() 转换字符串
            //字符串的值必须为可转数字
            //将字符串转换为 int 类型
            /*int a = int.Parse("123");*/
            //将字符串转换为 double 类型
            /*double b = double.Parse("123.45");*/
            //将字符串转换为 float 类型
            /*float c = float.Parse("123.45");*/

            //显式转换TryParse()
            //该方法用于尝试将字符串转换为数字类型
            //如果转换成功，返回 true，并将转换后的值存储在 out 后的参数中
            //如果转换失败，返回 false，并将 out 后的参数设置为 0
            /*int x;
            int.TryParse("123a", out x);*/ //返回 false，x 的值为 0
            /*int y;
            int.TryParse("123", out y);*/ //返回 true，y 的值为 123
            
        }
    }
}