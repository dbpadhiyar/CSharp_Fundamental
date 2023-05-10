/*
1 Declare Integer Array and print it using for loop


int[] values = new int[5];

values[0] = 11;
values[1] = 21;
values[2] = 31;
values[3] = 41;
values[4] = 51;

for(int i = 0; i <values.Length; i++)
{
    Console.WriteLine("Value of Index {0} is => {1}",i,values[i]);
}
*/

/*
2 Print Pattern Using For Loop

Expected Output

*
**
***
****
*****



for(int i =1; i <= 5; i++)
{
    for(int j = 1; j<=i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}
*/

/*3 Print Pattern Using For Loop

Expected Output

*****
****
***
**
*


for (int i=5; i>=1; i--)
{
    for(int j = 1; j<=i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}
*/


/*4 Break StateMent

Break statement will break loop once condition is met

Expected Output

1
2
3

for (int i=1; i<=5; i++)
{
    if (i == 4)
        break;
    else
        Console.WriteLine("Current value of i is {0}",i);
}
*/

/*5 Continue StateMent

Continue statement will skip iteration if condition met else will continue iteration

Expected Output

1
2
3
5
6
7
8
10
*/

for (int i=1; i<=10; i++)
{
    if (i == 4 || i == 9)
        continue;
    else
        Console.WriteLine("Current value of i is {0}",i);
}





