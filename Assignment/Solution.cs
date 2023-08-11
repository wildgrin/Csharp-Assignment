using Newtonsoft.Json;

namespace Assignment
{
    public class Solution
    {
        public IList<int> MaxFrequency(int[] numsArr, int k)
        {
            // Array Initialization
            List<int>[] finalList = new List<int>[numsArr.Length + 1];

            // Dictionary Initialization
            Dictionary<int, int> countMap = new();

            // Filling the dictionary with unique keys and values
            foreach (int n in numsArr)
            {

                if (countMap.ContainsKey(n))
                {
                    countMap[n]++;
                }
                else
                {
                    countMap[n] = 1;
                }

                Console.WriteLine(JsonConvert.SerializeObject(numsArr));
            }

            // Passing the dictionary in final list
            foreach (int key in countMap.Keys)
            {
                int frequency = countMap[key];
                if (finalList[frequency] == null)
                {
                    finalList[frequency] = new List<int>();
                }
                finalList[frequency].Add(key);
                Console.WriteLine(JsonConvert.SerializeObject(finalList));

            }

            List<int> result = new();

            // Variable initialization to keep track of the number of elements added to final list array
            for (int index = finalList.Length - 1; index >= 0 && result.Count < k; index--)
            {
                if (finalList[index] != null)
                {
                    result.AddRange(finalList[index]);
                }
            }
            return result;
        }
    }
}