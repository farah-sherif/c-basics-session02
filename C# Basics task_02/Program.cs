
namespace C__Basics_task_02
{

    public class Program
    {

        static void Main(string[] args)
        {
            Object book = new Book()
            {
                Title="my_book",
                Pages = 250
            };
            // Q01
            Console.WriteLine(book);

            // Q02
            Console.WriteLine(book.ToString());
            Console.WriteLine(Equals(book,book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());

            /* Q03
             * int pages = "464";  >> compile-time error
             */
            int pages = 464;

            // Q04
            try
            {
                int x = 10;
                int y = 0;
                int result = x / y;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            // Q05
            int pages1 = 300;
            double pages2 = pages1;
            Console.WriteLine(pages2.GetType());

            // Q06
            double price = 49.99;
            int price2 = (int) price;
            Console.WriteLine(price2.GetType());

            // Q07
            string pagesText = "464";
            int pagesText2 = Convert.ToInt32(pagesText);
            Console.WriteLine(pagesText2.GetType());

            // Q08
            string yearText = "2023";
            int yearText2 = int.Parse(yearText);
            Console.WriteLine(yearText2.GetType());
            string badText = "abc";
            if (!int.TryParse(badText, out int res))
            {
                Console.WriteLine("Invalid number");
            }
            Console.WriteLine(res);

            // Q09
            int pagess = 464;
            String text = pagess.ToString();
            Console.WriteLine(text);
            Console.WriteLine(text.GetType());

            //Q10

            int copies = 100;
            object obj = copies;
            int newcopies = (int)obj;
            Console.WriteLine(obj);
            Console.WriteLine(newcopies);
        }
    }
}