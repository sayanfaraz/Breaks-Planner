using System;
using System.Diagnostics;

public class Person
{
    // VARIABLES
    private bool gender; // stores gender of user (used to determine how many cups of water they need)
    private float cups_drunk; // stores number of cups drunk so far
    private int work_time_msecs; // how long they want to work before needing a break
    private Stopwatch elapsed_time; // Stopwatch measuring how long they have worked so far

    // GETTERS, SETTERS

    public bool Gender
    {
        get
        {
            return gender;
        }

        set
        {
            gender = value;
        }
    }

    public float Cups_drunk
    {
        get
        {
            return cups_drunk;
        }

        set
        {
            cups_drunk = value;
        }
    }

    public int Work_time_msecs
    {
        get
        {
            return work_time_msecs;
        }

        set
        {
            work_time_msecs = value;
        }
    }

    public Stopwatch Elapsed_time
    {
        get
        {
            return elapsed_time;
        }

        set
        {
            elapsed_time = value;
        }
    }

    // CONSTRUCTOR
    public Person(bool inp_gender, int inp_work_time_mins)
    {
        Gender = inp_gender;
        Cups_drunk = 0;
        Work_time_msecs = inp_work_time_mins * 60 * 1000;
        elapsed_time = new Stopwatch();
    }


}
