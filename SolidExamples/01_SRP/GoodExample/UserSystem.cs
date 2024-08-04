namespace SolidExamples._01_SRP.GoodExample
{
    internal class UserReports // User Reports Generation 
    {
        void GenerateReports() { /* Generate Reports for User */ }
    }

    internal class UserOutput // Data Visualization
    {
        void ShowUser() { /* Show User in some Output */ }
    }

    internal class UserRepository // Data Manipulation
    {
        void DeleteUser() { /* Remove User from some Data Storage */ }
    }

    internal class UserRent // User Rent Manager
    {
        void CalculateRent() { /* Calculate User Rent */ }
    }

    internal class UserSystem
    {
        private UserRent rentManager = new UserRent();
        private UserRepository repository = new UserRepository();
        private UserOutput output = new UserOutput();
        private UserReports reports = new UserReports();
    }
}
