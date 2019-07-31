using System;
using System.Collections;
using System.Collections.Generic;

namespace HomeWork2
{
    class ElementList : IEnumerable
    {
        private IList<int> _initArray;
        private IList<int> _resultArray;

        public ElementList(IList<int> array)
        {
            _initArray = new List<int>();
            _resultArray = new List<int>();

            foreach (int element in array)
            {
                _initArray.Add(element);
            }
        }

        public void AddIndexRange(int firstIndex, int lastIndex)
        {
            if ((firstIndex * lastIndex <= 0) || Math.Abs(firstIndex) > _initArray.Count || Math.Abs(lastIndex) > _initArray.Count)
                return;

            if (firstIndex < 0)
            {
                firstIndex = _initArray.Count + firstIndex;
                lastIndex = _initArray.Count + lastIndex;
            }
            else
            {
                firstIndex--;
                lastIndex--;
            }

            if (firstIndex <= lastIndex)
            {
                for (int i = firstIndex; i <= lastIndex; i++)
                    _resultArray.Add(_initArray[i]);
            }
            else
            {
                for (int i = firstIndex; i >= lastIndex; i--)
                    _resultArray.Add(_initArray[i]);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _resultArray.GetEnumerator();
        }
    }
}
