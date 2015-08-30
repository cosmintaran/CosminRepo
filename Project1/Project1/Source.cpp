#define _CRT_SECURE_NO_DEPRECATE
#include<iostream>
using namespace std;

static class Student
{
public:
	char* nume;
protected:
	int matricol;
private:
	float medie;
public:

	Student()
	{
		this->nume = new char[7];
		strcpy(this->nume, "Anonim");
		this->matricol = 0;
		this->medie = 0.0;
	}
	Student (char* nume,int matricol, float medie)
	{
		this->nume = new char[strlen(nume)+1];
		strcpy(this->nume, nume);
		this->matricol = matricol;
		this->medie = medie;
	}

	Student(const Student& obj)
	{
		this->nume = new char[strlen(obj.nume) + 1];
		strcpy(this->nume, obj.nume);
		this->matricol = obj.matricol;
		this->medie = obj.medie;
	}
	~Student()
	{
		delete[] this->nume;
	}

	char* GetNume();
	float GetMedie();
	double operator+ (Student& s)
	{

	}
	Student& operator=(const Student& obj)
	{
		if (this->nume != NULL)
		{
			delete[] nume;
		}

		this->nume = new char[strlen(obj.nume) + 1];
		strcpy(this->nume, obj.nume);
		this->matricol = obj.matricol;
		this->medie = obj.medie;
		return *this;
	}
};

char* Student::GetNume()
{
	return nume;
}

float Student::GetMedie()
{
	return medie;
}

//Student Student::operator+(Student& a,Student& b)
//{
//	Student c;
//	//c.matricol
//}


void main(void)
{	
	Student *s = new Student("Taran Constantin", 123, 10.0);
	cout<<s->GetMedie()<<"\n";
	Student s1;
	s1 = *s;
	cout<<s1.GetNume()<<endl;
	delete s;
	cin.get();
}