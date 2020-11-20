namespace HelpClass
{
    public static class WhichComputer
    {
        public static string ComputerName()
        {
            string computerName = "Other";
            HardDrive hd = new HardDrive();
            var list = hd.GetHDDInformation();
            foreach (var item in list)
            {
                if (item.SerialNo == "2J1720122823")
                {
                    //Lenovo
                    computerName = "Lenovo";
                }
            }
            return computerName;
        }
    }

}
