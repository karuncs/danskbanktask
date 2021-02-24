using System;
using System.IO;

namespace danskebanktask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call producer
            //new InputData().invokeProducer();

            //Call consumer
            new InputData().invokeCosumer();
        }
    }
}
