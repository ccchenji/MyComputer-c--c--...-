/*#include <iostream>
using namespace std;
typedef int elemtype;
typedef struct linknode//定义结点类型
{
	elemtype data;
	struct linknode*next;
}nodetype;
nodetype*createlink()
{//d为1，n为4
	int n, d;
	nodetype *h, *p, *s;
	s = new nodetype;
	s->next = NULL;
	h = s;
	cout << "输入元素的个数" << endl;
	cin >> n;
	cout << "输入每个元素:" << endl;
	for (int i = 1; i <= n; i++)
	{
		cout << "输入第" << i << "个元素";
		cin >> d;
		p = new nodetype;
		p->data = d; p->next = NULL;
		s->next = p; s = s->next;
	}
	return h;
}

void disp(nodetype *h)
{
	nodetype *p = h->next;
	cout << "输出一个单链表" << endl << "";
	if (p = NULL)cout << "空表";
	while (p != NULL)
	{
		cout << p->data << "";
		p = p->next;
	}
	cout << endl;
}
void main()
{
	disp(createlink());
}
少时诵诗书所所所所所所所所所所所所所所所所*/
#include <iostream>
using namespace std;
typedef int elemtype;
typedef struct linknode//定义结点类型
{
	elemtype data;
	struct linknode*next;
}nodetype;
nodetype*createlink()
{//d为1，n为4
	int n, d;
	nodetype *h, *p, *s;
	s = new nodetype;
	s->next = NULL;
	h = s;
	cout << "输入元素的个数" << endl;
	cin >> n;
	cout << "输入每个元素:" << endl;
	for (int i = 1; i <= n; i++)
	{
		cout << "输入第" << i << "个元素";
		cin >> d;
		p = new nodetype;
		p->data = d; p->next = NULL;
		s->next = p; s = s->next;
	}
	return h;
}

void disp(nodetype *h)
{
	nodetype *p = h->next;
	cout << "输出一个单链表" << endl << "";
	if (p = NULL)cout << "空表";
	while (p != NULL)
	{
		cout << p->data << "";
		p = p->next;
	}
	cout << endl;
}
nodetype*find(nodetype *h, int i)
{
	nodetype*p = h;
	int j = i;
	while (p != NULL&&j < i)
	{
		j++; p = p->next;
	}
	return p;
}
nodetype*ins(nodetype *h, int t, elemtype x)
{
	nodetype *p, *s;
	s->data = x;
	s = new nodetype;
	s->next = NULL;
	s->next = p->next;
	p->next = s;
	return s;
}
nodetype *delet(nodetype *h,int i)
{
	nodetype *p = h, *s;
	if (i == 1)
	{
		h = h->next;
		free(p);
	}
	else
	{
		p = find(h, i - 1);
		if (p != NULL&&p->next != NULL)
		{
			s = p->next;
			p->next = s->next;
			free(s);
		}
		else cout << "输入的i值不正确" << endl;
	}return h;
}
//线性链表的逆转
nodetype*invert(nodetype*h)
{
	nodetype*p, *q, *r;
	/*if (len(h) <= 1){
		cout << "逆置的单链表至少有2个结点" << endl;
		return NULL;
	}
	else{*/
		p = h; q = p->next;
		while(q != NULL)
		{
			r = q->next; q->next = p;
			p = q; q = r;
		}
		h->next = NULL;
		h = p;
		return h;
}
void main()
{
	nodetype *t,*p;
	t = createlink();
	disp(t);
	ins(t, 2, 3);
	disp(t);
	p = invert(t);
	disp(p);
}