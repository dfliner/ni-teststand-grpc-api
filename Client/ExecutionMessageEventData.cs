using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleClient
{
    public class ExecutionMessageEventData
    {
        public int MessageCode { get; set; }
        public string ExecutionId { get; set; }
        public string SequenceId { get; set; }
        
        public StepData PrevStep { get; set; }
        public StepData CurrStep { get; set; }
        public StepData NextStep { get; set; }
    }

    public class StepData
    {
        public int StepIndex { get; set; } = -1;
        public string StepName { get; set; }
        public string StepTypeName { get; set; }
        public string StepResultStatus { get; set; } = string.Empty;
    }
}
