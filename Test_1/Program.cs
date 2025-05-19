using System;

namespace Lesson_helloworld_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console:控制台
            //WriteLine:写一行.显示.打印
            //内容:Hell World!
            Console.WriteLine("Hello World!");
            Console.WriteLine("我是麦迪");

            //ReadLine:读取一行
            //string:设置值
            //将读取一行收到的值存在name这个位置
            string name =Console.ReadLine();
            //将name位置存在的值显示出来
            Console.WriteLine(name);
        }

    }
}