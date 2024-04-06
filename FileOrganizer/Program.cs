namespace FileOrganize;

class Program
{

    static void Main(String[] args)
    {
        Console.Clear();
        var f = new File(@"C:\Users\Marco\Desktop\projects.txt");
        Console.WriteLine(f.Name);
        Console.Write(f.Etype);
    }
}