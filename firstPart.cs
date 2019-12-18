using System;


namespace TestProject2
{

     static class Converter{

    //    public Converter(int number){
    //        this.number=number;
    //    }

        public static  string convert(this int  input){
            // char[] ch = new char[input.length()]; 
            //  ch=input.tocharArray();
            //  for (int i = 0; i < str.length(); i++) { 
            //   ch[i] = input.charAt(i); 
            //  } 
            //  for(int i=0;i<characters.length();i++){
            //      int counter=0;
            //      while(counter<3){
            //         Console.WriteLine(characters[i]);
            //         counter++; 
            //      }
            //      Console.WriteLine(",");
            //  }
            //input= 3.ToString("000"); 

            return String.Format("{0:n0}", input);
        }

    public static string ToPersianDateString(this DateTime georgianDate)
        {
            System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();

            string year = persianCalendar.GetYear(georgianDate).ToString();
            string month = persianCalendar.GetMonth(georgianDate).ToString().PadLeft(2,'0');
            string day = persianCalendar.GetDayOfMonth(georgianDate).ToString().PadLeft(2, '0');
            string persianDateString = string.Format("{0}/{1}/{2}", year, month, day);
            return persianDateString;
        }
    }
     static class toPersian{
        public static string ToPersianNameString( this string name){
          return "برنا";
      }  
     }  
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            input="borna";
            //Console.WriteLine("Hello World!");
            // int convertedValue= Convert.ToInt32(input);
            // Console.WriteLine(convertedValue.convert());
           
            // DateTime date=DateTime.Now;
            // Console.WriteLine(date.ToPersianDateString());
            Console.WriteLine(input.ToPersianNameString());
        }
    }
}
///////////
using System.Collections.Generic;
using System.Net.Mail;
using System;


namespace TestProject2
{
    

    interface ICar{
         int speed{ get{ return speed; }
          set { speed = value; }}
          int engine {get{ return engine; }
           set { engine = value; }}
          int doorsNumber{get { return doorsNumber; }
           set { doorsNumber = value; }}
    }
     public  class Bmw:ICar{
         
         int speed{ get{ return speed; }
          set { speed = value; }}
          int engine {get{ return engine; }
           set { engine = value; }}
          int doorsNumber{get { return doorsNumber; }
           set { doorsNumber = value; }}
         public void printState(){
             Console.WriteLine("speed="+speed);
             Console.WriteLine("enginePower="+engine);
             Console.WriteLine("mydoornumbers="+doorsNumber);
         }

     }  

     public  class pride:ICar{
           int speed{ get{ return speed; }
          set { speed = value; }}
          int engine {get{ return engine; }
           set { engine = value; }}
          int doorsNumber{get { return doorsNumber; }
           set { doorsNumber = value; }}
         public void printState(){
             Console.WriteLine("speed="+speed);
             Console.WriteLine("enginePower="+engine);
             Console.WriteLine("mydoornumbers="+doorsNumber);
         }
     }

     public class samand:ICar{
          int speed{ get{ return speed; }
          set { speed = value; }}
          int engine {get{ return engine; }
           set { engine = value; }}
          int doorsNumber{get { return doorsNumber; }
           set { doorsNumber = value; }}
         public void printState(){
             Console.WriteLine("speed="+speed);
             Console.WriteLine("enginePower="+engine);
             Console.WriteLine("mydoornumbers="+doorsNumber);
         }
     }
    class Program
    {
        static void Main(string[] args)
        {
           // string input;
            //input="borna";
            //Console.WriteLine("Hello World!");
            // int convertedValue= Convert.ToInt32(input);
            // Console.WriteLine(convertedValue.convert());
           
            // DateTime date=DateTime.Now;
            // Console.WriteLine(date.ToPersianDateString());
            //Console.WriteLine(input.ToPersianNameString());
             IEnumerable<int> List=new List<int>();


        }
    }
}
