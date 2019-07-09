using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System;

namespace Tests
{
    public class VowelsAndDigits
    {
        [Test]
        public void NewTestScriptSimplePasses()
        {
            int res = countVowelsAndDigits("asd123");
            //Assert.That(res);
        }
        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            yield return null;
        }

        public int countVowelsAndDigits(String line)
        {
            int[] countElements = new int[2];
         

            for (int i = 0; i < 6; ++i)
            {
                char ch = line[i];

                if (ch == 'a' || ch == 'e' || ch == 'i'
                    || ch == 'o' || ch == 'u')
                {
                    ++countElements[0];
                }
                else if (ch >= '0' && ch <= '9')
                {
                    ++countElements[1];
                }
            }
            return countElements[1];
            
        }
    }
}
