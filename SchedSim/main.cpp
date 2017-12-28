#include "process.h"
#include "scheduler.h"
#include<iostream>
using namespace std;

ifstream in("data.in");
ofstream out("data.out");

Scheduler* main_controller = nullptr;

void set_scheduler(int scheduler_type)          // 1 = FCFS 2 = SJF 3 = RR
{
    main_controller = Scheduler::getInstance();
    main_controller.setSchedulerType(scheduler_type);
}


int main()
{
    set_scheduler();

    return 0;

}
