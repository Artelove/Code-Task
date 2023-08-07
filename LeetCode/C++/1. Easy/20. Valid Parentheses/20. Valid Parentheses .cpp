#include <iostream>
#include <map>
#include <list>

using namespace std;

bool isValid(string s) {
    list<char> leftParenthesesOrder;
    map<char,char> pairs = {{'(',')'}, {'{','}'}, {'[',']'}};

    for (char i:s) {
        if(pairs.find(i)->first == i)
            leftParenthesesOrder.push_back(i);
        else if(i == pairs.find(leftParenthesesOrder.back())->second){
            leftParenthesesOrder.pop_back();
        } else
            return false;
    }
    if(!leftParenthesesOrder.empty())
        return false;
    return true;
}
int main() {
    std::cout << isValid("[") << std::endl;
    return 0;
}
