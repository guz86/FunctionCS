using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Конвертер валют Currency Converter
            // Написать конвертер валют (3 валюты).
            // У пользователя есть баланс в каждой из представленных валют.
            // Он может попросить сконвертировать часть баланса с одной валюты в другую.
            // Тогда у него с баланса одной валюты снимется X и зачислится на баланс другой Y.
            // Курс конвертации должен быть просто прописан в программе.
            // Программа должна завершиться тогда, когда это решит пользователь.
            
            float userRub;
            float userUsd;
            float userEur;
            string convertCur;
            string convertCurNeed;
            float curRubUsd = 75.25f;
            float curRubEur = 85.34f;
            float curUsdRub = 73.44f;
            float curUsdEur = 1.3f;
            float curEurUsd = 1.2f;
            float curEurRub = 82.12f;
            int countCur;
            string choice;
            // ToSingle для float
            // проблема с дробными числами, надо исключения какие то продумать...
            Console.Write("Введите сколько у вас RUB: ");
            userRub = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите сколько у вас USD: ");
            userUsd = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите сколько у вас EUR: ");
            userEur = Convert.ToSingle(Console.ReadLine());

            while (true)
            {
            Console.WriteLine("У Вас на руках: RUB: "+userRub+", USD: "+userUsd+", EUR: "+userEur);
            Console.WriteLine("Курсы валют на сегодня: \n RUB --> USD: " + curRubUsd + " \n USD --> RUB: " + curUsdRub + "\n RUB --> EUR: "+curRubEur+ "\n EUR --> RUB: "
                + curEurRub+ "\n USD --> EUR: "+ curUsdEur+ "\n EUR --> USD: "+ curEurUsd);

            Console.Write("Какую валюту вы хотите сконвертировать (RUB, USD, EUR): ");
            convertCur = Console.ReadLine();

            // После выбора валюты пользователю надо предоставить две другие валюты...

            if (convertCur == "RUB")
            {
                Console.Write("Вы можете конвертировать RUB в USD или EUR, введите наименование валюты: ");
                convertCurNeed = Console.ReadLine();
                Console.Write("Сколько вы хотите конвертировать RUB: ");
                countCur = Convert.ToInt32(Console.ReadLine());
                if (countCur > userRub)
                {
                    Console.WriteLine("Указанное количество RUB - "+ countCur + " больше вашего баланса" + userRub +" , введите сумму меньше!");
                    countCur = Convert.ToInt32(Console.ReadLine());

                }


                if (convertCurNeed == "USD")
                {
                    Console.WriteLine("Конвертируем "+ countCur + " RUB в USD по текущему курсу - " + curRubUsd);
                    userRub -= countCur; 
                    userUsd += countCur / curRubUsd;
                }
                if (convertCurNeed == "EUR")
                {
                    Console.WriteLine("Конвертируем " + countCur + " RUB в EUR по текущему курсу - " + curRubEur);
                    userRub -= countCur;
                    userEur += countCur / curRubEur;

                }

            }

            // После выбора валюты пользователю надо предоставить две другие валюты...
            if (convertCur == "USD")
            {
                Console.Write("Вы можете конвертировать USD в RUB или EUR, введите наименование валюты: ");
                convertCurNeed = Console.ReadLine();
                Console.Write("Сколько вы хотите конвертировать USD: ");
                countCur = Convert.ToInt32(Console.ReadLine());

                if (countCur > userUsd)
                {
                    Console.WriteLine("Указанное количество USD - " + countCur + " больше вашего баланса" + userUsd + " , введите сумму меньше!");
                    countCur = Convert.ToInt32(Console.ReadLine());

                }


                if (convertCurNeed == "RUB")
                {
                    Console.WriteLine("Конвертируем " + countCur + " USD в RUB по текущему курсу - " + curUsdRub);
                    userUsd -= countCur;
                    userRub += countCur * curUsdRub;
                }
                if (convertCurNeed == "EUR")
                {
                    Console.WriteLine("Конвертируем " + countCur + " USD в EUR по текущему курсу - " + curUsdEur);
                    userUsd -= countCur;
                    userEur += countCur * curUsdEur;

                }

            }

            // После выбора валюты пользователю надо предоставить две другие валюты...
            if (convertCur == "EUR")
            {
                Console.Write("Вы можете конвертировать EUR в RUB или USD, введите наименование валюты: ");
                convertCurNeed = Console.ReadLine();
                Console.Write("Сколько вы хотите конвертировать EUR: ");
                countCur = Convert.ToInt32(Console.ReadLine());

                if (countCur > userEur)
                {
                    Console.WriteLine("Указанное количество EUR - " + countCur + " больше вашего баланса" + userEur + " , введите сумму меньше!");
                    countCur = Convert.ToInt32(Console.ReadLine());

                }


                if (convertCurNeed == "RUB")
                {
                    Console.WriteLine("Конвертируем " + countCur + " EUR в RUB по текущему курсу - " + curEurRub);
                    userEur -= countCur;
                    userRub += countCur * curEurRub;
                }
                if (convertCurNeed == "USD")
                {
                    Console.WriteLine("Конвертируем " + countCur + " EUR в USD по текущему курсу - " + curEurUsd);
                    userEur -= countCur;
                    userUsd += countCur * curEurUsd;

                }

            } 

                // Вывод
                Console.WriteLine("У Вас " + userRub + " RUB, " + userUsd + " USD, " + userEur + " EUR.");


                Console.Write("Вы хотите еще что то конвертировать? (Нажмите любую клавишу или напишите NO): ");
                choice = Console.ReadLine();
                if (choice == "NO")
                {
                    break;
                }



            }

           


            /*
            // Конвертер валют Currency_Converter_ver2 через switch case

            float userRub;
            float userUsd;
            float userEur;
            string userChoiceСur;
            string userChoiceCurConvert;
            float userCurCount;
            string toExit;

            // курсы
            float rubToUsd = 75;
            float usdToRub = 73;

            float rubToEur = 85;
            float eurToRub = 83;

            float usdToEur = 1.2f;
            float eurToUsd = 1.1f;


            Console.Write("Введите сколько у вас RUB: ");
            userRub = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите сколько у вас USD: ");
            userUsd = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите сколько у вас EUR: ");
            userEur = Convert.ToSingle(Console.ReadLine());


            while (true)
            {
                Console.WriteLine("\n\nКурсы на сегодня: \n RUB >> USD: " + rubToUsd 
                    + "\n USD >> RUB: " + usdToRub
                    + "\n RUB >> EUR: " + rubToEur
                    + "\n EUR >> RUB: " + eurToRub
                    + "\n USD >> EUR: " + usdToEur
                    + "\n EUR >> USD: "+eurToUsd );

                Console.Write("\nКакую валюту вы хотите обменять RUB (1), USD (2), EUR (3): ");
                userChoiceСur = Console.ReadLine();

                switch (userChoiceСur)
                {
                    // RUB
                    case "1":
                        Console.Write("\n\nНа какую валюту вы хотите поменять RUB? USD (1) или EUR (2): ");
                        userChoiceCurConvert = Console.ReadLine();
                        Console.Write("Сколько RUB вы хотите обменять: ");
                        userCurCount = Convert.ToSingle(Console.ReadLine());

                        if (userRub < userCurCount)
                        {
                            Console.WriteLine("У вас не достаточно RUB! Введите сумму меньше " + userRub);
                            break;
                        }

                        switch (userChoiceCurConvert)
                        {
                            // RUB >> USD
                            case "1":
                                    userRub -= userCurCount;
                                    userUsd += userCurCount / rubToUsd;
                                break;
                            // RUB >> EUR
                            case "2":
                                userRub -= userCurCount;
                                userEur += userCurCount / rubToEur;
                                break;

                            default:
                                Console.WriteLine("Вы не верно выбрали валюту для обмена!");
                                break;
                        }

                        break;
                    // USD
                    case "2":
                        Console.Write("\n\nНа какую валюту вы хотите поменять USD? RUB (1) или EUR (2): ");
                        userChoiceCurConvert = Console.ReadLine();
                        Console.Write("Сколько USD вы хотите обменять: ");
                        userCurCount = Convert.ToSingle(Console.ReadLine());

                        if (userUsd < userCurCount )
                        {
                            Console.WriteLine("У вас не достаточно USD! Введите сумму меньше "+ userUsd);
                            break;
                        }

                        switch (userChoiceCurConvert)
                        {
                            // USD >> RUB
                            case "1":
                                userUsd -= userCurCount;
                                userRub += userCurCount * usdToRub;
                                break;
                            // USD >> EUR
                            case "2":
                                userUsd -= userCurCount;
                                userEur += userCurCount / usdToEur;
                                break;

                            default:
                                Console.WriteLine("Вы не верно выбрали валюту для обмена!");
                                break;
                        }

                        break;
                    // EUR
                    case "3":
                        Console.Write("\n\nНа какую валюту вы хотите поменять EUR? RUB (1) или USD (2): ");
                        userChoiceCurConvert = Console.ReadLine();
                        Console.Write("Сколько EUR вы хотите обменять: ");
                        userCurCount = Convert.ToSingle(Console.ReadLine());

                        if (userEur < userCurCount)
                        {
                            Console.WriteLine("У вас не достаточно EUR! Введите сумму меньше " + userEur);
                            break;
                        }
                        switch (userChoiceCurConvert)
                        {
                            // EUR >> RUB
                            case "1":
                                userEur -= userCurCount;
                                userRub += userCurCount * eurToRub;
                                break;
                            // EUR >> USD
                            case "2":
                                userEur -= userCurCount;
                                userUsd += userCurCount * eurToUsd;
                                break;

                            default:
                                Console.WriteLine("Вы не верно выбрали валюту для обмена!");
                                break;
                        }


                        break;
                    default:
                        Console.WriteLine("Вы ввели не верную валюту");

                        break;

                }

                Console.WriteLine("\n\nПосле обмена у вас на руках RUB: " + userRub + ", USD: " + userUsd + ", EUR: " + userEur);

                Console.Write("\n\nНажмите любую клавишу для продолжения!\n" +
                    "Если желаете выйти, напишите 1: ");
                toExit = Console.ReadLine();

                if (toExit == "1")
                {
                    break;
                }


            }
            */


            // Конвертер валют Currency_Converter_ver3 через switch case и валютные пары
            /*
            float userRUB;
            float userUSD;
            float userEUR;
            string choiceCurUser;
            float choiceCurCountUser;
            string exitConv;

            float curRUBToUSD = 75;
            float curUSDToRUB = 73;
            float curRUBToEUR = 88;
            float curEURToRUB = 85;
            float curEURToUSD = 1.1f;
            float curUSDToEUR = 1.2f;

            // меняем цвет текста
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Сколько у вас RUB: ");
            userRUB = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас USD: ");
            userUSD = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас EUR: ");
            userEUR = Convert.ToSingle(Console.ReadLine());
            //float.Parse аналогично Convert.ToSingle

            while (true)
            {

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("Курсы на сегодня:\n" + "RUB >> USD - " + curRUBToUSD + "\nUSD >> RUB - " + curUSDToRUB +
                    "\nRUB >> EUR - " + curRUBToEUR + "\nEUR >> RUB - " + curEURToRUB + "\nEUR >> USD - " + curEURToUSD +
                    "\nUSD >> EUR - " + curUSDToEUR);

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Выберите что вы хотите обменять:\n" +
                    "RUB >> USD напишите 1,\n" +
                    "USD >> RUB напишите 2,\n" +
                    "RUB >> EUR напишите 3,\n" +
                    "EUR >> RUB напишите 4,\n" +
                    "EUR >> USD напишите 5,\n" +
                    "USD >> EUR напишите 6,\n"
                    );
                choiceCurUser = Console.ReadLine();

                Console.Write("Сколько вы хотите поменять валюты: ");
                choiceCurCountUser = Convert.ToSingle(Console.ReadLine());

                switch (choiceCurUser)
                {
                    // RUB >> USD
                    case "1":
                        if (userRUB >= choiceCurCountUser)
                        {
                            userRUB -= choiceCurCountUser;
                            userUSD += choiceCurCountUser / curRUBToUSD;

                            Console.WriteLine("Конвертируем " + choiceCurCountUser + " RUB в USD.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("У Вас нет столько RUB для обмена, введите число меньше: " + userRUB);
                            break;
                        }


                    // USD >> RUB
                    case "2":
                        if (userUSD >= choiceCurCountUser)
                        {
                            userUSD -= choiceCurCountUser;
                            userRUB += choiceCurCountUser * curUSDToRUB;

                            Console.WriteLine("Конвертируем " + choiceCurCountUser + " USD в RUB.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("У Вас нет столько USD для обмена, введите число меньше: " + userUSD);
                            break;
                        }

                    // RUB >> EUR
                    case "3":
                        if (userRUB >= choiceCurCountUser)
                        {
                            userRUB -= choiceCurCountUser;
                            userEUR += choiceCurCountUser / curRUBToEUR;

                            Console.WriteLine("Конвертируем " + choiceCurCountUser + " RUB в EUR.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("У Вас нет столько USD для обмена, введите число меньше: " + userRUB);
                            break;
                        }

                    // EUR >> RUB
                    case "4":
                        if (userEUR >= choiceCurCountUser)
                        {
                            userEUR -= choiceCurCountUser;
                            userRUB += choiceCurCountUser * curEURToRUB;

                            Console.WriteLine("Конвертируем " + choiceCurCountUser + " EUR в RUB.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("У Вас нет столько EUR для обмена, введите число меньше: " + userEUR);
                            break;
                        }

                    // EUR >> USD
                    case "5":
                        if (userEUR >= choiceCurCountUser)
                        {
                            userEUR -= choiceCurCountUser;
                            userUSD += choiceCurCountUser * curEURToUSD;

                            Console.WriteLine("Конвертируем " + choiceCurCountUser + " EUR в USD.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("У Вас нет столько EUR для обмена, введите число меньше: " + userEUR);
                            break;
                        }

                    // USD >> EUR
                    case "6":
                        if (userUSD < choiceCurCountUser)
                        {
                            userUSD -= choiceCurCountUser;
                            userEUR += choiceCurCountUser * curUSDToEUR;

                            Console.WriteLine("Конвертируем " + choiceCurCountUser + " USD в EUR.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("У Вас нет столько USD для обмена, введите число меньше: " + userUSD);
                            break;
                        }
                    // Можно сделать 7 и 8 пункты для инфо по счетам и выхода, но придется в каждый кейс дописывать ввод валюты choiceCurCountUser
                    // Wrong way
                    default:
                        Console.WriteLine("Вам нужно выбрать пункт от 1 до 6, вы ошиблись с выбором валютной пары!");
                        break;
                }

                Console.WriteLine("В результате обмена у вас на руках RUB: " + userRUB + ", USD: " + userUSD + ", EUR: " + userEUR);

                Console.WriteLine("Напишите \"1\" для выхода! Или нажмите любую клавишу чтобы продолжить обмен.");
                exitConv = Console.ReadLine();
                if (exitConv == "1")

                {
                    break;
                }

            }
            */
        }

    }
}