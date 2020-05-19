using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mybook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<book> list = new List<book>();
            list.Add(new book()
            {
                name = "PHP 프로그래밍 입문",
                issueday = Convert.ToDateTime("2013 05 20"),
                author = "황재호",
                publisher = "김태현",
                publicshinghouse = "한빛아카데미(주)",
                headeditor = "김현용",
                planner = "김이화",
                editor = "김이화",
                designer="여동일",
            });

            foreach(var item in list)
            {
                Console.WriteLine("책 제목: " + item.name + "\n"
                                 + "초판 발행: " + item.issueday.Year + "년 " + item.issueday.Month + "월 " + item.issueday.Day + "일" + "\n"
                                 + "지은이: " + item.author + "\n"
                                 + "펴낸이: " + item.publisher + "\n"
                                 + "펴낸곳: " + item.publicshinghouse + "\n"
                                 + "책임편집: " + item.headeditor + "\n"
                                 + "기획: " + item.planner + "\n"
                                 + "편집: " + item.editor + "\n"
                                 + "디자인: " + item.designer);
            }

        }
    }
}
