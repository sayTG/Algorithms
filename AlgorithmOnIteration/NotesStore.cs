using System;
using System.Collections.Generic;

namespace AlgorithmOnIteration
{

    public class NotesStore
    {
        Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>();
        public NotesStore() { }
        public void AddNote(String state, String name)
        {

            if (string.IsNullOrEmpty(name))
                throw new Exception("Name cannot be empty");
            if (state == "completed")
            {
                if (!keyValuePairs.ContainsKey(state))
                    keyValuePairs[state] = new List<string> { name };
                else
                    keyValuePairs[state].Add(name);
            }
            else if (state == "active")
            {
                if (!keyValuePairs.ContainsKey(state))
                    keyValuePairs[state] = new List<string> { name };
                else
                    keyValuePairs[state].Add(name);
            }
            else if (state == "others")
            {
                if (!keyValuePairs.ContainsKey(state))
                    keyValuePairs[state] = new List<string> { name };
                else
                    keyValuePairs[state].Add(name);
            }
            else
                throw new Exception($"Invalid state {state}");
        }
        public List<String> GetNotes(String state)
        {
            if (state == "completed")
            {
                if (!keyValuePairs.ContainsKey(state))
                    return new List<string>();
                return keyValuePairs[state];
            }
            else if (state == "active")
            {
                if (!keyValuePairs.ContainsKey(state))
                    return new List<string>();
                return keyValuePairs[state];
            }
            else if (state == "others")
            {
                if (!keyValuePairs.ContainsKey(state))
                    return new List<string>();
                return keyValuePairs[state];
            }
            else
                throw new Exception($"Invalid state {state}");
        }
    }

    //public class Solution1
    //{
        //public static void Main()
        //{
        //    var notesStoreObj = new NotesStore();
        //    var n = int.Parse(Console.ReadLine());
        //    for (var i = 0; i < n; i++)
        //    {
        //        var operationInfo = Console.ReadLine().Split(' ');
        //        try
        //        {
        //            if (operationInfo[0] == "AddNote")
        //                notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
        //            else if (operationInfo[0] == "GetNotes")
        //            {
        //                var result = notesStoreObj.GetNotes(operationInfo[1]);
        //                if (result.Count == 0)
        //                    Console.WriteLine("No Notes");
        //                else
        //                    Console.WriteLine(string.Join(",", result));
        //            }
        //            else
        //            {
        //                Console.WriteLine("Invalid Parameter");
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("Error: " + e.Message);
        //        }
        //    }
        //}
    //}
}
