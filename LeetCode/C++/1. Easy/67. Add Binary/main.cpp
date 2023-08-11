#include <iostream>
#include <cstring>
#include <algorithm>

using namespace std;

string addBinary(string a, string b) {
    string maxLengthWord = a.size() > b.size() ? a : b;
    string minLengthWord = a.size() > b.size() ? b : a;
    reverse(maxLengthWord.begin(), maxLengthWord.end());
    reverse(minLengthWord.begin(), minLengthWord.end());
    string result;
    int additional= 0;
    int sum;
    for (int i = 0; i < maxLengthWord.size(); ++i) {
        sum = 0;
        if(i<minLengthWord.size()){
            sum+=stoi(to_string(maxLengthWord[i]))+stoi(to_string(minLengthWord[i]))+additional-'0'-'0';
            additional = 0;
            if(sum==0) result+='0';
            if(sum==1) result+='1';
            if(i==maxLengthWord.size()-1){
                if (sum == 2) {
                    result += "01";
                }
                if (sum == 3) {
                    result += "11";
                }
            } else {
                if (sum == 2) {
                    result += '0';
                    additional = 1;
                }
                if (sum == 3) {
                    result += '1';
                    additional = 1;
                }
            }
        }
        else
        {
            sum+=stoi(to_string(maxLengthWord[i]))+additional-'0';
            additional = 0;
            if(i==maxLengthWord.size()-1) {
                if (sum == 0) {
                    result += "0";
                }
                if (sum == 1) {
                    result += "1";
                }
                if (sum == 2) {
                    result += "01";
                }
            } else {
                if (sum == 0) {result += '0';}
                if (sum == 1) {result += '1';}
                if (sum == 2) {
                    result += '0';
                    additional = 1;
                }
            }
        }
    }
    reverse(result.begin(), result.end());
    return result;
}

int main() {
    string a = "1010", b = "1011";
    std::cout << addBinary(a,b) << std::endl;
    return 0;
}
