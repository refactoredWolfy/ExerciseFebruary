Md

#**Exercise February**

##**C# Practice Exercises**


This repository contains ** simple C# practice exercises** learn and reinforce fundamental programming concepts**

---

##**Most Frequent Number**

### **Problem Description**

This console application determines the**most frequent number** in an integer array.

If **multiple numbers share the same highest frequency**, the programm returns the ** smaller number**.

---

##**How the solution works**

###**Step 1- Count Occurrences**

- The programm iterates through the array.
- A **Dictionary<int,int>** is used to store:
- **Key** -> the number
- **Value** -> how often the number appears

  ---

### **Step 2- Determine the Result**

- The dictionary is iterated to find the **highest frequency**
- if two numbers have the same frequency:
- The **smaller number** is selected using a tie-breaking rule.
 
  ---

##**Example**

```csharp
int [] numbers = {1,2,2,2,2,2,3,4,4,7,7,8,9,9,9,9,9};
**Result** = 2;


  
