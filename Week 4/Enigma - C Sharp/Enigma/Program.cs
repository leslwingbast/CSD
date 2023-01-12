﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Changing the output encoding of the console to support '€' in output
            string e = Encoding.Default.GetString(new byte[] { 128 });
            Console.OutputEncoding = Encoding.Default;
            Console.WriteLine(e);

            // List of rotors to map characters. Spaces and full stops are ignored.
            List<string> rotors = new List<string>();
            rotors.Add("BDFHJLCPRTXVZNYEIWGAKMUSQO");
            rotors.Add("SEBZKTHAYJDQXGCUMFNPVIORWL");
            rotors.Add("SKPWHAJEBTQNVCMGZDXFIOLYRU");
            rotors.Add("KFNASGBWCMVDTLQJHEIYRPXOUZ");

            string startMessage = "Error messages are difficult to read.";

            Console.WriteLine("The starting message is: " + startMessage);

            string encodedMessage = EnigmaMachine.Encode(startMessage, 2, rotors);
            Console.WriteLine("\nThe encoded message is: {0}", encodedMessage);

            Console.WriteLine("\n\nDecoding the message: {0}", encodedMessage);

            string decodedMessage = EnigmaMachine.Decode(encodedMessage, 2, rotors);

            Console.WriteLine("\n\nThe decoded message is:{0} \n", decodedMessage);

        }

    }
}
