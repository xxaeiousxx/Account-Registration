using System;


public delegate long DelegateNumber(long number);
public delegate string DelegateText(string text);

public class StudentInfoClass
{
    public static string FirstName = " ";
    public static string LastName = " ";
    public static string MiddleName = " ";
    public static string address = " ";
    public static string Program = " ";

    public static long Age = 0;
    public static long ContactNo = 0;
    public static long StudentNo = 0;

    public StudentInfoClass()
    {
    }

    public static string GetFirstName(string Fi)
    {
        return FirstName;
    }
    public static string GetLastName(string LastName)
    {
        return LastName;
    }
    public static string GetMiddleName(string MiddleName)
    {
        return MiddleName;
    }
    public static string GetAddress(string address)
    {
        return address;
    }
    public static string GetProgram(string Program)
    {
        return Program;
    }
    public static long GetAge(long Age)
    {
        return Age;
    }
    public static long GetContactNo(long ContactNo)
    {
        return ContactNo;
    }
    public static long GetStudentNo(long StudentNo)
    {
        return StudentNo;
    }
}
