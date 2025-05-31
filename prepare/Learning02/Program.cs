using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Liberty";
        job1._jobTitle = "Janitor";
        job1._startYear = 2022;
        job1._endYear = 2034;

        Job job2 = new Job();
        job2._company = "Liberty";
        job2._jobTitle = "Technician";
        job2._startYear = 2022;
        job2._endYear = 2034;

        Resume resume1 = new Resume();
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1._name = "Samuel";

        resume1.Display();


    }
}