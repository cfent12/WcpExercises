﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientConsoleApp.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Microsoft.ServiceModel.Samples", ConfigurationName="ServiceReference1.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/ICalculator/Add", ReplyAction="http://Microsoft.ServiceModel.Samples/ICalculator/AddResponse")]
        double Add(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/ICalculator/Add", ReplyAction="http://Microsoft.ServiceModel.Samples/ICalculator/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/ICalculator/Subtract", ReplyAction="http://Microsoft.ServiceModel.Samples/ICalculator/SubtractResponse")]
        double Subtract(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/ICalculator/Subtract", ReplyAction="http://Microsoft.ServiceModel.Samples/ICalculator/SubtractResponse")]
        System.Threading.Tasks.Task<double> SubtractAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/ICalculator/Multiply", ReplyAction="http://Microsoft.ServiceModel.Samples/ICalculator/MultiplyResponse")]
        double Multiply(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/ICalculator/Multiply", ReplyAction="http://Microsoft.ServiceModel.Samples/ICalculator/MultiplyResponse")]
        System.Threading.Tasks.Task<double> MultiplyAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/ICalculator/Divide", ReplyAction="http://Microsoft.ServiceModel.Samples/ICalculator/DivideResponse")]
        double Divide(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/ICalculator/Divide", ReplyAction="http://Microsoft.ServiceModel.Samples/ICalculator/DivideResponse")]
        System.Threading.Tasks.Task<double> DivideAsync(double n1, double n2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : ClientConsoleApp.ServiceReference1.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<ClientConsoleApp.ServiceReference1.ICalculator>, ClientConsoleApp.ServiceReference1.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double n1, double n2) {
            return base.Channel.Add(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(double n1, double n2) {
            return base.Channel.AddAsync(n1, n2);
        }
        
        public double Subtract(double n1, double n2) {
            return base.Channel.Subtract(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> SubtractAsync(double n1, double n2) {
            return base.Channel.SubtractAsync(n1, n2);
        }
        
        public double Multiply(double n1, double n2) {
            return base.Channel.Multiply(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> MultiplyAsync(double n1, double n2) {
            return base.Channel.MultiplyAsync(n1, n2);
        }
        
        public double Divide(double n1, double n2) {
            return base.Channel.Divide(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> DivideAsync(double n1, double n2) {
            return base.Channel.DivideAsync(n1, n2);
        }
    }
}
