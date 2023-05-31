namespace IfStatements
{
    public static class Task8
    {
        public static bool DoSomething(bool b, int i)
        {
            if (b)
            {
                if (i < -6)
                {
                    return true;
                }
                else if (i >= -6 && i < -3)
                {
                    return false;
                }
                else if (i >= -3 && i < 0)
                {
                    return true;
                }
                else if (i == 0)
                {
                    return false;
                }
                else if (i > 0 && i <= 3)
                {
                    return true;
                }
                else if (i > 3 && i <= 6)
                {
                    return false;
                }
                else if (i > 6)
                {
                    return true;
                }
            }
            else
            {
                if (i < -6)
                {
                    return true;
                }
                else if (i >= -6 && i <= -3)
                {
                    return false;
                }
                else if (i > -3 && i < 0)
                {
                    return true;
                }
                else if (i == 0)
                {
                    return false;
                }
                else if (i > 0 && i < 3)
                {
                    return true;
                }
                else if (i >= 3 && i <= 6)
                {
                    return false;
                }
                else if (i > 6)
                {
                     return true;
                }
            }

            return false;
        }
    }
}
