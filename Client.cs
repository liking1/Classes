using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Classes
{
    class Client
    {
        private string name;
        public string Name
        {
            get => name;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
            }
        }
        private string number;
        public string Number
        {
            get => number;
            set
            {
                string tmp = value.Remove(0, 1);
                if (tmp.All(c => char.IsDigit(c)) && value[0] == '+')
                {
                    this.number = value;
                }
                else
                {
                    Console.WriteLine("Don`t work");
                }

            }
        }
        public Client(string name = "NoName", string number = "+32")
        {
            Name = name;
            Number = number;
        }
        public override string ToString()
        {
            return $"Name: {name}\nPhone: {number}";
            
        }

    }
}
