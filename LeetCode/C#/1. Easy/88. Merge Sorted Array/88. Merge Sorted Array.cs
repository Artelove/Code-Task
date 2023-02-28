/*
You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

Merge nums1 and nums2 into a single array sorted in non-decreasing order.

The final sorted array should not be returned by the function, but instead be stored inside the array nums1. 
To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
 */

public void Merge(int[] nums1, int m, int[] nums2, int n) {
    int [] nums3 = new int[m+n];

    int M = m-1;
    int N = n-1;
    int K = n+m-1;
    while(M >= 0 && N >= 0){
        if(nums1[M]>nums2[N]){
            nums1[K] = nums1[M];
            M--; K--;
        }
        else{
            nums1[K] = nums2[N];
            N--; K--;
        }
    }
    while(N >= 0)
    {
        nums1[K] = nums2[N];
        N--; K--;
    }
}
