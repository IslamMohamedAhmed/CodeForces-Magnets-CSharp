using static System.Console;
using static System.Convert;
using static System.Math;

int n,indicator=0,counter=1,mx=0;
string[] magnets = new string[100005];
n = ToInt32(ReadLine());
for(int i = 0; i < n; i++)
{
    magnets[i] = ReadLine();
}
for(int i = 1; i < n; i++)
{
    if (!magnets[i].Equals(magnets[i-1]))
    {
        counter++;
    }
    else
    {
        continue;
    }
}

WriteLine(counter);