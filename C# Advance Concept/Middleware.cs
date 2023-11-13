using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advance_Concept
{
    internal class Middleware
    {
        public void concept()
        {
            string WhatIs_MiddleWare = "" +
                "A middleware is a component or a series of components that process requests and response and is executed on every request in the asp .net core app" +
                "Or in other word middleware is a set of code that runs between the client and server during the handling of a request and response" +
                "middleware is organized in a pipeline" +
                "each middleware inside that pipeline perform a specific task in the request-response pipeline" +

                "and they can inspect, modify or even cut off the pipeline to return the request and response" +

                "middleware is executed on every incoming HTTP request. " +
                "this means that each middleware component has an opportunity to process the request or response as the flow through the pipeline " +
                "but there are also cases where middleware might decide to stop processing of the request and immediately return a response" +
                "because it detects a condition that allows it to generate response without passing the request to the next component in the pipeline  "
                ;
        }
    }
}
