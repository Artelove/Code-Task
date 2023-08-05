#include <iostream>
#include <vector>
#include <map>
using namespace std;

class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        map<int,int> difference;
        for (int i = 0; i < nums.size(); ++i) {
            difference[target - nums[i]] = i;
        }
        for (int i = 0; i < nums.size(); ++i) {
            if( difference.find(nums[i]) != difference.end() && difference.find(nums[i])->second != i)
                return vector<int>{i,difference.find(nums[i])->second};
        }
        return vector<int>{0,1};
    }
};
int main() {
    Solution solution;
    vector<int> input = vector<int>{3,2,4};
    vector<int> res = solution.twoSum(input, 6);
    for (int i: res)
        cout<<(i)<<endl;
    return 0;
}

