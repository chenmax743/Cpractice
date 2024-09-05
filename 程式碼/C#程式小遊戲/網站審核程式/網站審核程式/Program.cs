class Person
{
    public string name;
    public int age;
    public void SayHi()
    {
        Console.WriteLine("Hi" +  name  + "My name is Rem");
        Console.WriteLine("How can I help");
        
    }
    public bool isAdult()
    {
        
       if(age>=18)
        {
            return true;
        }
       else
        {
            return false;
        }
    }
    
}
