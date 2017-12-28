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


    virtual ~Process();

protected:

private:

    string process_name;

    int burst_time;         //  cat timp dureaza procesul efectiv;
    int start_time;         //  cand ar trebui sa intre procesul in functiune
    int remaining_time;     //  cat timp a mai ramas din timpul total - putem sterge asta daca vrem neaparat si sa folosim doar burst
    int finish_time;        //  timpul cand s-a terminat procesul
    int waiting_time;       //  cat timp a asteptat procesul sa ii vina randul

    int priority;           //  prioritatea proceselor
    int percent_completed;  //  cat % din proces este complet

    friend istream& operator >>(istream &in,Process &p);
    friend ostream& operator <<(ostream &out,const Process p);

};







#endif // PROCESS_H
