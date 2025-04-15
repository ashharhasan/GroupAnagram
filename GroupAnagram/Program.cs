// See https://aka.ms/new-console-template for more information
using System.Text;

string[] input = { "act", "pots", "tops", "cat", "stop", "hat" };
        var grouped = GroupAnagrams(input);

        foreach (var group in grouped)
        {
            Console.WriteLine($"[{string.Join(", ", group)}]");
        }

List<List<string>> GroupAnagrams(string[] strs) {
    //Dictionary<string,int> d1= new  Dictionary<string, int>();
    List<List<string>> output = new List<List<string>>();

foreach (var str in strs)
{
    if(output.Count == 0)
    {
        output.Add(new List<string>{str});
        continue;
    }
    bool found=false;
    for(int i=0;i<output.Count;i++)
    {
        if(isAnagram(output[i][0], str))
        {
            output[i].Add(str);
            found = true;
            break;
        }
    }
    if (!found)
    {
        output.Add(new List<string>{str});
    }
}
return output;
}


     bool isAnagram (string s1,string s2)
    {
        Dictionary<char,int> d1 = new Dictionary <char, int>();
        if(s1.Length!=s2.Length)
            return false;

        for (int i=0; i<s1.Length;i++)
        {
            d1[s1[i]]= d1.GetValueOrDefault(s1[i]) +1;
        }
        for(int i=0;i<s1.Length; i++)
        {
            if(!d1.ContainsKey(s2[i]))
                return false;
            d1[s2[i]]--;
            if(d1[s2[i]] <0)
            {
                return false;
            }
        }
        return true;
    }