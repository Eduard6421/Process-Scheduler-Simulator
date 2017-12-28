#include "Scheduler.h"

Scheduler* Scheduler::sched_instance = nullptr;

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
	if (!initialised)
	{
		Scheduler::sched_instance = new Scheduler();
		initialised = true;
	}
	return Scheduler::sched_instance;
}
