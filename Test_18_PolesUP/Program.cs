using System;

namespace Test_18_PolesUP
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {


                Console.WriteLine("Введите IP адрес");
                string IP = Console.ReadLine();
                string Chek_IP = "";
                int Simbol;
                bool Bool = true;
                string Viev_IP = "";
                int Count = 1;
                for (int i = 0; i < IP.Length; i++)
                {
                    if ((IP[i] <= '9' && IP[i] >= 0) || (IP[i] <= 'f' && IP[i] >= 'a') || (IP[i] <= 'F' && IP[i] >= 'A') || IP[i] == '.' || IP[i] == ':')
                    {


                        if (IP[i] == '.' && Viev_IP != "IPv6")
                        {
                            Viev_IP = "IPv4";
                            Simbol = Convert.ToInt32(Chek_IP);
                            Chek_IP = "";
                            Count++;
                            if (Simbol > 255)
                            {
                                Bool = false;
                                break;
                            }
                        }
                        else if (IP[i] == ':' && Viev_IP != "IPv4")
                        {
                            Viev_IP = "IPv6";
                            if (Chek_IP.Length > 4 || Chek_IP.Length < 1)
                            {
                                Bool = false;
                                break;
                            }
                            Chek_IP = "";
                            Count++;
                        }
                        else
                        {
                            Chek_IP += IP[i];
                        }
                    }
                    else
                    {
                        Bool = false;
                        break;
                    }

                }
                if (Count != 8 && Count != 4)
                {
                    Bool = false;
                }
                if (Bool == true)
                {
                    Console.WriteLine("Этот IP типа " + Viev_IP);
                }
                else
                {
                    Console.WriteLine("Этот текст не является IP");
                }
            }
        }
    }
}
