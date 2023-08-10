#include <iostream>

using namespace std;

int lengthOfLastWord(string s) {
    string word;
    bool readWord = false;
    for (int i = s.size(); i >= 0; --i) {
        if (s[i] != ' ' && s[i] != '\000') {
            readWord = true;
        } else if(readWord)
            return word.size();
        if(readWord){
            word+=s[i];
        }
    }
}

int main() {
    std::cout << lengthOfLastWord("   fly me   to   the moon  ") << std::endl;
    return 0;
}
