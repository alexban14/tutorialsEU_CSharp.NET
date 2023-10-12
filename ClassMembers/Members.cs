using System;

public class Members
{
    // member constructor
    public Members()
    {
        this.age = 30;
        this.salary = 6000;
        this.jobTitle = "Developer";
        Console.WriteLine("Objec Created");
    }
    // member private field (lowercase first letter)
    private string memberName;
    private string jobTitle;
    private int salary;

    // member public filed
    public int age;

    // member property (captialcase) => exposes the the jobTitle field safely 
    public string JobTitle
    {
        get
        {
            return jobTitle;
        }

        set
        {
            jobTitle = value;
        }
    }

    // public member method
    public void Introducing(bool isFriend)
    {
        if (isFriend)
        {
            SharePrivateInfo();
        } 
        else
        {
            Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2} years old.", this.memberName, this.jobTitle, this.age);
        }
    }

    // private member method
    private void SharePrivateInfo()
    {
        Console.WriteLine("My salary is {0}", this.salary);
    }

    // member finalizer - destructor
    ~Members()
    {
        // cleanup statements...

        Console.WriteLine("Destruction of Members object");

    }
}
