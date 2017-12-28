#ifndef PROCESS_H
#define PROCESS_H
#include<string>

class Process
{
public:
    Process();
    Process(std::string s,int burst,int exec,int start);


    virtual ~Process();

protected:

private:

    std::string process_name;

    int burst_time;
    int execution_time;
    int start_time;

};

#endif // PROCESS_H
