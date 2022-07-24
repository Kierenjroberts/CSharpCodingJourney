using Exercise1;

var cookie = new HttpCookie();
cookie["name"] = "Mosh";
Console.WriteLine(cookie["name"]);