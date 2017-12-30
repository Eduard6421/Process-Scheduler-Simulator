#include "Scheduler.h"
#include<iostream>
Scheduler* Scheduler :: sched_instance = nullptr;
bool Scheduler :: initialised = false;

Scheduler::Scheduler()     //ctor
{

    current_active_processes = 0;
    current_time = 0;
    cpu_utilisation = 0;
    thoroughput = 0;
    turnaround_time_average = 0;
    waiting_time_average = 0;
    response_time_average = 0;

}

Scheduler::~Scheduler()
{
    //dtor
}

Scheduler* Scheduler::getInstance()
{
    if(!initialised)
    {
        Scheduler::sched_instance = new Scheduler();
        initialised = true;
    }
    return Scheduler::sched_instance;
}

void Scheduler :: setSchedulerType(int scht)
{
    scheduler_type = scht;
}

void Scheduler :: addProcess(Process tmp)
{
    v.push_back(tmp);
}

void Scheduler :: FCFS()
{

    int i  = 0 ;
    int n  = v.size() ;
    bool finished;

    while( i < n )
    {
        current_process = v[i];
        advanceTime();
        if(v[i].finish_time !=0)
            ++i;
    }


}

void Scheduler :: calculateAverages()
{
    int i ;
    int n ;

    n = v.size();

    for(i = 0 ; i < n  ; ++i)
    {
        turnaround_time_average +=v[i].finish_time;
        response_time_average   += v[i].response_time;
        waiting_time_average    += v[i].waiting_time;
    }

    turnaround_time_average /= n;
    response_time_average   /= n;
    waiting_time_average    /= n;

}




void Scheduler ::advanceTime()
{

    int i;

    ++current_time;


    for(i = 0 ; i < v.size(); ++i)
    {   Process tmp = v[1];
        if(current_time >= v[i].start_time)
        {
            if(v[i]==current_process)
            {
                v[i].remaining_time -=1;
                if(v[i].remaining_time == 0)
                {
                    v[i].finish_time = current_time - v[i].start_time + 1;
                    v[i].finished = true;

                }
            }

            else if(v[i].start_time <= current_time && !v[i].finished)
            {
                ++v[i].waiting_time;
            }
        }
    }
}

void Scheduler :: schedule()
{
    cpu_utilisation = 100;
    switch (scheduler_type)
    {
    case 0 :
        FCFS();
        break;
    case 1 :

        break;
    case 2 :
        break;
    default :
        break;
    }

    calculateAverages();
}

