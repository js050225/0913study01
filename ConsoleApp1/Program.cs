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
            Console.WriteLine("안녕하세요"); //출력문
            string a = Console.ReadLine(); //스트림 입력문
            Console.WriteLine("사용자가" + a + " 라고 입력하였습니다"); //스트림 출력문



            if(a == "안녕")
            {
                Console.WriteLine("다시한번 안녕");
            }
            else if(a == "아니 안녕못해")
            {
                Console.WriteLine("ㅠㅠ");
                
            }
            else
            {
                Console.WriteLine("뭐라고 말좀해봐");
            }

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1 + "회차 진행중...");
            }
            Console.ReadLine();


        }

     
    }

}
