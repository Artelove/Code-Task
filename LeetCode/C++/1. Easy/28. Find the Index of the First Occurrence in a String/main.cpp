#include <iostream>

using namespace std;
int strStr(string haystack, string needle) {
    int acceptCharsCounter = 0;
    int index = -1;
    if(needle.size()>haystack.size())
        return -1;
    for (int i = 0; i < haystack.size(); ++i) {
        if(needle[acceptCharsCounter]==haystack[i]) {
            if (acceptCharsCounter == 0) {
                index = i;
            }
            acceptCharsCounter++;
        } else{
            i-=acceptCharsCounter;
            index = -1;
            acceptCharsCounter=0;
        }
        if(acceptCharsCounter==needle.size())
            return index;
    }
    return -1;
}
int main() {
    std::cout << strStr("mississippi", "issipi") << std::endl;
    return 0;
}
