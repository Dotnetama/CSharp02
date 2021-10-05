using System;
using System.Collections.Generic;

namespace CSharp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // item : 항목, collection : 모음집 => 리스트
            foreach (BbsInfo bbsInfo in GetBbsInfos())
            {
                Console.WriteLine($"{bbsInfo.Writer}가" +
                    $" {bbsInfo.CreatedTicks} Ticks에 작성한" +
                    $" {bbsInfo.BbsSeq}번째 글의 제목과 내용은 다음과 같습니다.");
                Console.WriteLine($"제목 : {bbsInfo.Title}");
                Console.WriteLine($"내용 : {bbsInfo.Content}");
            }
        }

        // List<리스트 항목의 타입> => using System.Collections.Generic;
        private static List<BbsInfo> GetBbsInfos()
        {
            List<BbsInfo> bbsInfos = new List<BbsInfo>();
            int rowCount = 100;

            // for(initializer; condition; iterator)
            // 초기값; 조건; 반복 연산자(증가 또는 감소)
            for (int index = 0; index < rowCount; index++)
            {
                bbsInfos.Add(new BbsInfo
                {
                    BbsSeq = index + 1,
                    Title = $"{index + 1}번째 글의 제목입니다.",
                    Content = $"{index + 1}번째 글의 내용입니다.",
                    Writer = "Michael Bruce",
                    CreatedTicks = DateTime.Now.Ticks
                });
            }

            return bbsInfos;
        }
    }

    public class BbsInfo
    {
        public int BbsSeq { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Writer { get; set; }

        /*
         * 1 tick == 1/10,000,000초
         * 1 millisecond == 1/1,000초 == 10,000 tick
         * 정밀한 값을 계산할 때 사용
         */
        public long CreatedTicks { get; set; }
    }
}
