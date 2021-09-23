using System;
using System.Globalization;

namespace ClassLib
{
    public record ImmutableStudent{

        public int id {get; init;}
        public string GivenName {get; init;}
        public string Surname {get; init;}

        public Status Status{
            get {
                if(DateTime.Compare(StartDate, DateTime.Now) > 30){
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

        public DateTime StartDate {get; init;}
        public DateTime EndDate {get; init;}
        public DateTime GraduationDate {get; init;}

        public ImmutableStudent(int id, string GivenName, string Surname, DateTime StartDate, DateTime EndDate, DateTime GraduationDate){
            this.id = id;
            this.GivenName = GivenName;
            this.Surname = Surname;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.GraduationDate = GraduationDate;
        }

        public override string ToString(){
            return "Name: " + this.GivenName + " " + this.Surname + ". ID: " + this.id + ". StartDate: " + this.StartDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture) +". EndDate: " + this.EndDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture) + ". GraduationDate: " + this.GraduationDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture) + ". Status: " + this.Status; 
        }
    }
}