interface IFile
{
    void ReadFile();
    void WriteFile(string text);
}
interface IFile
{
    protected void ReadFile(); //compile-time error
    private void WriteFile(string text); //compile-time error
}
interface IFile
{
    void ReadFile();
    void WriteFile(string text){
        Console.Write(text); //error: cannot implement method
    }
}
interface IFile
{
    void ReadFile();
    void WriteFile(string text);
}
class FileInfo : IFile
{
    public void ReadFile()
    {
        Console.WriteLine("Reading File");
    }
    public void WriteFile(string text)
    {
        Console.WriteLine("Writing to file");
    }
}
public class Program
{
    public static void Main()
    {
        IFile file1 = new FileInfo();
        FileInfo file2 = new FileInfo();
        file1.ReadFile();
        file1.WriteFile("content");
        file2.ReadFile();
        file2.WriteFile("content");
    }
}
interface IFile
{
    void ReadFile();
    void WriteFile(string text);
}
class FileInfo : File
{
    void IFile.ReadFile()
    {
        Console.WriteLine("Reading File");
    }
    void IFile.WriteFile(string text)
    {
        Console.WriteLine("Writing to file");
    }
}
interface IFile
{
    void ReadFile();
    void WriteFile(string text);
}
class FileInfo : IFile
{
    void IFile.ReadFile()
    {
        Console.WriteLine("Reading File");
    }
    void IFile.WriteFile(string text)
    {
        Console.WriteLine("Writing to file");
    }
    public void Search(string text)
    {
        Console.WriteLine("Searching in file");
    }
}
public class Program
{
    public static void Main()
    {
        IFile file1 = new FileInfo();
        FileInfo file2 = new FileInfo();
        file1.ReadFile();
        file1.WriteFile("content");
        //file1.Search("text to be searched")//compile-time error
        file2.Search("text to be searched");
        //file2.ReadFile(); //compile-time error
        //file2.WriteFile("content"); //compile-time error
    }
}
interface IFile
{
    void ReadFile();
}
interface IBinaryFile
{
    void OpenBinaryFile();
    void ReadFile();
}
class FileInfo : IFile, IBinaryFile
{
    void IFile.ReadFile()
    {
        Console.WriteLine("Reading Text File");
    }
    void IBinaryFile.OpenBinaryFile()
    {
        Console.WriteLine("Opening Binary File");
    }
    void IBinaryFile.ReadFile()
    {
        Console.WriteLine("Reading Binary File");
    }
    public void Search(string text)
    {
        Console.WriteLine("Searching in File");
    }
}
public class Program
{
    public static void Main()
    {
        IFile file1 = new FileInfo();
        IBinaryFile file2 = new FileInfo();
        FileInfo file3 = new FileInfo();
        file1.ReadFile();
        //file1.OpenBinaryFile(); //compile-time error
        //file1.SearchFile("text to be searched"); //compile-time error
        file2.OpenBinaryFile();
        file2.ReadFile();
        //file2.SearchFile("text to be searched"); //compile-time error
        file3.Search("text to be searched");
        //file3.ReadFile(); //compile-time error
        //file3.OpenBinaryFile(); //compile-time error
    }
}
int x = 5 + 5;
int y = 10 + x;
int z = x + y;
string greet1 = "Hello " + "World!";
string greet2 = greeting + name;
public class Program
{
    public static void Main()
    {
        int x = 5 + 5;
        int y = x + 5;
        int z = x + y;
        float z = x + y;
        float f = 3.5f + 5.25f;
        string greet = "Hello" + " World";
        Console.WriteLine("x = 5 + 5 = {0}",x);
        Console.WriteLine("y = x + 5 = {0}",y);
        Console.WriteLine("z = x + y = {0}",z);
        Console.WriteLine("f = {0}", f);
    }
    public static void Main()
    {
        int x = 5 - 1;
        int y = x - 2;
        int z = x - y;
        float f1 = 6.5f - 5.25f;
        float f2 = 4.5f - 5-25f;
        Console.WriteLine("x = 5 - 1 = {0}", x);
        Console.WriteLine("y = x - 2 = {0}", y);
        Console.WriteLine("z = x - y = {0}", z);
        Console.WriteLine("f = 6.5 - 5.25 = {0}", f1);
        Console.WriteLine("f = 4.5 - 5.25 = {0}", f2);
    }
    public static void Main()
    {
        int x = 5 * 1;
        int y = x * 2;
        int z = x * y;
        float f = 6.5f * 5.25f;
        Console.WriteLine("x = 5 * 1 = {0}", x);
        Console.WriteLine("y = x * 2 = {0}", y);
        Console.WriteLine("z = x * y = {0}", z);
        Console.WriteLine("f = 6.5 * 5.25 = {0}", f);
    }
    public static void Main()
    {
        int x = 10 / 2;
        int y = x / 5;
        int z = x * y;
        float f = 6.5f / 5.25f;
        Console.WriteLine("x = 10/2 = {0}", x);
        Console.WriteLine("y = x/5 = {0}", y);
        Console.WriteLine("z = x/y = {0}", z);
        Console.WriteLine("f = 6.5 / 5.25 = {0}", f);
    }
    public static void Main()
    {
        int x = 5 % 2;
        int y = x % 2;
        int z = x % y;
        float f = 6.5f % 5.25f;
        Console.WriteLine("x = 5 % 2 = {0}", x);
        Console.WriteLine("y = x/% 25 = {0}", y);
        Console.WriteLine("z = x % y = {0}", z);
        Console.WriteLine("f = 6.5 % 5.25 = {0}", f);
    }
    public static void Main()
    {
        int x = 5;
        int y = 6;
        float f = 6.5f;
        Console.WriteLine("x++ = {0}", x++);
        Console.WriteLine("x = {0} after x++", x);
        Console.WriteLine("++y = {0}", ++y);
        Console.WriteLine("f++ = {0}", f++);
        Console.WriteLine("f = {0} after f++", f);
    }
    public static void Main()
    {
        int x = 5;
        float f = 6.5f;
        Console.WriteLine("+x = {0}", +x);
        Console.WriteLine("+f = {0}", +f);
        Console.WriteLine("-x = {0}", -x);
        Comsole.WriteLine("-x + 3 = {0}", -x + 3);
        Console.WriteLine("-f = {0}", -f);
    }
    public static void Main()
    {
        int x,y;
        Console.WriteLine("x = 5 = {0}", x = 5);
        Console.WriteLine("y = (x = 5) = {0}", y = (x = 5));
    }
    public static void Main()
    {
        int x = 5;
        Console.WriteLine("x += 5 = {0}", x += 5);
        Console.WriteLine("x -= 5 = {0}", x -= 5);
        Console.WriteLine("x *= 5 = {0}", x *= 5);
        Console.WriteLine("x /= 5 = {0}", x /= 5);
    }
    public static void Main()
    {
        string str = null;
        str ??= "Hello World";
        Console.WriteLine("str ??= {0}", str ??= "Hello World");
        IList<string> list = null;
        (list ??= new List<string>()).Add("test");
        Console.WriteLine("list ??= {0}", list[0]);
        int? x = null,y=null,z=null;
        x ??= y ??= z ??= 5;
        Console.WriteLine("x??={0}",x);
    }
    public static void Main()
    {
        int x = 5, y = 10;
        float f = 5.3f;
        Console.WriteLine(3 < 2);
        Console.WriteLine(x < y);
        Console.WriteLine(x < f);
    }
    int i = 10, j = 20;
    if (i < j)
    {
        Console.WriteLine("i is less than j");
    }
    if (i > j)
    {
        Console.WriteLine("i is greater than j");
    }
    /*
    int i = 10, j = 20;
    if (i + 1)
    {
        Console.WriteLine("i is less than j");
    }
    if (i + j)
    {
        Console.WriteLine("i is greater than j");
    }
    */
// condition ? statement 1 : statement 2
int x = 20, y = 10;
var result = x > y ? "x is greater than y" : "x is less than y";
Console.WriteLine(result);
int y = 10, y = 100;