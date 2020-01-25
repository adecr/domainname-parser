using System;
using System.IO;
using System.Diagnostics;
using DomainParser.Library;
using DomainParser.Tests;

namespace DomainParser.TestConsole {
    class Program {
        static void Main(string[] args) {

            //What the hell is d: ????  :) :D (*_*)
            TLDRulesCache.RulesFileLocation = @"d:\" + Path.GetFileName(TLDRulesCache.RulesFileLocation);

            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            DomainTests tests = new DomainTests();

            Trace.WriteLine("-------- ParseNormalDomain");
            tests.ParseNormalDomain();
            Trace.WriteLine("");

            Trace.WriteLine("-------- ParseNormalDomainWhereTLDOccursInDomain");
            tests.ParseNormalDomainWhereTLDOccursInDomain();
            Trace.WriteLine("");

            Trace.WriteLine("-------- ParseWildcardDomain");
            tests.ParseWildcardDomain();
            Trace.WriteLine("");

            Trace.WriteLine("-------- ParseWildcardDomainWhereTLDOccursInDomain");
            tests.ParseWildcardDomainWhereTLDOccursInDomain();
            Trace.WriteLine("");

            Trace.WriteLine("-------- ParseExceptionDomain");
            tests.ParseExceptionDomain();
            Trace.WriteLine("");

            Trace.WriteLine("-------- ParseExceptionDomainWhereTLDOccursInSubdomain");
            tests.ParseExceptionDomainWhereTLDOccursInSubdomain();


            Console.ReadKey();

        }
    }
}
