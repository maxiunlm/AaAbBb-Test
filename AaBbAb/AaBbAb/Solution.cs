
namespace AaBbAb
{
    internal class Solution
    {
        private const string aaStr = "AA";
        private const string abStr = "AB";
        private const string bbStr = "BB";

        public string solution(int AA, int AB, int BB)
        {
            string aaWay = GetAA(AA, AB, BB);
            string abWay = GetAB(AA, AB, BB);
            string bbWay = GetBB(AA, AB, BB);

            string longestString = aaWay.Length > abWay.Length ? aaWay : abWay;
            longestString = longestString.Length > bbWay.Length ? longestString : bbWay;

            return longestString;
        }

        private string GetAA(int aa, int ab, int bb)
        {
            if (aa-- > 0)
            {
                return $"AA{GetBB(aa, ab, bb)}";
            }

            return string.Empty;
        }

        private string GetAB(int aa, int ab, int bb)
        {
            if (ab-- > 0)
            {
                string aaWay = $"AB{GetAA(aa, ab, bb)}";
                string abWay = $"AB{GetAB(aa, ab, bb)}";

                return aaWay.Length > abWay.Length? aaWay : abWay;
            }

            return string.Empty;
        }

        private string GetBB(int aa, int ab, int bb)
        {
            if (bb-- > 0)
            {
                string aaWay = $"BB{GetAA(aa, ab, bb)}";
                string abWay = $"BB{GetAB(aa, ab, bb)}";

                return aaWay.Length > abWay.Length ? aaWay : abWay;
            }

            return string.Empty;
        }
    }
}
