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
            "the task is done, and it will trigger the remain async code that has been waiting for the prior task to be done"+
            "with async code, that time between the database query start and the data return, the thread will be free to do something else, like handle the user input"+
            "and the user will see a loading icon (that we have to set up manually) and they will be happy"
            
            ;
            //we only have a single core, we can not do parallel caculation but TASKS ARE NOT CPU BOUND for that reason we can do them in parallel with a single thread
            //"for C# server, they support both parallel and aysnc " +

            string definitionOnSERVERLevel = "" +
            "let's we have a server with 2 cpu" +
            "so when the user send an http request, like a cat video" +
            "the server will start a NUMBER OF THREAD IN THE THREAD POOL, and by default, the number of thread in the thread pool will be equal to the number of cpu cores" +
            "and it could start a thousand threads theoretically BUT that gonna takes a lot of memory AND it take TIME to start a thread, thread is HEAVY WEIGHT, it could use up to MEGABYPE" +
            "so the thread pool shouldn't and can't grow indefinitely, there is a limit for what a machine can handle" +
            "so typically, you'd try to keep the thread pool small, not too small otherwise you would have to put in a lot of memory" +
            
            "so in our case, we will have 2 thread, equal with our cpu, " +
            "each hppt request is assigned an IDLE THREAD IN THE THREAD POOL" +
            "so our cat video http request will TAKE UP ONE THREAD in out thread pool" +
            "now after a bit of processing, it finds out it need to get the cat video from the database/disk and that cat video gonna take a lot of time to get" +
            
            "NOW is where if we DO NOT do async code, our thread will be block for a long time" +
            "that precious thread will be blocking, will be waiting for the ENTIRE TIME of that then send back the result for the client" +
            "so if ANOTHER CLIENT NEED TO SEE THAT CAT VIDEO and that thread still processing, we gonna need our second thread in the thread pool to do the same" +
            "and then THERE IS ANOTHER, AND ANOTHER, AND ANOTHER and what will happen is the server gonna start more and more thread, " +
            "and schedule those threads on our poor 2 cpus, and them threads gonna keep waiting and waiting and our cpus got overloaded" +
            "but those threads that holding the cpu hostage don't really do anything, they just idle, they just BLOCKING the cpuj , and like we said earler" +
            "every thread that the operating system creates uses a lot of resources, and that sounds bad, like really baddddddddddddddddddddddddddddddddddddd" +
            //SO THIS IS WHERE WE HAVE TO CHANGE OUR WAY OF PROGRAMMING
            "we have to change our approach to ASYNCHRONOUS programming even on the server" +
            "so let's start again, we have 2 threads, 2 cpus, a http request come in, request a cat video" +
            "we use a thread to process that request, on the other hand we have the database," +
            "we're issuing the io operation on the database and then WE HAND BACK THE THREAD" +
            "the thread only locked for a very small of time and once we done, it get back to the thread pool" +
            "and here goes the second request, it can go again to that exact same thread and it gonna to the same thing" +
            "then the request of the first database query comes back the one that belongs to the first http request, we gonna processing that" +
            "then send it back to the client" +
            "then the second io come back an we can process that second io and send it back to the second client" +
            "and now, with the power of asynchronous programming, we ONLY NEED ONE THREAD to handle multiple http request at the same time" +
            
            "the different between parallel in this is in parallel programming, we gonna use another thread to do that but here we only need to use that single thread" +
            "asynchronous programming is always used when you do any kind of non cpu-bound work, like accessing a database, a file server, a network..."


            ;



            /*
             

             
             */





        }

    }
}
