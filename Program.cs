// See https://aka.ms/new-console-template for more information

// >  <  >=  != == <= 

int grade1, grade2, grade3, grade4, grade5, grade6;
int average;
Console.WriteLine("Enter Grade1");
grade1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Grade2");
grade2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Grade3");
grade3=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Grade4");
grade4=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Grade5");
grade5=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Grade6");
grade6=Convert.ToInt32(Console.ReadLine());

average=(grade1+grade2+grade3+grade4+grade5+grade6)/6;


if(average >=70)
{
   
       Console.WriteLine("1st");
   
}
else
{
    if(average >=60)
    {
         Console.WriteLine("2:1");
    }
    else
        if(average >=50)
        {
            Console.WriteLine("2:2");
        }
        else
            if(average >=40)
            {
                Console.WriteLine("3rd");
            }
            else
               {
                   Console.WriteLine("Fail");
               }
}

Console.ReadKey();

