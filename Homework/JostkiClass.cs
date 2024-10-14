namespace Homework
{
    public class JostkiClass
    {
        //1*1
        public static double Dz1_1(double a)
        {
            double Price = 150 + (70 * a);

            return Price;
        }

        //1*2
        public static double Dz1_2(double amountSales, double salesPlan)
        {
            if ((amountSales - salesPlan) / 100 > 0.1)
            {
                double prize = amountSales * 0.01;
                Console.WriteLine(prize);
                return prize;
            }
            else
            {
                Console.WriteLine("Сотрудник не получает премию");
                return 0;
            }
        }

        //1*3
        public static double Dz1_3(double a)
        {
            double amountDeposit = a / 100 * 10;

            return amountDeposit;
        }

        //2*1
        public static double Dz2_1(string stocks, double quantity, double pricePerUnit, double result)
        {
            double discount = 0;
            if (stocks == "Да")
            {
                discount += 15;
            }
            else if (quantity >= 5)
            {
                result = pricePerUnit * quantity / discount;

            }

            return result;
        }

        //2*2
        public static string Dz2_2(int a)
        {
            if (a <= 2)
            {
                return "Маленький стол";
            }
            else if (a <= 4 || a >= 3)
            {
                return "Средний стол";
            }
            else if (a <= 8 || a >= 5)
            {
                return "Большой стол";
            }
            return "Компанию более 8-и человек ресторан разместить не сможет(";
        }

        //2*3
        public static string Dz2_3(int Age, int NumberOrders, double amountMoneySpent)
        {
            if (Age >= 60)
            {
                return "Клиент получает скидку";
            }
            else if (NumberOrders <= 4 || amountMoneySpent <= 5000)
            {
                return "Клиент получает скидку";
            }

            return "Клиент не получает скидку";
        }

        //2*4
        public static string Dz2_4(double Length, double Width, double Height, double mass, double distance)
        {
            if (Length + Width + Height <= 150 || Length < 100 || Width < 100 || Height < 100 || mass > 10 || distance >= 3 || distance <= 10)
            {
                return "Отправление малогабаритное";
            }
            return "Отправление не малогабаритное";
        }

        //3*1
        public static double Dz3_1(int a, int b)
        {
            int zero = 0;

            for (int i = 1; i < b; i++)
            {
                zero = a * b;
            }
            return zero;
        }

        //3*2
        public static int Dz3_2(int a, int b)
        {
            int i = 0;
            for (i = 0; i <= 1000; i++)
            {

                if (a % i == 0) ;
                {
                    return i;
                }

            }

            return i;

        }

        //3*3
        public static double Dz3_3(int a)
        {

            int amountOfCorrrectNumbers = 0;
            for (int i = 1; i * i < a; i++)
            {
                amountOfCorrrectNumbers = amountOfCorrrectNumbers + 1;
            }
            double result = amountOfCorrrectNumbers;
            return result;
        }

        //3*4
        public static double Dz3_4(int a)
        {
            int result = 0;
            for (int i = 1; i == a; i++)
            {
                if (i != a || a / 2 != 0)
                {
                    result = i;
                }
            }
            return result;
        }

        //3*5
        public static int Dz3_5(int a, int b)
        {
            if (a > b)
            {
                int lol = a;
                a = b;
                b = lol;
            }

            for (int i = a; i >= b; i++)
            {
                if (i % 7 == 0)
                {
                    return i;
                }
            }
            int eror = 0;

            return eror;
        }

        //4*1
        public static double Dz4_1(double a, double b)
        {

            while (a != b)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else if (a < b)
                {
                    b = b % a;
                }


            }

            double NOD = a + b;

            return NOD;

        }

        //4*2
        public static double Dz4_2(double a)
        {
            int sum = 0;
            while (a == 0)
            {
                if (a / 2 != 0)
                {
                    sum++;
                }
            }

            return sum;
        }

        //4*3
        public static double Dz4_3(string userInputNumberOne)
        {
            int inputtedNumber = Convert.ToInt32(userInputNumberOne);
            long result = 0;
            while (inputtedNumber > 0)
            {
                int current = inputtedNumber % 10;
                inputtedNumber = inputtedNumber / 10;
                result = result * 10 + current;
            }
            return result;
        }





    }
}
