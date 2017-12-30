#include "Process.h"

Process::Process()
{
    //ctor
}

Process ::Process(string s,int burst,int start,int prior)
{

    process_name = s;
    burst_time = burst;
    start_time = start;
    priority = prior;
    response_time = burst;
    finish_time = 0;
    waiting_time = 0;
    remaining_time = 0;

}


Process::~Process()
{
    finish_time = 0;
    waiting_time = 0;
    remaining_time = 0;

    //dtor
}

bool Process :: operator ==(const Process &t)
{
    if(process_name !=t.process_name)
        return false;
    return true;
}




istream& operator >> ( istream &in,Process &p)
{
    in>>p.process_name>>p.burst_time>>p.start_time>>p.priority;
    p.remaining_time = p.burst_time;
    p.finish_time = 0;
    p.waiting_time = 0;
    p.finished = false;


    return in;
}

ostream& operator <<(ostream &out,const Process p)
{
    out<<p.process_name<<' '<<p.burst_time<<' '<<p.start_time<<' '<<p.priority<<'\n';
    return out;

}



