public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        if (span > digits.Length||span<0)
        {
            throw new ArgumentException();
        }
        long maxRes = 0;
        
        for (int i = 0; i <= digits.Length-span; i++)
        {
            long k = 1;
            if (!digits.All(char.IsDigit))
                throw new ArgumentException();
            for (int j = 0; j < span; j++)
            {
                int dig = digits[i+j]-'0';
                k*=dig;
            }
            if (maxRes < k)
            {
                maxRes = k;
            }
        }
        return maxRes;

    }
}
