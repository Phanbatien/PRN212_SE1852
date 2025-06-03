using System.Text; 
Console.OutputEncoding = Encoding.UTF8;
/*
 * dùng linqtoobject để xuất các số chẵn trong danh sách 
 */
int[] arr = { 100, 35, 80, 17, 22, 40, 70, 33, 18 };
// cachs 1 : dung method syntax (extention method)
var even_list =arr.Where(x => x % 2 == 0);
Console.WriteLine(" danh sách các số chẵn theo method syntax:");
foreach (var x in even_list)
    Console.Write(x + "\t");
// cách 2 : dùng query syntax (cú pháp tương tự sql)
var  even_list2 = from x in arr 
                   where x% 2 == 0  
                   select x;
Console.WriteLine("\n danh sách các ố chẵn theo query syntax");
foreach (var x in even_list2)   
    Console.Write(x+"\t");

/* SẮP xếp mảng tăng dần và giảm dần dùng method và quecy syntax*/
// dùng method;
var list_asc = arr.OrderBy(x=>x);
// dungf quecy 
var list_asc2 = from x in arr
                orderby x descending
                select x;
var list_desc2 = arr.OrderDescending(x=>x);
// tính tổng danh sách:
Console.WriteLine("tong=" + arr.Sum());
Console.WriteLine("dem so chan= "+arr.Where(x=> x% 2 == 0).Count());
