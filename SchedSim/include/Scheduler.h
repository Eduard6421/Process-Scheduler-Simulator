#ifndef SCHEDULER_H
#define SCHEDULER_H


class Scheduler
{
public:

    Scheduler* getInstance();

    virtual ~Scheduler();

protected:

private:
    bool initialised = false;
    Scheduler();

};

#endif // SCHEDULER_H
