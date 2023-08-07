#include <iostream>

struct ListNode {
    int val;
    ListNode *next;

    ListNode() : val(0), next(nullptr) {}

    ListNode(int x) : val(x), next(nullptr) {}

    ListNode(int x, ListNode *next) : val(x), next(next) {}
};

ListNode *mergeTwoLists(ListNode *list1, ListNode *list2) {
    ListNode *result;
    ListNode *next;
    if (list1->val > list2->val) {
        result = list2;
        list2 = list2->next;
    }
    else{
        result = list1;
        list1 = list1->next;
    }
    next = result;

    while (list1 != nullptr || list2 != nullptr){

        if(list1 == nullptr){
            next->next = list2;
            list2 = list2->next;
        } else
        if(list2 == nullptr){
            next->next = list1;
            list1 = list1->next;
        } else
        if (list1->val > list2->val) {
            next->next = list2;
            list2 = list2->next;
        }
        else{
            next->next = list1;
            list1 = list1->next;
        }
        next = next->next;
    }
    return result;
}

int main() {

    ListNode one_4 = ListNode(4);
    ListNode one_2 = ListNode(2, &one_4);
    ListNode one_1 = ListNode(1, &one_2);
    ListNode two_5 = ListNode(4);
    ListNode two_3 = ListNode(3, &two_5);
    ListNode two_1 = ListNode(1, &two_3);
    mergeTwoLists(&one_1,&two_1);
    std::cout << "Hello, World!" << std::endl;
    return 0;
}
