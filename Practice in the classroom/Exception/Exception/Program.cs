using Exception.Controllers;
using Exception.LibraryController;
using System;
#region HomeWork
//LibraryController.GetAll();
//var books = LibraryController.GetAllBooksbyLibrary(m => m.LibraryId == 1);
//foreach (var item in books)
//{
//    Console.WriteLine(item.Name+" "+ item.Author);
//}
#endregion


#region SystemException
//bool isParse=true;

//try
//{
//	int index=int.Parse(Console.ReadLine());
//	int[] arr=new int[2];
//	arr[0]= 5;

//	string name = "Anar";
//	if(name is null)
//	{
//		throw new NullReferenceException();
//	}
//	isParse=true;
//	Console.WriteLine(arr[index]);

//}
//catch (System.Exception ex)
//{
//	Console.WriteLine(ex.Message);
//	isParse=false;
//}
//finally
//{
//	if (isParse)
//	{
//		Console.WriteLine("Duzgundur");
//	}
//	else
//	{
//		Console.WriteLine("Sehvdir");

//    }

//}

//GetNameById(null);


//static void GetNameById(int? id)
//{
//	try
//	{
//        if (id == null)
//        {
//            throw new ArgumentNullException();
//        }
//        else
//        {
//            Console.WriteLine("name id: " + id);
//        }

//    }
//	catch (System.Exception ex)
//	{

//        Console.WriteLine(ex.Message);
//	}

//}
#endregion


AccountController accountController = new AccountController();
//accountController.Register();
accountController.GetUserById();





