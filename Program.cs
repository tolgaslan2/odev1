// See https://aka.ms/new-console-template for more information

//yeni dotnet 6 ile oluşturulduğu için bu şablon gelidi direkt olarak.

byte b = 5;
sbyte c = 5;

short s = 5;
ushort us = 5;

Int16 i16 = 2;
int i = 2;
Int32 i32 = 2;
Int64 i64 = 2;

uint ui = 2;
long l = 4;
ulong ul = 4;

float f = 5;
double d = 5;

char ch = '2';
string str = "Tolga";

bool b1 = true;
bool b2 = false;

DateTime dt = DateTime.Now;
Console.WriteLine(dt);


object o1 = "x";
object o2 = 'y';
object o3 = 4;
object o4 = 4.3;

string str1 = string.Empty;
str1 = "Tolga Aslan";
string ad = "Tolga";
string soyad = "Aslan";
string tamisim = ad + " " + soyad;

int integer1 = 5;
int integer2 = 3;
int integer3 = integer1 * integer2;

bool bool1 = 10 > 2;

string str24 = "24";
int int20 = 20;

string teniDeger = str24 + int20.ToString();
Console.WriteLine(teniDeger);

int int21 = int20 + Convert.ToInt32(str24);
Console.WriteLine(int21);

int int22 = int20 + int.Parse(str24);

string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime2);

string datetime3 = DateTime.Now.ToString("HH:mm");
Console.WriteLine(datetime3);
