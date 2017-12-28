#pragma once
#ifndef SCHEDULER_H
#define SCHEDULER_H
#include "Process.h"
#include <vector>
class Scheduler
{
public:

	Scheduler * getInstance();       // cu getInstance() luati instanta Scheduler ! E pointer!

	virtual ~Scheduler();

protected:

private:
	bool initialised = false;

	static Scheduler* sched_instance;

	int cpu_utilisation;         // cat % din CPU e utilizat / cam o sa fie 0 sau 100%
	int thoroughput;             // numarul de procese terminate in unitatea de timp
	int turnaround_time_average; // cat timp mi a luat sa termin fiecare proces in medie
	int waiting_time_average;    // cat timp au asteptat procesele in medie
	int response_time_average;   // cat timp a durat ca procesul sa fie bagat in seama in medie

	Scheduler();

};



#endif // SCHEDULER_H