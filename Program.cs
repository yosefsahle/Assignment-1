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

            static void menu(){
                Console.WriteLine("\nplease select number\n 1. Revers String\n 2. check palindrome\n 3. exit");
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
