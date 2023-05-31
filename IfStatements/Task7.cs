namespace IfStatements
{
    public static class Task7
    {
        public static int DoSomething(bool b, int i)
        {
            if (b is true && i <= -7)
            {
                return i;
            }
            else if (b is true && i > -7 && i < 7)
            {
                return 7 - i;
            }
            else if (b is true && i >= 7)
            {
                return i;
            }
            else if (b is false && i <= -5)
            {
                return i + 5;
            }
            else if (b is false && i > -5 && i < 5)
            {
                return i;
            }
            else
            {
                return i + 5;
            }
        }
    }
}
