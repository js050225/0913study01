using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("안녕하세요"); //출력문
            //string a = Console.ReadLine(); //스트림 입력문
            //Console.WriteLine("사용자가" + a + " 라고 입력하였습니다"); //스트림 출력문



            //if (a == "안녕")
            //{
            //    Console.WriteLine("다시한번 안녕");
            //}
            //else if (a == "아니 안녕못해")
            //{
            //    Console.WriteLine("ㅠㅠ");

            //}
            //else
            //{
            //    Console.WriteLine("뭐라고 말좀해봐");
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i + 1 + "회차 진행중...");
            //}

            //Console.ReadLine();

            /////////////////////////////////////////////////////////--응용 Paise -------------
            Console.WriteLine("계산기");
            Console.Write("첫번째숫자-->");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("두번째숫자는-->");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine("부호는(-나+ 만가능) ");
            string z = Console.ReadLine();
            if (z == "+")
            {
                Console.WriteLine("더한 결과는 :" + (x + y) + "입니다");
            }
            else if (z == "-")
            {
                Console.WriteLine("뺀 결과는:" + (x - y) + "입니다");
            }
            else
            {
                Console.WriteLine("버젼이 낮아서 안되");
            }
            Console.ReadLine();


            // 반복문으로 받아서, 사용자가 0을 입력하면 종료. 종료가 될 때 까지, 입력한 모든 숫자를 더하세요.
        }

     
    }

}
