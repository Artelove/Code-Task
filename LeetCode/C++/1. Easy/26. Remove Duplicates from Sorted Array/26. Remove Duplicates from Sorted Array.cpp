#include <iostream>
#include <vector>
#include <map>

using namespace std;
int removeDuplicates(vector<int>& nums) {
    map<int,int> notDublicates;
    for (int i = 0; i < nums.size(); ++i) {
        notDublicates[nums[i]]++;
    }
    {
        int i = 0;
        for (auto dup: notDublicates) {
            nums[i] = dup.first;
            i++;
        }
    }
    return notDublicates.size();
}
int main() {
    vector<int> nums = {1,1,2};
    std::cout << removeDuplicates(nums)<< std::endl;
    return 0;
}
