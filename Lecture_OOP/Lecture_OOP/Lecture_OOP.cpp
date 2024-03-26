#include <iostream>
#include <vector>

using namespace std;

class IObserver
{
public:
	virtual void Notify() = 0;
};

class StatusObserver : public IObserver
{
public:
	virtual void Notify() override
	{
		cout << "status Noti" << endl;
	};
};

class DistanceObserver : public IObserver
{
public:
	virtual void Notify() override
	{
		cout << "distance Noti" << endl;
	};
};

class Subject
{
public:
	void RegistObserver(IObserver * observer)
	{
		m_observers.push_back(observer);
	}

	void NotifyAll()
	{
		for (const auto& ob : m_observers)
			ob->Notify();
	}

private:
	vector<IObserver*> m_observers;
};



int main()
{
	Subject* sub = new Subject();
	sub->RegistObserver(new StatusObserver());
	sub->RegistObserver(new DistanceObserver());

	sub->NotifyAll();
}
