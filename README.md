# Sparse-Arrays

There is a collection of  strings ( There can be multiple occurences of a particular string ). Each string's length is no more than  characters. There are also  queries. For each query, you are given a string, and you need to find out how many times this string occurs in the given collection of  strings.

Input Format

The first line contains , the number of strings.
The next  lines each contain a string.
The nd line contains , the number of queries.
The following  lines each contain a query string.

Constraints

 
 
    

Sample Input

4
aba
baba
aba
xzxb
3
aba
xzxb
ab
Sample Output

2
1
0
Explanation

Here, "aba" occurs twice, in the first and third string. The string "xzxb" occurs once in the fourth string, and "ab" does not occur at all.
