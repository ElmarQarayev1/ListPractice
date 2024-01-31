using System.Collections;

namespace ListPractice;

class Program
{
    

    static void Main(string[] args)
    {
        //List<int> insttemo = new List<int>();
        //insttemo.Add(1);
        //insttemo.Add(546);
        //List<int> ints = new List<int>();

        //ints.Add(12);
        //ints.Add(34);
        //ints.Add(56);
        //foreach (var item in ints)
        //{
        //    Console.WriteLine(item);
        //}
        //Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");
        //ints.RemoveAt(1);
        //foreach (var item in ints)
        //{
        //    Console.WriteLine(item);
        //}
        //ints.Add(67);
        //ints.Add(345);
        //ints.RemoveRange(0, 1);
        //Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");
        //foreach (var item in ints)
        //{
        //    Console.WriteLine(item);
        //}

        //Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");

        //Console.WriteLine(ints.Contains(4));
        //Console.WriteLine(ints.Contains(56));

        //ints.AddRange(insttemo);
        //foreach (var item in ints)
        //{
        //    Console.WriteLine(item);
        //}

        //Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");

        //Console.WriteLine(ints.Capacity);
        //Console.WriteLine(ints.Count);
        //Console.WriteLine(ints.IndexOf(1));
        //ints.Insert(2,333);
        //Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");
        //foreach (var item in ints)
        //{
        //    Console.WriteLine(item);
        //}

        //Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");

        //Console.WriteLine(ints.LastIndexOf(333));

        //ints.Remove(333);
        //Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");
        //foreach (var item in ints)
        //{
        //    Console.WriteLine(item);
        //}

        //Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");

        //ints.Sort();
        //ints.Reverse();
        //Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");
        //foreach (var item in ints)
        //{
        //    Console.WriteLine(item);
        //}

        //Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");

        //Console.WriteLine(ints.Sum());


        Dictionary<string, int> emtel = new Dictionary<string, int>();

        emtel.Add("elmar@code.edu.az", 05555555);
        emtel.Add("cavid@code.edu.az", 2343454);
        emtel.Add("kenan@code.edu.az", 0123445);
        emtel.Add("ilham@code.edu.az", 1234321);
        emtel.Add("cingiz@code.edu.az", 243354);

        foreach (var item in emtel)
        {
            Console.WriteLine(item.Key+" "+item.Value.ToString());

        }
        Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");


       // Console.WriteLine("emailinizi  daxil edin:");
       // string email = Console.ReadLine();

       // int  phone;
       // if(emtel.TryGetValue(email,out phone))
       // {

       //     Console.WriteLine(phone);
       // }
       // else
       // {
       //     Console.WriteLine("tapilmadi!");
       // }
       // Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");

       // Console.WriteLine("emailinizi daxil edin:");
       // string email1 = Console.ReadLine();
       // Console.WriteLine("nomrenizi daxil edin: ");
       // int phone1 = Convert.ToInt32(Console.ReadLine());
        
       //if(emtel.TryAdd(email1, phone1))
       // {
       //     Console.WriteLine("elave edildi!");
       // }

       // else
       // {
       //     Console.WriteLine("elave edile bilmedi!");
       // }

        //Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");


        //Stack<int> num = new Stack<int>();
        //num.Push(12);
        //num.Push(45);
        //num.Push(123);
        //num.Push(232);
        //foreach (var item in num)
        //{
        //    Console.WriteLine(item);
        //}
        //num.Pop();
        //num.Pop();
        //Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");

        //foreach (var item in num)
        //{
        //    Console.WriteLine(item);
        //}
        //Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");

        //// Console.WriteLine(num.Peek());

        Queue<string> str = new Queue<string>();
        str.Enqueue("cf");
        str.Enqueue("as");
        str.Enqueue("qw");
        str.Enqueue("er");
        str.Enqueue("2q");
        str.Enqueue("vf");
        foreach (var item in str)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");

        str.Dequeue();
        str.Dequeue();
        foreach (var item in str)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");


        ArrayList arrList = new ArrayList();

        arrList.Add("salam");
        arrList.Add(12);
        arrList.Add("sagol");

         arrList.RemoveAt(1);

        Console.WriteLine(arrList.IndexOf("elmar"));
        Console.WriteLine(arrList.Contains("sagol"));
       
        Console.WriteLine(arrList.Capacity);
        Console.WriteLine(arrList.Count);
        
        foreach (var item in arrList)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");

        Hashtable table = new Hashtable();

        table.Add("a", 1123);
        table.Add("c", 1145);
        table.Add(1, "salam");

        Console.WriteLine(table[1]);

        Console.ReadLine();
    }
}

