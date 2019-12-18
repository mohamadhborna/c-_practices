using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using System;
using System.Linq;


namespace TestProject2
{
    

    // interface ICar{
    //      int speed{ get{ return speed; }
    //       set { speed = value; }}
    //       int engine {get{ return engine; }
    //        set { engine = value; }}
    //       int doorsNumber{get { return doorsNumber; }
    //        set { doorsNumber = value; }}
    // }
    //  public  class Bmw:ICar{
         
    //      int speed{ get{ return speed; }
    //       set { speed = value; }}
    //       int engine {get{ return engine; }
    //        set { engine = value; }}
    //       int doorsNumber{get { return doorsNumber; }
    //        set { doorsNumber = value; }}
    //      public void printState(){
    //          Console.WriteLine("speed="+speed);
    //          Console.WriteLine("enginePower="+engine);
    //          Console.WriteLine("mydoornumbers="+doorsNumber);
    //      }

    //  }  

    //  public  class pride:ICar{
    //        int speed{ get{ return speed; }
    //       set { speed = value; }}
    //       int engine {get{ return engine; }
    //        set { engine = value; }}
    //       int doorsNumber{get { return doorsNumber; }
    //        set { doorsNumber = value; }}
    //      public void printState(){
    //          Console.WriteLine("speed="+speed);
    //          Console.WriteLine("enginePower="+engine);
    //          Console.WriteLine("mydoornumbers="+doorsNumber);
    //      }
    //  }

    //  public class samand:ICar{
    //       int speed{ get{ return speed; }
    //       set { speed = value; }}
    //       int engine {get{ return engine; }
    //        set { engine = value; }}
    //       int doorsNumber{get { return doorsNumber; }
    //        set { doorsNumber = value; }}
    //      public void printState(){
    //          Console.WriteLine("speed="+speed);
    //          Console.WriteLine("enginePower="+engine);
    //          Console.WriteLine("mydoornumbers="+doorsNumber);
    //      }
    //  }
          public class Person{
          public  int id{ get{ return id; }
          set { id = value; }}
          public  string name {get{ return name; }
           set { name = value; }}
          public  int age{get { return age; }
           set { age = value; }}

           public  string familyName{get{return familyName;}  
           set { familyName = value; }}
           
        //     public  float avg{get { return avg; }
        //    set { avg = value; }}
           public Person(int Id ,string Name, int Age ,string FamilyName){
                this.familyName=FamilyName;
                this.name=Name;
                this.age=Age;
                this.id =Id;
           }


        //  public void printState(){
        //      Console.WriteLine("speed="+speed);
        //      Console.WriteLine("enginePower="+engine);
        //      Console.WriteLine("mydoornumbers="+doorsNumber);
        //  }
     }

     public class Scores{
         public  int id;
          public int csharp;
          public int java;
          public int cplus;

       public Scores(int Id, int Csharp,int Java, int Cplus){
           this.id=Id;
           this.csharp=Csharp;
           this.java=Java;
           this.cplus=Cplus;
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
        //      Random rnd = new Random();
        //   int[] array1 = new int[10];
        //   for(int i=0;i<10;i++){
        //     int randomNumber  = rnd.Next(1, 100);
        //     array1[i]=randomNumber;
        //   }
        //       foreach (var n in array1)
        //     {
        //         Console.WriteLine(n);
        //     }
            Console.WriteLine("////////");

          //var scoreQuery=  from score in array1 where score>10 select score;
            // var sorted = (from n in array1 orderby n ascending select n).ToArray();
            //  foreach (var n in sorted)
            // {
            //     Console.WriteLine(n);
            // }
        //    var scoreQuery =(from score in array1 where score==2 select score).Count();
        //     Console.WriteLine(scoreQuery);

         List<Person> persons = new List<Person>();

         Person p1=new Person(1,"mamad",20,"borna");
         Person p2=new Person(2,"ali",21,"elahi");
         Person p3=new Person(3,"moein",22,"shafie");
        //  persons.Add(p1);
        //  persons.Add(p2);
        //  persons.Add(p3);

        // Scores scores1=new Scores(1,20,14,18);
        // Scores scores2=new Scores(2,20,14,20);
        // Scores scores3=new Scores(3,10,15,18);

         List<Scores> scores=new List<Scores>();
        //   scores.Add(scores1);
        //   scores.Add(scores2);
        //   scores.Add(scores3);
         // int[] average=new int[3];
            //  var res = (from e1 in persons 
            //         join e2 in scores 
            //             on e1.id equals e2.id 
            //                 select new 
            //                 { 
            //                     name=e1.name,
            //                     familyName=e1.familyName,
            //                     csharp=e2.csharp,
            //                     java=e2.java,
            //                     cplus=e2.cplus,
            //                     avg = (e2.cplus+e2.csharp+e2.java)/3
            //                 }).Average();//.Sum()// 
  
        // Display result 
       // Console.WriteLine("Employee and their Salary: "); 
        // foreach(var val in res) 
        // { 
            // float  avg=val.java+val.csharp.val.cplus;
            // avg=avg
            //Console.WriteLine(val.name+"......."+"java="+val.java+"csharp="+val.csharp+"cplusplus"+val.cplus);
        //}



        }
    }
}
