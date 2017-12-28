#include "Scheduler.h"

Scheduler* Scheduler :: sched_instance = nullptr;
bool Scheduler :: initialised = false;

Scheduler::Scheduler()
{
    //ctor
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


}

