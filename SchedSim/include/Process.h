#ifndef PROCESS_H
#define PROCESS_H
#include<fstream>
#include<string>

using namespace std;

class Process
{
public:
    Process();
    Process(string s,int burst,int exec,int start);
    bool operator == (const Process &t);


    virtual ~Process();

    string process_name;

    bool finished;
    int burst_time;         //  cat timp dureaza procesul efectiv;
    int start_time;         //  cand ar trebui sa intre procesul in functiune
    int remaining_time;     //  cat timp a mai ramas din timpul total - putem sterge asta daca vrem neaparat si sa folosim doar burst
    int finish_time;        //  timpul cand s-a terminat procesul
    int waiting_time = 0;   //  cat timp a asteptat procesul sa ii vina randul
    int response_time = 0;

    int priority;           //  prioritatea proceselor
    int percent_completed;  //  cat % din proces este complet



    friend istream& operator >>(istream &in,Process &p);
    friend ostream& operator <<(ostream &out,const Process p);      // name / burst time / start time / priority

};







#endif // PROCESS_H
