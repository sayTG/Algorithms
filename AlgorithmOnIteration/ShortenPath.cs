using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmOnIteration
{
    class ShortenPath
    {
        public static string ShortenInputPath(string path)
        {
            var splittedPath = path.Split('/').ToList();
            splittedPath.RemoveAt(0);
            if (!path.StartsWith("/"))
                return path;
            else
            {
                for(int i = 0; i < splittedPath.Count; i++)
                {
                    while(splittedPath[0] == "..")
                    {
                        splittedPath.RemoveAt(0);
                        i = 0;
                    }
                    if (splittedPath[i] == "..")
                    {
                        splittedPath.RemoveAt(i);
                        splittedPath.RemoveAt(i-1);
                        i = 0;
                    }
                    if(string.IsNullOrEmpty(splittedPath[i]) || splittedPath[i] == ".")
                        splittedPath.RemoveAt(i);
                }
            }
            return "/" + String.Join("/", splittedPath);
        }
        //another logic is to
        //using foreach
        //check the conditions use try catch when popping the element;
    }
}
