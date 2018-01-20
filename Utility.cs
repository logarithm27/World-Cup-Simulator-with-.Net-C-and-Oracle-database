/* Maftoul Omar December 2017 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace worldCupTest2
{
    public static class Utility
    {
        public static List<int> randomScores;
        public static string GetDescriptionFromEnumValue(Enum value)
        {
            DescriptionAttribute attribute = value.GetType()
                .GetField(value.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false)
                .SingleOrDefault() as DescriptionAttribute;
            return attribute == null ? value.ToString() : attribute.Description;
        }

        public static T GetEnumValueFromDescription<T>(string description)
        {
            var type = typeof(T);
            if (!type.IsEnum)
                throw new ArgumentException();
            FieldInfo[] fields = type.GetFields();
            var field = fields
                .SelectMany(f => f.GetCustomAttributes(
                    typeof(DescriptionAttribute), false), (
                    f, a) => new { Field = f, Att = a })
                .Where(a => ((DescriptionAttribute)a.Att)
                            .Description == description).SingleOrDefault();
            return field == null ? default(T) : (T)field.Field.GetRawConstantValue();
        }

        public static void generateRandomScore()
        {
            List<int> available = new List<int>(7);
            for (int i = 0; i < 7; i++)
                available.Add(i);
            randomScores = new List<int>(7);
            randomScores = shuffleScores(available);
        }
        private static  List<int> shuffleScores(List<int> available)
        {
            Random random = new Random();
            List<int> result = new List<int>(7);
            while (available.Count > 0)
            {
                //Assign to Index a random value between 0 and the max size of List (here is 8)
                int index = random.Next(0, available.Count);
                //Such indexes will be used to get the value from the available list,
                //Add it in the result 
                result.Add(available[index]);
                //remove it from the available list to avoid repetition 
                available.RemoveAt(index);
            }
            return result;
        }
        public static List<int> SwapTeams(List<int> list, int indexA, int indexB)
        {
            var tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
            return list;
        }
     
    }
}