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
