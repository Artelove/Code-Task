#include <iostream>
#include <cmath>

using namespace std;

class Solution {
public:
    bool isPalindrome(int x) {
        int countNumbers = 1;
        int counter = 2;
        double xDublicate = x;
        while (xDublicate / 10.0 >= 1){
            xDublicate /= 10.0;
            countNumbers++;
        }
        if(countNumbers ==1 || x < 0)
            return true;
        int right = x % 10;
        int left = x / ((int)pow(10, countNumbers - 1));
        bool compare = false;
        while (right == left){
            compare = true;
            if(countNumbers/2<counter)
                return compare;
            right = x % ((int)pow(10,counter)) / ((int)pow(10, counter - 1));
            left = x / ((int)pow(10,countNumbers - counter)) % 10;
            counter++;
            compare = false;
        }
        return compare;
    }
};

int main() {
    Solution solution;
    cout << solution.isPalindrome(10);
    return 0;
}