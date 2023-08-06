#include <iostream>

using namespace std;

int romanToInt(string s) {
    int sum = 0;
    for (auto it = s.cbegin(); it != s.cend(); ++it) {
        if (*it == 'V')
        {
            sum+=5;
        }
        if (*it == 'L')
        {
            sum+=50;
        }
        if (*it == 'D')
        {
            sum+=500;
        }
        if (*it == 'M')
        {
            sum+=1000;
        }
        if (*it == 'C')
        {
            sum+=100;
            if(*(it+1) == 'D') {
                sum += 300;
                it++;
            }
            if(*(it+1) == 'M') {
                sum += 800;
                it++;
            }
        }
        if (*it == 'X')
        {
            sum+=10;
            if(*(it+1) == 'L') {
                sum += 30;
                it++;
            }
            if(*(it+1) == 'C') {
                sum += 80;
                it++;
            }
        }
        if (*it == 'I')
        {
            sum++;
            if(*(it+1) == 'V') {
                sum += 3;
                it++;
            }
            if(*(it+1) == 'X') {
                sum += 8;
                it++;
            }
        }



    }
    return sum;
}

int main() {
    std::cout <<  romanToInt("MCMXCIV") << std::endl;

    return 0;
}
