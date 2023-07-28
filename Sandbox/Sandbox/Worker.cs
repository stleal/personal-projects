using Packages;

namespace Sandbox
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private Calculator calculator = new Calculator(); 
        private TwoSum twoSum = new TwoSum(); 

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {

                // declare variables 
                string userInput = string.Empty; 

                // loop forever until exit 
                while(userInput.ToLower() != "exit") 
                {

                    // prompt user for input 
                    Console.WriteLine("Please enter a package name to run: ");
                    Console.WriteLine("For example, some of the available options are: TwoSum.cs, and Calculator.cs");

                    // get input from the user 
                    userInput = Console.ReadLine().ToLower();
                    string[] args = userInput.Split(" "); 

                    // executes a selected program 
                    switch (args[0].ToLower())
                    {
                        case "twosum":
                            twoSum.Run(); 
                        break;
                        case "calculator":
                            calculator.Run(args); 
                        break; 
                    }

                }
                //int x = 23; int y = 94;
                //Console.WriteLine(calculator.Add(x, y));
                //Console.WriteLine(calculator.Subtract(x, y));
            }
            catch (TaskCanceledException)
            {
                // When the stopping token is canceled, for example, a call made from services.msc,
                // we shouldn't exit with a non-zero exit code. In other words, this is expected...
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Message}", ex.Message);

                // Terminates this process and returns an exit code to the operating system.
                // This is required to avoid the 'BackgroundServiceExceptionBehavior', which
                // performs one of two scenarios:
                // 1. When set to "Ignore": will do nothing at all, errors cause zombie services.
                // 2. When set to "StopHost": will cleanly stop the host, and log errors.
                //
                // In order for the Windows Service Management system to leverage configured
                // recovery options, we need to terminate the process with a non-zero exit code.
                Environment.Exit(1);
            }
        }
    }
}