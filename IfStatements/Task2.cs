namespace IfStatements
{
    public static class Task2
    {
        public static int DoSomething1(int i)
        {
            if (i < -5)
            {
                return -i * i;
            }
            else if (i >= -5 && i <= 0)
            {
                return -i;
            }
            else
            {
                return i;
            }
        }

        public static int DoSomething2(int i)
        {
            if (i < -5)
            {
                int result = -(i * i);
                return result;
            }
            else if (i < 0)
            {
                int result = 0 - i;
                return result;
            }
            else
            {
                return i;
            }
        }
    }
}
