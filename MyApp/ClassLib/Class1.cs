using System;

namespace ClassLib
{
    public class Student
    {
        int id;
        string GivenName;
        string Surname;
        readonly Status Status;
        DateTime StartDate;
        DateTime EndDate;
        DateTime GraduationDate;
    }

    public enum Status
    {
        New,
        Active,
        Dropout,
        Graduated
    }
}
