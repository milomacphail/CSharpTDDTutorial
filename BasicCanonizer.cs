using System;
using System.Linq;

namespace CSharpTDDTutorial
{
    public class BasicCanonizer
    {
	    public static string getCanonicalSearch(string searchTerm)
	    {
            if (searchTerm == null)
            {
                throw new ArgumentNullException("searchTerm");
            }

            return searchTerm
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToUpper())
                .OrderBy(x => x)
                .Aggregate(" ", (x, y) => x + " " + y)
                .Trim();
	    }
    } 

}