#include "Process.h"

Process::Process()
{
	//ctor
}

Process::Process(std::string s, int burst, int start, int prior)
{

	process_name = s;
	burst_time = burst;
	start_time = start;
	priority = prior;

}


Process::~Process()
{
	//dtor
}


istream& operator >> (istream &in, Process &p)
{
	in >> p.burst_time >> p.start_time >> p.priority >> p.process_name;

	return in;
}

ostream& operator << (ostream &out, Process p)
{
	out << p.process_name<<' ' << p.finish_time<<' '<< p.start_time <<' '<< p.priority<<'\n';
	return out;
}

