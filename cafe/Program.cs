using System;

namespace cafe
{
    class Program
    {
        static void Main(string[] args)
        {
            Table tableOne = new Table();
            tableOne.MaxPlace = 10;
        }
    }

    class Table
    {
        public int NumberTable;
        public int FreePlace;
        public int MaxPlace;
    }
}
