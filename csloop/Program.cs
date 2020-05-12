using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csloop
{
    class Program
    {
        static void Main(string[] args)
        {
            //long start = DateTime.Now.Ticks;
            //long count = 0;
            //while(start + (10000000) > DateTime.Now.Ticks)
            //{
            //    count++;
            //}
            //Console.WriteLine(count + "만큼 반복했습니다");

            //string[] array = { "사과", "배", "포도", "딸기", "바나나" };
            //foreach (string item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //string input = "Potato Tomato";
            //Console.WriteLine(input.ToUpper());
            //Console.WriteLine(input.ToLower());

            //input = "감자 고구마 토마토";
            //string[] inputs = input.Split(new Char[] { ' ' });
            //foreach (var item in inputs)
            //{
            //    Console.WriteLine(item);
            //}

            //string[] arr = { "감자", "고구마", "토마토", "가지" };
            //Console.WriteLine(string.Join(", ", arr));

            //int x = 1;
            //while(x < 50)
            //{
            //    //화면 지우고 커서 이동
            //    Console.Clear();
            //    Console.SetCursorPosition(x, 5);

            //    //출력
            //    if (x % 3 == 0)
            //        Console.WriteLine("__@");
            //    else if (x % 3 == 1)
            //        Console.WriteLine("_^@");
            //    else
            //        Console.WriteLine("^_@");

            //    //100밀리초 정지하고 x를 증가합니다.
            //    Thread.Sleep(100);
            //    x++;    
            //}

            // 실습일지 2번
            int[] array = new int[10];
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }

        }
    }
}
