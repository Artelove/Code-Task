#include <iostream>
#include "vector"
using namespace std;
vector<int> plusOne(vector<int>& digits) {
    int i = digits.size()-1;
    bool needAppendOneAtFront = false;
    digits[i]++;
    while (digits[i]==10){
        digits[i]=0;
        i--;
        if(i<0) {
            needAppendOneAtFront = true;
            break;
        }
        digits[i]++;
    }

    if(needAppendOneAtFront){
        vector<int> digitsAdvanced(digits.size()+1);
        digitsAdvanced[0] = 1;
        for (int j = 0, k = 0; j < digits.size(); ++j, ++k) {
            digitsAdvanced[k+1] = digits[j];
        }
        return digitsAdvanced;
    }
    return digits;
}
int main() {
    vector<int> digits = {9,9,9};
    plusOne(digits);
    return 0;
}
