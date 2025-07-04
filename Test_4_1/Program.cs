using System;

namespace Test_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1
            /*Console.WriteLine("请输入姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入语文成绩");
            string chineseScore = Console.ReadLine();
            Console.WriteLine("请输入数学成绩");
            string mathScore = Console.ReadLine();
            Console.WriteLine("请输入英语成绩");
            string englishScore = Console.ReadLine();

            double chinese = Convert.ToDouble(chineseScore);
            double math = Convert.ToDouble(mathScore);
            double english = Convert.ToDouble(englishScore);

            double totalScore = chinese + math + english;
            double averageScore = totalScore / 3;

            Console.WriteLine("{0},你的总成绩为{1}分，平均成绩为{2}分",name,totalScore,averageScore);*/

            //练习2
            /*Console.WriteLine("请输入数字");
            string input = Console.ReadLine();
            float number = Convert.ToSingle(input);
            Console.WriteLine(number * 1.5);*/

            //练习3
            /*Console.WriteLine("请输入一段数字");
            string input = Console.ReadLine();
            int num;
            bool b = int.TryParse(input, out num);
            string result = b ? "输入的是数字" : "输入的不是数字";
            Console.WriteLine("b:{0},num:{1},输入结果:{2}",b,num,result);*/

            //练习4
            /*Console.WriteLine("请输入姓名");
            string name = Console.ReadLine();

            Console.WriteLine("请输入语文成绩");
            string chineseScore = Console.ReadLine();
            int chinese;
            bool c = int.TryParse(chineseScore, out chinese);

            Console.WriteLine("请输入数学成绩");
            string mathScore = Console.ReadLine();
            int math;
            bool m = int.TryParse(mathScore, out math);

            Console.WriteLine("请输入英语成绩");
            string englishScore = Console.ReadLine();
            int english;
            bool e = int.TryParse(englishScore,out english);

            int totalScore = chinese + math + english;
            int averageScore = totalScore / 3;
            Console.WriteLine("{0}同学,你的总成绩为{1}分,平均成绩为{2}分",name,totalScore,averageScore);*/

            //练习5
            Console.WriteLine("请输入第一个数字");
            string input1 = Console.ReadLine();
            Console.WriteLine("请输入第二个数字");
            string input2 = Console.ReadLine();
            int num1;
            bool isNum1 = int.TryParse(input1, out num1);
            string result1 = isNum1 ? "第一个输入是数字" : "第一个输入不是数字";
            int num2;
            bool isNum2 = int.TryParse(input2, out num2);
            string result2 = isNum2 ? "第二个输入是数字" : "第二个输入不是数字";
            string finalResult = isNum1 && isNum2 ? "两个数字的和为"+ (num1 + num2) : "至少有一个输入不是数字";
            Console.WriteLine(finalResult);
        }

    }
}