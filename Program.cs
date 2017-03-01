using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums1=new int[11];
            int[] nums3=new int[]{};
            for(var i=0;i<nums3.Length;i++)
            {
                nums1[i]=nums3[i];
            }
            
            foreach(var item in nums1)
            {
                Console.WriteLine("Before: {0}",item);
            }
            
            int[] nums2=new int[5]{0,1,2,3,4};
            
            int m=nums3.Length;
            int n=nums2.Length;
            
            Solution solu=new Solution();
            solu.Merge(nums1, m, nums2, n);
            foreach(var item in nums1)
                Console.WriteLine("after sorted array: {0}",item);
        }
    }
    
    
    public class Solution {
        public void Merge(int[] nums1, int m, int[] nums2, int n) {
           
            int k=m+n-1;
            var i=m-1;
            var j=n-1;
            if(m==0)
            {
              while(j>-1)
                {
                    nums1[k]=nums2[j];
                    k--;
                    j--;
                }
            } else if(n==0)
            {
                
            }else
            {
                while(i>-1 && j>-1)
                {
                    Console.WriteLine("Hi1");
                    if(nums1[i]>=nums2[j])
                    {
                        Console.WriteLine("Hi2");
                        nums1[k]=nums1[i];
                        k--;
                        i--;
                    }else
                    {
                        nums1[k]=nums2[j];
                        k--;
                        j--;
                    }
                }
                //nums1 run out first, move all the rest of nums2 to nums1
                while(j>-1)
                {
                    nums1[k]=nums2[j];
                    k--;
                    j--;
                }
            }
            
        }
    }
}
