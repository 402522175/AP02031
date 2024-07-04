#include<math.h>
#include<iostream>
using namespace std;
class point
{
public:
    int m_x;
    int m_y;
    point(int x,int y)
    {
        m_x = x;
        m_y = y;
    }
    
    double fasele(const point &p)const
    {
    double xdiff = m_x - p.m_x;
    double ydiff = m_y - p.m_x;
    return sqrt(xdiff * xdiff + ydiff * ydiff);
}
};

class circle
{
    point m_center;
    double m_radius;
public:
    circle(const point &p,double r):
    m_center(p)
    ,m_radius(r)
    {}
    double masahat()
    {
        return m_radius*m_radius*M_PI;
    }
    double mohit()
    {
        return m_radius*2*M_PI;
    }
    double fasele(const point &p)const
    {
        return p.fasele(m_center);
    }
};

int main()
{
    point p(1,1);
    circle c(point(5,2),4);
    circle c2(point(1,2),3);
    cout<<c.fasele(p)<<endl;

    return 0;
}