﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2> result) result = arg2;
    if(arg3> result) result = arg3;
    return result;
}


int a1 = 12;    
int b1 = 22;
int c1 = 2456;
int a2 = 12;    
int b2 = 68;
int c2 = 8;
int a3 = 56;    
int b3 = 88888;
int c3 = 133;

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);