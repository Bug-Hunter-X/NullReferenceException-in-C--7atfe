public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Accessing a null reference
        Console.WriteLine(MyProperty.ToString());
    }
}