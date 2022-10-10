Console.Clear();
//как не надо писать код
bool Metodi(int chislo) {
    bool resultati = false;
    if (chislo % 2 == 0) {resultati = true; }
    else {resultati = false; }
    if (resultati == false) {return false; }
    else { return true; }
}
Console.WriteLine($"Как не надо писать код {Metodi(5)}");
// как надо писать код
bool IsEven(int value) {
    return value % 2 == 0;
}
Console.WriteLine($"Вариант 1: {IsEven(8)}");
// Еще его можно переписать таким образом
bool IsEven2(int value) => value % 2 == 0;
Console.WriteLine($"Вариант 2: {IsEven2(9)}");
// Еще его можно переписать таким образом
var IsEven3 = (int v) => v % 2 == 0;
Console.WriteLine($"Вариант 3: {IsEven3(6)}"); 
Console.WriteLine();
// ним когжда не использовать проверки 
//- если какое то логическое значение или логическая переменная равна False
// например, "если b == false...." 
// Лучше проверить на отрицание, использовать:"!b"  

// var - не явная типизация, суть в том, что вместо какого то типа данных, абсолютно любого,
// вы можете написать ключевое слово "var" - не использовать там, где она точно не нужна
// используется в тех случаях, когда наперед тип данных не известен
// Пример:
int x = 12;
Console.WriteLine(x.GetType()); // обнаружим при запуске System.Int32
string text = "стринг";
Console.WriteLine(text.GetType()); // обнаружим при запуске System.String
var y = 15;
var z = 15.85;
var str = "строка";
Console.WriteLine(y.GetType().Name); // обнаружим при запуске Int32
Console.WriteLine(z.GetType().Name); // обнаружим при запуске Double
Console.WriteLine(str.GetType().Name); // обнаружим при запуске String
// .Name убирает System.
Console.WriteLine();
// Еще пример:
var data = new int[] {1,2,3,4}
        .Where(e => e > 0)
        .Select(e => new {q = e,  w= e + 1});
        Console.WriteLine(data.GetType().Name); 
        //WhereSelectArrayIterator`2
Console.WriteLine(data.GetType()); 
// System.Linq.Enumerable+WhereSelectArrayIterator`2[System.Int32,<>f__AnonymousType0`2[System.Int32,System.Int32]]