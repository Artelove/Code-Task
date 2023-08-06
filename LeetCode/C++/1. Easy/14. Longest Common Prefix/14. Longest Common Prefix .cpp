#include <iostream>
#include <vector>

using namespace std;
string longestCommonPrefix(vector<string>& strs) {
    string prefix = "";
    int minLength = 0;
    int minLengthStrIndex = 0;
    for (int i = 0; i < strs.size(); ++i) {
        if(strs[i].size()>minLength) {
            minLength = strs[i].size();
            minLengthStrIndex = i;
        }
    }
    for (int i = 0; i < strs[minLengthStrIndex].size(); ++i) {
        for (int j = 0; j < strs.size(); ++j) {
            if(strs[j][i] != strs[minLengthStrIndex][i]){
                return prefix;
            }
        }
        prefix+=strs[minLengthStrIndex][i];
    }
    return prefix;
}
int main() {
    vector<string> strs = {"qwe1r", "qwer1", "qw1er"};
    cout << longestCommonPrefix(strs) << endl;
    return 0;
}
