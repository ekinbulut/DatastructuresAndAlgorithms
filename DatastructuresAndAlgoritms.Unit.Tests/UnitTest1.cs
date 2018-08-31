using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace DatastructuresAndAlgoritms.Unit.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {


            Validate("(()()");

        }



        public bool Validate(string input)
        {
            bool result = false;
            Dictionary<char, char> pairs = new Dictionary<char, char>();

            pairs.Add('(', ')');

            Stack st = new Stack();

            char[] cs = input.ToCharArray();

            for (int i = 0; i < cs.Length; i++)
            {

                if (st.Count != 0)
                {
                    if ((char)st.Peek() != cs[i])
                    {
                        char temp;
                        pairs.TryGetValue(cs[i - 1], out temp);

                        if (temp == cs[i])
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                }



                st.Push(cs[i]);
            }

            return result;

        }
    }
}
