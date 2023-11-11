using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advance_Concept
{
    internal class Async_concept
    {
        public void Parallel_Programming()
        {
            string definition = "A thread is an instance of work" +
            "it's the smallest unit of execution within a process" +

            "A process can consist of multiple threads," +
            "and they share the same process resources " +

            "A computer can run multiple process due to the operating system scheduler " +

            "Parallel programming is when you distribute the calculation problem into multiple part " +
            "and you run them in parallel " +
            "it means you have some cpu bound you would like to do in parallel at the same point in time, " +
            "multiple calculation going on at the same time ";

             

            //For parallel programming you need multiple cpu core
            //For async programming you DO NOT

            /*
             

             
             */
        }

        public void Async_Programming()
        {

            string definitionOnUILevel = "" +
            "so, imagine you have a UI with one thread, like a WPS or winform ui, that render stuff and handle User Input" +
            "at one point in time, your UI decide it need to go to the database or access the disk and it WILL TAKE A CERTAIN AMOUNT OF TIME" +
            "so, if you DO NOT do async programming, your thread will actively WAIT and BLOCK the cpu until that specific task is done"+
            "so it will not be busy, it will not do any calculation, it just sits there and wait until the database return the result"+
            "and that time when it waits, is a PROBLEM, cuz we still have the USER INTERFACE which also a thread, and we're blocking it"+
            "and so the application is frozen for the entire time, it doesn't respond to the user input at all"+
            "and we know the user is generally stupid, and they will get mad at you because they think the app not working,"+
            "or they're know we're stupid and doing bad blocking code (which actually true)" +
            "we don't want neither of that, cuz we want the user to be happy, if the user is happy, our boss will be happy and we will get a raise (hopefully)" +
            
            //AND SAME IS PARTLY TRUE FOR THE SERVER

            "so what can we do? " +
            "we can run a tiny bit of code, that code will issue the database query, "+
            "that tiny bit of ASYNC code will tell the thread to GO DO SOMETHING ELSE, YOU'RE NOT BUSY, SOMEONE ELSE IS BUSY (which is the database in this case)"+
            "and it will also set a task, its like an alarm, when the task is done, it will go and tell the cpu that"+
            "the task is done, and it will trigger the remain async code that been waiting for the prior task to be done"+
            "with async code, that time between the database query start and the data return, the thread will be free to do something else, like handle the user input"+
            "and the user will see a loading icon (that we have to set up manually) and they will be happy"
            ;



             



            /*
             

             
             */





        }

    }
}
