// Собрать строку с числапми олт а до б
/*
string NumbersFor (int a, int b)
{
    string result =string.Empty;
    for (int i = a; i <= b; i++)
    {
        result +=$"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a<=b) return $"{a}" + NumbersRec(a+1,b);
    else return String.Empty;
}

Console.WriteLine(NumbersFor(1,10));
Console.WriteLine(NumbersRec(1,10));
*/

//найти сумму чисел от 1 до N
/*
int Sumfor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}


System.Console.WriteLine(SumRec(5));

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}
System.Console.WriteLine(SumRec(5));
*/


//факториал числа
/*
int FactorialFor(int N)
{
    int result = 1;
    for (int i = 1; i <= N; i++)
    {
        result = result * i;
    }
    return result;
}

int FactorialRec(int N)
{
    if (N == 1) return 1;
    else return N * FactorialRec(N - 1);
}


System.Console.WriteLine(FactorialFor(10));
System.Console.WriteLine(FactorialRec(10));
*/

//возвести число а в натуральную степень n




//Перебор слов из букв 
/*
 char[] s = {'а','и','с','в'};
 int count = s.Length;
 int n =1;
 for (int i = 0; i < count; i++)
 {
    for (int j = 0; j < count; j++)
    {
        System.Console.WriteLine($"{n++,-5}{s[i]}{s[j]}");
    } 
 }
*/

//перебор c рекурсией
/*
int n = 1;
void FinWords(string alphabet, char[] word, int Length = 0)
{
    if (Length == word.Length)
    {
        System.Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[Length] = alphabet[i];
        FinWords(alphabet, word, Length + 1);
    }

}

FinWords("аисв", new char[5]);
*/



// работа с директориями
/*
string path = @"C:\Users\cepji\Desktop\Business intelligence\Все про C#\Seminars\Lection7";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
*/

// рекурсия ходячая по папкам
//че то не работает


void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        System.Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }


FileInfo[] files = catalog.GetFiles();

for (int i = 0; i < files.Length; i++)
{
    System.Console.WriteLine($"{indent}{catalogs[i].Name}");
}
}

string path = @"C:\Users\cepji\Desktop\Business intelligence\Все про C#\Seminars\Lecture copy 2";
CatalogInfo(path);


 // остановился на :25:37