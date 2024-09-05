namespace Animal
{
    namespace QQ
    {
        class Person
        {
            public double height;
            public int age;
            public string name;
            public void SayHi()
            {
                Console.WriteLine("Hi Max my name is "+name);
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
            public int Add(int num1, int num2,string qq)
            {
                return num1 + num2;
            }

        }

        

    }
    

}





