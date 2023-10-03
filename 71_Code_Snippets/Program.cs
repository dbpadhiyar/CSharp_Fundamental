/*
 * Snippets are one type of shortcut to improve you productivity and get boiler plate syntax
 * snippets like Insert snippets (Ctrl+K,X)
 * snippets like Surround with (Ctrl+K,S) are useful to speed up our productivity
 * we can add snippets using code snippets manager
 */ 
class Program
{
    public static void Main()
    {
        List<int> list = new List<int>() { 10,20,30,44,55,66,77,88,99,100};
        for (int i = 0; i < 5; i++)
        {
            for (int l = 0; l < list.Count; l++)
            {
                Console.WriteLine(list[l]);

            } 
        }

    }
}