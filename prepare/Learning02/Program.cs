using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Chief Financial Officer";
        job1._company = "Fluor Idaho";
        job1._startYear = 2016;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Accounting Manager";
        job2._company = "Idaho Environmental Coalition";
        job2._startYear = 2021;
        job2._endYear = 2023;

        Resume jason = new Resume();
        jason._name = "Jason Killpack";

        jason.AddJob(job1);
        jason.AddJob(job2);

        jason.DisplayResume();
    }
}