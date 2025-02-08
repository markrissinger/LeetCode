using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._2349.DesignANumberContainerSystem
{
    public class NumberContainers
    {
        public NumberContainers()
        {
            _numberToIndices = new();
            _indexToNumbers = new();
        }

        Dictionary<int, List<int>> _numberToIndices;
        Dictionary<int, int> _indexToNumbers;

        public void Change(int index, int number)
        {
            if (_indexToNumbers.ContainsKey(index))
            {
                int oldNumber = _indexToNumbers[index];
                _numberToIndices[oldNumber].Remove(index);
                if (_numberToIndices[oldNumber].Count == 0)
                {
                    _numberToIndices.Remove(oldNumber);
                }
            }

            _indexToNumbers[index] = number;
            if (!_numberToIndices.ContainsKey(number))
            {
                _numberToIndices[number] = new();
            }
            _numberToIndices[number].Add(index);
        }

        public int Find(int number)
        {
            if (_numberToIndices.ContainsKey(number))
            {
                return _numberToIndices[number].Min();
            }
            return -1;
        }
    }
}
