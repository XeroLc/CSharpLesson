﻿using System;
using System.Xml.Linq;

namespace Test_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //practice_01
            /*string name = "麦迪";
            Console.WriteLine("你好，" + name);*/

            /*string name = "麦迪";
            int age = 18;
            Console.WriteLine(name + ",今年" + age + "岁了");*/

            //practice_02
            /*Console.WriteLine("信息收集表");
            string name = "麦迪";
            int age = 18;
            string email = "2994042481@163.com";
            string address = "广东省佛山市顺德区伦教街道";
            int wages = 5000;
            Console.WriteLine("姓名：" + name);
            Console.WriteLine("年龄：" + age + "岁");
            Console.WriteLine("邮箱：" + email);
            Console.WriteLine("家庭地址：" + address);
            Console.WriteLine("期望工资：" + wages + "元/每月");
            Console.WriteLine("预期工作年限：" + (age + 10));*/

            //practice_03
            /*int a = 10;
            Console.WriteLine(++a);
            int b = 20;
            Console.WriteLine(--b);
            int c = 30;
            Console.WriteLine(c--);
            Console.WriteLine(c);
            int d = 40;
            Console.WriteLine(d++);
            Console.WriteLine(d);*/

            //practice_04
            /*int e = 50;
            e++;
            Console.WriteLine(e);
            int a = 10;
            a++;
            a = a + a;
            Console.WriteLine(a);
            int b = 10;
            b ++;
            b = b + ++b;
            Console.WriteLine(b);*/

            //practice_05
            /*int a = 10;
            int b = 20;
            int max = a > b ? a : b;
            Console.WriteLine(max);*/

            //practice_06
            /*Console.WriteLine("请输入名字");
            string name = Console.ReadLine();
            string result = name == "老王" ? "老王" : "流氓";
            Console.WriteLine(result);*/

            //practice_07
            /*bool gameOver;
            bool isWin;
            int health = 100;
            gameOver = true;
            isWin = false;
            Console.WriteLine (gameOver || isWin && health > 0);*/

            //practice_08
            /*string name = "麦迪";
            int csScore = 95;
            int unityScore = 90;
            string score = csScore >= 90 && unityScore >= 90 ? "通过" : "未通过";
            Console.WriteLine("学生：" + name);
            Console.WriteLine("成绩状态：" + score);*/

            //practice_09
            /*double year = 2023;
            bool isInt = (year / 400) % 1 == 0;
            Console.WriteLine(isInt);*/

            //practice_10
            /*int year = int.Parse(Console.ReadLine());
            string isLeapYear = year % 400 == 0 || (year % 4 == 0) && (year % 100 != 0) ? "是闰年" : "不是闰年";
            Console.WriteLine(isLeapYear);*/

            //practice_11
            /*Console.WriteLine("请输入你喜欢的运动");
            string sport = Console.ReadLine();
            Console.WriteLine("哈哈，好巧，我也喜欢{0}运动",sport);*/

            //practice_12
            /*Console.WriteLine("请输入用户名");
            string nameInput = Console.ReadLine();
            Console.WriteLine("请输入年龄");
            string ageInput = Console.ReadLine();
            Console.WriteLine("请输入班级");
            string classInput = Console.ReadLine();
            Console.WriteLine( "用户名：{0}，年龄：{1}，班级：{2}", nameInput, ageInput, classInput);*/

            //practice_13
            /*Console.WriteLine("请输入姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入语文成绩");
            int chineseScoreInput = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入数学成绩");
            int mathScoreInput = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入英语成绩");
            int englishScoreInput = int.Parse(Console.ReadLine());
            int totalScore = chineseScoreInput + mathScoreInput + englishScoreInput;
            int averageScore = totalScore / 3;
            Console.WriteLine("{0}，你的总成绩为{1}分，平均成绩为{2}分", name, totalScore, averageScore);*/

            
        }
    }
}