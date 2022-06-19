
using System;

namespace LabDay5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls ener your personal datas: ");

            Person fistPerson = new Person
            {
                _fistName = Console.ReadLine(),
                _secondName = "Mammadli",
                _age = 19,
                _phonenumber = "+994-050-333-12-75",
                _jobPosition = "Hr",
                _salary = 5000,
            };

       
        }

         



        public class Person
        {
            public string _fistName;
            public string _secondName;
            public decimal _age;
            public string _phonenumber;
            public string _jobPosition;
            public decimal _salary;

            public bool IsFirstCharUpper(string fistChar)
            {
                char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                for (int i = 0; i < alphabet.Length; i++)
                {
                    for (int k = 0; k < alphabet.Length; k++)
                    {
                        if (fistChar[0] != alphabet[k])
                        {
                            return false;
                        }
                    }

                }
                return true;
            }
            public bool IsAgeSuitable(int age)
            {
                if (_age > 18 !&& _age < 65)
                {
                    return false;
                }
                return true;
            }
            public bool IsFinCodeSuitable(string finCode)
            {
                char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                if (finCode.Length != 7)
                {
                    return false;
                }

                 for (int i = 0; i < alphabet.Length; i++)
                 {
                    for (int k = 0; k < alphabet.Length; k++)
                    {
                        if (finCode[k] != alphabet[k])
                        {
                            return false;
                        }
                     return true;
                   }
                }


                static bool IsTargerCharExists(string enteredData, string targetChar)
                {
                    int lastCharIndex = enteredData.Length - 1;
                    if (enteredData[0] == targetChar[0])
                    {
                        return true;
                    }
                    for (int i = 0; i < enteredData.Length; i++)
                    {
                        if (enteredData[lastCharIndex] == targetChar[0])
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }


        }
    }
}

