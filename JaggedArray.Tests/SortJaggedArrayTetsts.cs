using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Jagged_array;
namespace JaggedArray.Tests
{
    [TestFixture]
    public class SortJaggedArrayTetsts
    {
        [TestCaseSource("GetForSortArrayByDecreaseByMin")]
        public void SortArrayByDecreaseByMin(int[][] arr, int[][] arr2)
        {
            CompareByMinValue a = new CompareByMinValue();
            var del = new SortJaggedArray<int>.KindSortingDelegate(a.Compare);
            arr = SortJaggedArray<int>.SortArrayByDecrease(arr, del);
            CollectionAssert.AreEqual(arr, arr2);
        }

        [TestCaseSource("GetForSortArrayByIncreaseByMin")]
        public void SortArrayByIncreaseByMin(int[][] arr, int[][] arr2)
        {
            CompareByMinValue a = new CompareByMinValue();
            var del = new SortJaggedArray<int>.KindSortingDelegate(a.Compare);
            arr = SortJaggedArray<int>.SortArrayByIncrease(arr, del);
            CollectionAssert.AreEqual(arr, arr2);
        }

        [TestCaseSource("GetForSortArrayByDecreaseByMax")]
        public void SortArrayByDecreaseByMax(int[][] arr, int[][] arr2)
        {
            CompareByMaxValue a = new CompareByMaxValue();
            var del = new SortJaggedArray<int>.KindSortingDelegate(a.Compare);
            arr = SortJaggedArray<int>.SortArrayByDecrease(arr, del);
            CollectionAssert.AreEqual(arr, arr2);
        }

        [TestCaseSource("GetForSortArrayByIncreaseByMax")]
        public void SortArrayByIncreaseByMax(int[][] arr, int[][] arr2)
        {
            CompareByMaxValue a = new CompareByMaxValue();
            var del = new SortJaggedArray<int>.KindSortingDelegate(a.Compare);
            arr = SortJaggedArray<int>.SortArrayByIncrease(arr, del);
            CollectionAssert.AreEqual(arr, arr2);
        }

        [TestCaseSource("GetForSortArrayByDecreaseBySum")]
        public void SortArrayByDecreaseBySum(int[][] arr, int[][] arr2)
        {
            CompareBySum a = new CompareBySum();
            var del = new SortJaggedArray<int>.KindSortingDelegate(a.Compare);
            arr = SortJaggedArray<int>.SortArrayByDecrease(arr, del);
            CollectionAssert.AreEqual(arr, arr2);
        }

        [TestCaseSource("GetForSortArrayByIncreaseBySum")]
        public void SortArrayByIncreaseBySum(int[][] arr, int[][] arr2)
        {
            CompareBySum a = new CompareBySum();
            var del = new SortJaggedArray<int>.KindSortingDelegate(a.Compare);
            arr = SortJaggedArray<int>.SortArrayByIncrease(arr, del);
            CollectionAssert.AreEqual(arr, arr2);
        }
        public IEnumerable<TestCaseData> GetForSortArrayByDecreaseByMin()
        {
            yield return new TestCaseData(new int[][]
                     {
                        new int[] {-10,5,100}, new int[] {-400, 10000, 22, 11,5}, new int[] {2,1}
                     },
                     new int[][]
                     {
                         new int[] {2,1},new int[] {-10,5,100}, new int[] {-400, 10000, 22, 11,5}
                     });

            yield return new TestCaseData(new int[][]
                         {
                        new int[] {-10,-5,-100}, new int[] {-400, -10000, -22, -11,-5}, new int[] {-2,-1}
                         },
                         new int[][]
                         {
                       new int[] {-2,-1}, new int[] {-10,-5,-100}, new int[] {-400, -10000, -22, -11,-5}
                         });
            yield return new TestCaseData(new int[][]
                       {
                        new int[] {0,0,0}, new int[] {0}, new int[] {0}
                       },
                       new int[][] {
                           new int[] {0,0,0}, new int[] {0}, new int[] {0}
                       });
            yield return new TestCaseData(new int[][] { }, new int[][] { });

        }
        public IEnumerable<TestCaseData> GetForSortArrayByIncreaseByMin()
        {
            yield return new TestCaseData(new int[][]
                     {
                        new int[] {-10,5,100}, new int[] {-400, 10000, 22, 11,5}, new int[] {2,1}
                     },
                     new int[][]
                     {
                         new int[] {-400, 10000, 22, 11,5},new int[] {-10,5,100},new int[] {2,1}
                     });

            yield return new TestCaseData(new int[][]
                         {
                        new int[] {-10,-5,-100}, new int[] {-400, -10000, -22, -11,-5}, new int[] {-2,-1}
                         },
                         new int[][]
                         {
                      new int[] {-400, -10000, -22, -11,-5} , new int[] {-10,-5,-100},new int[] {-2,-1}
                         });
            yield return new TestCaseData(new int[][]
                       {
                        new int[] {0,0,0}, new int[] {0}, new int[] {0}
                       },
                       new int[][] {
                           new int[] {0,0,0}, new int[] {0}, new int[] {0}
                       });
            yield return new TestCaseData(new int[][] { }, new int[][] { });
        }

