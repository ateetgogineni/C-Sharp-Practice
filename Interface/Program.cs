using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOnInterface
{
    /*  
     *  Interface : it is like an abstract class where it can have method and properties( with empty bodies)
     *  At the beginning of the interface start with letter I.
     *  By default members of interface are abstract and public.
     *  Interface can contain property and method but not fields.
     *  Interface does not contain constructor.
     *    
     *  Why and When to use interfaces ?
     *  To achive security hide sertain details and to show only important details of an object(interface).
     *  C sharp does not support multiple inheritance. We can achive it through multiple interfaces.
     *  Put a comma (,) between multiple interfaces.
     */

    // to create interface where it has for showing the notification and get the date
    // i want to display sender name , message name, and date 

    interface ISender
    {
        string Notification();
        string GetDate(string date);
    }

    class SenderMessage : ISender
    {
        string senderName;
        string messageName;
        string myDate;

        public SenderMessage()
        {
            this.senderName = "Venkat";
            this.messageName = "Hello";
            this.myDate = "11-0-2022";
        }

        public SenderMessage(string name, string message, string date)
        {
            this.senderName = name;
            this.messageName = message;
            this.myDate = date;
        }
        public void Notification()
        {
            Console.WriteLine("{0},{1},{2}", senderName,messageName,myDate);
        }
        public string GetDate (string date)
        {
            myDate = date;
            return myDate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SenderMessage sender = new SenderMessage("Venkat","Hello","11-02-2022");
            SenderMessage sender2 = new SenderMessage("Ateet", "Hi", "22-12-2022");

            sender.Notification();
            sender.GetDate("11-02-2022");

            sender2.Notification();



            Console.Read();
        }
    }



}
