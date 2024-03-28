namespace InversionOfControl.ProgramHelpers
{
    public static class ConvertIntToIntArray
    {
        public static int[] GetDigits(int id)
        {
            return id.ToString().Select(d => d - '0').ToArray();
        }
        internal static int[] GetDigits_Alternative1(int id)
        {
            return id.ToString().Select(d => (int)char.GetNumericValue(d)).ToArray();
        }
        internal static int[] GetDigits_Alternative2(int id)
        {
            return id.ToString().Select(d => int.Parse(d.ToString())).ToArray();
        }

        //https://makolyte.com/csharp-how-to-convert-char-to-int/
        //According to this article the Subtract '0' approach is the fastest one
        //followed by the GetNumericValue.

        //**for further reading : 
        //https://makolyte.com/comparing-performance-with-benchmarkdotnet-graphs/
    }
}