#include <iostream>
#include <stdlib.h>

using namespace std;

int str_len(const char *s)
{
    int i = 0;
    while (s[i] != 0)
    {
        i++;
    }
    return i;
}

class str
{
    char *m_str;

public:
    str() : m_str(nullptr) {}

    str(const char *pch)
    {
        m_str = (char *)malloc((str_len(pch) + 1) * sizeof(char));
        for (int i = 0; i < str_len(pch); i++)
            m_str[i] = pch[i];
        m_str[str_len(pch)] = '\0';
    }

    str(const str &s)
    {
        m_str = (char *)malloc((s.len() + 1) * sizeof(char));
        for (int i = 0; i < s.len(); i++)
            m_str[i] = s.m_str[i];
        m_str[s.len()] = '\0';
    }

    ~str()
    {
        if (m_str != NULL)
            free(m_str);
    }

    int len() const
    {
        int i = 0;
        while (m_str[i] != 0)
        {
            i++;
        }
        return i;
    }

    void append(const char *pch)
    {
        int currentlen = len();
        int secondlen = str_len(pch);
        char *temp = (char *)malloc((currentlen + secondlen + 1) * sizeof(char));

        for (int i = 0; i < currentlen; i++)
        {
            temp[i] = m_str[i];
        }
        int j = 0;
        for (int i = currentlen; i < currentlen + secondlen + 1; i++)
        {
            temp[i] = pch[j];
            j++;
        }
        m_str = temp;
        free(temp);
        m_str[currentlen + secondlen + 1] = '\0';
    }

    void append(const str &s)
    {
        int currentLen = len();
        int secondLen = s.len();
        char *temp = (char *)malloc((currentLen + secondLen + 1) * sizeof(char));

        for (int i = 0; i < currentLen; i++)
        {
            temp[i] = m_str[i];
        }

        for (int i = currentLen, j = 0; i < currentLen + secondLen; i++, j++)
        {
            temp[i] = s.m_str[j];
        }

        temp[currentLen + secondLen] = '\0';
        free(m_str);
        m_str = temp;
    }

    void print() const
    {
        for (int i = 0; i < len(); i++)
            cout << m_str[i];
    }

    const char *chars() const
    {
        for (int i = 0; i < len(); i++)
            cout << m_str[i];
    }

    void replace(char c1, char c2)
    {
        for (int i = 0; i < len(); i++)
        {
            if (m_str[i] == c1)
                m_str[i] = c2;
        }
    }

    str substr(int start, int count) const
    {
        char *sub = (char *)malloc((count + 1) * sizeof(char));
        int j = 0;
        for (int i = start; i < start + count; i++)
        {
            sub[j] = m_str[i];
            j++;
        }
        sub[count] = '\0';
        return str(sub);
    }

void remove(int start, int count)
{
    int currentLen = len();
    char *temp = (char *)malloc((currentLen - count + 1) * sizeof(char));

    for (int i = 0 ; i < start; i++)
    {
        temp[i] = m_str[i];
    }

    for (int i = start + count; i < currentLen; i++)
    {
        temp[i - count] = m_str[i];
    }

    temp[currentLen - count] = '\0';
    m_str = temp; 
    }

    str reverse() const
    {
        int length = len();
        char *reversed = (char *)malloc((length + 1) * sizeof(char));
        for (int i = 0; i < length; ++i)
        {
            reversed[i] = m_str[length - 1 - i];
        }
        reversed[length] = '\0';
        return str(reversed);
    }

    char get_char(int loc) const
    {
        if (loc < len())
            return m_str[loc];
        return -1;
    }
};

int main()
{
    str s("Matin");
    cout << "s1: ";
    s.print();
    cout << endl;

    s.append("Nouri");
    s.print();
    cout << endl;

    str sub = s.substr(1, 3);
    sub.print();
    cout << endl;


    s.replace('a', 'n');
    s.print();
    cout << endl;

    s.remove(1, 3);
    cout << "String after removing: ";
    s.print(); 

    return 0;
}
