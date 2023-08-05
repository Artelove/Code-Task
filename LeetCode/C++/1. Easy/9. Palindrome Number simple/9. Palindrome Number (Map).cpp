#include <iostream>
#include <cmath>
#include <algorithm>

using namespace std;

class Solution {
public:
    bool isPalindrome(int x) {
        if (x < 0) {
            return false;
        }

        long long reversed = 0;
        long long temp = x;

        while (temp != 0) {
            int digit = temp % 10;
            reversed = reversed * 10 + digit;
            temp /= 10;
        }

        return (reversed == x);
    }
};

int main() {
    Solution solution;
    cout << solution.isPalindrome(10001);
    return 0;
}