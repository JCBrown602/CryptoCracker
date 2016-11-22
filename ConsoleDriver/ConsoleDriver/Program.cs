/* ***************************************************************************
 * 28 October, 2016 
 * ~ Jason Brown, Advancing Computer Science (ACS) Major
 * ~ University of Advancing Technology
 * 
 * CryptoCracker: This application will aid in solving various historical
 * ciphers, ie simple substitution, Vigenere, Enigma, etc. Beyond traditional
 * analysis of letter frequency, di/trigraphs, and indices of coincidence, my
 * main goal for this project is to develop a means of efficiently working
 * through all of the possibilities of two ciphers I have encountered on a
 * certain website. They both display simple substitution frequency distribution 
 * characteristics, but when applied, it yields gibberish in English, German, 
 * and Spanish.
 * 
 * My goal is to develop an algorithm that can discover a certain pattern.
 * The hypotheses is that this is, indeed, a simple substitution cipher,
 * yet the deciphered plain text is a second cipher text. Possibly every
 * third letter, a second substitution, etc.
 * 
 * I will include more notes and add the links in the ReadMe.md
 * 
 * ***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Aesthetics; // Helps keep the console output tidy

namespace ConsoleDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PHILL MILLER TEST..."); // debug: sanity check

            SpacerClass sp = new SpacerClass();
            sp.showSpacer();
        }
    }
}
