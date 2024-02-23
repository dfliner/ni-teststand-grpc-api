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
        
        public int? PrevStepIndex { get; set; }
        public string PrevStepName { get; set; }
        public string PrevStepTypeName { get; set; }
        public string PrevStepResultStatus { get; set; }

        public int? CurrentStepIndex { get; set; }
        public string CurrentStepName { get; set; }
        public string CurrentStepTypeName { get; set; }
        public string CurrentStepResultStatus { get; set; }
        
        public int? NextStepIndex { get; set; }
        public string NextStepName { get; set; }
        public string NextStepTypeName { get; set; }
        public string NextStepResultStatus { get; set; }

        public int LoopIterationNumber { get; set; } = -1;
    }

    internal class StepData
    {
        public string StepName { get; set; }
        public string StepTypeName { get; set; }
        public string StepResultStatus { get; set; }
    }
}
