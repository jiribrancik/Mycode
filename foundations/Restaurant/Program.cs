namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant("pepek", 1);
            Manager mager = new Manager(" pepa");
            restaurant.Hire(mager);
            restaurant.GuestsArrived();
            Chef chef = new Chef("hamond");
            chef.Cook("mrdka");
            chef.Cook("mrdka");
            chef.Cook("mrdka");
            chef.Cook("spina");
            chef.Cook("spina");


        }
    }
}