using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PrimeNumber
    {
        [Test]
        public void returnTrueIfInputIsPrime()
        {
           
            var res = isPrime(7);
            Assert.IsTrue(res);
        }
        [Test]
        public void returnFalseIfInputIsOne()
        {
            var res = isPrime(1);
            Assert.That(res);
        }
        [Test]
        public void returnFalseIfInputIsLessThanOne()
        {

            var res = isPrime(-1);
            Assert.IsFalse(res);
        }
        [Test]
        public void returnFalseIfInputIsAlphhabet()
        {

            var res = isPrime('b');
            Assert.IsFalse(res);
        }
        
        [Test]
        public void returnsFalseIfInputIsPositiveNonPrime()
        {

            var res = isPrime(120);
            Assert.IsFalse(res);
        }
        [UnityTest]
        public IEnumerator PrimeNumberWithEnumeratorPasses()
        {
            yield return null;
        }
        public bool isPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}
