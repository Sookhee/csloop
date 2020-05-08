using System;
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

            string[] array = { "사과", "배", "포도", "딸기", "바나나" };
            foreach(string item in array)
            {
                Console.WriteLine(item);
            }

            string input = "Potato Tomato";
            Console.WriteLine(input.ToUpper());
            Console.WriteLine(input.ToLower());

            input = "감자 고구마 토마토";
            string[] inputs = input.Split(new Char[] { ' ' });
            foreach(var item in inputs)
            {
                Console.WriteLine(item);
            }

            string[] arr = { "감자", "고구마", "토마토", "가지" };
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
