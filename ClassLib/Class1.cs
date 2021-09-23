using System;
using System.Globalization;

namespace ClassLib
{
    public class Student
    {
        int id;
        string GivenName;
        string Surname;

        public Status Status{
            get {
                if(DateTime.Compare(StartDate, DateTime.Now) < 30){
                    return Status.New;
                }else if(EndDate < GraduationDate){
                    return Status.Dropout;
                }else if(EndDate.Equals(GraduationDate)){
                    return Status.Graduated;
                }else{
                    return Status.Active;
                }
            }

        }

        DateTime StartDate;
        DateTime EndDate;
        DateTime GraduationDate;

        public Student(int id, string GivenName, string Surname, DateTime StartDate, DateTime EndDate, DateTime GraduationDate){
            this.id = id;
            this.GivenName = GivenName;
            this.Surname = Surname;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.GraduationDate = GraduationDate;
        }

        public override string ToString(){
            return "Name: " + this.GivenName + " " + this.Surname + ". ID: " + this.id + ". StartDate: " + this.StartDate +". EndDate: " + this.EndDate + ". GraduationDate: " + this.GraduationDate + ". Status: " + this.Status; 
        }

    }

    public enum Status
    {
        New,
        Active,
        Dropout,
        Graduated
    }
}


// Active = between startdate and 3 months after  
// Active = between end/grad and start
// Dropout = Enddate before grad date
// Grad = Enddate = graduationdate 
