namespace AddressBookSystems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBookSystems");

           UC2_AddDetails addDetails = new UC2_AddDetails();
           addDetails.EnterInput();
           addDetails.ViewTheDetails();
           //addDetails.PrintTheDetails();

            UC3_EditDetails editDetails = new UC3_EditDetails();
            editDetails.EditUsingName();

            UC4_DeleteDetails deleteDetails = new UC4_DeleteDetails();
            deleteDetails.DeletetheName();

        }
    }
}