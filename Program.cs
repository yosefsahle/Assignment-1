using System;

namespace Assignment_1
{
    class Program
    {
         static void Revers(){
            int length;
            string rev= "";
            Console.WriteLine("Inpute Your String");
            string name = Console.ReadLine();

            length = name.Length -1;
            while(length>=0)
            {
                rev = rev + name[length];
                length --;

            }
            Console.WriteLine("\n_________________________________\n\n>>> the reverse of "+ name+ " is " +rev+" <<<\n_________________________________");
            menu();
            }

            static void checkpro(){
                int length;
            string rev= "";
            Console.WriteLine("Inpute Your String");
            string name = Console.ReadLine();
            string cap ="";
            for (int i=0;i<name.Length;i++){
                if (name[i]>='a'&&name[i]<='z'){
                    cap += (char)(name[i]-32 );
                }
                else{
                    cap += name[i];
                }
            }

            length = cap.Length -1;
            while(length>=0)
            {
                rev = rev + cap[length];
                length --;

            }
            
            
            if(cap==rev){
                Console.WriteLine("\n_________________________________\n\n>>> "+name+" is palindrome String<<< \n_________________________________");
                menu();
            }
            else {Console.WriteLine("\n_________________________________\n\n>>> "+name+" is not palindrome String <<< \n_________________________________");
            menu();}
            }

            static void Wordor(){
            int length;
            string rev= "";
            Console.WriteLine("Inpute Your Sentence");
            string name = Console.ReadLine();

            length = name.Length -1;
            while(length>=0)
            {
                rev = rev + name[length];
                length --;

            }
            Console.WriteLine("\n_________________________________\n\n>>> the reverse of "+ name+ " is " +rev+" <<<\n_________________________________");
            menu();
            }

            static void countoccr(){
                Console.WriteLine("Please Input Sentense or Word ...");
                string input = Console.ReadLine();
                Console.WriteLine("Now Insert the word you want to count");
                string find = Console.ReadLine();
                int count = 0;
                foreach(char item in input){
                    if (item == find[0]){
                        count++;
                    }
                    
                }
                Console.WriteLine("\n__________________________\nthe Word " + find + " occurse " +count+ " times\n_____________________");
                menu();
            }

            static void menu(){
                Console.WriteLine("\nplease select number\n 1. Revers String\n 2. check palindrome\n 3. Reverse word Order \n 4. count Occurence of Word\n 5. exit");
           string N = Console.ReadLine();
           if (N=="1"){
               Revers();
           }
           else {
               if (N == "2"){
               checkpro();
           }
            else{
                if (N == "3"){
                    Wordor();
                }
                if (N == "4"){
                    countoccr();
                }
                if (N == "5"){
                    Console.WriteLine("thank You");
                }
                else { Console.WriteLine("\n>>>please Input the correct nember<<<\n");
            menu();}
            }
           }
            }
        static void Main(string[] args)
        {
            menu();
           
            }
    }
}
