namespace Deneme.Database.Context
{
    public static class DatabaseAdres
    {
        static string Work = "Data Source=(LocalDb)\\MSSQLLocalDb;Initial Catalog=Yesilyurt;Integrated Security=True;";
        static string Lenovo = "Data Source=CAGLARDESKTOP;Initial Catalog=Yesilyurt;User=sa;password=1;";
        public static string ConnectionString()
        {
            if (HelpClass.WhichComputer.ComputerName() == "Lenovo") return Lenovo;
            else return Work;
        }
    }
}
