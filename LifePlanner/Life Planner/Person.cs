using System;
using System.Diagnostics;

public class Person
{
    // VARIABLES
    private bool gender;
    private float cups_drunk;
    private int work_time_msecs;
    private Stopwatch elapsed_time;

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

    public Person(bool inp_gender, int inp_work_time_mins)
    {
        Gender = inp_gender;
        Cups_drunk = 0;
        Work_time_msecs = inp_work_time_mins * 60 * 1000;
        elapsed_time = new Stopwatch();
    }


}
