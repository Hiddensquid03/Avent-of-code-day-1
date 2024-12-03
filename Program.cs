string[] lines = File.ReadAllLines("E:\\Programming\\Vscode stuff\\Adventofcodday1\\adventofcode1\\Numbers.txt");

int[] list1 = new int[lines.Length];
int[] list2 = new int[lines.Length];

for(int i = 0; i < lines.Length; i++){
    string[] numbers = lines[i].Split("   ");
    list1[i] = Int32.Parse(numbers[0]);
    list2[i] = Int32.Parse(numbers[1]);
}

Array.Sort(list1);
Array.Sort(list2);

float difference = 0;

for(int i = 0; i < list1.Length; i++){
    difference += MathF.Abs(list1[i]-list2[i]);
}

Console.WriteLine(difference);
/*
list1 = 0; 
list2 = 0;

if 
list1 == list2 
int matching = matching + 1

else
{
    list2 = i ++
}
*/
for (int i = 0; i < list1.Length; i++)
{
    int matching = 0;
    for (int j = 0; j <list2.Length; j++)
    {
        if (list1[i] == list2[j])
        {
            matching ++;
        }
    }
    list1[i] *= matching;
}

int finalnumber = 0;

for (int i = 0; i < list1.Length; i++)
{
    finalnumber = finalnumber + list1[i];
}
Console.Write (finalnumber);