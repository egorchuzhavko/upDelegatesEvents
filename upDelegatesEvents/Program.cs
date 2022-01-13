using z1;

static void Message(string s)
{
    Console.WriteLine(new string('-', 50));
    Console.WriteLine(s);
    Console.WriteLine(new string('-', 50));
}


Console.WriteLine("Задание 1\n");

Console.WriteLine("Введите х начальное: ");
double xnach = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите х конечное: ");
double xkon = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите шаг: ");
double shag = Convert.ToDouble(Console.ReadLine());
Zadanie11 tan = Tan;
Zadanie12 cos = Cos;
Console.WriteLine("Cos(x)\tTan(x)");
for (; xnach < xkon; xnach += shag)
{
    Console.WriteLine($"{cos(xnach):f2}\t{tan(xnach):f2}");
}


Console.WriteLine("\n\nЗадание 2\n");
Book[] books = new Book[4];
books[0] = new Book("Гарри Поттер", "Дж. К. Роулинг", "Bloomsbury");
books[1] = new Book("Ведьмак", "Анджей Сапковский", "superNOWA");
books[2] = new Book("Оно", "Стивен Кинг", "Viking");
books[3] = new Book("Бегущий в лабиринте", "Джеймс Дэшнер", "Delacorte Press");

Library library = new Library(books);
Console.WriteLine("Сортировка по автору: \n");
library.SortingLibrary(new DelegatToSortZad2(library.SortByAuthor));
Console.WriteLine(library);
Console.WriteLine("\nСортировка по названию: \n");
library.SortingLibrary(new DelegatToSortZad2(library.SortByName));
Console.WriteLine(library);
Console.WriteLine("\nСортировка по издательству: \n");
library.SortingLibrary(new DelegatToSortZad2(library.SortByPublishing));
Console.WriteLine(library);


Console.WriteLine("\n\nЗадание 3\n");
string[] fio = { "Чужавко", "Егор", "Андреевич" };
Fio fiocl = new Fio();
DelegatFIOZad3 del = fiocl.ShortInfo;
Console.WriteLine(del(fio));
del = fiocl.LongInfo;
Console.WriteLine(del(fio));


Console.WriteLine("\n\nЗадание 4\n");
Key k = new Key();
k.Notify += Message;
k.Push();


Console.WriteLine("\n\nЗадание 5\n");
NewsOperator NewsOp = new NewsOperator();
Subscriber Sub1 = new Subscriber("Подписчик 1");
Subscriber Sub2 = new Subscriber("Подписчик 2");
NewsOp.SubscribeTo(Category.Events, Sub1);
NewsOp.SubscribeTo(Category.Events, Sub2);
NewsOp.SubscribeTo(Category.News, Sub2);
NewsOp.SubscribeTo(Category.Sport, Sub1);
NewsOp.SubscribeTo(Category.Humor, Sub1);
NewsOp.SubscribeTo(Category.Weather, Sub2);

NewsOp.AddNews(Category.Events, "Новость #1");
NewsOp.AddNews(Category.Events, "Новость #2");
NewsOp.AddNews(Category.Sport, "Спортивная новость");
NewsOp.AddNews(Category.Humor, "Шутка)");
NewsOp.AddNews(Category.Weather, "Холодно");
NewsOp.SubscribeTo(Category.Sport, Sub2);
NewsOp.AddNews(Category.Sport, "Спортивная новость222");


Console.WriteLine("\n\nЗадание 6\n");
Console.WriteLine("1 + 2 = " + Calculator.Add(1, 2));
Console.WriteLine("2 - 1 = " + Calculator.Subtract(2, 1));
Console.WriteLine("2 * 2 = " + Calculator.Multiply(2, 2));
Console.WriteLine(" 4 / 2 = " + Calculator.Divide(4, 2));

deleg d = (double a, double b) => a + b;
Console.WriteLine(d(5, 5));
d = (double a, double b) => a * b;
Console.WriteLine(d(5, 5));



static double Tan(double x) { return Math.Tan(x); }
static double Cos(double x) { return Math.Cos(x); }

delegate double Zadanie11(double x);
delegate double Zadanie12(double x);
delegate void DelegatToSortZad2();
delegate string DelegatFIOZad3(string[] mas);
delegate double deleg(double a, double b);