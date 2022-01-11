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

            static void substring(){  
                
                Console.WriteLine("please write your string");
                string str = Console.ReadLine();
                Console.WriteLine("-----------------");
                int n = str.Length; 
                for (int len = 1; len <= n; len++)
            {
                
                for (int i = 0; i <= n - len; i++)
                {
                    
                    int j = i + len - 1;

                    for (int k = i; k <= j; k++) 
                    System.Console.Write(str[k]);
                    System.Console.WriteLine();
                    
                }
                
            }
            Console.WriteLine("To Check another task press 1 || press anything to exit");
            string D = Console.ReadLine();
            if(D == "1"){menu();}
            else{
                Console.WriteLine("thank you");
            }
            
            
                     }
            static void largint(){Console.WriteLine("largest integer");}
            static void twoone(){Console.WriteLine("twoone");}
            static void hourmun(){

                try{
                Console.Write("Enter the hours : ");
                
            int hours = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the Minutes : ");
            int minutes = int.Parse(Console.ReadLine());
            
            double hourInDegrees = (hours * 30) + (minutes * 30.0 / 60);
            double minuteInDegrees = minutes * 6;
            double diff = Math.Abs(hourInDegrees - minuteInDegrees);
            if (diff > 180)
            {
                diff = 360 - diff;
            }
            Console.WriteLine($"\n>>> Angle between {hours} hour and {minutes} minute is {diff} degrees <<<");
            menu();
            }
            catch{Console.WriteLine("invalid input please try again\n -----------------");
            hourmun();
            
            }
            }

            static void menu(){
                Console.WriteLine("\nplease select number\n 1. Revers String                        ||    2. check palindrome\n 3. Reverse word Order                   ||    4. count Occurence of Word\n 5. Substring                            ||    6. second largest integer\n 7. Two dimensional to one dimensional   ||    8. angel b/n hour and minute\n 9. Exit");
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
                else{
                    if (N == "4"){
                    countoccr();
                }
                else{
                    if (N == "5"){
                    substring();
                }
                else{
                    if(N=="6"){
                        largint();
                    }
                    else{
                        if(N=="7"){
                            twoone();
                        }
                        else{
                            if(N=="8"){
                                hourmun();
                            }
                            else{
                                if(N=="9"){
                                    Console.WriteLine("Thank You");
                                }
                                else { Console.WriteLine("\n>>>please Input the correct nember<<<\n");
                                menu();}
                            }
                        }
                    }
                }
                }
                
                }
            }
           }
            }
        static void Main(string[] args)
        {
            menu();
           
            }
    }
}
