#include <iostream>
#include <vector>
#include "map"
#include <cmath>
using namespace std;
int removeElement(vector<int>& nums, int val) {
    map<int,int> nums_map;
    for (int i = 0; i < nums.size(); ++i) {
        nums_map[nums[i]]++;
        nums[i] = val;
    }
    int i = 0;
    for(auto item: nums_map){
        if(item.first != val)
            while (item.second != 0){
                item.second--;
                nums[i]=item.first;
                i++;
            }
    }
    return nums.size() - nums_map.find(val)->second;
}
int main() {
    vector<int> nums {3,2,2,3,3,3};
    int val = 3;
    std::cout << removeElement(nums, val) << std::endl;
    return 0;
}
