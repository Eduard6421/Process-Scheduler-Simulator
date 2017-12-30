#ifndef SCHEDULER_H
#define SCHEDULER_H
#include "process.h"
#include<vector>
class Scheduler
{
public:
    virtual ~Scheduler();
    static Scheduler* getInstance();       // cu getInstance() luati instanta Scheduler ! E pointer!
    void setSchedulerType(int scht);       // setam scheduler type  1 = FCFS 2 = SJF 3 = RR
    void addProcess(Process tmp);          // adaugam procesul in vectorul de prokese
    void schedule();
    void calculateAverages();
    void advanceTime();

protected:

private:

    Scheduler();
    static bool initialised;
    static Scheduler* sched_instance;

    int current_active_processes;     // numarul de procese active la momentul prezent
    int current_time = 0;             // cat timp a trecut de cand am inceput procese
    int scheduler_type;               // am scris in main care ce si cum :)
    int cpu_utilisation;              // cat % din CPU e utilizat / cam o sa fie 0 sau 100%
    int thoroughput;                  // numarul de procese terminate in unitatea de timp
    int turnaround_time_average;      // cat timp mi a luat sa termin fiecare proces in medie
    int waiting_time_average;         // cat timp au asteptat procesele in medie
    int response_time_average;        // cat timp a durat ca procesul sa fie bagat in seama in medie

    void FCFS();

    vector<Process> v;

    Process current_process;

};



#endif // SCHEDULER_H
