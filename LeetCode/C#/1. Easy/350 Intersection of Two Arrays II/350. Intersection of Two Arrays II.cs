public int[] Intersect(int[] nums1, int[] nums2) {

        Dictionary<int,int> d = new Dictionary<int,int>();
        foreach(int elem in nums1)
        {
            if(d.ContainsKey(elem))
            {
                d[elem]++;
            }
            else
                d.Add(elem,1);
        }
        List<int> list = new List<int>();
        foreach(int elem in nums2)
        {
            if(d.ContainsKey(elem))
            {
                list.Add(elem);
                d[elem]--;
                if(d[elem] == 0)
                    d.Remove(elem);
            }
        }
        int[] n = new int[list.Count];
        int i=0;
        foreach(int elem in list)
        {
            n[i] = elem;
            i++;
        }

        return n;
    }