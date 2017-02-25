# Leetcode:220. Contains Duplicate III
<a href="https://leetcode.com/problems/contains-duplicate-iii/?tab=Description">Link</a>
<h3>Description</h3>
<p>
Given an array of integers, 
find out whether there are two 
distinct indices i and j in the array such that the absolute difference between nums[i] and nums[j] is at most t and the absolute difference between i and j is at most k.
</p>

<h3>Scenario</h3>
<p>
Given int[] nums<br/>
And int i, j<br/>
When exist i, j for |nums[i] - nums[j]| <= t<br/>
And |i-j| <= k </br>
Then Return true
</p>
<hr/>
<p>
Given int[] nums<br/>
And int i, j<br/>
When no exist i, j satisfy for |nums[i] - nums[j]| <= t<br/>
Then Return false
</p>
<hr/>
<p>
Given int[] nums<br/>
And int i, j<br/>
When exist i,j satisfy for |i-j| <= t<br/>
And |i - j| >t</br>
Then Return false
</p>
