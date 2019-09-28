using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Chore : IChore 
    {
        IMessageSender _messageSender;
        ILogger _logger;

        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }


        public Chore(ILogger logger, IMessageSender meesageSender)
        {
            this._logger = logger;
            this._messageSender = meesageSender;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on { ChoreName }");
        }

        public void CompleteChore()
        {
            IsComplete = true;

            _logger.Log($"Completed { ChoreName }"); 

            _messageSender.SendMessage(Owner, $"The chore { ChoreName } is complete.");
        }
    }
} 