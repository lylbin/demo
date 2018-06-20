using JiebaNet.Segmenter;
using System;
using System.Text;
using Xunit;

namespace JieBaDemo
{
    public class SegmenterTest
    {

        [Fact]
        public void Get_Word1_Test()
        {
            string val = "上个月物流费用是多少";
            var segmenter = new JiebaSegmenter();
            var segments = segmenter.Cut(val, cutAll: true);

            Console.WriteLine(string.Join('/', segments));

            segments = segmenter.Cut(val);
            Console.WriteLine(string.Join('/', segments));

            segments = segmenter.CutForSearch(val);
            Console.WriteLine(string.Join('/', segments));
        }

        [Fact]
        public void Get_Word2_Test()
        {
            string val = "今年累计物流费用是多少";
            var segmenter = new JiebaSegmenter();
            var segments = segmenter.Cut(val, cutAll: true);

            Console.WriteLine(string.Join('/', segments));

            segments = segmenter.Cut(val);
            Console.WriteLine(string.Join('/', segments));

            segments = segmenter.CutForSearch(val);
            Console.WriteLine(string.Join('/', segments));
        }

        [Fact]
        public void Get_Word3_Test()
        {
            string val = "去年物流费用是多少";
            var segmenter = new JiebaSegmenter();
            var segments = segmenter.Cut(val, cutAll: true);

            Console.WriteLine(string.Join('/', segments));

            segments = segmenter.Cut(val);
            Console.WriteLine(string.Join('/', segments));

            segments = segmenter.CutForSearch(val);
            Console.WriteLine(string.Join('/', segments));
        }

        [Fact]
        public void Get_Word4_Test()
        {
            string val = "上个月发货多少车";
            var segmenter = new JiebaSegmenter();
            var segments = segmenter.Cut(val, cutAll: true);

            Console.WriteLine(string.Join('/', segments));

            segments = segmenter.Cut(val);
            Console.WriteLine(string.Join('/', segments));

            segments = segmenter.CutForSearch(val);
            Console.WriteLine(string.Join('/', segments));
        }

        [Fact]
        public void Get_Word5_Test()
        {
            string val = "上个月发货多少订单";
            var segmenter = new JiebaSegmenter();
            var segments = segmenter.Cut(val, cutAll: true);

            Console.WriteLine(string.Join('/', segments));

            segments = segmenter.Cut(val);
            Console.WriteLine(string.Join('/', segments));

            segments = segmenter.CutForSearch(val);
            Console.WriteLine(string.Join('/', segments));
        }

        [Fact]
        public void Get_Word6_Test()
        {
            string val = "今年累计发货多少车";
            var segmenter = new JiebaSegmenter();
            var segments = segmenter.Cut(val, cutAll: true);

            Console.WriteLine(string.Join('/', segments));

            segments = segmenter.Cut(val);
            Console.WriteLine(string.Join('/', segments));

            segments = segmenter.CutForSearch(val);
            Console.WriteLine(string.Join('/', segments));
        }
    }
}