        public IEnumerable<TestCaseData> GetForSortArrayByDecreaseByMax()
        {
            yield return new TestCaseData(new int[][]
                     {
                        new int[] {-10,5,100}, new int[] {-400, 10000, 22, 11,5}, new int[] {2,1}
                     },
                     new int[][]
                     {
                         new int[] {-400, 10000, 22, 11,5},new int[] {-10,5,100},new int[] {2,1}

                     });

            yield return new TestCaseData(new int[][]
                         {

                             new int[] {-400, -10000, -22, -11,-5},
                             new int[] {-10,-5,-100},
                             new int[] {-2,-1}
                         },
                         new int[][]
                         {
                       new int[] {-2,-1}, new int[] {-10,-5,-100}, new int[] {-400, -10000, -22, -11,-5}
                         });
            yield return new TestCaseData(new int[][]
                       {
                        new int[] {0,0,0}, new int[] {0}, new int[] {0}
                       },
                       new int[][] {
                           new int[] {0,0,0}, new int[] {0}, new int[] {0}
                       });
            yield return new TestCaseData(new int[][] { }, new int[][] { });

        }

        public IEnumerable<TestCaseData> GetForSortArrayByIncreaseByMax()
        {
            yield return new TestCaseData(new int[][]
                     {
                        new int[] {-10,5,100}, new int[] {-400, 10000, 22, 11,5}, new int[] {2,1}
                     },
                     new int[][]
                     {
                          new int[] {2,1},new int[] {-10,5,100}, new int[] {-400, 10000, 22, 11,5}
                     });

            yield return new TestCaseData(new int[][]
                         {
                        new int[] {-10,-5,-100}, new int[] {-400, -10000, -22, -11,-5}, new int[] {-2,-1}
                         },
                         new int[][]
                         {
                             new int[] {-10,-5,-100}, new int[] {-400, -10000, -22, -11,-5} ,new int[] {-2,-1}
                         });
            yield return new TestCaseData(new int[][]
                       {
                        new int[] {0,0,0}, new int[] {0}, new int[] {0}
                       },
                       new int[][] {
                           new int[] {0,0,0}, new int[] {0}, new int[] {0}
                       });
            yield return new TestCaseData(new int[][] { }, new int[][] { });
        }

        public IEnumerable<TestCaseData> GetForSortArrayByDecreaseBySum()
        {
            yield return new TestCaseData(new int[][]
                     {
                        new int[] {-10,5,100},
                         new int[] {-400, 10000, 22, 11,5},
                         new int[] {2,1}
                     },
                     new int[][]
                     {
                         new int[] {-400, 10000, 22, 11,5},
                         new int[] {-10,5,100},
                         new int[] {2,1}

                     });

            yield return new TestCaseData(new int[][]
                         {

                             new int[] {-400, -10000, -22, -11,-5},
                             new int[] {-10,-5,-100},
                             new int[] {-2,-1}
                         },
                         new int[][]
                         {
                             new int[] {-2,-1},
                             new int[] {-10,-5,-100},
                             new int[] {-400, -10000, -22, -11,-5}
                         });
            yield return new TestCaseData(new int[][]
                       {
                        new int[] {0,0,0}, new int[] {0}, new int[] {0}
                       },
                       new int[][] {
                           new int[] {0,0,0}, new int[] {0}, new int[] {0}
                       });
            yield return new TestCaseData(new int[][] { }, new int[][] { });

        }

        public IEnumerable<TestCaseData> GetForSortArrayByIncreaseBySum()
        {
            yield return new TestCaseData(new int[][]
                     {
                        new int[] {-10,5,100},
                         new int[] {-400, 10000, 22, 11,5},
                         new int[] {2,1}
                     },
                     new int[][]
                     {
                         new int[] {2,1},
                         new int[] {-10,5,100},
                         new int[] {-400, 10000, 22, 11,5}
                     });

            yield return new TestCaseData(new int[][]
                         {
                             new int[] {-10,-5,-100},
                             new int[] {-400, -10000, -22, -11,-5},
                             new int[] {-2,-1}
                         },
                         new int[][]
                         {
                             new int[] {-400, -10000, -22, -11,-5},
                             new int[] {-10,-5,-100},
                             new int[] {-2,-1}
                         });
            yield return new TestCaseData(new int[][]
                       {
                        new int[] {0,0,0}, new int[] {0}, new int[] {0}
                       },
                       new int[][] {
                           new int[] {0,0,0}, new int[] {0}, new int[] {0}
                       });
            yield return new TestCaseData(new int[][] { }, new int[][] { });
        }
    }
}
