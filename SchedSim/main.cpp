#include "process.h"
#include "scheduler.h"
#include<iostream>

using namespace std;

ifstream in("data.in");
ofstream out("data.out");

Scheduler* main_controller = nullptr;

void set_scheduler(int scheduler_type)
{
    main_controller = Scheduler::getInstance();
    main_controller->setSchedulerType(scheduler_type);
}

void insert_processes()
{
    int n;
    int i;

    Process tmp;

    in>>n;
    for(i = 0 ; i < n ; ++i)
    {
        in>>tmp;
        main_controller->addProcess(tmp);
    }


}


int main()
{
    set_scheduler(0);
    insert_processes();
    main_controller->schedule();

    return 0;

}
