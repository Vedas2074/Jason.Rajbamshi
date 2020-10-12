using System.Collections.Generic;
public class Collections
{
    public void LearnAboutList()
    {
        List<string> names = new List<string> { "Ram", "James" };
        
        names.Add("Jason");
        names.Add("AJason");
        names.Add("DJason");
        names.Add("CJason");
        
        names.Sort();
    }

    public void LearnAboutDictionary()
    {
        // Holds key-value pairs
        Dictionary<string, string> countryCapitals = new Dictionary<string, string>
        {
            ["Bhutan"] = "Thimpu",
            ["China"] = "Beijing"
        };
        
        countryCapitals.Add("Nepal", "Kathmandu");
        countryCapitals.Add("India", "Delhi");
        countryCapitals.Add("USA", "WDC");
        countryCapitals.Add("Russia", "Mosco");
    }
}