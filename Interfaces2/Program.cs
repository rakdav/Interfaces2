using Interfaces2;

Director director = new Director
{
    FirstName = "Матрас",
    LastName = "Матрасов",
    BirthDate = new DateTime(2009, 1, 12),
    Position = "Директор",
    Salary = 0.10
};

IWorker seller = new Seller
{
    FirstName = "Матроса",
    LastName = "Матрасова",
    BirthDate = new DateTime(2010, 2, 5),
    Position = "Продавец",
    Salary = 0.05
};

if(seller is Employee)
{
    Console.WriteLine((seller as Employee).ToString());
}

director.ListOfWorkers = new List<IWorker>
{
    seller,new Cashier{FirstName="Крыса",
        LastName="Матрасова",
        BirthDate=new DateTime(2010,5,8),
        Position="Кассир",
        Salary=0.01
    },
    new StoreKipper{FirstName="Матрос",LastName="Матрасов",
    BirthDate=new DateTime(2008,12,11),Position="Кладовщик",
    Salary=1.0 }
};
Console.WriteLine(director.ToString());
if(director is IManager)
{
    director.Control();
}
foreach  (IWorker item in director.ListOfWorkers)
{
    Console.WriteLine(item);
    if (item.IsWorking)
    {
        Console.WriteLine(item.Work());
    }
}