using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using System;
using System.Linq;
using System.Xml.Schema;


namespace TestProject2
{
    

    
          public class Person{
          public  int id{ get; set; }
          public string name;
          public   string familyName; 
          public Person(int Id ,string Name, string FamilyName){
                familyName=FamilyName;
                name = Name;
                id =Id;
          }
    //       private String courseName;
    // public Person(String name)
    // {
    //     courseName = name;
    // }
    // public void displayMessage()
    // {
    //     Console.WriteLine("The name of the course is \n{0}", courseName);
    // }


        //  public void printState(){
        //      Console.WriteLine("speed="+speed);
        //      Console.WriteLine("enginePower="+engine);
        //      Console.WriteLine("mydoornumbers="+doorsNumber);
        //  }
     }

     public class Scores{
          public  int id;
          public int day;
          public int bahman;
          public int esfand;

       public Scores(int Id, int Day,int Bahman, int Esfand){
           this.id=Id;
           this.day=Day;
           this.bahman=Bahman;
           this.esfand=Esfand;
       }


    //  }


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
          //  Random rnd = new Random();
          // int[] array1 = new int[10];
          // for(int i=0;i<10;i++){
          // int randomNumber  = rnd.Next(1, 100);
          // array1[i]=randomNumber;
          // }
          //   foreach (var n in array1)
          // {
          //     Console.WriteLine(n);
          // }
            int[] array1 = {1, 2, 2, 3, 3, 3, 13, 13};
            
            // var check = array1.Where(a => a == 2).Any();
            // var checkWithAny = array1.Any(a => a == 2);
            //
            //
            //
            // var firstSlected = array1.Where(a => a == 13).First();
            // var secondSelected = array1.Where(a => a == 13).FirstOrDefault();
            // var thirdSelected = array1.Where(a => a == 13).SingleOrDefault();
            // var fourthSelected = array1.Where(a => a == 13).FirstOrDefault();
            // Console.WriteLine(check);
            // Console.WriteLine(ch);
            string[] array2 = {"rahim", "Samad", "jafar", "alI"};

            var selected = array2.Where(a => a.ToLower().Contains("i")).ToList();
            var selected2 = array2.Where(a => a.ToLower().StartsWith("s")).ToList();
            var selected3 = array2.Where(a => a.ToLower().EndsWith("m"));
            foreach (var VARIABLE in selected3)
            {
               // Console.WriteLine(VARIABLE);
            }
            
            Console.WriteLine("////////");

          //var scoreQuery=  from score in array1 where score>10 select score;
            // var sorted = (from n in array1 orderby n ascending select n).ToArray();
            //  foreach (var n in sorted)
            // {
            //     Console.WriteLine(n);
            // }
        //    var scoreQuery =(from score in array1 where score==2 select score).Count();
        //     Console.WriteLine(scoreQuery);
        //
        List<Person> persons = new List<Person>();
        //
        Person p1=new Person(1,"mamad","borna");
        Person p2=new Person(2,"ali","elahi");
        Person p3=new Person(3,"moein","shafee");
        persons.Add(p1);
        persons.Add(p2);
        persons.Add(p3);
        //
        Scores scores1=new Scores(1,20,14,18);
        Scores scores2=new Scores(2,20,14,20);
        Scores scores3=new Scores(3,10,15,18);
        
         List<Scores> scores=new List<Scores>();
          scores.Add(scores1);
          scores.Add(scores2);
          scores.Add(scores3);
          
          
        var selected4= persons.GroupJoin(scores,person => person.id,score =>score.id,(person, scoreGroup) =>new {newperson =person,sum=scoreGroup.ToArray().Sum(singleScore => singleScore.bahman + singleScore.day + singleScore.esfand)}).OrderBy(input => input.sum).Last()

            ; 
        
        
        Console.WriteLine(selected4.newperson.name);
        // var query = database.Posts    // your starting point - table in the "from" statement
        //     .Join(database.Post_Metas, // the source table of the inner join
        //         post => post.ID,        // Select the primary key (the first part of the "on" clause in an sql "join" statement)
        //         meta => meta.Post_ID,   // Select the foreign key (the second part of the "on" clause)
        //         (post, meta) => new { Post = post, Meta = meta }) // selection
        //     .Where(postAndMeta => postAndMeta.Post.ID == id);
          
          
        //  int[] average=new int[3];
        //  var res = (from e1 in persons
        //      join e2 in scores
        //          on e1.id equals e2.id
        //      select new
        //      {
        //          name = e1.name,
        //          familyName = e1.familyName,
        //          csharp = e2.csharp,
        //          java = e2.java,
        //          cplus = e2.cplus,
        //      }).ToList();
        //
        // Display result 
       // Console.WriteLine("Employee and their Salary: "); 
        // foreach(var val in res) 
        // { 
            //float  avg=val.java+val.csharp.val.cplus;
            //avg=avg
            //int sum = val.  
        //     Console.WriteLine(val.name + "......."); //);
        // }
        //    Console.WriteLine("Enter the name of the coursebook");
        //     String cousebookname = Console.ReadLine();
        //     Person p1 = new Person(cousebookname);
        //     p1.displayMessage();



        }
    }
}
}
