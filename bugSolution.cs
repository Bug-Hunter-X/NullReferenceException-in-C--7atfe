public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Solution: Check for null before accessing the property
        if (MyProperty != null)
        {
            Console.WriteLine(MyProperty.ToString());
        }
        else
        {
            Console.WriteLine("MyProperty is null");
        }
    }
}