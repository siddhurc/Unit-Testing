using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Binarysearch
    {
        [Test]
        public void BinarysearchSimplePasses()
        {
            int[] nar = new int[] {4,5,6,7,8,9,10};
            var res = binarySearch(nar, 6, 0, 7);
            Assert.That(res,Is.EqualTo(2));
        }
        [Test]
        public void binarySearchReturnsLeastIndexIfTheItemIsLessThanLeastIndexElement()
        {
            int[] nar = new int[] { 4, 5, 6, 7, 8, 9, 10 };
            var res = binarySearch(nar, 2, 0, 7);
            Assert.That(res, Is.EqualTo(0));
        }
        [Test]
        public void bindarySearchReturnsMaximumIndexIfTheItemIsgreaterThanMaximumIndexElement()
        {
            int[] nar = new int[] { 4, 5, 6, 7, 8, 9, 10 };
            var res = binarySearch(nar, 12, 0, 6);
            Assert.That(res, Is.EqualTo(7));
        }
        [Test]
        public void returnIndexOfItemElementIfItemIsBetweenHighIndexAndLowIndex()
        {
            int[] nar = new int[] { 4, 5, 6, 7, 8, 9, 10 };
            var res = binarySearch(nar, 7, 0, 6);
            Assert.That(res, Is.EqualTo(4));
        }
        [Test]
        public void returnIndexOfItemElementIfItemIsLargerThanMidIndexElement()
        {
            int[] nar = new int[] { 4, 5, 6, 7, 8, 9, 10 };
            var res = binarySearch(nar, 9, 0, 6);
            Assert.That(res, Is.EqualTo(6));
        }
        [Test]
        public void returnIndexOfItemElementIfItemIsSmallerThanMidIndexElement()
        {
            int[] nar = new int[] { 4, 5, 6, 7, 8, 9, 10 };
            var res = binarySearch(nar, 5, 0, 6);
            Assert.That(res, Is.EqualTo(2));
        }
        [UnityTest]
        public IEnumerator BinarysearchWithEnumeratorPasses()
        {
            yield return null;
        }
        public int binarySearch(int[] a, int item, int low, int high)
        {
            if (high <= low)
                return (item > a[low]) ? (low + 1) : low;

            int mid = (low + high) / 2;

            if (item == a[mid])
                return mid + 1;

            if (item > a[mid])
                return binarySearch(a, item, mid + 1, high);



            return binarySearch(a, item, low, mid - 1);
        }
    }
}
