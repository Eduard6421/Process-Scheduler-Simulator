#include "Process.h"

Process::Process()
{
    //ctor
}

Process ::Process( std::string s,int burst,int exec,int start)
{
    process_name = s;
    burst_time = burst;
    execution_time = exec;
    start_time = start;

}


Process::~Process()
{
    //dtor
}
