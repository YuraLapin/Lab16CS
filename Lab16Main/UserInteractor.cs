namespace Lab16Main
{
    public static class UserInteractor
    {
        public static bool IsInt(string str)
        {
            for (int i = 0; i < str.Length; ++i)
            {
                if ("0123456789".IndexOf(str[i]) < 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int GetIntFromUser(string message)
        {
            int result;
            string? buffer;
            while (true)
            {
                Console.Write(message + ": ");
                buffer = Console.ReadLine();
                if (buffer == "" || buffer == null)
                {
                    Console.WriteLine("Не введено число");
                }
                else if (!int.TryParse(buffer, out result))
                {
                    if (IsInt(buffer))
                    {
                        Console.WriteLine("Число слишком большое");
                    }
                    else
                    {
                        Console.WriteLine("Число должно быть целым и состоять только из цифр");
                    }
                }
                else
                {
                    result = int.Parse(buffer);
                    return result;
                }
            }
        }

        public static int GetPositiveIntFromUser(string message)
        {
            while (true)
            {
                int result = GetIntFromUser(message);
                if (result <= 0)
                {
                    Console.WriteLine("Число должно быть положительным");
                }
                else
                {
                    return result;
                }
            }
        }
    }
}