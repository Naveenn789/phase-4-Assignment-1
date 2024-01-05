namespace ClassLib
{
    public class Calculator
    {
        public int Fnum { get; set; }
        public int Snum { get; set;}
        public int Add()
        {
            int result = Fnum + Snum;
            return result; 
        }
        public int Sub()
        {
            int result = Fnum - Snum;
            return result;
        }
        public int Multi()
        {
            int result = Fnum * Snum;
            return result;
        }
        public int Div()
        {
            int result = Fnum / Snum;
            return result;
        }
    }
}