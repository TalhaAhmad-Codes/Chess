namespace Chess.Core.Misc
{
    public static class Func
    {
        public static string CapitalizeString(string value)
        {
            string _new = "";
            
            for (int i = 0; i < value.Length; i++)
            {
                var chr = value[i];
                _new += i == 0 ? char.ToUpper(chr) : char.ToLower(chr);
            }

            return _new;
        }
    }
}
